namespace ojo_gagal_eneh_anjing
{
    partial class Login_Screen
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_Screen));
            sellers = new RadioButton();
            admin = new RadioButton();
            show_password = new CheckBox();
            forgot_password = new LinkLabel();
            username_label = new Label();
            label_password = new Label();
            username = new TextBox();
            password = new TextBox();
            backgroud_login = new PictureBox();
            login_button = new Button();
            ((System.ComponentModel.ISupportInitialize)backgroud_login).BeginInit();
            SuspendLayout();
            // 
            // sellers
            // 
            sellers.AutoSize = true;
            sellers.BackColor = Color.White;
            sellers.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            sellers.Location = new Point(851, 376);
            sellers.Margin = new Padding(3, 5, 3, 5);
            sellers.Name = "sellers";
            sellers.Size = new Size(68, 23);
            sellers.TabIndex = 18;
            sellers.TabStop = true;
            sellers.Text = "Sellers";
            sellers.UseVisualStyleBackColor = false;
            // 
            // admin
            // 
            admin.AutoSize = true;
            admin.BackColor = Color.White;
            admin.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            admin.Location = new Point(686, 376);
            admin.Margin = new Padding(3, 5, 3, 5);
            admin.Name = "admin";
            admin.Size = new Size(70, 23);
            admin.TabIndex = 17;
            admin.TabStop = true;
            admin.Text = "Admin";
            admin.UseVisualStyleBackColor = false;
            admin.CheckedChanged += admin_CheckedChanged;
            // 
            // show_password
            // 
            show_password.AutoSize = true;
            show_password.BackColor = Color.White;
            show_password.Font = new Font("Segoe UI", 6.75F, FontStyle.Regular, GraphicsUnit.Point);
            show_password.Location = new Point(686, 573);
            show_password.Margin = new Padding(3, 5, 3, 5);
            show_password.Name = "show_password";
            show_password.Size = new Size(111, 19);
            show_password.TabIndex = 16;
            show_password.Text = "Show password";
            show_password.UseVisualStyleBackColor = false;
            show_password.CheckedChanged += show_password_CheckedChanged;
            // 
            // forgot_password
            // 
            forgot_password.AutoSize = true;
            forgot_password.BackColor = Color.White;
            forgot_password.Font = new Font("Segoe UI", 6.75F, FontStyle.Regular, GraphicsUnit.Point);
            forgot_password.LinkColor = Color.DodgerBlue;
            forgot_password.Location = new Point(945, 575);
            forgot_password.Name = "forgot_password";
            forgot_password.Size = new Size(100, 15);
            forgot_password.TabIndex = 15;
            forgot_password.TabStop = true;
            forgot_password.Text = "Forgot password?";
            // 
            // username_label
            // 
            username_label.AutoSize = true;
            username_label.BackColor = Color.White;
            username_label.Font = new Font("Segoe UI", 6.75F, FontStyle.Regular, GraphicsUnit.Point);
            username_label.Location = new Point(686, 424);
            username_label.Name = "username_label";
            username_label.Size = new Size(60, 15);
            username_label.TabIndex = 14;
            username_label.Text = "Username";
            // 
            // label_password
            // 
            label_password.AutoSize = true;
            label_password.BackColor = Color.White;
            label_password.Font = new Font("Segoe UI", 6.75F, FontStyle.Regular, GraphicsUnit.Point);
            label_password.Location = new Point(686, 508);
            label_password.Name = "label_password";
            label_password.Size = new Size(57, 15);
            label_password.TabIndex = 13;
            label_password.Text = "Password";
            // 
            // username
            // 
            username.BorderStyle = BorderStyle.FixedSingle;
            username.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            username.Location = new Point(686, 451);
            username.Margin = new Padding(3, 5, 3, 5);
            username.Name = "username";
            username.RightToLeft = RightToLeft.No;
            username.Size = new Size(359, 27);
            username.TabIndex = 12;
            username.TextChanged += email_TextChanged;
            // 
            // password
            // 
            password.BorderStyle = BorderStyle.FixedSingle;
            password.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            password.Location = new Point(686, 535);
            password.Margin = new Padding(3, 5, 3, 5);
            password.Name = "password";
            password.Size = new Size(359, 27);
            password.TabIndex = 11;
            password.UseSystemPasswordChar = true;
            // 
            // backgroud_login
            // 
            backgroud_login.Image = (Image)resources.GetObject("backgroud_login.Image");
            backgroud_login.Location = new Point(-2, -2);
            backgroud_login.Margin = new Padding(3, 5, 3, 5);
            backgroud_login.Name = "backgroud_login";
            backgroud_login.Size = new Size(1213, 953);
            backgroud_login.SizeMode = PictureBoxSizeMode.Zoom;
            backgroud_login.TabIndex = 10;
            backgroud_login.TabStop = false;
            // 
            // login_button
            // 
            login_button.BackColor = Color.RoyalBlue;
            login_button.FlatStyle = FlatStyle.Flat;
            login_button.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            login_button.ForeColor = Color.White;
            login_button.Location = new Point(686, 635);
            login_button.Margin = new Padding(3, 4, 3, 4);
            login_button.Name = "login_button";
            login_button.Size = new Size(359, 49);
            login_button.TabIndex = 19;
            login_button.Text = "Log in";
            login_button.UseVisualStyleBackColor = false;
            login_button.Click += login_button_Click;
            // 
            // Login_Screen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1209, 948);
            Controls.Add(admin);
            Controls.Add(sellers);
            Controls.Add(username);
            Controls.Add(password);
            Controls.Add(show_password);
            Controls.Add(forgot_password);
            Controls.Add(login_button);
            Controls.Add(username_label);
            Controls.Add(label_password);
            Controls.Add(backgroud_login);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "Login_Screen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "My Laptop";
            Load += Login_Screen_Load;
            ((System.ComponentModel.ISupportInitialize)backgroud_login).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton admin;
        private RadioButton sellers;
        private Label username_label;
        private Label label_password;
        private TextBox username;
        private TextBox password;
        private CheckBox show_password;
        private LinkLabel forgot_password;
        private Button login_button;
        private PictureBox backgroud_login;
    }
}