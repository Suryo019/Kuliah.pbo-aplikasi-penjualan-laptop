namespace ojo_gagal_eneh_anjing
{
    partial class Admin_Products_Screen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_Products_Screen));
            categories_label = new Label();
            price_label = new Label();
            qty_label = new Label();
            label2 = new Label();
            label1 = new Label();
            price_box = new TextBox();
            qty_box = new TextBox();
            name_box = new TextBox();
            id_box = new TextBox();
            delete_button = new Button();
            edit_button = new Button();
            add_button = new Button();
            logout_button = new Button();
            categories_button = new Button();
            products_button = new Button();
            backgroud_login = new PictureBox();
            categories_cbox1 = new ComboBox();
            categories_cbox2 = new ComboBox();
            refresh_button = new Button();
            sellers_button = new Button();
            datagrid_products = new DataGridView();
            reset_button = new Button();
            ((System.ComponentModel.ISupportInitialize)backgroud_login).BeginInit();
            ((System.ComponentModel.ISupportInitialize)datagrid_products).BeginInit();
            SuspendLayout();
            // 
            // categories_label
            // 
            categories_label.AutoSize = true;
            categories_label.BackColor = Color.RoyalBlue;
            categories_label.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            categories_label.ForeColor = Color.White;
            categories_label.Location = new Point(250, 550);
            categories_label.Name = "categories_label";
            categories_label.Size = new Size(53, 23);
            categories_label.TabIndex = 46;
            categories_label.Text = "Ctgrs";
            // 
            // price_label
            // 
            price_label.AutoSize = true;
            price_label.BackColor = Color.RoyalBlue;
            price_label.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            price_label.ForeColor = Color.White;
            price_label.Location = new Point(250, 489);
            price_label.Name = "price_label";
            price_label.Size = new Size(49, 23);
            price_label.TabIndex = 45;
            price_label.Text = "Price";
            // 
            // qty_label
            // 
            qty_label.AutoSize = true;
            qty_label.BackColor = Color.RoyalBlue;
            qty_label.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            qty_label.ForeColor = Color.White;
            qty_label.Location = new Point(250, 429);
            qty_label.Name = "qty_label";
            qty_label.Size = new Size(39, 23);
            qty_label.TabIndex = 44;
            qty_label.Text = "Qty";
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
            label2.TabIndex = 43;
            label2.Text = "Name";
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
            label1.TabIndex = 42;
            label1.Text = "Id";
            // 
            // price_box
            // 
            price_box.BackColor = Color.White;
            price_box.BorderStyle = BorderStyle.FixedSingle;
            price_box.Location = new Point(325, 485);
            price_box.Name = "price_box";
            price_box.Size = new Size(210, 27);
            price_box.TabIndex = 39;
            // 
            // qty_box
            // 
            qty_box.BackColor = Color.White;
            qty_box.BorderStyle = BorderStyle.FixedSingle;
            qty_box.Location = new Point(325, 425);
            qty_box.Name = "qty_box";
            qty_box.Size = new Size(210, 27);
            qty_box.TabIndex = 38;
            // 
            // name_box
            // 
            name_box.BackColor = Color.White;
            name_box.BorderStyle = BorderStyle.FixedSingle;
            name_box.Location = new Point(325, 364);
            name_box.Name = "name_box";
            name_box.Size = new Size(210, 27);
            name_box.TabIndex = 37;
            name_box.TextChanged += name_box_TextChanged;
            // 
            // id_box
            // 
            id_box.BackColor = Color.White;
            id_box.BorderStyle = BorderStyle.FixedSingle;
            id_box.Location = new Point(325, 304);
            id_box.Name = "id_box";
            id_box.Size = new Size(210, 27);
            id_box.TabIndex = 36;
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
            delete_button.TabIndex = 35;
            delete_button.Text = "DELETE";
            delete_button.UseVisualStyleBackColor = true;
            delete_button.Click += delete_button_Click;
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
            edit_button.TabIndex = 34;
            edit_button.Text = "EDIT";
            edit_button.UseVisualStyleBackColor = true;
            edit_button.Click += edit_button_Click;
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
            add_button.TabIndex = 33;
            add_button.Text = "ADD";
            add_button.UseVisualStyleBackColor = true;
            add_button.Click += add_button_Click;
            // 
            // logout_button
            // 
            logout_button.FlatAppearance.BorderSize = 0;
            logout_button.FlatStyle = FlatStyle.Flat;
            logout_button.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            logout_button.Location = new Point(92, 715);
            logout_button.Name = "logout_button";
            logout_button.Size = new Size(85, 36);
            logout_button.TabIndex = 32;
            logout_button.Text = "Log out";
            logout_button.UseVisualStyleBackColor = true;
            logout_button.Click += logout_button_Click;
            // 
            // categories_button
            // 
            categories_button.FlatAppearance.BorderSize = 0;
            categories_button.FlatStyle = FlatStyle.Flat;
            categories_button.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            categories_button.Location = new Point(92, 337);
            categories_button.Name = "categories_button";
            categories_button.Size = new Size(111, 36);
            categories_button.TabIndex = 31;
            categories_button.Text = "Categories";
            categories_button.UseVisualStyleBackColor = true;
            categories_button.Click += categories_button_Click;
            // 
            // products_button
            // 
            products_button.FlatAppearance.BorderSize = 0;
            products_button.FlatStyle = FlatStyle.Flat;
            products_button.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            products_button.Location = new Point(92, 295);
            products_button.Name = "products_button";
            products_button.Size = new Size(98, 36);
            products_button.TabIndex = 30;
            products_button.Text = "Products";
            products_button.UseVisualStyleBackColor = true;
            // 
            // backgroud_login
            // 
            backgroud_login.Image = (Image)resources.GetObject("backgroud_login.Image");
            backgroud_login.Location = new Point(-2, -2);
            backgroud_login.Margin = new Padding(3, 5, 3, 5);
            backgroud_login.Name = "backgroud_login";
            backgroud_login.Size = new Size(1213, 953);
            backgroud_login.SizeMode = PictureBoxSizeMode.Zoom;
            backgroud_login.TabIndex = 29;
            backgroud_login.TabStop = false;
            // 
            // categories_cbox1
            // 
            categories_cbox1.BackColor = Color.White;
            categories_cbox1.Font = new Font("Segoe UI Semilight", 9F, FontStyle.Regular, GraphicsUnit.Point);
            categories_cbox1.ForeColor = Color.RoyalBlue;
            categories_cbox1.FormattingEnabled = true;
            categories_cbox1.Location = new Point(325, 545);
            categories_cbox1.Name = "categories_cbox1";
            categories_cbox1.Size = new Size(210, 28);
            categories_cbox1.TabIndex = 49;
            categories_cbox1.Text = "Select Categories";
            categories_cbox1.SelectedIndexChanged += categories_cbox1_SelectedIndexChanged;
            // 
            // categories_cbox2
            // 
            categories_cbox2.BackColor = Color.White;
            categories_cbox2.Font = new Font("Segoe UI Semilight", 9F, FontStyle.Regular, GraphicsUnit.Point);
            categories_cbox2.ForeColor = Color.RoyalBlue;
            categories_cbox2.FormattingEnabled = true;
            categories_cbox2.Location = new Point(797, 260);
            categories_cbox2.Name = "categories_cbox2";
            categories_cbox2.Size = new Size(210, 28);
            categories_cbox2.TabIndex = 50;
            categories_cbox2.Text = "Select Categories";
            categories_cbox2.SelectedIndexChanged += categories_cbox2_SelectedIndexChanged;
            // 
            // refresh_button
            // 
            refresh_button.FlatAppearance.BorderSize = 0;
            refresh_button.FlatStyle = FlatStyle.Flat;
            refresh_button.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            refresh_button.ForeColor = Color.RoyalBlue;
            refresh_button.Location = new Point(1013, 260);
            refresh_button.Name = "refresh_button";
            refresh_button.Size = new Size(91, 28);
            refresh_button.TabIndex = 51;
            refresh_button.Text = "Refresh";
            refresh_button.UseVisualStyleBackColor = true;
            refresh_button.Click += button1_Click;
            // 
            // sellers_button
            // 
            sellers_button.FlatAppearance.BorderSize = 0;
            sellers_button.FlatStyle = FlatStyle.Flat;
            sellers_button.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            sellers_button.Location = new Point(92, 379);
            sellers_button.Name = "sellers_button";
            sellers_button.Size = new Size(85, 36);
            sellers_button.TabIndex = 52;
            sellers_button.Text = "Sellers";
            sellers_button.UseVisualStyleBackColor = true;
            sellers_button.Click += sellers_button_Click;
            // 
            // datagrid_products
            // 
            datagrid_products.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            datagrid_products.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            datagrid_products.BackgroundColor = Color.White;
            datagrid_products.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            datagrid_products.ColumnHeadersHeight = 29;
            datagrid_products.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            datagrid_products.GridColor = SystemColors.ActiveCaption;
            datagrid_products.Location = new Point(578, 304);
            datagrid_products.Name = "datagrid_products";
            datagrid_products.ReadOnly = true;
            datagrid_products.RowHeadersWidth = 51;
            datagrid_products.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            datagrid_products.RowTemplate.Height = 29;
            datagrid_products.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            datagrid_products.Size = new Size(526, 447);
            datagrid_products.StandardTab = true;
            datagrid_products.TabIndex = 79;
            datagrid_products.CellContentClick += datagrid_products_CellContentClick;
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
            reset_button.TabIndex = 80;
            reset_button.Text = "Reset";
            reset_button.UseVisualStyleBackColor = true;
            reset_button.Click += reset_button_Click;
            // 
            // Admin_Products_Screen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1209, 948);
            Controls.Add(reset_button);
            Controls.Add(datagrid_products);
            Controls.Add(sellers_button);
            Controls.Add(refresh_button);
            Controls.Add(categories_cbox2);
            Controls.Add(categories_cbox1);
            Controls.Add(categories_label);
            Controls.Add(price_label);
            Controls.Add(qty_label);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(price_box);
            Controls.Add(qty_box);
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
            Name = "Admin_Products_Screen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "My Laptop";
            Load += Admin_Products_Screen_Load;
            ((System.ComponentModel.ISupportInitialize)backgroud_login).EndInit();
            ((System.ComponentModel.ISupportInitialize)datagrid_products).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label categories_label;
        private Label price_label;
        private Label qty_label;
        private Label label2;
        private Label label1;
        private TextBox price_box;
        private TextBox qty_box;
        private TextBox name_box;
        private TextBox id_box;
        private Button delete_button;
        private Button edit_button;
        private Button add_button;
        private Button logout_button;
        private Button categories_button;
        private Button products_button;
        private PictureBox backgroud_login;
        private ComboBox categories_cbox1;
        private ComboBox categories_cbox2;
        private Button refresh_button;
        private Button sellers_button;
        private DataGridView datagrid_products;
        private Button reset_button;
    }
}