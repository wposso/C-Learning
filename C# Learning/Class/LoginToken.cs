using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Learning.Class
{
    internal class LoginToken
    {
        private ScreenToken screenToken;

        public LoginToken(ScreenToken _screenToken)
        {
            screenToken = _screenToken;
            
        }

        public Dictionary<string, TextBox> _dictionaryTextBox;
        private string _values;
        private void DictionaryDefinition()
        {
            if (screenToken != null && screenToken._dictionarytxtBox != null)
            {
                var txtBox = screenToken._dictionarytxtBox;

                if (txtBox.ContainsKey("txtToken1") &&
                    txtBox.ContainsKey("txtToken2") &&
                    txtBox.ContainsKey("txtToken3") &&
                    txtBox.ContainsKey("txtToken4"))

                {
                    _values = txtBox["txtToken1"].Text +
                        txtBox["txtToken2"].Text +
                        txtBox["txtToken3"].Text +
                        txtBox["txtToken4"].Text;
                }
            }
        }
        public void _LoginToken(object sender, EventArgs e)
        {
            DictionaryDefinition();
            try
            {
                string code = "select ID from Users where ID=@id";
                using (SqlConnection connectionSQL = ConnectionDatabase.GetSqlConnection())
                {
                    connectionSQL.Open();
                    SqlCommand command = new SqlCommand(code, connectionSQL);
                    command.Parameters.AddWithValue("@id", _values);
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        MessageBox.Show("Token found");
                    }
                    else
                    {
                        MessageBox.Show("Token not found");

                    }
                    connectionSQL.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        public void _debug(object sender, EventArgs e) 
        {
            
            MessageBox.Show("Token: " + _values);
        }
    }
}
