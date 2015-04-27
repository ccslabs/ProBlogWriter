using ProBlogWriter.Forms.Dockable.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;




namespace ProBlogWriter
{
    public partial class frmMain : Form
    {
        private string version = Assembly.GetExecutingAssembly().GetName().Version.ToString();
        private string configFile = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),"ProBlogWriter\\config.xml");
        private bool m_bSaveLayout = true;
        private DeserializeDockContent m_deserializeDockContent;
        private frmLogging loggingForm = null;


        public frmMain()
        {
            InitializeComponent();

            if(FirstRun())
            {
                Directory.CreateDirectory(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "ProBlogWriter"));
                // Better get the User's Wordpress Account details
                // Better Get the User's Facebook Details
                // Better Get the User's Twitter Details
                // Other accounts can be added through plugins.
            }

            this.Text = this.Text + "  (" + version + ")";
            m_deserializeDockContent = new DeserializeDockContent(GetContentFromPersistString);
            
        }

        private bool FirstRun()
        {
            // Simple check for just now
            return !Directory.Exists(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "ProBlogWriter"));
        }

        private IDockContent GetContentFromPersistString(string persistString)
        {
            if (persistString == typeof(frmLogging).ToString())
            {
            loggingForm = new frmLogging();
            Log("Loading Logging Window");
            loggingToolStripMenuItem.Checked = true;
            return loggingForm;
            }

            return null;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            if (File.Exists(configFile))
                dockPanel.LoadFromXml(configFile, m_deserializeDockContent);
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (m_bSaveLayout)
            {
                Log("Saving layout.");
                dockPanel.SaveAsXml(configFile);
            }
            else if (File.Exists(configFile))
                File.Delete(configFile);
        }

        private void Log(string message)
        {
            loggingForm.Log(message);
        }

        private void loggingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(loggingToolStripMenuItem.Checked)
            {
                loggingForm.Close();
                loggingForm = null;
            }
            else
            {
                if (loggingForm == null)
                {
                    loggingForm = new frmLogging();
                    loggingForm.Show(dockPanel, DockState.DockBottom);
                   Log("Loading Logging Window");
                }                
            }

            loggingToolStripMenuItem.Checked = !loggingToolStripMenuItem.Checked; // Toggle the check state
        }
    }
}
