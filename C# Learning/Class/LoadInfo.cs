using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace C__Learning.Class
{
    internal class LoadInfo
    {
       private Dictionary<string, Button> buttonMap;

        public LoadInfo(Dictionary<string,Button> buttonMap) 
        {
            this.buttonMap = buttonMap; 
        }
        public void loadInfo(object sender, EventArgs e) 
        {
            try
            {
                string code = ("select code, isbusy from airplane");
                SqlCommand command = new SqlCommand(code,ConnectionManage.GetSqlConnection());
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string codeID = reader["code"].ToString();
                    int isbusy = Convert.ToInt32(reader["isbusy"]);

                    if (buttonMap.ContainsKey(codeID)) 
                    {   
                        Button button = buttonMap[codeID];
                        if (isbusy == 1)
                        {
                            button.BackColor = Color.Red;
                            button.ForeColor = Color.White;
                        }
                        else if (isbusy == 0)
                        {
                            button.BackColor = Color.Green;
                            button.ForeColor = Color.White;
                        }
                    }
                    
                }
                reader.Close();

            }
            catch (Exception ex) 
            {
                MessageBox.Show("Has ocurred an error with database",ex.Message);
            }
        }
    }
}
