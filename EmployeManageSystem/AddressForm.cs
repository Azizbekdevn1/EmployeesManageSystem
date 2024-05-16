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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EmployeManageSystem
{
    public partial class AddressForm : Form
    {
        public MySqlConnection connection;
        private string connectionString = "server=localhost;database=employe_manage_db;uid=root;password=Loyiha330";
        public AddressForm()
        {
            InitializeComponent();
            connection = new MySqlConnection(connectionString);
        }
        public void clear()
        {
            street_textBox1.Text = "";
            city_textBox2.Text = "";
            postal_textBox3.Text = "";
            country_textBox4.Text = "";
        }

        private void LoadData()
        {
            try
            {
                connection.Open();
                string query = "SELECT * FROM addresses";
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

        private void AddressForm_Load(object sender, EventArgs e)
        {

        }

        private void select_btn_Click(object sender, EventArgs e)
        {
            LoadData(); 

        }
        int Selectedindexrow = 0;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Selectedindexrow = e.RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[Selectedindexrow];
            street_textBox1.Text = selectedRow.Cells[1].Value.ToString();
            city_textBox2.Text = selectedRow.Cells[2].Value.ToString();
            postal_textBox3.Text = selectedRow.Cells[3].Value.ToString();
            country_textBox4.Text = selectedRow.Cells[4].Value.ToString();
        }

        private void insert_btn_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                string param = "(street_address,city,postal_code,country)";
                string query = "insert into addresses" + param + "values(@street_address,@city,@postal_code,@country)";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@street_address", street_textBox1.Text);
                command.Parameters.AddWithValue("@city", city_textBox2.Text);
                command.Parameters.AddWithValue("@postal_code", postal_textBox3.Text);
                command.Parameters.AddWithValue("@country", country_textBox4.Text);
                int i = command.ExecuteNonQuery();
                MessageBox.Show("Yangi manzil qoshildi", "Add address", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clear();
                connection.Close();
                LoadData();
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

        private void delete_btn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int selectedIndex = dataGridView1.SelectedRows[0].Index;
                int selectedID = Convert.ToInt32(dataGridView1.Rows[selectedIndex].Cells["id"].Value);

                try
                {
                    connection.Open();
                    string deleteQuery = "DELETE FROM addresses WHERE id = @id";
                    MySqlCommand command = new MySqlCommand(deleteQuery, connection);
                    command.Parameters.AddWithValue("@id", selectedID);
                    int rowsAffected = command.ExecuteNonQuery();
                    MessageBox.Show("Manzil o'chirildi : " + rowsAffected);
                    connection.Close();
                    LoadData(); 
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
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            DataGridViewRow datagrid = dataGridView1.Rows[Selectedindexrow];

            datagrid.Cells[1].Value = street_textBox1.Text;
            datagrid.Cells[2].Value = city_textBox2.Text;
            datagrid.Cells[3].Value = postal_textBox3.Text;
            datagrid.Cells[4].Value = country_textBox4.Text;



            if (dataGridView1.SelectedRows.Count > 0)
            {
                connection.Open();
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                int id = Convert.ToInt32(selectedRow.Cells["id"].Value);
                string valuess = "street_address=@street_address,city=@city,postal_code=@postal_code,country=@country";
                string updatequery = "UPDATE addresses SET " + valuess + " WHERE id = @id";

                MySqlCommand command = new MySqlCommand(updatequery, connection);

                command.Parameters.AddWithValue("@id", id);
                command.Parameters.AddWithValue("@street_address", street_textBox1.Text);
                command.Parameters.AddWithValue("@city", city_textBox2.Text);
                command.Parameters.AddWithValue("@postal_code", postal_textBox3.Text);
                command.Parameters.AddWithValue("@country", country_textBox4.Text);

                try
                {
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Ma'lumotlar yangilandi!");
                        clear();
                        connection.Close();
                        LoadData();

                    }
                    else
                    {
                        MessageBox.Show("Update failed!");
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please select a row to update.");
            }

        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            street_textBox1.Text = "";
            city_textBox2.Text = "";
            postal_textBox3.Text = "";
            country_textBox4.Text = "";
        }
    }
}
