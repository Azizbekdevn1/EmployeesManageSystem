using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace EmployeManageSystem
{
    public partial class Form1 : Form
    {

        public MySqlConnection connection;
        private string connectionString = "server=localhost;database=employe_manage_db;uid=root;password=Loyiha330";
        public Form1()
        {
            InitializeComponent();
            connection=new MySqlConnection(connectionString);
        }

        public void loadform(object Form)
        {
            if(this.mainpanel.Controls.Count > 0)
            {
                this.mainpanel.Controls.RemoveAt(0);
            }
            Form  f=Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainpanel.Controls.Add(f);
            this.mainpanel.Tag = f;
            f.Show();

        }

        private void mainpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            loadform(new AddressForm());
        }

        private void panelside_Paint(object sender, PaintEventArgs e)
        {

        }

        private void query_btn_Click(object sender, EventArgs e)
        {
            QueryForm queryForm = new QueryForm();
            queryForm.Show();
        }
    }
}
