using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using WeifenLuo.WinFormsUI.Docking;

namespace ProBlogWriter.Forms.Dockable.Logging
{
    public partial class frmLogging : DockContent
    {

        public frmLogging()
        {
            InitializeComponent();
        }

        internal void Log(string message)
        {
            fctb.AppendText(message + Environment.NewLine);
        }
    }
}
