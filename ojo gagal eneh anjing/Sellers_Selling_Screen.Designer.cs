namespace ojo_gagal_eneh_anjing
{
    partial class Sellers_Selling_Screen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sellers_Selling_Screen));
            backgroud_admin_sellers = new PictureBox();
            name_label = new Label();
            id_label = new Label();
            name_box = new TextBox();
            id_box = new TextBox();
            price_label = new Label();
            price_box = new TextBox();
            add_products_button = new Button();
            categories_cbox1 = new ComboBox();
            refresh_button = new Button();
            add_button = new Button();
            print_button = new Button();
            logout_button = new Button();
            products_list_label = new Label();
            sells_list_label = new Label();
            data_grid_categories = new DataGridView();
            data_grid_sell = new DataGridView();
            data_grid_product = new DataGridView();
            prdct_id = new DataGridViewTextBoxColumn();
            prdcts_name = new DataGridViewTextBoxColumn();
            prdcts_prc = new DataGridViewTextBoxColumn();
            prdcts_qty = new DataGridViewTextBoxColumn();
            total = new DataGridViewTextBoxColumn();
            date_label = new Label();
            sellers_label = new Label();
            amount_label = new Label();
            qty_label = new Label();
            qty_box = new TextBox();
            print_preview_bill = new PrintPreviewDialog();
            print_bill = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)backgroud_admin_sellers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)data_grid_categories).BeginInit();
            ((System.ComponentModel.ISupportInitialize)data_grid_sell).BeginInit();
            ((System.ComponentModel.ISupportInitialize)data_grid_product).BeginInit();
            SuspendLayout();
            // 
            // backgroud_admin_sellers
            // 
            backgroud_admin_sellers.Image = (Image)resources.GetObject("backgroud_admin_sellers.Image");
            backgroud_admin_sellers.Location = new Point(-2, -2);
            backgroud_admin_sellers.Margin = new Padding(3, 5, 3, 5);
            backgroud_admin_sellers.Name = "backgroud_admin_sellers";
            backgroud_admin_sellers.Size = new Size(1213, 953);
            backgroud_admin_sellers.SizeMode = PictureBoxSizeMode.Zoom;
            backgroud_admin_sellers.TabIndex = 59;
            backgroud_admin_sellers.TabStop = false;
            backgroud_admin_sellers.Click += backgroud_admin_sellers_Click;
            // 
            // name_label
            // 
            name_label.AutoSize = true;
            name_label.BackColor = Color.RoyalBlue;
            name_label.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            name_label.ForeColor = Color.White;
            name_label.Location = new Point(250, 345);
            name_label.Name = "name_label";
            name_label.Size = new Size(57, 23);
            name_label.TabIndex = 74;
            name_label.Text = "Name";
            // 
            // id_label
            // 
            id_label.AutoSize = true;
            id_label.BackColor = Color.RoyalBlue;
            id_label.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            id_label.ForeColor = Color.White;
            id_label.Location = new Point(250, 303);
            id_label.Name = "id_label";
            id_label.Size = new Size(57, 23);
            id_label.TabIndex = 73;
            id_label.Text = "Bill Id";
            // 
            // name_box
            // 
            name_box.BackColor = Color.White;
            name_box.BorderStyle = BorderStyle.FixedSingle;
            name_box.Location = new Point(325, 341);
            name_box.Name = "name_box";
            name_box.Size = new Size(210, 27);
            name_box.TabIndex = 72;
            // 
            // id_box
            // 
            id_box.BackColor = Color.White;
            id_box.BorderStyle = BorderStyle.FixedSingle;
            id_box.Location = new Point(325, 299);
            id_box.Name = "id_box";
            id_box.Size = new Size(210, 27);
            id_box.TabIndex = 71;
            // 
            // price_label
            // 
            price_label.AutoSize = true;
            price_label.BackColor = Color.RoyalBlue;
            price_label.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            price_label.ForeColor = Color.White;
            price_label.Location = new Point(250, 388);
            price_label.Name = "price_label";
            price_label.Size = new Size(49, 23);
            price_label.TabIndex = 76;
            price_label.Text = "Price";
            // 
            // price_box
            // 
            price_box.BackColor = Color.White;
            price_box.BorderStyle = BorderStyle.FixedSingle;
            price_box.Location = new Point(325, 384);
            price_box.Name = "price_box";
            price_box.Size = new Size(210, 27);
            price_box.TabIndex = 75;
            // 
            // add_products_button
            // 
            add_products_button.FlatAppearance.BorderSize = 0;
            add_products_button.FlatStyle = FlatStyle.Flat;
            add_products_button.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            add_products_button.ForeColor = Color.RoyalBlue;
            add_products_button.Location = new Point(325, 469);
            add_products_button.Name = "add_products_button";
            add_products_button.Size = new Size(210, 33);
            add_products_button.TabIndex = 77;
            add_products_button.Text = "ADD PRODUCTS";
            add_products_button.UseVisualStyleBackColor = true;
            add_products_button.Click += add_products_button_Click;
            // 
            // categories_cbox1
            // 
            categories_cbox1.BackColor = Color.White;
            categories_cbox1.Font = new Font("Segoe UI Semilight", 9F, FontStyle.Regular, GraphicsUnit.Point);
            categories_cbox1.ForeColor = Color.RoyalBlue;
            categories_cbox1.FormattingEnabled = true;
            categories_cbox1.Location = new Point(250, 517);
            categories_cbox1.Name = "categories_cbox1";
            categories_cbox1.Size = new Size(188, 28);
            categories_cbox1.TabIndex = 78;
            categories_cbox1.Text = "Select Categories";
            categories_cbox1.SelectionChangeCommitted += categories_cbox1_SelectionChangeCommitted;
            // 
            // refresh_button
            // 
            refresh_button.FlatAppearance.BorderSize = 0;
            refresh_button.FlatStyle = FlatStyle.Flat;
            refresh_button.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            refresh_button.ForeColor = Color.RoyalBlue;
            refresh_button.Location = new Point(444, 517);
            refresh_button.Name = "refresh_button";
            refresh_button.Size = new Size(91, 28);
            refresh_button.TabIndex = 79;
            refresh_button.Text = "Refresh";
            refresh_button.UseVisualStyleBackColor = true;
            refresh_button.Click += refresh_button_Click;
            // 
            // add_button
            // 
            add_button.FlatAppearance.BorderSize = 0;
            add_button.FlatStyle = FlatStyle.Flat;
            add_button.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            add_button.ForeColor = Color.RoyalBlue;
            add_button.Location = new Point(576, 727);
            add_button.Name = "add_button";
            add_button.Size = new Size(91, 28);
            add_button.TabIndex = 80;
            add_button.Text = "ADD";
            add_button.UseVisualStyleBackColor = true;
            add_button.Click += add_button_Click;
            // 
            // print_button
            // 
            print_button.FlatAppearance.BorderSize = 0;
            print_button.FlatStyle = FlatStyle.Flat;
            print_button.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            print_button.ForeColor = Color.RoyalBlue;
            print_button.Location = new Point(682, 727);
            print_button.Name = "print_button";
            print_button.Size = new Size(91, 28);
            print_button.TabIndex = 81;
            print_button.Text = "PRINT";
            print_button.UseVisualStyleBackColor = true;
            print_button.Click += print_button_Click;
            // 
            // logout_button
            // 
            logout_button.FlatAppearance.BorderSize = 0;
            logout_button.FlatStyle = FlatStyle.Flat;
            logout_button.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            logout_button.Location = new Point(92, 715);
            logout_button.Name = "logout_button";
            logout_button.Size = new Size(85, 36);
            logout_button.TabIndex = 82;
            logout_button.Text = "Log out";
            logout_button.UseVisualStyleBackColor = true;
            logout_button.Click += logout_button_Click;
            // 
            // products_list_label
            // 
            products_list_label.AutoSize = true;
            products_list_label.BackColor = Color.RoyalBlue;
            products_list_label.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            products_list_label.ForeColor = Color.White;
            products_list_label.Location = new Point(576, 247);
            products_list_label.Name = "products_list_label";
            products_list_label.Size = new Size(113, 23);
            products_list_label.TabIndex = 83;
            products_list_label.Text = "Products List";
            // 
            // sells_list_label
            // 
            sells_list_label.AutoSize = true;
            sells_list_label.BackColor = Color.RoyalBlue;
            sells_list_label.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            sells_list_label.ForeColor = Color.White;
            sells_list_label.Location = new Point(576, 490);
            sells_list_label.Name = "sells_list_label";
            sells_list_label.Size = new Size(79, 23);
            sells_list_label.TabIndex = 84;
            sells_list_label.Text = "Sells List";
            // 
            // data_grid_categories
            // 
            data_grid_categories.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            data_grid_categories.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            data_grid_categories.BackgroundColor = Color.White;
            data_grid_categories.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            data_grid_categories.ColumnHeadersHeight = 29;
            data_grid_categories.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            data_grid_categories.GridColor = SystemColors.Highlight;
            data_grid_categories.Location = new Point(250, 551);
            data_grid_categories.Name = "data_grid_categories";
            data_grid_categories.ReadOnly = true;
            data_grid_categories.RowHeadersWidth = 51;
            data_grid_categories.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            data_grid_categories.RowTemplate.Height = 29;
            data_grid_categories.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            data_grid_categories.Size = new Size(285, 204);
            data_grid_categories.StandardTab = true;
            data_grid_categories.TabIndex = 78;
            data_grid_categories.CellContentClick += data_grid_categories_CellContentClick;
            // 
            // data_grid_sell
            // 
            data_grid_sell.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            data_grid_sell.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            data_grid_sell.BackgroundColor = Color.White;
            data_grid_sell.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            data_grid_sell.ColumnHeadersHeight = 29;
            data_grid_sell.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            data_grid_sell.GridColor = SystemColors.Highlight;
            data_grid_sell.Location = new Point(576, 517);
            data_grid_sell.Name = "data_grid_sell";
            data_grid_sell.ReadOnly = true;
            data_grid_sell.RowHeadersWidth = 51;
            data_grid_sell.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            data_grid_sell.RowTemplate.Height = 29;
            data_grid_sell.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            data_grid_sell.Size = new Size(530, 204);
            data_grid_sell.StandardTab = true;
            data_grid_sell.TabIndex = 78;
            data_grid_sell.CellContentClick += data_grid_sell_CellContentClick;
            // 
            // data_grid_product
            // 
            data_grid_product.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            data_grid_product.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            data_grid_product.BackgroundColor = Color.White;
            data_grid_product.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            data_grid_product.ColumnHeadersHeight = 29;
            data_grid_product.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            data_grid_product.Columns.AddRange(new DataGridViewColumn[] { prdct_id, prdcts_name, prdcts_prc, prdcts_qty, total });
            data_grid_product.GridColor = SystemColors.Highlight;
            data_grid_product.Location = new Point(576, 273);
            data_grid_product.Name = "data_grid_product";
            data_grid_product.ReadOnly = true;
            data_grid_product.RowHeadersWidth = 51;
            data_grid_product.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            data_grid_product.RowTemplate.Height = 29;
            data_grid_product.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            data_grid_product.Size = new Size(530, 204);
            data_grid_product.StandardTab = true;
            data_grid_product.TabIndex = 78;
            data_grid_product.CellContentClick += data_grid_product_CellContentClick;
            // 
            // prdct_id
            // 
            prdct_id.HeaderText = "prdcts_id";
            prdct_id.MinimumWidth = 6;
            prdct_id.Name = "prdct_id";
            prdct_id.ReadOnly = true;
            prdct_id.Width = 98;
            // 
            // prdcts_name
            // 
            prdcts_name.HeaderText = "prdcts_name";
            prdcts_name.MinimumWidth = 6;
            prdcts_name.Name = "prdcts_name";
            prdcts_name.ReadOnly = true;
            prdcts_name.Width = 122;
            // 
            // prdcts_prc
            // 
            prdcts_prc.HeaderText = "prdcts_prc";
            prdcts_prc.MinimumWidth = 6;
            prdcts_prc.Name = "prdcts_prc";
            prdcts_prc.ReadOnly = true;
            prdcts_prc.Width = 106;
            // 
            // prdcts_qty
            // 
            prdcts_qty.HeaderText = "prdcts_qty";
            prdcts_qty.MinimumWidth = 6;
            prdcts_qty.Name = "prdcts_qty";
            prdcts_qty.ReadOnly = true;
            prdcts_qty.Width = 106;
            // 
            // total
            // 
            total.HeaderText = "total";
            total.MinimumWidth = 6;
            total.Name = "total";
            total.ReadOnly = true;
            total.Width = 69;
            // 
            // date_label
            // 
            date_label.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            date_label.AutoSize = true;
            date_label.BackColor = Color.RoyalBlue;
            date_label.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            date_label.ForeColor = Color.White;
            date_label.Location = new Point(972, 197);
            date_label.Name = "date_label";
            date_label.RightToLeft = RightToLeft.Yes;
            date_label.Size = new Size(134, 28);
            date_label.TabIndex = 85;
            date_label.Text = "dd/mm/yyyy";
            date_label.TextAlign = ContentAlignment.TopRight;
            // 
            // sellers_label
            // 
            sellers_label.AutoSize = true;
            sellers_label.BackColor = Color.RoyalBlue;
            sellers_label.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            sellers_label.ForeColor = Color.White;
            sellers_label.Location = new Point(250, 197);
            sellers_label.Name = "sellers_label";
            sellers_label.Size = new Size(74, 28);
            sellers_label.TabIndex = 86;
            sellers_label.Text = "Sellers";
            sellers_label.Click += sellers_label_Click;
            // 
            // amount_label
            // 
            amount_label.AutoSize = true;
            amount_label.BackColor = Color.RoyalBlue;
            amount_label.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            amount_label.ForeColor = Color.White;
            amount_label.Location = new Point(898, 480);
            amount_label.Name = "amount_label";
            amount_label.Size = new Size(102, 23);
            amount_label.TabIndex = 87;
            amount_label.Text = "Amount Rp";
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
            qty_label.TabIndex = 89;
            qty_label.Text = "Qty";
            // 
            // qty_box
            // 
            qty_box.BackColor = Color.White;
            qty_box.BorderStyle = BorderStyle.FixedSingle;
            qty_box.Location = new Point(325, 425);
            qty_box.Name = "qty_box";
            qty_box.Size = new Size(210, 27);
            qty_box.TabIndex = 88;
            // 
            // print_preview_bill
            // 
            print_preview_bill.AutoScrollMargin = new Size(0, 0);
            print_preview_bill.AutoScrollMinSize = new Size(0, 0);
            print_preview_bill.ClientSize = new Size(400, 300);
            print_preview_bill.Document = print_bill;
            print_preview_bill.Enabled = true;
            print_preview_bill.Icon = (Icon)resources.GetObject("print_preview_bill.Icon");
            print_preview_bill.Name = "print_preview_bill";
            print_preview_bill.Visible = false;
            // 
            // print_bill
            // 
            print_bill.PrintPage += print_bill_PrintPage;
            // 
            // Sellers_Selling_Screen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1209, 948);
            Controls.Add(qty_label);
            Controls.Add(qty_box);
            Controls.Add(amount_label);
            Controls.Add(sellers_label);
            Controls.Add(date_label);
            Controls.Add(data_grid_product);
            Controls.Add(data_grid_sell);
            Controls.Add(data_grid_categories);
            Controls.Add(sells_list_label);
            Controls.Add(products_list_label);
            Controls.Add(logout_button);
            Controls.Add(print_button);
            Controls.Add(add_button);
            Controls.Add(refresh_button);
            Controls.Add(categories_cbox1);
            Controls.Add(add_products_button);
            Controls.Add(price_label);
            Controls.Add(price_box);
            Controls.Add(name_label);
            Controls.Add(id_label);
            Controls.Add(name_box);
            Controls.Add(id_box);
            Controls.Add(backgroud_admin_sellers);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Sellers_Selling_Screen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "My Laptop";
            Load += Sellers_Selling_Screen_Load;
            ((System.ComponentModel.ISupportInitialize)backgroud_admin_sellers).EndInit();
            ((System.ComponentModel.ISupportInitialize)data_grid_categories).EndInit();
            ((System.ComponentModel.ISupportInitialize)data_grid_sell).EndInit();
            ((System.ComponentModel.ISupportInitialize)data_grid_product).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox backgroud_admin_sellers;
        private Label name_label;
        private Label id_label;
        private TextBox name_box;
        private TextBox id_box;
        private Label price_label;
        private TextBox price_box;
        private Button add_products_button;
        private ComboBox categories_cbox1;
        private Button refresh_button;
        private Button add_button;
        private Button print_button;
        private Button logout_button;
        private Label products_list_label;
        private Label sells_list_label;
        private DataGridView data_grid_categories;
        private DataGridView data_grid_sell;
        private DataGridView data_grid_product;
        private Label date_label;
        private Label sellers_label;
        private Label amount_label;
        private Label qty_label;
        private TextBox qty_box;
        private DataGridViewTextBoxColumn prdct_id;
        private DataGridViewTextBoxColumn prdcts_name;
        private DataGridViewTextBoxColumn prdcts_prc;
        private DataGridViewTextBoxColumn prdcts_qty;
        private DataGridViewTextBoxColumn total;
        private PrintPreviewDialog print_preview_bill;
        private System.Drawing.Printing.PrintDocument print_bill;
    }
}