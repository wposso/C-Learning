using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Learning.Class
{
    internal class PanelContainer
    {
        private Dictionary<string, Panel> ListadoPanel;
        private ScreenLogin screenLogin;

        public PanelContainer(ScreenLogin screenLogin,Dictionary<string, Panel> ListadoPanel) 
        {
            this.screenLogin = screenLogin;
            this.ListadoPanel = ListadoPanel;
            this.dictionaryDefinition();

        }

        private Panel pnlContainer;
        private void dictionaryDefinition()
        {
            if (this.ListadoPanel.ContainsKey("pnlContainer"))
            {
                pnlContainer = ListadoPanel["pnlContainer"];
            }
            else
            {
                MessageBox.Show("The Key was not found");
            }
        }
        public void panelContainer(object container) 
        {
            pnlContainer.Controls.Clear();
            Form A = container as Form;
            A.TopLevel = false;
            A.Dock = DockStyle.Fill;
            this.pnlContainer.Controls.Add(A);
            this.pnlContainer.Tag = A;
            A.Show();

        }
    }
}
