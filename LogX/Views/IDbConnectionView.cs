using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogX.Views {
    public interface IDbConnectionView {
        event EventHandler TestConnectionEvent;
        event EventHandler SaveConnectionEvent;

        string ConnectionName { get; set; }
        string Host { get; set; }
        string Port { get; set; }
        string Schema { get; set; }
        string Password { get; set; }
        string Sid { get; set; }
        string ServiceName { get; set; }
        bool IsMasterActive { get; set; }
        bool IsTestActive { get; set; }

        void WriteError(string message);
        void WriteSuccessful(string message);
        void ClearAllTextBoxes();
    }
}
