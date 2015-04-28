using ProBlogWriter.Classes.Wordpress;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProBlogWriter.Forms.Dialogs
{
    public partial class frmLogin : Form
    {
        internal enum LoginProvider
        {
            Wordpress,
            Twitter,
            YouTube,
            Facebook,
        }

        internal LoginProvider loginProvider { get; set; }

        public frmLogin()
        {
            InitializeComponent();
            switch (loginProvider)
            {
                case LoginProvider.Wordpress:
                    loginWordpress();
                    break;
                case LoginProvider.Twitter:
                    break;
                case LoginProvider.YouTube:
                    break;
                case LoginProvider.Facebook:
                    break;
                default:
                    break;
            }
        }

        private void loginWordpress()
        {
            pbLoginIcon.Image = ilLoginProviderIcons.Images[0];
            Text = "Wordpress Login";
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            switch (loginProvider)
            {
                case LoginProvider.Wordpress:
                    Wordpress wp = new Wordpress();
                    wp.wpUsername = tbUsername.Text;
                    wp.wpPassword = tbPassword.Text;
                    wp.GetBlogs();

                    break;
                case LoginProvider.Twitter:
                    break;
                case LoginProvider.YouTube:
                    break;
                case LoginProvider.Facebook:
                    break;
                default:
                    break;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }
    }
}
