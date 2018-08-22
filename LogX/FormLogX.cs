using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogX {
    public partial class FormLogX : Form {
        Connection Connection { get; set; }
        OraSession OraSession { get; set; }
        FlatFile FlatFile = new FlatFile(@"C:\Users\msbz\Desktop\Sharp_extracts\BJG.txt");

        public FormLogX() {
            InitializeComponent();
            Connect();
        }

        private void Connect() {
            if (OraSession == null) {
                Connection Connection = new Connection(host: "DK01SV7020", port: "1521", sid: "T7020230", schema: "TESTIMMD", password: "TESTIMMD");
                OraSession = new OraSession(Connection.String);
                textBoxMessages.Text = OraSession.TryConnect();
            }
        }

        private async void LastExecutedBJG() {
            if (OraSession != null) {
                DateTime FromDate = new DateTime(2017, 5, 1);
                string query = "select bjg.bjobgrpik, bj.bjobik, max(ex.startts) max_start " +
                    "from BATCHJOBEXECS ex " +
                    "join BATCHJOBS bj on bj.bjobik = ex.bjobik " +
                    "join BATCHJOBGRPS bjg on bjg.bjobgrpik = ex.bjobgrpik " +
                    "where ex.startts >= to_timestamp(:FromDate,'DD/MM/YYYY HH24:MI:SS') " +
                    "group by bjg.bjobgrpik, bj.bjobik";

                OracleCommand cmd = new OracleCommand(query, OraSession.OracleConnection);
                cmd.Parameters.Add(":FromDate", OracleDbType.Varchar2).Value = FromDate;
                textBoxMessages.Text = "Calculating...";
                DataTable dt = await OraSession.ExecuteQueryParallel(cmd);
                textBoxMessages.Text = "Writing to file...";
                FlatFile.Write(dt);
                textBoxMessages.Text = "Finished";
            }
        }

        private void ButtonGoClick(object sender, EventArgs e) {
            LastExecutedBJG();
        }
    }
}
