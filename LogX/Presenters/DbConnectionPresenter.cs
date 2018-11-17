using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogX.Views;
using LogX.Models;
using System.ComponentModel.DataAnnotations;

namespace LogX.Presenters {
    class DbConnectionPresenter {
        readonly IDbConnectionView DbConnectionView;
        private DbConnection DbConnection { get; set; }
        private OraSession OraSession { get; set; }

        public DbConnectionPresenter(IDbConnectionView dbConnectionView) {
            DbConnectionView = dbConnectionView;
            DbConnectionView.TestConnectionEvent += OnTestConnection;
            DbConnectionView.SaveConnectionEvent += OnSaveConnection;
        }

        private void GetConnectionInfoFromFile(string connectionName) {
            try {
                DbConnection connection = SerializerPresenter.DeserializeFromFile(FlatFile.GetDBConfigsFile(), connectionName);
                DbConnectionView.Host = connection.Host;
                DbConnectionView.Port = connection.Port;
                DbConnectionView.Schema = connection.Schema;
                DbConnectionView.Password = connection.Password;
                DbConnectionView.Sid = connection.Sid;
                DbConnectionView.ServiceName = connection.ServiceName;
            } catch (InvalidOperationException) {
                DbConnectionView.WriteError("Connection to database does not set, please configure it");
                return;
            } catch (InvalidDataException) {
                DbConnectionView.WriteError(connectionName + " connection has errors and need to be reconfigured");
                DbConnectionView.ClearAllTextBoxes();
                return;
            } catch (NullReferenceException) {
                DbConnectionView.WriteError(connectionName + " connection not found. Please configure it");
                DbConnectionView.ClearAllTextBoxes();
                return;
            }
        }

        private void OnTestConnection(object sender, EventArgs e) {
            string connectionName = "";
            if (DbConnectionView.IsMasterActive) {
                connectionName = "Master";
            } else if (DbConnectionView.IsTestActive) {
                connectionName = "Test";
            }
            try {
                DbConnection = new DbConnection(
                    connectionName,
                    DbConnectionView.Host,
                    DbConnectionView.Port,
                    DbConnectionView.Schema,
                    DbConnectionView.Password,
                    DbConnectionView.Sid,
                    DbConnectionView.ServiceName
                );
                ValidationContext context = new ValidationContext(DbConnection, null, null);
                List<ValidationResult> results = new List<ValidationResult>();
                bool valid = Validator.TryValidateObject(DbConnection, context, results, true);

                if (!valid) {
                    foreach (var item in results) {
                        DbConnectionView.WriteError(item.ErrorMessage);
                    }
                } else {
                    OraSession = new OraSession(DbConnection.CreateConnectionString());
                    DbConnectionView.WriteSuccessful("Connected to " + connectionName + " database");
                }
            } catch (Exception ex) {
                DbConnectionView.WriteError(ex.Message);
            }
        }

        private void OnSaveConnection(object sender, EventArgs e) {
            if (DbConnection != null) {
                SerializerPresenter.SerializeToFile(FlatFile.GetDBConfigsFile(), DbConnection);
                DbConnectionView.WriteSuccessful("Saved");
            } else {
                DbConnectionView.WriteError("Firstly test your connection. Only successful connection can be saved");
            }
        }
    }
}
