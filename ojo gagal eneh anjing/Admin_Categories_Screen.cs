using System;
using System.Data;
using System.Net;
using System.Windows.Forms;
using Npgsql;

namespace ojo_gagal_eneh_anjing
{
    public partial class Admin_Categories_Screen : Form
    {
        public Admin_Categories_Screen()
        {
            InitializeComponent();
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost; port=5432; Database=my_laptop; User Id=postgres; Password=indra1978");
            conn.Open();
            NpgsqlCommand comm = new NpgsqlCommand();
            comm.Connection = conn;
            comm.CommandType = CommandType.Text;
            comm.CommandText = "select * from categories";
            NpgsqlDataReader dr = comm.ExecuteReader();
            if (dr.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(dr);
                datagrid_categories.DataSource = dt;
            }
            comm.Dispose();
            conn.Close();
        }


        private void add_button_Click(object sender, EventArgs e)
        {
            try
            {
                NpgsqlConnection conn = new NpgsqlConnection("Server=localhost; port=5432; Database=my_laptop; User Id=postgres; Password=indra1978");
                conn.Open();
                string query = "insert into categories(ctgrs_id, ctgrs_name, ctgrs_descrpt) values (" + id_box.Text + ",'" + name_box.Text + "','" + descrpt_box.Text + "')";
                NpgsqlCommand comm = new NpgsqlCommand(query, conn);
                comm.ExecuteNonQuery();
                MessageBox.Show("Category Added Successfully");
                conn.Close();
                populate();
                clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void populate()
        {
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost; port=5432; Database=my_laptop; User Id=postgres; Password=indra1978");
            conn.Open();
            string query = "select * from categories";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, conn);
            NpgsqlCommandBuilder builder = new NpgsqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            datagrid_categories.DataSource = ds.Tables[0];
            conn.Close();
        }

        private void clear()
        {
            id_box.Text = "";
            name_box.Text = "";
            descrpt_box.Text = "";
        }

        private void Admin_Categories_Screen_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void datagrid_categories_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id_box.Text = datagrid_categories.SelectedRows[0].Cells[0].Value.ToString();
            name_box.Text = datagrid_categories.SelectedRows[0].Cells[1].Value.ToString();
            descrpt_box.Text = datagrid_categories.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (id_box.Text == "")
                {
                    MessageBox.Show("Selecet The Category to Delete");
                }
                else
                {
                    NpgsqlConnection conn = new NpgsqlConnection("Server=localhost; port=5432; Database=my_laptop; User Id=postgres; Password=indra1978");
                    conn.Open();
                    string query = "delete from categories where ctgrs_id = " + id_box.Text + "";
                    NpgsqlCommand comm = new NpgsqlCommand(query, conn);
                    comm.ExecuteNonQuery();
                    MessageBox.Show("Category Deleted Successfully");
                    conn.Close();
                    populate();
                    clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void reset_button_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void edit_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (id_box.Text == "" || name_box.Text == "" || descrpt_box.Text == "")
                {
                    MessageBox.Show("Missing Information");
                }
                else
                {
                    NpgsqlConnection conn = new NpgsqlConnection("Server=localhost; port=5432; Database=my_laptop; User Id=postgres; Password=indra1978");
                    conn.Open();
                    string query = "update categories set ctgrs_name = '" + name_box.Text + "', ctgrs_descrpt = '" + descrpt_box.Text + "' where ctgrs_id = " + id_box.Text + "";
                    NpgsqlCommand comm = new NpgsqlCommand(query, conn);
                    comm.ExecuteNonQuery();
                    MessageBox.Show("Category Successfully Updated");
                    conn.Close();
                    populate();
                    clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void products_button_Click(object sender, EventArgs e)
        {
            Admin_Products_Screen admin_products = new Admin_Products_Screen();
            admin_products.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Admin_Sellers_Screen admin_sellers = new Admin_Sellers_Screen();
            admin_sellers.Show();
            this.Hide();
        }

        private void backgroud_admin_sellers_Click(object sender, EventArgs e)
        {

        }

        private void logout_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login_Screen login = new Login_Screen();
            login.Show();
        }
    }
}
