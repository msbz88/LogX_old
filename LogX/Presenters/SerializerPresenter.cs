using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json.Linq;
using System.Threading.Tasks;
using System.IO;
using LogX.Models;

namespace LogX.Presenters {
    public static class SerializerPresenter {
        public static DbConnection DeserializeFromFile(string configFilePath, string name) {
            JArray jObjects = new JArray();
            JToken jToken = null;
            FileInfo file = new FileInfo(configFilePath);
            if (file.Exists && file.Length > 0) {
                string fileContent = File.ReadAllText(configFilePath);
                jObjects = JArray.Parse(fileContent);
                jToken = jObjects.First(jo => jo["Name"].ToString() == name);
            } else { throw new InvalidOperationException(); }
            return jToken.ToObject<DbConnection>();
        }

        public static void SerializeToFile(string configFilePath, DbConnection dbConnection) {
            JArray jObjects = new JArray();
            FileInfo file = new FileInfo(configFilePath);
            if (file.Exists && file.Length > 0) {
                string fileContent = File.ReadAllText(configFilePath);
                try {
                    jObjects = JArray.Parse(fileContent);
                    jObjects.Where(jo => jo["Name"].ToString() == dbConnection.ConnectionName).ToList().ForEach(jo => jo.Remove());
                } catch (Exception) { file.Delete(); }
            }
            JToken connection = JToken.FromObject(dbConnection);
            jObjects.Add(connection);
            File.WriteAllText(configFilePath, jObjects.ToString());
        }
    }
}
