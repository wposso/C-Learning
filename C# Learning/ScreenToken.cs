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
        private LoginToken _loginToken;
        public ScreenToken()
        {
            InitializeComponent();
            DictionarytxtBox();
            InitializeClass();
        }

        private void InitializeClass() 
        {
            _loginToken = new LoginToken(this);
        }
        public Dictionary<string, TextBox> _dictionarytxtBox;
        private void DictionarytxtBox() 
        {
            _dictionarytxtBox = new Dictionary<string, TextBox> 
            {
                {"txtToken1", txtToken1 },
                {"txtToken2", txtToken2 },
                {"txtToken3", txtToken3 },
                {"txtToken4", txtToken4 }
            };
        }
    }
}
