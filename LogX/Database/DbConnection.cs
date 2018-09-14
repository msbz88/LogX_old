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
        public string Host { get; set; }
        public string Port { get; set; }
        public string Schema { get; set; }
        public string Password { get; set; }
        public string Sid { get; set; }
        public string ServiceName { get; set; }

        public DbConnection(string host, string port, string schema, string password, string sid = "", string serviceName = "") {
            Host = host;
            Port = port;
            Schema = schema;
            Password = password;
            Sid = sid;
            ServiceName = serviceName;
        }

        public static DbConnection DeserializeFromFile(string configFilePath) {
            return JsonConvert.DeserializeObject<DbConnection>(File.ReadAllText(configFilePath));
        }

        public void SerializeToFile(string configFilePath) {
            File.WriteAllText(configFilePath, JsonConvert.SerializeObject(this));
        }

        public string CreateConnectionString() {
            string sidOrServiceName = "";
            if (Sid == "") {
                sidOrServiceName = "SERVICE_NAME=" + ServiceName;
            } else {
                sidOrServiceName = "SID=" + Sid;
            }
            return "Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(" +
                   "HOST=" + Host + ")(" +
                   "PORT=" + Port + ")))(" +
                   "CONNECT_DATA=(" + sidOrServiceName + "))); " +
                   "USER ID=" + Schema + "; " +
                   "PASSWORD=" + Password + ";";
        }
    }
}
