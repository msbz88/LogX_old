using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogX {
    public class Message {
        public static void WriteSuccessful(Label label, string message) {
            label.ForeColor = Color.Green;
            label.Text = message;
        }

        public static void WriteError(Label label, string message) {
            label.ForeColor = Color.Red;
            label.Text = message;
        }
    }
}
