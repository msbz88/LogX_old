using System;
using System.IO;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Collections.Generic;

namespace LogX.Models {
    public class DbConnection {
        [Required]
        [StringLength(150, MinimumLength = 3, ErrorMessage = "Connection name must be between 3 and 150 characters")]
        [DataType(DataType.Text)]
        public string ConnectionName { get; set; }
        [Required]
        [StringLength(150, MinimumLength = 3, ErrorMessage = "Username must be between 3 and 150 characters")]
        [DataType(DataType.Text)]
        public string Schema { get; set; }
        [Required]
        [StringLength(150, MinimumLength = 3, ErrorMessage = "Password must be between 3 and 150 characters")]
        [DataType(DataType.Text)]
        public string Password { get; set; }
        [Required]
        [StringLength(150, MinimumLength = 3, ErrorMessage = "Host name must be between 3 and 150 characters")]
        [DataType(DataType.Text)]
        public string Host { get; set; }
        [Required]
        [Range(1000, 10000, ErrorMessage = "Port must be an integer between 1000 and 10000")]
        public string Port { get; set; }
        public string Sid { get; set; }
        public string ServiceName { get; set; }

        public DbConnection(string connectionName, string host, string port, string schema, string password, string sid = "", string serviceName = "") {
            ConnectionName = connectionName;
            Host = host;
            Port = port;
            Schema = schema;
            Password = password;
            Sid = sid;
            ServiceName = serviceName;
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
