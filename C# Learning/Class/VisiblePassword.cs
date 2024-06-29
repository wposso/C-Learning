using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Learning.Class
{
    internal class VisiblePassword
    {
        private ScreenLogin screenLogin;

        public VisiblePassword(ScreenLogin screenLogin,Dictionary<string, TextBox> textBoxList, Dictionary<string, Label> labelList) 
        { 
            this.screenLogin = screenLogin;
            this.textBoxList = textBoxList;
            this.labelList = labelList;
            dictionaryDefinition();
            labelDefinition();
        }
        private Dictionary<string, Label> labelList;

        private Label lblShowPass;
        private void labelDefinition() 
        {
            if (labelList.ContainsKey("lblShowPass")) 
            {
                lblShowPass = labelList["lblShowPass"];
            }
        }

        private Dictionary<string, TextBox> textBoxList;

        private TextBox txtpassword;

        private void dictionaryDefinition() 
        {
            if (textBoxList.ContainsKey("txtpassword")) 
            {
                txtpassword = textBoxList["txtpassword"];
            }
        }
        public void mouseEnter(object sender, EventArgs e) 
        {
            txtpassword.PasswordChar = '\0';
        }
        public void mouseLeave(object sender, EventArgs e) 
        {
            txtpassword.PasswordChar = '•';
        }

        public void showIconPass(object sender, EventArgs e) 
        {
            if(lblShowPass.Visible == false) 
            {
                lblShowPass.Visible = true;
            }
            if (string.IsNullOrEmpty(txtpassword.Text)) 
            {
                lblShowPass.Visible = false;
            }
        }
    }
}
