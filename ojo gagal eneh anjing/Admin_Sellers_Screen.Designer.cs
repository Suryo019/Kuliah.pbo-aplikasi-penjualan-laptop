namespace ojo_gagal_eneh_anjing
{
    partial class Admin_Sellers_Screen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_Sellers_Screen));
            backgroud_login = new PictureBox();
            logout_button = new Button();
            add_button = new Button();
            edit_button = new Button();
            delete_button = new Button();
            id_box = new TextBox();
            name_box = new TextBox();
            phone_box = new TextBox();
            age_box = new TextBox();
            pass_box = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            datagrid_sellers = new DataGridView();
            categories_button = new Button();
            products_button = new Button();
            sellers_button = new Button();
            ctgrs_button = new Button();
            prdcts_button = new Button();
            reset_button = new Button();
            ((System.ComponentModel.ISupportInitialize)backgroud_login).BeginInit();
            ((System.ComponentModel.ISupportInitialize)datagrid_sellers).BeginInit();
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
            // logout_button
            // 
            logout_button.FlatAppearance.BorderSize = 0;
            logout_button.FlatStyle = FlatStyle.Flat;
            logout_button.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            logout_button.Location = new Point(92, 715);
            logout_button.Name = "logout_button";
            logout_button.Size = new Size(85, 36);
            logout_button.TabIndex = 14;
            logout_button.Text = "Log out";
            logout_button.UseVisualStyleBackColor = true;
            logout_button.Click += logout_button_Click;
            // 
            // add_button
            // 
            add_button.FlatAppearance.BorderSize = 0;
            add_button.FlatStyle = FlatStyle.Flat;
            add_button.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            add_button.ForeColor = Color.RoyalBlue;
            add_button.Location = new Point(250, 605);
            add_button.Name = "add_button";
            add_button.Size = new Size(91, 49);
            add_button.TabIndex = 15;
            add_button.Text = "ADD";
            add_button.UseVisualStyleBackColor = true;
            add_button.Click += add_button_Click;
            // 
            // edit_button
            // 
            edit_button.FlatAppearance.BorderSize = 0;
            edit_button.FlatStyle = FlatStyle.Flat;
            edit_button.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            edit_button.ForeColor = Color.RoyalBlue;
            edit_button.Location = new Point(347, 605);
            edit_button.Name = "edit_button";
            edit_button.Size = new Size(91, 49);
            edit_button.TabIndex = 16;
            edit_button.Text = "EDIT";
            edit_button.UseVisualStyleBackColor = true;
            edit_button.Click += edit_button_Click;
            // 
            // delete_button
            // 
            delete_button.FlatAppearance.BorderSize = 0;
            delete_button.FlatStyle = FlatStyle.Flat;
            delete_button.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            delete_button.ForeColor = Color.RoyalBlue;
            delete_button.Location = new Point(444, 605);
            delete_button.Name = "delete_button";
            delete_button.Size = new Size(91, 49);
            delete_button.TabIndex = 17;
            delete_button.Text = "DELETE";
            delete_button.UseVisualStyleBackColor = true;
            delete_button.Click += delete_button_Click;
            // 
            // id_box
            // 
            id_box.BackColor = Color.White;
            id_box.BorderStyle = BorderStyle.FixedSingle;
            id_box.Location = new Point(325, 304);
            id_box.Name = "id_box";
            id_box.Size = new Size(210, 27);
            id_box.TabIndex = 18;
            // 
            // name_box
            // 
            name_box.BackColor = Color.White;
            name_box.BorderStyle = BorderStyle.FixedSingle;
            name_box.Location = new Point(325, 364);
            name_box.Name = "name_box";
            name_box.Size = new Size(210, 27);
            name_box.TabIndex = 19;
            // 
            // phone_box
            // 
            phone_box.BackColor = Color.White;
            phone_box.BorderStyle = BorderStyle.FixedSingle;
            phone_box.Location = new Point(325, 485);
            phone_box.Name = "phone_box";
            phone_box.Size = new Size(210, 27);
            phone_box.TabIndex = 21;
            // 
            // age_box
            // 
            age_box.BackColor = Color.White;
            age_box.BorderStyle = BorderStyle.FixedSingle;
            age_box.Location = new Point(325, 425);
            age_box.Name = "age_box";
            age_box.Size = new Size(210, 27);
            age_box.TabIndex = 20;
            // 
            // pass_box
            // 
            pass_box.BackColor = Color.White;
            pass_box.BorderStyle = BorderStyle.FixedSingle;
            pass_box.Location = new Point(325, 546);
            pass_box.Name = "pass_box";
            pass_box.Size = new Size(210, 27);
            pass_box.TabIndex = 22;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.RoyalBlue;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(250, 308);
            label1.Name = "label1";
            label1.Size = new Size(26, 23);
            label1.TabIndex = 24;
            label1.Text = "Id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.RoyalBlue;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(250, 368);
            label2.Name = "label2";
            label2.Size = new Size(57, 23);
            label2.TabIndex = 25;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.RoyalBlue;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(250, 489);
            label3.Name = "label3";
            label3.Size = new Size(59, 23);
            label3.TabIndex = 27;
            label3.Text = "Phone";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.RoyalBlue;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(250, 429);
            label4.Name = "label4";
            label4.Size = new Size(42, 23);
            label4.TabIndex = 26;
            label4.Text = "Age";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.RoyalBlue;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(250, 550);
            label5.Name = "label5";
            label5.Size = new Size(43, 23);
            label5.TabIndex = 28;
            label5.Text = "Pass";
            // 
            // datagrid_sellers
            // 
            datagrid_sellers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            datagrid_sellers.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            datagrid_sellers.BackgroundColor = Color.White;
            datagrid_sellers.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            datagrid_sellers.ColumnHeadersHeight = 29;
            datagrid_sellers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            datagrid_sellers.GridColor = SystemColors.ActiveCaption;
            datagrid_sellers.Location = new Point(578, 250);
            datagrid_sellers.Name = "datagrid_sellers";
            datagrid_sellers.ReadOnly = true;
            datagrid_sellers.RowHeadersWidth = 51;
            datagrid_sellers.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            datagrid_sellers.RowTemplate.Height = 29;
            datagrid_sellers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            datagrid_sellers.Size = new Size(526, 501);
            datagrid_sellers.StandardTab = true;
            datagrid_sellers.TabIndex = 79;
            datagrid_sellers.CellContentClick += datagrid_sellers_CellContentClick;
            // 
            // categories_button
            // 
            categories_button.FlatAppearance.BorderSize = 0;
            categories_button.FlatStyle = FlatStyle.Flat;
            categories_button.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            categories_button.Location = new Point(92, 330);
            categories_button.Name = "categories_button";
            categories_button.Size = new Size(111, 36);
            categories_button.TabIndex = 13;
            categories_button.Text = "Categories";
            categories_button.UseVisualStyleBackColor = true;
            // 
            // products_button
            // 
            products_button.FlatAppearance.BorderSize = 0;
            products_button.FlatStyle = FlatStyle.Flat;
            products_button.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            products_button.Location = new Point(92, 288);
            products_button.Name = "products_button";
            products_button.Size = new Size(98, 36);
            products_button.TabIndex = 12;
            products_button.Text = "Products";
            products_button.UseVisualStyleBackColor = true;
            // 
            // sellers_button
            // 
            sellers_button.FlatAppearance.BorderSize = 0;
            sellers_button.FlatStyle = FlatStyle.Flat;
            sellers_button.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            sellers_button.Location = new Point(92, 379);
            sellers_button.Name = "sellers_button";
            sellers_button.Size = new Size(85, 36);
            sellers_button.TabIndex = 82;
            sellers_button.Text = "Sellers";
            sellers_button.UseVisualStyleBackColor = true;
            // 
            // ctgrs_button
            // 
            ctgrs_button.FlatAppearance.BorderSize = 0;
            ctgrs_button.FlatStyle = FlatStyle.Flat;
            ctgrs_button.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            ctgrs_button.Location = new Point(92, 337);
            ctgrs_button.Name = "ctgrs_button";
            ctgrs_button.Size = new Size(111, 36);
            ctgrs_button.TabIndex = 81;
            ctgrs_button.Text = "Categories";
            ctgrs_button.UseVisualStyleBackColor = true;
            ctgrs_button.Click += ctgrs_button_Click;
            // 
            // prdcts_button
            // 
            prdcts_button.FlatAppearance.BorderSize = 0;
            prdcts_button.FlatStyle = FlatStyle.Flat;
            prdcts_button.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            prdcts_button.Location = new Point(92, 295);
            prdcts_button.Name = "prdcts_button";
            prdcts_button.Size = new Size(98, 36);
            prdcts_button.TabIndex = 80;
            prdcts_button.Text = "Products";
            prdcts_button.UseVisualStyleBackColor = true;
            prdcts_button.Click += prdcts_button_Click;
            // 
            // reset_button
            // 
            reset_button.FlatAppearance.BorderSize = 0;
            reset_button.FlatStyle = FlatStyle.Flat;
            reset_button.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            reset_button.ForeColor = Color.RoyalBlue;
            reset_button.Location = new Point(1051, 693);
            reset_button.Name = "reset_button";
            reset_button.Size = new Size(51, 36);
            reset_button.TabIndex = 84;
            reset_button.Text = "Reset";
            reset_button.UseVisualStyleBackColor = true;
            reset_button.Click += reset_button_Click;
            // 
            // Admin_Sellers_Screen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1209, 948);
            Controls.Add(reset_button);
            Controls.Add(sellers_button);
            Controls.Add(ctgrs_button);
            Controls.Add(prdcts_button);
            Controls.Add(datagrid_sellers);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pass_box);
            Controls.Add(phone_box);
            Controls.Add(age_box);
            Controls.Add(name_box);
            Controls.Add(id_box);
            Controls.Add(delete_button);
            Controls.Add(edit_button);
            Controls.Add(add_button);
            Controls.Add(logout_button);
            Controls.Add(categories_button);
            Controls.Add(products_button);
            Controls.Add(backgroud_login);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Admin_Sellers_Screen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "My Laptop";
            Load += Admin_Sellers_Screen_Load;
            ((System.ComponentModel.ISupportInitialize)backgroud_login).EndInit();
            ((System.ComponentModel.ISupportInitialize)datagrid_sellers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox backgroud_login;
        private Button logout_button;
        private Button add_button;
        private Button edit_button;
        private Button delete_button;
        private TextBox id_box;
        private TextBox name_box;
        private TextBox phone_box;
        private TextBox age_box;
        private TextBox pass_box;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private DataGridView datagrid_sellers;
        private Button categories_button;
        private Button products_button;
        private Button sellers_button;
        private Button ctgrs_button;
        private Button prdcts_button;
        private Button reset_button;
    }
}