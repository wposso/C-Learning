using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Learning.Class
{
    internal class UpdateStateMethod
    {
        private Dictionary<string, Button> buttonMap;

        public void updateStateMethod(object sender, EventArgs e) 
        {
            string code = ("select code,isbusy from airplane");
            SqlCommand command = new SqlCommand(code,ConnectionManage.GetSqlConnection());
            SqlDataReader readr = command.ExecuteReader();

            while (readr.Read()) 
            {
                string codeID = readr["code"].ToString();
                int isbusy = Convert.ToInt32(readr["isbusy"]);

                if (buttonMap.ContainsKey(codeID)) 
                {
                    Button button = buttonMap[codeID];
                    if(isbusy == 1) 
                    {
                        button.BackColor = Color.Red;
                    }
                    else if(isbusy == 0) 
                    {
                        button.BackColor= Color.Green;
                    }
                }
            }
        }
    }
}
