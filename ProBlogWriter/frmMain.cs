using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;




namespace ProBlogWriter
{
    public partial class frmMain : Form
    {
        private string version = Assembly.GetExecutingAssembly().GetName().Version.ToString();

        public frmMain()
        {
            InitializeComponent();
            this.Text = this.Text + "  (" + version + ")";
        }
    }
}
