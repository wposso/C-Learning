using C__Learning.Class;
using System.Data.SqlClient;
using System.Drawing.Text;
using System.Security.Cryptography.X509Certificates;

namespace C__Learning
{
    public partial class ScreenReserve : Form
    {
        private Dictionary<string, Button> buttonMap;
        private LoadInfo loadMethod;
        private UpdateState updateState;

        private Button button;
        public ScreenReserve()
        {
            InitializeComponent();
            InitializeDatabaseConnection();
            InitializeButtonMap();
            InitializeLoadMethod();
            InitializeUpdateStatus();

            
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void InitializeDatabaseConnection()
        {
            try
            {
                ConnectionDatabase.OpenConnection();
                SqlConnection connection = ConnectionDatabase.GetSqlConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Has ocurred an error with database", ex.Message);
            }
        }
        private void InitializeButtonMap()
        {
            buttonMap = new Dictionary<string, Button>();

            buttonMap.Add("co01", btnco01);
            buttonMap.Add("co02", btnco02);
            buttonMap.Add("co03", btnco03);

        }
        private void InitializeLoadMethod()
        {
            loadMethod = new LoadInfo(buttonMap);
            loadMethod.loadInfo(this, EventArgs.Empty);
        }
        private void InitializeUpdateStatus()
        {
            updateState = new UpdateState();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            InitializeLoadMethod();
        }

        public void btnrelease_Click(object sender, EventArgs e)
        {

        }

        private void btnco01_Click(object sender, EventArgs e)
        {
            btnrelease.Tag = "co01";
        }

        private void btnco02_Click(object sender, EventArgs e)
        {
            btnrelease.Tag = "co02";
        }

        private void btnco03_Click(object sender, EventArgs e)
        {
            btnrelease.Tag = "co03";
        }
    }

}
