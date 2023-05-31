using System;
using System.Data;
using System.Net;
using System.Windows.Forms;
using Npgsql;

namespace ojo_gagal_eneh_anjing
{
    public partial class Login_Screen : Form
    {
        public Login_Screen()
        {
            InitializeComponent();
        }

        public static string sellername = "";

        private void show_password_CheckedChanged(object sender, EventArgs e)
        {
            if (show_password.Checked == true)
            {
                password.UseSystemPasswordChar = false;
            }
            else
            {
                password.UseSystemPasswordChar = true;
            }
        }

        private void email_TextChanged(object sender, EventArgs e)
        {

        }

        private void login_button_Click(object sender, EventArgs e)
        {
            if (username.Text == "" || password.Text == "")
            {
                MessageBox.Show("Enter The Email and Password");
            }
            else
            {
                if (admin.Checked)
                {
                    NpgsqlConnection conn = new NpgsqlConnection("Server=localhost; port=5432; Database=my_laptop; User Id=postgres; Password=indra1978");
                    conn.Open();
                    NpgsqlDataAdapter da = new NpgsqlDataAdapter("select count(8) from admin_user where admin_name = '" + username.Text + "' and admin_pass = '" + password.Text + "'", conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    if (dt.Rows[0][0].ToString() == "1")
                    {
                        Admin_Products_Screen admin_products = new Admin_Products_Screen();
                        admin_products.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("If You are the Admin, Enter the Correct Username and Password");
                    }
                }
                else if (sellers.Checked)
                {
                    NpgsqlConnection conn = new NpgsqlConnection("Server=localhost; port=5432; Database=my_laptop; User Id=postgres; Password=indra1978");
                    conn.Open();
                    NpgsqlDataAdapter da = new NpgsqlDataAdapter("select count(8) from sellers where sllrs_name = '" + username.Text + "' and sllrs_pass = '" + password.Text + "'", conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (dt.Rows[0][0].ToString() == "1")
                    {
                        Login_Screen.sellername = username.Text;
                        Sellers_Selling_Screen sellung_screen = new Sellers_Selling_Screen();
                        sellung_screen.Show();
                        this.Hide();
                        conn.Close();
                    }
                    else
                    {
                        MessageBox.Show("Wrong Username or Password");
                    }
                    conn.Close() ;

                    MessageBox.Show("You are A Seller");
                }
                else
                {
                    MessageBox.Show("Select A Role");
                }
            }
        }

        private void Login_Screen_Load(object sender, EventArgs e)
        {

        }

        private void admin_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}