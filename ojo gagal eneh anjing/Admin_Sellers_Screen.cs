using System;
using System.Data;
using System.Net;
using System.Windows.Forms;
using Npgsql;

namespace ojo_gagal_eneh_anjing
{
    public partial class Admin_Sellers_Screen : Form
    {
        public Admin_Sellers_Screen()
        {
            InitializeComponent();
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost; port=5432; Database=my_laptop; User Id=postgres; Password=indra1978");
            conn.Open();
            NpgsqlCommand comm = new NpgsqlCommand();
            comm.Connection = conn;
            comm.CommandType = CommandType.Text;
            comm.CommandText = "select * from sellers";
            NpgsqlDataReader dr = comm.ExecuteReader();
            if (dr.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(dr);
                datagrid_sellers.DataSource = dt;
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
                string query = "insert into sellers(sllrs_id, sllrs_name, sllrs_age, sllrs_phn, sllrs_pass) values (" + id_box.Text + ",'" + name_box.Text + "','" + age_box.Text + "','" + phone_box.Text + "','" + pass_box.Text + "')";
                NpgsqlCommand comm = new NpgsqlCommand(query, conn);
                comm.ExecuteNonQuery();
                MessageBox.Show("Seller Added Successfully");
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
            string query = "select * from sellers";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, conn);
            NpgsqlCommandBuilder builder = new NpgsqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            datagrid_sellers.DataSource = ds.Tables[0];
            conn.Close();
        }

        private void clear()
        {
            id_box.Text = "";
            name_box.Text = "";
            age_box.Text = "";
            phone_box.Text = "";
            pass_box.Text = "";
        }
        private void Admin_Sellers_Screen_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void datagrid_sellers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id_box.Text = datagrid_sellers.SelectedRows[0].Cells[0].Value.ToString();
            name_box.Text = datagrid_sellers.SelectedRows[0].Cells[1].Value.ToString();
            age_box.Text = datagrid_sellers.SelectedRows[0].Cells[2].Value.ToString();
            phone_box.Text = datagrid_sellers.SelectedRows[0].Cells[3].Value.ToString();
            pass_box.Text = datagrid_sellers.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (id_box.Text == "")
                {
                    MessageBox.Show("Selecet The Seller to Delete");
                }
                else
                {
                    NpgsqlConnection conn = new NpgsqlConnection("Server=localhost; port=5432; Database=my_laptop; User Id=postgres; Password=indra1978");
                    conn.Open();
                    string query = "delete from sellers where sllrs_id = " + id_box.Text + "";
                    NpgsqlCommand comm = new NpgsqlCommand(query, conn);
                    comm.ExecuteNonQuery();
                    MessageBox.Show("Seller Deleted Successfully");
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
                if (id_box.Text == "" || name_box.Text == "" || age_box.Text == "" || phone_box.Text == "" || pass_box.Text == "")
                {
                    MessageBox.Show("Missing Information");
                }
                else
                {
                    NpgsqlConnection conn = new NpgsqlConnection("Server=localhost; port=5432; Database=my_laptop; User Id=postgres; Password=indra1978");
                    conn.Open();
                    string query = "update sellers set sllrs_name = '" + name_box.Text + "', sllrs_age = '" + age_box.Text + "', sllrs_phn = '" + phone_box.Text + "', sllrs_pass = '" + pass_box.Text + "' where sllrs_id = " + id_box.Text + "";
                    NpgsqlCommand comm = new NpgsqlCommand(query, conn);
                    comm.ExecuteNonQuery();
                    MessageBox.Show("Seller Successfully Updated");
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

        private void prdcts_button_Click(object sender, EventArgs e)
        {
            Admin_Products_Screen admin_products = new Admin_Products_Screen();
            admin_products.Show();
            this.Hide();
        }

        private void ctgrs_button_Click(object sender, EventArgs e)
        {
            Admin_Categories_Screen admin_categories = new Admin_Categories_Screen();
            admin_categories.Show();
            this.Hide();
        }

        private void logout_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login_Screen login = new Login_Screen();
            login.Show();
        }
    }
}
