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
        private ScreenToken _screenToken;
        
        public LoginToken(ScreenToken _screenToken,Dictionary<string, TextBox> _dictionaryTextBox) 
        {
            this._screenToken = _screenToken;
            this._dictionaryTextBox = _dictionaryTextBox;
            DictionaryDefinition();
        }

        private Dictionary<string, TextBox> _dictionaryTextBox;
        private string _values;
        private void DictionaryDefinition() 
        {
            if(_screenToken != null && _screenToken.textBoxList != null) 
            {
                var txtBox = _screenToken.textBoxList;

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
            try
            {
                string code = "select ID from Users where ID=@id";
                using (SqlConnection connectionSQL = ConnectionDatabase.GetSqlConnection())
                {
                    connectionSQL.Open();
                    SqlCommand command = new SqlCommand(code, connectionSQL);
                    command.Parameters.AddWithValue("@id",_values);
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read()) 
                    {
                        MessageBox.Show("User has found");
                    }
                    else 
                    {
                        MessageBox.Show("Token: " + _values);
                        MessageBox.Show("User has not found");
                        
                    }
                    connectionSQL.Close();
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
