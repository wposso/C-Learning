using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Learning.Class
{
    internal class ValidateToken    
    {
        //...Screens
        private ScreenToken screenToken;

        public ValidateToken(ScreenToken screenToken, Dictionary<string, TextBox> textBoxList) 
        {
            this.screenToken = screenToken;
            this.textBoxList = textBoxList;
            textDefinition();
        }

        private Dictionary<string, TextBox> textBoxList;

        private TextBox txt1;
        private TextBox txt2;
        private TextBox txt3;
        private TextBox txt4;
        private void textDefinition() 
        {
            if(textBoxList.ContainsKey("txtToken1")) 
            {
                txt1 = textBoxList["txtToken1"];
            }
            if (textBoxList.ContainsKey("txtToken2")) 
            {
                txt2 = textBoxList["txtToken2"];
            }
            if (textBoxList.ContainsKey("txtToken3")) 
            {
                txt3 = textBoxList["txtToken3"];
            }
            if (textBoxList.ContainsKey("txtToken4")) 
            {
                txt4 = textBoxList["txtToken4"];
            }
        }

        public void tokenValidation(object sender, EventArgs e)
        {
            try
            {
                string code = "select ID from Users where ID ='" + txt1.Text + "'+'" + txt2.Text + "'+'" + txt3.Text + "'";
                using (SqlConnection SQLconnection = ConnectionDatabase.GetSqlConnection())
                {
                    SQLconnection.Open();
                    SqlCommand command = new SqlCommand(code, SQLconnection);
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        MessageBox.Show("Token has been found");
                    }
                    else
                    {
                        MessageBox.Show("Token has not been found");
                    }
                    SQLconnection.Close();
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Error: database"+ex.Message);
            }
        }
        
    }
}
