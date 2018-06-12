using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IT
{
    public partial class AuthorizationForm : Form
    {
        public AuthorizationForm()
        {
            InitializeComponent();
        }

        private void LoginBut_Click(object sender, EventArgs e)
        {
            try
            {
                Authenticator.Login(textBox_login.Text, textBox_pass.Text);
                switch (CurrentUser.user.Role)
                {
                    case "admin": { Visible = false; var sf = new AdminForm(); sf.ShowDialog(); break; }
                    //case "master": { new MasterForm().Show(); break; }
                    //case "storekeeper": { new StorekeeperForm().Show(); break; }
                }
                //Visible = false;
            }
            catch (AuthenticationException ex)
            { MessageBox.Show(ex.Message); }
            finally { Close(); }
        }
    }
}
