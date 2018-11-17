using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace LogX {
    public class OraSession {
        public OracleConnection OracleConnection { get; set; }
        string ConnString { get; set; }

        public OraSession(string connString) {
            ConnString = connString;
            ConnectToDatabase();
        }

        public void ConnectToDatabase() {
            OracleConnection = new OracleConnection { ConnectionString = ConnString };
            OracleConnection.Open();
        }

        public void CloseConnection() {
            OracleConnection.Close();
            OracleConnection.Dispose();
        }

        private DataTable ExecuteQuery(OracleCommand cmd) {
            DataTable dt = new DataTable();
            cmd.CommandType = CommandType.Text;
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            OracleCommandBuilder cb = new OracleCommandBuilder(da);
            da.Fill(dt);
            return dt;
        }

        public Task<DataTable> ExecuteQueryParallel(OracleCommand cmd) {
            return Task.Run(() => ExecuteQuery(cmd));
        }
    }
}
