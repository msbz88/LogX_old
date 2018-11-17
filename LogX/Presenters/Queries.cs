using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using System.ComponentModel;
using System.Data;
using LogX.Models;

namespace LogX.Controllers {
    public class Queries {
        DbConnection Connection { get; set; }
        static OraSession OraSession { get; set; }
        static FlatFile FlatFile = new FlatFile(@"C:\Users\msbz\Desktop\Sharp_extracts\BJG.txt");

        public static async void LastExecutedBJG() {
            DateTime FromDate = new DateTime(2015, 5, 1);
            DataTable excludedBJG = await FindFailedBJG(FromDate);
            if (excludedBJG.Rows.Count > 0) {
                FormExcludedBJG FormExcludedBJG = new FormExcludedBJG();
                FormExcludedBJG.Show();
                FormExcludedBJG.FillListView(excludedBJG);
            } else {
                string query = "with last_ex as ( " +
                                "select bjg.bjobgrpik, bj.bjobik, max(ex.startts) max_start " +
                                "from BATCHJOBEXECS ex " +
                                "join BATCHJOBS bj on bj.bjobik = ex.bjobik " +
                                "join BATCHJOBGRPS bjg on bjg.bjobgrpik = ex.bjobgrpik " +
                                "where ex.startts >= to_timestamp(:FromDate,'DD/MM/YYYY HH24:MI:SS') " +
                                "group by bjg.bjobgrpik, bj.bjobik) " +

                                "select bjg.bjobgrp, bj.bjob, ex.bjobstat, lex.max_start, sub.bjobactive, sub.sort " +
                                "from last_ex lex " +
                                "join BATCHJOBEXECS ex on ex.bjobgrpik = lex.bjobgrpik and ex.bjobik = lex.bjobik and ex.startts = lex.max_start " +
                                "join BATCHJOBS bj on bj.bjobik = ex.bjobik " +
                                "join BATCHJOBGRPS bjg on bjg.bjobgrpik = ex.bjobgrpik " +
                                "join BATCHJOBGRPSSUB sub on sub.bjobgrpik = bjg.bjobgrpik and sub.bjobik = bj.bjobik";
                OracleCommand cmd = new OracleCommand(query, OraSession.OracleConnection);
                cmd.Parameters.Add(":FromDate", OracleDbType.Varchar2).Value = FromDate;
                DataTable dt = await OraSession.ExecuteQueryParallel(cmd);
                FlatFile.Write(dt);
            }
        }

        private static async Task<DataTable> FindFailedBJG(DateTime fromDate) {
            string query = "with last_ex as ( " +
                            "select bjg.bjobgrpik, bj.bjobik, max(ex.startts) max_start " +
                            "from BATCHJOBEXECS ex " +
                            "join BATCHJOBS bj on bj.bjobik = ex.bjobik " +
                            "join BATCHJOBGRPS bjg on bjg.bjobgrpik = ex.bjobgrpik " +
                            "where ex.startts >= to_timestamp(:FromDate,'DD/MM/YYYY HH24:MI:SS') " +
                            "group by bjg.bjobgrpik, bj.bjobik) " +

                            "select bjg.bjobgrp, bj.bjob, DECODE(ex.bjobstat,1,'Failed',2,'Cancelled/stopped',3,'Not executed',4,'Executing',5,'N/A',6,'Not active') bjobstat, lex.max_start, sub.bjobactive, sub.sort " +
                            "from last_ex lex " +
                            "join BATCHJOBEXECS ex on ex.bjobgrpik = lex.bjobgrpik and ex.bjobik = lex.bjobik and ex.startts = lex.max_start " +
                            "join BATCHJOBS bj on bj.bjobik = ex.bjobik " +
                            "join BATCHJOBGRPS bjg on bjg.bjobgrpik = ex.bjobgrpik " +
                            "join BATCHJOBGRPSSUB sub on sub.bjobgrpik = bjg.bjobgrpik and sub.bjobik = bj.bjobik " +
                            "where ex.bjobstat <> 0 " +
                            "order by bjg.bjobgrp, sub.sort";

            OracleCommand cmd = new OracleCommand(query, OraSession.OracleConnection);
            cmd.Parameters.Add(":FromDate", OracleDbType.Varchar2).Value = fromDate;
            return await OraSession.ExecuteQueryParallel(cmd);
        }
    }
}
