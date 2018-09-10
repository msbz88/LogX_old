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
    public partial class FormExcludedBJG : Form {
        public FormExcludedBJG() {
            InitializeComponent();
            InitListViewExcludedBJG();
        }

        private void InitListViewExcludedBJG() {
            listViewExcludedBJG.Columns.Add("Batch Job Group", 150, HorizontalAlignment.Left);
            listViewExcludedBJG.Columns.Add("Batch Job", 150, HorizontalAlignment.Left);
            listViewExcludedBJG.Columns.Add("Status", 50, HorizontalAlignment.Left);
            listViewExcludedBJG.Columns.Add("Last time Executed", 120, HorizontalAlignment.Left);
            listViewExcludedBJG.Columns.Add("Active", 50, HorizontalAlignment.Left);
            listViewExcludedBJG.Columns.Add("Sort", 50, HorizontalAlignment.Left);
            textBoxExcludedBJG.Text = "For BJG from list below logs will not be generated:";
        }

        public void FillListView(DataTable dt) {
            listViewExcludedBJG.Items.Clear();
            foreach (DataRow row in dt.Rows) {
                ListViewItem item = new ListViewItem(row[0].ToString());
                for (int i = 1; i < dt.Columns.Count; i++) {
                    item.SubItems.Add(row[i].ToString());
                }
                listViewExcludedBJG.Items.Add(item);
            }
        }
    }
}
