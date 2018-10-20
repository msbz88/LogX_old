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
        public string Name { get; set; }
        public string Host { get; set; }
        public string Port { get; set; }
        public string Schema { get; set; }
        public string Password { get; set; }
        public string Sid { get; set; }
        public string ServiceName { get; set; }

        public DbConnection(string name, string host, string port, string schema, string password, string sid = "", string serviceName = "") {
            Name = name;
            Host = host;
            Port = port;
            Schema = schema;
            Password = password;
            Sid = sid;
            ServiceName = serviceName;
        }

        public static DbConnection DeserializeFromFile(string configFilePath, string name) {
            FileInfo file = new FileInfo(configFilePath);
            JToken jToken = null;
            if (file.Exists) {
                JArray jObjects = new JArray();
                if (file.Length > 0) {
                    string fileContent = File.ReadAllText(configFilePath);
                    jObjects = JArray.Parse(fileContent);
                    jToken = jObjects.First(jo => jo["Name"].ToString() == name);
                    
                }
            }
            return jToken.ToObject<DbConnection>();
        }

        public void SerializeToFile(string configFilePath) {
            FileInfo file = new FileInfo(configFilePath);
            if (file.Exists) {
                JArray jObjects = new JArray();
                if (file.Length > 0) {
                    string fileContent = File.ReadAllText(configFilePath);
                    jObjects = JArray.Parse(fileContent);
                    jObjects.Where(jo => jo["Name"].ToString() == this.Name).ToList().ForEach(jo => jo.Remove()); 
                }
                JToken connection = JToken.FromObject(this);
                jObjects.Add(connection);
                File.WriteAllText(configFilePath, jObjects.ToString());
            }
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
