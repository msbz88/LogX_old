using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogX {
    class FlatFile {
        public string FilePath { get; set; }

        public FlatFile(string filePath) {
            FilePath = filePath;
        }

        public void Write(DataTable dt) {
            StringBuilder sb = new StringBuilder();
            IEnumerable<string> columnNames = dt.Columns.Cast<DataColumn>().Select(column => column.ColumnName);
            sb.AppendLine(string.Join("\t", columnNames));

            foreach (DataRow row in dt.Rows) {
                IEnumerable<string> fields = row.ItemArray.Select(field => field.ToString());
                sb.AppendLine(string.Join("\t", fields));
            }
            File.WriteAllText(FilePath, sb.ToString());
        }
    }
}
