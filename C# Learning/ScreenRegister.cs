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
    public partial class ScreenRegister : Form
    {
        private ScreenLogin screenLogin;
        public ScreenRegister()
        {
            InitializeComponent();

        }

        private void OpenLogin(object Form)
        {

        }
        private void lblLogin_Click(object sender, EventArgs e)
        {
            screenLogin = new ScreenLogin();
            screenLogin.Show();
        }

        //private void FieldEquals()
        //{
        //    if (txtnewpass.Text != txtnewuser.Text)
        //    {
        //        MessageBox.Show("Si, esto los valida y no son iguales");
        //    }
        //    else 
        //    {
        //        MessageBox.Show("Ahora si son iguales");
        //    }
        //}

        private void btnsignin_Click(object sender, EventArgs e)
        {

        }

        private void ScreenRegister_Load(object sender, EventArgs e)
        {

        }
    }
}
