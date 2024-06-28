﻿using C__Learning.Class;
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
        private ScreenLogin loginRegister;
        private Login login;
        private DeleteFields deleteFields;

        public ScreenLogin()
        {
            InitializeComponent();
            InitializeLogin();
            ListadoBotones();
            ListadoTextbox();

            deleteFields = new DeleteFields(this, diccionarioTextbox);
            login = new Login(this, diccionarioBotones, diccionarioTextbox,deleteFields);
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

        private void btnsignin_Click(object sender, EventArgs e)
        {
            login.loginmethod(sender, e);
        }

        private void chpassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chpassword.Checked) 
            {
                txtpassword.PasswordChar = '\0';
            }
            else 
            {
                txtpassword.PasswordChar = '•';
            }
        }
    }
}