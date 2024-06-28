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
        private ScreenLogin screenRegister;
        private Dictionary<string, Button> listadoBotones;
        private Dictionary<string, TextBox> ListadoTextbox;
        private DeleteFields deleteFields;

        public Login(ScreenLogin screenRegister, Dictionary<string, Button> listadoBotones, Dictionary<string, TextBox> ListadoTextbox,DeleteFields deleteFields) 
        {
            this.screenRegister = screenRegister;
            this.listadoBotones = listadoBotones;
            this.ListadoTextbox = ListadoTextbox;
            this.deleteFields = deleteFields;
        }

        private Button singin;
        private void listadoBotonesDefinition(object sender, EventArgs e) 
        {
            Button singin = null;

            if (listadoBotones.ContainsKey("btnsingin"))
            {
                singin = listadoBotones["btnsingin"];
            }
        }

        //private TextBox txtusername;
        //private TextBox txtpassword;
        private void listadoTextboxDefinition(object sender, EventArgs e) 
        {
            //TextBox txtusername = null;
            //TextBox txtpassword = null;

            //if (ListadoTextbox.ContainsKey("txtusername"))
            //{
            //    txtusername = ListadoTextbox["txtusername"];
            //}
            //if (ListadoTextbox.ContainsKey("txtPassword"))
            //{
            //    txtpassword = ListadoTextbox["txtpassword"];
            //}
        }

        public void loginmethod(object sender, EventArgs e)
        {
            TextBox txtusername = null;
            TextBox txtpassword = null;

            if (ListadoTextbox.ContainsKey("txtusername"))
            {
                txtusername = ListadoTextbox["txtusername"];
            }
            if (ListadoTextbox.ContainsKey("txtpassword"))
            {
                txtpassword = ListadoTextbox["txtpassword"];
            }

            try
            {
                string code = ("select username, password from users where username=@txtusername and password=@txtpassword");
                using (SqlConnection connection = ConnectionDatabase.GetSqlConnection()) 
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(code, connection)) 
                    {
                        command.Parameters.AddWithValue("txtusername", txtusername.Text);
                        command.Parameters.AddWithValue("txtpassword", txtpassword.Text);
                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.Read())
                        {
                            MessageBox.Show("usuario encontrado");
                        }
                        else
                        {
                            MessageBox.Show("Usuario no encontrado");
                        }
                        reader.Close();
                        deleteFields.emptyFields(sender, e);
                    }
                    ConnectionDatabase.CloseConnection();
                } 
            }
            catch (Exception ex)
            {

                MessageBox.Show("has ocurred an error with database", ex.Message);

            }

        }
    }
}
