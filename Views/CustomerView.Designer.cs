namespace Supermarket_mvp.Views
{
    partial class CustomerView
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
            tabPageCustomerList = new TabPage();
            tabPageCustomerDetail = new TabPage();
            label2 = new Label();
            textBox1 = new TextBox();
            dataGridView1 = new DataGridView();
            BtnSearch = new Button();
            BtnNew = new Button();
            BtnEdit = new Button();
            BtnDelete = new Button();
            BtnClose = new Button();
            label3 = new Label();
            TxtCustomerId = new TextBox();
            TxtCustomer_First_Name = new TextBox();
            label4 = new Label();
            TxtCustomer_Last_Name = new TextBox();
            label5 = new Label();
            TxtCustomerDocument = new TextBox();
            label6 = new Label();
            TxtCustomerAddress = new TextBox();
            label7 = new Label();
            TxtCustomerBirthday = new TextBox();
            label8 = new Label();
            TxtCustomerPhone_Number = new TextBox();
            label9 = new Label();
            TxtCustomerEmail = new TextBox();
            label10 = new Label();
            BtnSave = new Button();
            BtnCancel = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl1.SuspendLayout();
            tabPageCustomerList.SuspendLayout();
            tabPageCustomerDetail.SuspendLayout();
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
            panel1.Size = new Size(800, 124);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(175, 32);
            label1.Name = "label1";
            label1.Size = new Size(141, 37);
            label1.TabIndex = 0;
            label1.Text = "Customer";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.client_svgrepo_com;
            pictureBox1.Location = new Point(33, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(110, 89);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageCustomerList);
            tabControl1.Controls.Add(tabPageCustomerDetail);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 124);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 326);
            tabControl1.TabIndex = 1;
            // 
            // tabPageCustomerList
            // 
            tabPageCustomerList.Controls.Add(BtnClose);
            tabPageCustomerList.Controls.Add(BtnDelete);
            tabPageCustomerList.Controls.Add(BtnEdit);
            tabPageCustomerList.Controls.Add(BtnNew);
            tabPageCustomerList.Controls.Add(BtnSearch);
            tabPageCustomerList.Controls.Add(dataGridView1);
            tabPageCustomerList.Controls.Add(textBox1);
            tabPageCustomerList.Controls.Add(label2);
            tabPageCustomerList.Location = new Point(4, 24);
            tabPageCustomerList.Name = "tabPageCustomerList";
            tabPageCustomerList.Padding = new Padding(3);
            tabPageCustomerList.Size = new Size(792, 298);
            tabPageCustomerList.TabIndex = 0;
            tabPageCustomerList.Text = "Customer List";
            tabPageCustomerList.UseVisualStyleBackColor = true;
            // 
            // tabPageCustomerDetail
            // 
            tabPageCustomerDetail.Controls.Add(BtnCancel);
            tabPageCustomerDetail.Controls.Add(BtnSave);
            tabPageCustomerDetail.Controls.Add(TxtCustomerEmail);
            tabPageCustomerDetail.Controls.Add(label10);
            tabPageCustomerDetail.Controls.Add(TxtCustomerPhone_Number);
            tabPageCustomerDetail.Controls.Add(label9);
            tabPageCustomerDetail.Controls.Add(TxtCustomerBirthday);
            tabPageCustomerDetail.Controls.Add(label8);
            tabPageCustomerDetail.Controls.Add(TxtCustomerAddress);
            tabPageCustomerDetail.Controls.Add(label7);
            tabPageCustomerDetail.Controls.Add(TxtCustomerDocument);
            tabPageCustomerDetail.Controls.Add(label6);
            tabPageCustomerDetail.Controls.Add(TxtCustomer_Last_Name);
            tabPageCustomerDetail.Controls.Add(label5);
            tabPageCustomerDetail.Controls.Add(TxtCustomer_First_Name);
            tabPageCustomerDetail.Controls.Add(label4);
            tabPageCustomerDetail.Controls.Add(TxtCustomerId);
            tabPageCustomerDetail.Controls.Add(label3);
            tabPageCustomerDetail.Location = new Point(4, 24);
            tabPageCustomerDetail.Name = "tabPageCustomerDetail";
            tabPageCustomerDetail.Padding = new Padding(3);
            tabPageCustomerDetail.Size = new Size(792, 298);
            tabPageCustomerDetail.TabIndex = 1;
            tabPageCustomerDetail.Text = "Customer Detail";
            tabPageCustomerDetail.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 16);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 0;
            label2.Text = "Search";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(28, 42);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(332, 23);
            textBox1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(24, 82);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(435, 193);
            dataGridView1.TabIndex = 2;
            // 
            // BtnSearch
            // 
            BtnSearch.Image = Properties.Resources.search_small;
            BtnSearch.Location = new Point(384, 27);
            BtnSearch.Name = "BtnSearch";
            BtnSearch.Size = new Size(75, 51);
            BtnSearch.TabIndex = 3;
            BtnSearch.UseVisualStyleBackColor = true;
            // 
            // BtnNew
            // 
            BtnNew.Image = Properties.Resources._new;
            BtnNew.Location = new Point(617, 30);
            BtnNew.Name = "BtnNew";
            BtnNew.Size = new Size(75, 48);
            BtnNew.TabIndex = 4;
            BtnNew.UseVisualStyleBackColor = true;
            // 
            // BtnEdit
            // 
            BtnEdit.Image = Properties.Resources.edit;
            BtnEdit.Location = new Point(617, 84);
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Size = new Size(75, 50);
            BtnEdit.TabIndex = 5;
            BtnEdit.UseVisualStyleBackColor = true;
            // 
            // BtnDelete
            // 
            BtnDelete.Image = Properties.Resources.delete1;
            BtnDelete.Location = new Point(617, 151);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(75, 43);
            BtnDelete.TabIndex = 6;
            BtnDelete.UseVisualStyleBackColor = true;
            // 
            // BtnClose
            // 
            BtnClose.Image = Properties.Resources.cerrar;
            BtnClose.Location = new Point(617, 211);
            BtnClose.Name = "BtnClose";
            BtnClose.Size = new Size(75, 45);
            BtnClose.TabIndex = 7;
            BtnClose.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 15);
            label3.Name = "label3";
            label3.Size = new Size(72, 15);
            label3.TabIndex = 0;
            label3.Text = "Customer Id";
            // 
            // TxtCustomerId
            // 
            TxtCustomerId.Location = new Point(16, 37);
            TxtCustomerId.Name = "TxtCustomerId";
            TxtCustomerId.ReadOnly = true;
            TxtCustomerId.Size = new Size(100, 23);
            TxtCustomerId.TabIndex = 1;
            TxtCustomerId.Text = "0";
            // 
            // TxtCustomer_First_Name
            // 
            TxtCustomer_First_Name.Location = new Point(171, 37);
            TxtCustomer_First_Name.Name = "TxtCustomer_First_Name";
            TxtCustomer_First_Name.Size = new Size(100, 23);
            TxtCustomer_First_Name.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(169, 15);
            label4.Name = "label4";
            label4.Size = new Size(119, 15);
            label4.TabIndex = 2;
            label4.Text = "Customer First Name";
            // 
            // TxtCustomer_Last_Name
            // 
            TxtCustomer_Last_Name.Location = new Point(16, 154);
            TxtCustomer_Last_Name.Name = "TxtCustomer_Last_Name";
            TxtCustomer_Last_Name.Size = new Size(100, 23);
            TxtCustomer_Last_Name.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(14, 132);
            label5.Name = "label5";
            label5.Size = new Size(118, 15);
            label5.TabIndex = 4;
            label5.Text = "Customer Last Name";
            // 
            // TxtCustomerDocument
            // 
            TxtCustomerDocument.Location = new Point(16, 92);
            TxtCustomerDocument.Name = "TxtCustomerDocument";
            TxtCustomerDocument.Size = new Size(100, 23);
            TxtCustomerDocument.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(14, 70);
            label6.Name = "label6";
            label6.Size = new Size(63, 15);
            label6.TabIndex = 6;
            label6.Text = "Document";
            // 
            // TxtCustomerAddress
            // 
            TxtCustomerAddress.Location = new Point(171, 92);
            TxtCustomerAddress.Name = "TxtCustomerAddress";
            TxtCustomerAddress.Size = new Size(100, 23);
            TxtCustomerAddress.TabIndex = 9;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(169, 70);
            label7.Name = "label7";
            label7.Size = new Size(49, 15);
            label7.TabIndex = 8;
            label7.Text = "Address";
            // 
            // TxtCustomerBirthday
            // 
            TxtCustomerBirthday.Location = new Point(171, 154);
            TxtCustomerBirthday.Name = "TxtCustomerBirthday";
            TxtCustomerBirthday.Size = new Size(100, 23);
            TxtCustomerBirthday.TabIndex = 11;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(169, 132);
            label8.Name = "label8";
            label8.Size = new Size(51, 15);
            label8.TabIndex = 10;
            label8.Text = "Birthday";
            // 
            // TxtCustomerPhone_Number
            // 
            TxtCustomerPhone_Number.Location = new Point(326, 37);
            TxtCustomerPhone_Number.Name = "TxtCustomerPhone_Number";
            TxtCustomerPhone_Number.Size = new Size(100, 23);
            TxtCustomerPhone_Number.TabIndex = 13;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(324, 15);
            label9.Name = "label9";
            label9.Size = new Size(88, 15);
            label9.TabIndex = 12;
            label9.Text = "Phone Number";
            // 
            // TxtCustomerEmail
            // 
            TxtCustomerEmail.Location = new Point(326, 92);
            TxtCustomerEmail.Name = "TxtCustomerEmail";
            TxtCustomerEmail.Size = new Size(100, 23);
            TxtCustomerEmail.TabIndex = 15;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(324, 70);
            label10.Name = "label10";
            label10.Size = new Size(36, 15);
            label10.TabIndex = 14;
            label10.Text = "Email";
            // 
            // BtnSave
            // 
            BtnSave.Image = Properties.Resources.save;
            BtnSave.Location = new Point(57, 225);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(75, 44);
            BtnSave.TabIndex = 16;
            BtnSave.UseVisualStyleBackColor = true;
            // 
            // BtnCancel
            // 
            BtnCancel.Image = Properties.Resources.cancel1;
            BtnCancel.Location = new Point(213, 225);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(75, 44);
            BtnCancel.TabIndex = 17;
            BtnCancel.UseVisualStyleBackColor = true;
            // 
            // CustomerView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Name = "CustomerView";
            Text = "Customer Management";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabControl1.ResumeLayout(false);
            tabPageCustomerList.ResumeLayout(false);
            tabPageCustomerList.PerformLayout();
            tabPageCustomerDetail.ResumeLayout(false);
            tabPageCustomerDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private TabControl tabControl1;
        private TabPage tabPageCustomerList;
        private TabPage tabPageCustomerDetail;
        private TextBox textBox1;
        private Label label2;
        private Button BtnClose;
        private Button BtnDelete;
        private Button BtnEdit;
        private Button BtnNew;
        private Button BtnSearch;
        private DataGridView dataGridView1;
        private TextBox TxtCustomerEmail;
        private Label label10;
        private TextBox TxtCustomerPhone_Number;
        private Label label9;
        private TextBox TxtCustomerBirthday;
        private Label label8;
        private TextBox TxtCustomerAddress;
        private Label label7;
        private TextBox TxtCustomerDocument;
        private Label label6;
        private TextBox TxtCustomer_Last_Name;
        private Label label5;
        private TextBox TxtCustomer_First_Name;
        private Label label4;
        private TextBox TxtCustomerId;
        private Label label3;
        private Button BtnCancel;
        private Button BtnSave;
    }
}