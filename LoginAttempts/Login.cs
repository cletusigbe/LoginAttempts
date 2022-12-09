using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginAttempts
{
    public partial class Login : Form
    {
        public int logAttempt = 0;
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "demo" && txtpwd.Text == "demo123")
            {
                //Do something
                this.Hide();
                Main main = new Main();
                main.Show();


            }
            else
            {
                MessageBox.Show("Wrong Username or Password");
                txtpwd.Text = "";
                txtUsername.Text = "";
                txtUsername.Focus();

                logAttempt += 1;

                if(logAttempt == 3)
                {
                    MessageBox.Show("You have exceeded the maximum number of attempts", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    btnLogin.Enabled = false;
                    txtpwd.Text = "";
                    txtUsername.Text = "";
                    txtpwd.Enabled = false;
                    txtUsername.Enabled = false;
                }

            }
        }
    }
}
