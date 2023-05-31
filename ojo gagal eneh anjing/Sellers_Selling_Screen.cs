using System;
using System.Data;
using System.Net;
using System.Windows.Forms;
using Npgsql;

namespace ojo_gagal_eneh_anjing
{
    public partial class Sellers_Selling_Screen : Form
    {
        public Sellers_Selling_Screen()
        {
            InitializeComponent();
        }

        private void Sellers_Selling_Screen_Load(object sender, EventArgs e)
        {
            populate();
            populatebill();
            fill_combo_box1();
            sellers_label.Text = Login_Screen.sellername;
        }

        private void populate()
        {
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost; port=5432; Database=my_laptop; User Id=postgres; Password=indra1978");
            conn.Open();
            string query = "select prdcts_name as products, prdcts_prc as price from products";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, conn);
            NpgsqlCommandBuilder builder = new NpgsqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            data_grid_categories.DataSource = ds.Tables[0];
            conn.Close();

            date_label.Text = DateTime.Today.ToString("dd/MM/yyyy");
            sellers_label.Text = Login_Screen.sellername;

        }

        private void populatebill()
        {
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost; port=5432; Database=my_laptop; User Id=postgres; Password=indra1978");
            conn.Open();
            string query = "select bill_id, sllrs_name, bill_date, bill_total from bill join sellers on bill.bill_sllrs_id = sellers.sllrs_id where sllrs_name = '" + sellers_label.Text + "'";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, conn);
            NpgsqlCommandBuilder builder = new NpgsqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            data_grid_sell.DataSource = ds.Tables[0];
            conn.Close();
            sellers_label.Text = Login_Screen.sellername;

        }

        private decimal selectedProductPrice;

        private void data_grid_categories_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            name_box.Text = data_grid_categories.SelectedRows[0].Cells[0].Value.ToString();
            string priceString = data_grid_categories.SelectedRows[0].Cells[1].Value.ToString();
            price_box.Text = decimal.Parse(priceString).ToString("0.##");
            decimal.TryParse(priceString, out selectedProductPrice);
        }


        private void backgroud_admin_sellers_Click(object sender, EventArgs e)
        {

        }

        private int prdcts_id = 0;
        private int Grdtotal = 0;

        private void add_products_button_Click(object sender, EventArgs e)
        {
            int quantity;

            if (int.TryParse(qty_box.Text, out quantity))
            {
                int total = (int)selectedProductPrice * quantity;

                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(data_grid_product);
                newRow.Cells[0].Value = prdcts_id + 1;
                newRow.Cells[1].Value = name_box.Text;
                newRow.Cells[2].Value = selectedProductPrice.ToString();
                newRow.Cells[3].Value = qty_box.Text;
                newRow.Cells[4].Value = total.ToString();

                data_grid_product.Rows.Add(newRow);
                Grdtotal += total;
                amount_label.Text = "Amount Rp" + Grdtotal.ToString();

                prdcts_id++;
            }
            else if (name_box.Text == "" || price_box.Text == "" || qty_box.Text == "")
            {
                MessageBox.Show("Invalid input. Please input a name of product, price, and quantity.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (price_box.Text != price_box.Text)
            {
                MessageBox.Show("Invalid input for price. Please enter a correct price.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void data_grid_product_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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

        private void clear()
        {
            id_box.Text = "";
            name_box.Text = "";
            price_box.Text = "";
            qty_box.Text = "";
            fill_combo_box1();
            populate();
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            if (id_box.Text == "")
            {
                MessageBox.Show("Missing Data. Please enter a correct data");
            }
            else
            {
                try
                {
                    NpgsqlConnection conn = new NpgsqlConnection("Server=localhost; port=5432; Database=my_laptop; User Id=postgres; Password=indra1978");
                    conn.Open();
                    string query = "insert into bill (bill_id, bill_sllrs_id, bill_date, bill_total) values (" + id_box.Text + ", (select sllrs_id from sellers where sllrs_name = '" + sellers_label.Text + "'), '" + DateTime.Now.ToString("yyyy-MM-dd") + "', " + Grdtotal.ToString() + ")";
                    NpgsqlCommand comm = new NpgsqlCommand(query, conn);
                    comm.ExecuteNonQuery();
                    MessageBox.Show("Bill Added Successfully");
                    conn.Close();
                    populatebill();
                    clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void sellers_label_Click(object sender, EventArgs e)
        {

        }

        private void print_button_Click(object sender, EventArgs e)
        {
            if (print_preview_bill.ShowDialog() == DialogResult.OK)
            {
                print_bill.Print();
            }
        }

        private void print_bill_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string billId = data_grid_sell.SelectedRows[0].Cells[0].Value.ToString();
            string sellersName = data_grid_sell.SelectedRows[0].Cells[1].Value.ToString();
            DateTime date = DateTime.Parse(data_grid_sell.SelectedRows[0].Cells[2].Value.ToString());
            string total = data_grid_sell.SelectedRows[0].Cells[3].Value.ToString();

            e.Graphics.DrawString("My Laptop", new Font("Century Gothic", 25, FontStyle.Bold), Brushes.MidnightBlue, new Point(330, 50));
            e.Graphics.DrawString("Bill Id: " + billId, new Font("Century Gothic", 15, FontStyle.Bold), Brushes.RoyalBlue, new Point(130, 150));
            e.Graphics.DrawString("Seller: " + sellersName, new Font("Century Gothic", 15, FontStyle.Bold), Brushes.RoyalBlue, new Point(130, 180));
            e.Graphics.DrawString("Date: " + date.ToString("dd/MM/yyyy"), new Font("Century Gothic", 15, FontStyle.Bold), Brushes.RoyalBlue, new Point(130, 210));
            e.Graphics.DrawString("Total: Rp" + total, new Font("Century Gothic", 15, FontStyle.Bold), Brushes.RoyalBlue, new Point(130, 240));
            e.Graphics.DrawString("Code Space", new Font("Century Gothic", 15, FontStyle.Italic), Brushes.OrangeRed, new Point(350, 300));
        }

        private void data_grid_sell_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void categories_cbox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost; port=5432; Database=my_laptop; User Id=postgres; Password=indra1978");
            conn.Open();
            string query = "select prdcts_name as products, prdcts_prc as price from products join categories on products.prdcts_ctgrs_id = categories.ctgrs_id where ctgrs_name = '" + categories_cbox1.SelectedValue.ToString() + "'";
            NpgsqlCommand comm = new NpgsqlCommand(query, conn);


            NpgsqlDataReader dr = comm.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);

            if (dt.Rows.Count > 0)
            {
                data_grid_categories.DataSource = dt;
            }
            else
            {
                data_grid_categories.DataSource = null;
            }

            comm.Dispose();
            conn.Close();
        }

        private void refresh_button_Click(object sender, EventArgs e)
        {
            populate();
            clear();
        }

        private void logout_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login_Screen login = new Login_Screen();
            login.Show();
        }
    }
}
