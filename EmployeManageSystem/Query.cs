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

    public partial class QueryForm : Form
    {
        public MySqlConnection connection;
        private string connectionString = "server=localhost;database=employe_manage_db;uid=root;password=Loyiha330";
        public QueryForm()
        {
            InitializeComponent();
            connection = new MySqlConnection(connectionString);
        }

        private void query_label_Click(object sender, EventArgs e)
        {

        }

        private void query_result_btn_Click(object sender, EventArgs e)
        {
            string query = query_textbox.Text;
            try
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView1.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
