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
    public partial class ScreenLogin : Form
    {
        private Login login;
        private DeleteFields deleteFields;
        private VisiblePassword visiblePassword;
        private ValidateToken validateToken;
        private PanelContainer panelContainer;
        private LoginToken _loginToken;
        private ScreenRegister screenRegister;
        private ScreenToken _screenToken;
        public ScreenLogin()
        {
            InitializeComponent();
            InitializeLogin();
            ListadoBotones();
            ListadoTextbox();
            ListadoPanel();
            ListadoLabel();
            InitializeScreens();
            InitializeClass();
            InitializeEvents();
        }
        private void InitializeScreens() 
        {
            _screenToken = new ScreenToken();
        }
        private void InitializeClass() 
        {
            deleteFields = new DeleteFields(this, diccionarioTextbox);
            login = new Login(this, diccionarioBotones, diccionarioTextbox, deleteFields);
            panelContainer = new PanelContainer(this, diccionarioPanel);
            visiblePassword = new VisiblePassword(this, diccionarioTextbox, diccionarioLabel);
            _loginToken = new LoginToken(_screenToken);
            
        }
        private void InitializeEvents() 
        {
            txtpassword.TextChanged += new EventHandler(visiblePassword.showIconPass);
            lblShowPass.MouseEnter += new EventHandler(visiblePassword.mouseEnter);
            lblShowPass.MouseLeave += new EventHandler(visiblePassword.mouseLeave);
        }

        private void InitializeLogin()
        {

        }

        public Dictionary<string, Button> diccionarioBotones;
        private void ListadoBotones()
        {
            diccionarioBotones = new Dictionary<string, Button>
            {
                {"btnsignin",btnsignin }
            };
        }

        private Dictionary<string, TextBox> diccionarioTextbox;
        private void ListadoTextbox()
        {
            diccionarioTextbox = new Dictionary<string, TextBox>
            {
                {"txtusername",txtusername},
                {"txtpassword",txtpassword},
            };
        }

        private Dictionary<string, Panel> diccionarioPanel;
        private void ListadoPanel()
        {
            diccionarioPanel = new Dictionary<string, Panel>
            {
                {"pnlContainer",pnlContainer},
                {"pnlToken",pnlToken },
            };
        }

        private Dictionary<string, Label> diccionarioLabel;
        private void ListadoLabel()
        {
            diccionarioLabel = new Dictionary<string, Label>
            {
                {"lblShowPass",lblShowPass },
            };
        }

        private bool useLoginToken = true;
        private void btnsignin_Click(object sender, EventArgs e)
        {
            if (useLoginToken) 
            {
                _loginToken._LoginToken(sender, e);
            }
            
            login.loginmethod(sender,e);
        }

        
        private void lblLogin_Click(object sender, EventArgs e)
        {
            panelContainer.panelContainer(screenRegister);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtusername_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblShowPass_Click(object sender, EventArgs e)
        {
        }

        private void pnlContainer_Paint(object sender, PaintEventArgs e)
        {

        }


        private void label4_Click(object sender, EventArgs e)
        { 
        }

        private void btnToken_Click(object sender, EventArgs e)
        {
            panelToken(_screenToken);
        }

        private void ScreenLogin_Load(object sender, EventArgs e)
        {

        }
        private void panelToken(object Token) 
        {
            pnlToken.Controls.Clear();
            Form B = Token as Form;
            B.TopLevel = false;
            B.Dock = DockStyle.Fill;
            this.pnlToken.Controls.Add(B);
            this.pnlToken.Tag = B;
            B.Show();
        }
       
 
    }
}
