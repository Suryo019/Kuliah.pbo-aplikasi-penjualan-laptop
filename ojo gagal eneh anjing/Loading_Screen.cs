using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ojo_gagal_eneh_anjing
{
    public partial class Loading_Screen : Form
    {
        public Loading_Screen()
        {
            InitializeComponent();
        }
        int startpoint = 0;
        private void loading_timer_Tick(object sender, EventArgs e)
        {
            startpoint += 1;
            loading_bar.Value = startpoint;
            if (loading_bar.Value == 100)
            {
                loading_bar.Value = 0;
                loading_timer.Stop();
                Login_Screen login_Screen = new Login_Screen();
                this.Hide();
                login_Screen.Show();
            }
        }

        private void Loading_Screen_Load(object sender, EventArgs e)
        {
            loading_timer.Start();
        }
    }
}
