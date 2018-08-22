using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogX {
    public class Connection {
        public string String { get; set; }

        public Connection(string host, string port, string schema, string password, string sid = "", string serviceName = "") {
            string sidOrServiceName = "";
            if (sid == "") {
                sidOrServiceName = "SERVICE_NAME=" + serviceName;
            } else {
                sidOrServiceName = "SID=" + sid;
            }
            String = "Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(" +
                   "HOST=" + host + ")(" +
                   "PORT=" + port + ")))(" +
                   "CONNECT_DATA=(" + sidOrServiceName + "))); " +
                   "USER ID=" + schema + "; " +
                   "PASSWORD=" + password + ";";
        }
    }
}
