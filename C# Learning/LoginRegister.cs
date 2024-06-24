using C__Learning.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C__Learning
{
    public partial class LoginRegister : Form
    {
        public TextBox txtusername;
        public TextBox txtpassword;
        private Button btnlogin;

        private Login login;
        public LoginRegister()
        {
            InitializeComponent();
            InitializeLogin();
        }

        private void btnsignin_Click(object sender, EventArgs e)
        {
            login.loginmethod(sender, e);
        }

        private void InitializeLogin() 
        {
            this.login = new Login(this);
        }
    }
}
