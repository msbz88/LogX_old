using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogX {
    public class InfoMessage {
        static Timer Timer = new Timer();

        public static void WriteSuccessful(Label label, string message) {
            label.ForeColor = Color.Green;
            label.Text = message;
            ClearTimer(label);
        }

        public static void WriteError(Label label, string message) {
            label.ForeColor = Color.Red;
            label.Text = message;
            ClearTimer(label);
        }

        public static void WriteSuccessful(RichTextBox richTextBox, string message) {
            richTextBox.ForeColor = Color.Green;
            richTextBox.AppendText(message + Environment.NewLine);
            ClearTimer(richTextBox);
        }

        public static void WriteError(RichTextBox richTextBox, string message) {
            richTextBox.ForeColor = Color.Red;
            richTextBox.AppendText(message + Environment.NewLine);
            ClearTimer(richTextBox);
        }

        private static void ClearTimer(Label label) {
            Timer.Stop();
            Timer.Interval = 10000;
            Timer.Tick += (s, e) =>
            {
                Timer.Stop();
                label.Text = "";               
                label.ForeColor = Color.Black;
            };
            Timer.Start();
        }

        private static void ClearTimer(RichTextBox richTextBox) {
            Timer.Stop();
            Timer.Interval = 15000;
            Timer.Tick += (s, e) => {
                Timer.Stop();
                richTextBox.Text = "";
                richTextBox.ForeColor = Color.Black;
            };
            Timer.Start();
        }
    }
}
