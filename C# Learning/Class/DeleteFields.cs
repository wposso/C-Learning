using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Learning.Class
{
    internal class DeleteFields
    {
        private ScreenRegister screenRegister;
        private Dictionary<string, TextBox> textBoxs;

        public DeleteFields(ScreenRegister screenRegister,Dictionary<string, TextBox>textBoxs ) 
        {
            this.screenRegister = screenRegister;
            this.textBoxs = textBoxs;
            textDefinition();
           
        }

        private TextBox txtusername;
        private TextBox txtpassword;
        private void textDefinition() 
        {
            //TextBox txtusername = null;
            //TextBox txtpassword = null;

            if (textBoxs.ContainsKey("txtusername"))
            {
                txtusername = textBoxs["txtusername"];
            }
            if (textBoxs.ContainsKey("txtpassword"))
            {
                txtpassword = textBoxs["txtpassword"];
            }
        }

        public void emptyFields(object sender, EventArgs e) 
        {
            txtusername.Clear();
            txtpassword.Clear();
        }

    }
}
