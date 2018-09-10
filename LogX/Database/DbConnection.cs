using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogX {
    public class DbConnection {
        private string Host { get; set; }
        private string Port { get; set; }
        private string Schema { get; set; }
        private string Password { get; set; }
        private string Sid { get; set; }
        private string ServiceName { get; set; }
        public string ConnectionString { get; set; }

        public DbConnection(string host, string port, string schema, string password, string sid = "", string serviceName = "") {
            Host = host;
            Port = port;
            Schema = schema;
            Password = password;
            Sid = sid;
            ServiceName = serviceName;
            CreateConnectionString();
        }

        public static DbConnection DeserializeFromFile(string configFilePath) {
            return JsonConvert.DeserializeObject<DbConnection>(File.ReadAllText(configFilePath));
        }

        public void SerializeToFile(string configFilePath) {
            File.WriteAllText(configFilePath, JsonConvert.SerializeObject(this));
        }

        private void CreateConnectionString() {
            string sidOrServiceName = "";
            if (Sid == "") {
                sidOrServiceName = "SERVICE_NAME=" + ServiceName;
            } else {
                sidOrServiceName = "SID=" + Sid;
            }
            ConnectionString = "Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(" +
                   "HOST=" + Host + ")(" +
                   "PORT=" + Port + ")))(" +
                   "CONNECT_DATA=(" + sidOrServiceName + "))); " +
                   "USER ID=" + Schema + "; " +
                   "PASSWORD=" + Password + ";";
        }
    }
}
