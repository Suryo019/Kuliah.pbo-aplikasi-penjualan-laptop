namespace ojo_gagal_eneh_anjing
{
    partial class Loading_Screen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Loading_Screen));
            backgroud_login = new PictureBox();
            loading_timer = new System.Windows.Forms.Timer(components);
            loading_bar = new ProgressBar();
            ((System.ComponentModel.ISupportInitialize)backgroud_login).BeginInit();
            SuspendLayout();
            // 
            // backgroud_login
            // 
            backgroud_login.Image = (Image)resources.GetObject("backgroud_login.Image");
            backgroud_login.Location = new Point(-2, -2);
            backgroud_login.Margin = new Padding(3, 5, 3, 5);
            backgroud_login.Name = "backgroud_login";
            backgroud_login.Size = new Size(1213, 953);
            backgroud_login.SizeMode = PictureBoxSizeMode.Zoom;
            backgroud_login.TabIndex = 11;
            backgroud_login.TabStop = false;
            // 
            // loading_timer
            // 
            loading_timer.Tick += loading_timer_Tick;
            // 
            // loading_bar
            // 
            loading_bar.BackColor = Color.RoyalBlue;
            loading_bar.ForeColor = Color.RoyalBlue;
            loading_bar.Location = new Point(-1, 931);
            loading_bar.Margin = new Padding(3, 4, 3, 4);
            loading_bar.Name = "loading_bar";
            loading_bar.Size = new Size(1213, 20);
            loading_bar.TabIndex = 12;
            // 
            // Loading_Screen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1209, 948);
            ControlBox = false;
            Controls.Add(loading_bar);
            Controls.Add(backgroud_login);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "Loading_Screen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Loading...";
            Load += Loading_Screen_Load;
            ((System.ComponentModel.ISupportInitialize)backgroud_login).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox backgroud_login;
        private System.Windows.Forms.Timer loading_timer;
        private ProgressBar loading_bar;
    }
}