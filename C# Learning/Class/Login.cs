using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Learning.Class
{
    internal class Login
    {
        private LoginRegister loginregister;

        public Login(LoginRegister loginRegister) 
        {
            this.loginregister = loginRegister;
        }

        public void loginmethod(object sender, EventArgs e)
        {
            string username = loginregister.txtusername.Text;
            string password = loginregister.txtpassword.Text;

            try
            {
                string code = ("select username, password from user where username='"+username+"' and password='"+password+"'");
                SqlCommand command = new SqlCommand(code, ConnectionManage.GetSqlConnection());
                SqlDataReader reader = command.ExecuteReader();
                

                if (reader.Read()) 
                {
                    MessageBox.Show("login success");
                }
                else 
                {
                    MessageBox.Show("Connection Failed");
                }
                reader.Close();
                
            }
            catch (Exception ex)
            {

                MessageBox.Show("has ocurred an error with database", ex.Message);

            }

        }
    }
}
