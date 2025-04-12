namespace Supermarket_mvp.Views
{
    partial class ProductView
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
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            tabControl1 = new TabControl();
            tabPageProductList = new TabPage();
            tabPageProductDetail = new TabPage();
            label2 = new Label();
            TxtSearch = new TextBox();
            BtnSearch = new Button();
            dataGridView1 = new DataGridView();
            BtnNew = new Button();
            BtnEdit = new Button();
            BtnDelete = new Button();
            BtnClose = new Button();
            BtnSave = new Button();
            BtnCancel = new Button();
            label3 = new Label();
            TxtProductId = new TextBox();
            TxtProductName = new TextBox();
            label4 = new Label();
            TxtProductPrice = new TextBox();
            label5 = new Label();
            TxtCategoryId = new TextBox();
            label6 = new Label();
            TxtProductStock = new TextBox();
            label7 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl1.SuspendLayout();
            tabPageProductList.SuspendLayout();
            tabPageProductDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 102);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(170, 30);
            label1.Name = "label1";
            label1.Size = new Size(148, 37);
            label1.TabIndex = 0;
            label1.Text = "Productos";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.products1;
            pictureBox1.Location = new Point(35, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(103, 72);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageProductList);
            tabControl1.Controls.Add(tabPageProductDetail);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 102);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 348);
            tabControl1.TabIndex = 1;
            // 
            // tabPageProductList
            // 
            tabPageProductList.Controls.Add(BtnClose);
            tabPageProductList.Controls.Add(BtnDelete);
            tabPageProductList.Controls.Add(BtnEdit);
            tabPageProductList.Controls.Add(BtnNew);
            tabPageProductList.Controls.Add(dataGridView1);
            tabPageProductList.Controls.Add(BtnSearch);
            tabPageProductList.Controls.Add(TxtSearch);
            tabPageProductList.Controls.Add(label2);
            tabPageProductList.Location = new Point(4, 24);
            tabPageProductList.Name = "tabPageProductList";
            tabPageProductList.Padding = new Padding(3);
            tabPageProductList.Size = new Size(792, 320);
            tabPageProductList.TabIndex = 0;
            tabPageProductList.Text = "Product List";
            tabPageProductList.UseVisualStyleBackColor = true;
            // 
            // tabPageProductDetail
            // 
            tabPageProductDetail.Controls.Add(TxtProductStock);
            tabPageProductDetail.Controls.Add(label7);
            tabPageProductDetail.Controls.Add(TxtCategoryId);
            tabPageProductDetail.Controls.Add(label6);
            tabPageProductDetail.Controls.Add(TxtProductPrice);
            tabPageProductDetail.Controls.Add(label5);
            tabPageProductDetail.Controls.Add(TxtProductName);
            tabPageProductDetail.Controls.Add(label4);
            tabPageProductDetail.Controls.Add(TxtProductId);
            tabPageProductDetail.Controls.Add(label3);
            tabPageProductDetail.Controls.Add(BtnCancel);
            tabPageProductDetail.Controls.Add(BtnSave);
            tabPageProductDetail.Location = new Point(4, 24);
            tabPageProductDetail.Name = "tabPageProductDetail";
            tabPageProductDetail.Padding = new Padding(3);
            tabPageProductDetail.Size = new Size(792, 320);
            tabPageProductDetail.TabIndex = 1;
            tabPageProductDetail.Text = "Product Detail";
            tabPageProductDetail.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 16);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 0;
            label2.Text = "Search";
            // 
            // TxtSearch
            // 
            TxtSearch.Location = new Point(20, 37);
            TxtSearch.Name = "TxtSearch";
            TxtSearch.Size = new Size(331, 23);
            TxtSearch.TabIndex = 1;
            // 
            // BtnSearch
            // 
            BtnSearch.Image = Properties.Resources.search_small;
            BtnSearch.Location = new Point(378, 27);
            BtnSearch.Name = "BtnSearch";
            BtnSearch.Size = new Size(73, 40);
            BtnSearch.TabIndex = 2;
            BtnSearch.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(15, 115);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(418, 150);
            dataGridView1.TabIndex = 3;
            // 
            // BtnNew
            // 
            BtnNew.Image = Properties.Resources.new1;
            BtnNew.Location = new Point(593, 27);
            BtnNew.Name = "BtnNew";
            BtnNew.Size = new Size(91, 52);
            BtnNew.TabIndex = 4;
            BtnNew.UseVisualStyleBackColor = true;
            // 
            // BtnEdit
            // 
            BtnEdit.Image = Properties.Resources.edit1;
            BtnEdit.Location = new Point(593, 102);
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Size = new Size(91, 43);
            BtnEdit.TabIndex = 5;
            BtnEdit.UseVisualStyleBackColor = true;
            // 
            // BtnDelete
            // 
            BtnDelete.Image = Properties.Resources.delete;
            BtnDelete.Location = new Point(593, 167);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(91, 45);
            BtnDelete.TabIndex = 6;
            BtnDelete.UseVisualStyleBackColor = true;
            // 
            // BtnClose
            // 
            BtnClose.Image = Properties.Resources.cerrar;
            BtnClose.Location = new Point(593, 242);
            BtnClose.Name = "BtnClose";
            BtnClose.Size = new Size(91, 38);
            BtnClose.TabIndex = 7;
            BtnClose.UseVisualStyleBackColor = true;
            // 
            // BtnSave
            // 
            BtnSave.Image = Properties.Resources.save1;
            BtnSave.Location = new Point(21, 264);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(90, 50);
            BtnSave.TabIndex = 0;
            BtnSave.UseVisualStyleBackColor = true;
            // 
            // BtnCancel
            // 
            BtnCancel.Image = Properties.Resources.cancel11;
            BtnCancel.Location = new Point(166, 264);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(83, 48);
            BtnCancel.TabIndex = 1;
            BtnCancel.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(104, 13);
            label3.Name = "label3";
            label3.Size = new Size(17, 15);
            label3.TabIndex = 2;
            label3.Text = "Id";
            // 
            // TxtProductId
            // 
            TxtProductId.Location = new Point(21, 31);
            TxtProductId.Name = "TxtProductId";
            TxtProductId.ReadOnly = true;
            TxtProductId.Size = new Size(100, 23);
            TxtProductId.TabIndex = 3;
            TxtProductId.Text = "0";
            // 
            // TxtProductName
            // 
            TxtProductName.Location = new Point(23, 90);
            TxtProductName.Name = "TxtProductName";
            TxtProductName.Size = new Size(100, 23);
            TxtProductName.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(37, 72);
            label4.Name = "label4";
            label4.Size = new Size(84, 15);
            label4.TabIndex = 4;
            label4.Text = "Product Name";
            // 
            // TxtProductPrice
            // 
            TxtProductPrice.Location = new Point(23, 159);
            TxtProductPrice.Name = "TxtProductPrice";
            TxtProductPrice.Size = new Size(100, 23);
            TxtProductPrice.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(45, 141);
            label5.Name = "label5";
            label5.Size = new Size(78, 15);
            label5.TabIndex = 6;
            label5.Text = "Product Price";
            // 
            // TxtCategoryId
            // 
            TxtCategoryId.Location = new Point(178, 31);
            TxtCategoryId.Name = "TxtCategoryId";
            TxtCategoryId.Size = new Size(100, 23);
            TxtCategoryId.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(180, 13);
            label6.Name = "label6";
            label6.Size = new Size(69, 15);
            label6.TabIndex = 8;
            label6.Text = "Category ID";
            // 
            // TxtProductStock
            // 
            TxtProductStock.Location = new Point(21, 225);
            TxtProductStock.Name = "TxtProductStock";
            TxtProductStock.Size = new Size(100, 23);
            TxtProductStock.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(43, 207);
            label7.Name = "label7";
            label7.Size = new Size(81, 15);
            label7.TabIndex = 10;
            label7.Text = "Product Stock";
            // 
            // ProductView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Name = "ProductView";
            Text = "Product Management";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabControl1.ResumeLayout(false);
            tabPageProductList.ResumeLayout(false);
            tabPageProductList.PerformLayout();
            tabPageProductDetail.ResumeLayout(false);
            tabPageProductDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private TabControl tabControl1;
        private TabPage tabPageProductList;
        private TabPage tabPageProductDetail;
        private DataGridView dataGridView1;
        private Button BtnSearch;
        private TextBox TxtSearch;
        private Label label2;
        private Button BtnClose;
        private Button BtnDelete;
        private Button BtnEdit;
        private Button BtnNew;
        private Label label3;
        private Button BtnCancel;
        private Button BtnSave;
        private TextBox TxtCategoryId;
        private Label label6;
        private TextBox TxtProductPrice;
        private Label label5;
        private TextBox TxtProductName;
        private Label label4;
        private TextBox TxtProductId;
        private TextBox TxtProductStock;
        private Label label7;
    }
}