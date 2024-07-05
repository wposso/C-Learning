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
        //...Class
        private Login login;
        private DeleteFields deleteFields;
        private VisiblePassword visiblePassword;
        private ValidateToken validateToken;
        private PanelContainer panelContainer;
        private LoginToken loginToken;

        //...Screens
        private ScreenRegister screenRegister;
        private ScreenToken screenToken;
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
        }
        private void InitializeScreens() 
        {
            screenToken = new ScreenToken();
        }
        private void InitializeClass() 
        {
            deleteFields = new DeleteFields(this, diccionarioTextbox);
            login = new Login(this, diccionarioBotones, diccionarioTextbox, deleteFields);
            panelContainer = new PanelContainer(this, diccionarioPanel);
            visiblePassword = new VisiblePassword(this, diccionarioTextbox, diccionarioLabel);
            loginToken = new LoginToken(screenToken,diccionarioTextbox);

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

        private void btnsignin_Click(object sender, EventArgs e)
        {
            loginToken._LoginToken(sender,e);
            //login.loginmethod(sender, e);
            //MessageBox.Show("Token: " + _AllTextBox);
        }

        
        private void lblLogin_Click(object sender, EventArgs e)
        {
            screenRegister = new ScreenRegister();
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
                //string tokenFields = txtToken1.Text + txtToken2.Text + txtToken3.Text + txtToken4.Text;
                //MessageBox.Show("Fields: " + tokenFields);
            
        }

        private void btnToken_Click(object sender, EventArgs e)
        {
            screenToken = new ScreenToken();
            panelToken(screenToken);
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
