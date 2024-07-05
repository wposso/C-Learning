using C__Learning.Class;
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
    public partial class ScreenToken : Form
    {
        //...Class
        private ValidateToken validateToken;
        private LoginToken loginToken;
        //...Screens
        
        public ScreenToken()
        {
            InitializeComponent();
            textBoxDictionary();
            InitializeClass();

        }
        private void InitializeClass() 
        {
            validateToken = new ValidateToken(this, textBoxList);
            loginToken = new LoginToken(this, textBoxList);
        }

        public Dictionary<string, TextBox> textBoxList;
        private void textBoxDictionary()
        {
            textBoxList = new Dictionary<string, TextBox> 
            {
                { "txtToken1",txtToken1},
                { "txtToken2",txtToken2},
                { "txtToken3",txtToken3},
                { "txtToken4",txtToken4},
            };
        }
    }
}
