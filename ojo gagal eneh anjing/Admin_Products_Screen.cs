using System;
using System.Data;
using System.Net;
using System.Windows.Forms;
using Npgsql;

namespace ojo_gagal_eneh_anjing
{
    public partial class Admin_Products_Screen : Form
    {
        public Admin_Products_Screen()
        {
            InitializeComponent();
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost; port=5432; Database=my_laptop; User Id=postgres; Password=indra1978");
            conn.Open();
            NpgsqlCommand comm = new NpgsqlCommand();
            comm.Connection = conn;
            comm.CommandType = CommandType.Text;
            comm.CommandText = "select prdcts_id, prdcts_name, prdcts_qty, prdcts_prc, ctgrs_name from products join categories on products.prdcts_ctgrs_id = categories.ctgrs_id";
            NpgsqlDataReader dr = comm.ExecuteReader();
            if (dr.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(dr);
                datagrid_products.DataSource = dt;
            }
            comm.Dispose();
            conn.Close();
        }

        private void fill_combo_box1()
        {
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost; port=5432; Database=my_laptop; User Id=postgres; Password=indra1978");
            conn.Open();
            NpgsqlCommand comm = new NpgsqlCommand("select ctgrs_name from categories", conn);
            NpgsqlDataReader dr;
            dr = comm.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("ctgrs_name", typeof(string));
            dt.Load(dr);
            categories_cbox1.ValueMember = "ctgrs_name";
            categories_cbox1.DataSource = dt;
            conn.Close();
        }

        private void fill_combo_box2()
        {
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost; port=5432; Database=my_laptop; User Id=postgres; Password=indra1978");
            conn.Open();
            NpgsqlCommand comm = new NpgsqlCommand("select ctgrs_name from categories", conn);
            NpgsqlDataReader dr;
            dr = comm.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("ctgrs_name", typeof(string));
            dt.Load(dr);
            categories_cbox2.ValueMember = "ctgrs_name";
            categories_cbox2.DataSource = dt;
            conn.Close();
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            try
            {
                NpgsqlConnection conn = new NpgsqlConnection("Server=localhost; port=5432; Database=my_laptop; User Id=postgres; Password=indra1978");
                conn.Open();
                string query = "insert into products(prdcts_id, prdcts_name, prdcts_qty, prdcts_prc, prdcts_ctgrs_id) values (" + id_box.Text + ",'" + name_box.Text + "','" + qty_box.Text + "','" + price_box.Text + "', (select ctgrs_id from categories where ctgrs_name = '" + categories_cbox1.SelectedValue.ToString() + "'))";
                NpgsqlCommand comm = new NpgsqlCommand(query, conn);
                comm.ExecuteNonQuery();
                MessageBox.Show("Product Added Successfully");
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
            string query = "select prdcts_id, prdcts_name, prdcts_qty, prdcts_prc, ctgrs_name from products join categories on products.prdcts_ctgrs_id = categories.ctgrs_id";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, conn);
            NpgsqlCommandBuilder builder = new NpgsqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            datagrid_products.DataSource = ds.Tables[0];
            conn.Close();
        }

        private void clear()
        {
            id_box.Text = "";
            name_box.Text = "";
            qty_box.Text = "";
            price_box.Text = "";
            fill_combo_box1();
            fill_combo_box2();
            populate();
        }

        private void Admin_Products_Screen_Load(object sender, EventArgs e)
        {
            fill_combo_box1();
            fill_combo_box2();
            populate();
        }

        private void categories_button_Click(object sender, EventArgs e)
        {
            Admin_Categories_Screen admin_categories = new Admin_Categories_Screen();
            admin_categories.Show();
            this.Hide();
        }

        private void datagrid_products_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id_box.Text = datagrid_products.SelectedRows[0].Cells[0].Value.ToString();
            name_box.Text = datagrid_products.SelectedRows[0].Cells[1].Value.ToString();
            qty_box.Text = datagrid_products.SelectedRows[0].Cells[2].Value.ToString();
            price_box.Text = datagrid_products.SelectedRows[0].Cells[3].Value.ToString();
            categories_cbox1.SelectedValue = datagrid_products.SelectedRows[0].Cells[4].Value.ToString();
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
                    string query = "delete from products where prdcts_id = " + id_box.Text + "";
                    NpgsqlCommand comm = new NpgsqlCommand(query, conn);
                    comm.ExecuteNonQuery();
                    MessageBox.Show("Product Deleted Successfully");
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
            id_box.Text = "";
            name_box.Text = "";
            qty_box.Text = "";
            price_box.Text = "";
            fill_combo_box1();
        }

        private void edit_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (id_box.Text == "" || name_box.Text == "" || qty_box.Text == "" || price_box.Text == "")
                {
                    MessageBox.Show("Missing Information");
                }
                else
                {
                    NpgsqlConnection conn = new NpgsqlConnection("Server=localhost; port=5432; Database=my_laptop; User Id=postgres; Password=indra1978");
                    conn.Open();

                    string query = "update products set prdcts_name = '" + name_box.Text + "', prdcts_qty = '" + qty_box.Text + "', prdcts_prc = '" + price_box.Text + "', prdcts_ctgrs_id = (select ctgrs_id from categories where ctgrs_name = '" + categories_cbox1.SelectedValue.ToString() + "') where prdcts_id = " + id_box.Text;

                    NpgsqlCommand comm = new NpgsqlCommand(query, conn);
                    comm.ExecuteNonQuery();
                    MessageBox.Show("Product Successfully Updated");
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

        private void categories_cbox2_SelectedIndexChanged(object sender, EventArgs e)
        {

            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost; port=5432; Database=my_laptop; User Id=postgres; Password=indra1978");
            conn.Open();
            string query = "select prdcts_id, prdcts_name, prdcts_qty, prdcts_prc, ctgrs_name from products join categories on products.prdcts_ctgrs_id = categories.ctgrs_id where ctgrs_name = '" + categories_cbox2.SelectedValue.ToString() + "'";
            NpgsqlCommand comm = new NpgsqlCommand(query, conn);


            NpgsqlDataReader dr = comm.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);

            if (dt.Rows.Count > 0)
            {
                datagrid_products.DataSource = dt;
            }
            else
            {
                datagrid_products.DataSource = null;
            }

            comm.Dispose();
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            populate();
        }

        private void categories_cbox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void sellers_button_Click(object sender, EventArgs e)
        {
            Admin_Sellers_Screen admin_sellers = new Admin_Sellers_Screen();
            admin_sellers.Show();
            this.Hide();
        }

        private void name_box_TextChanged(object sender, EventArgs e)
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
