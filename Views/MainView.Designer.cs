namespace Supermarket_mvp.Views
{
    partial class MainView
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
            BtnProduct = new Button();
            BtnCategory = new Button();
            BtnExit = new Button();
            BtnPayMode = new Button();
            pictureBox1 = new PictureBox();
            BtnCustomer = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(BtnCustomer);
            panel1.Controls.Add(BtnProduct);
            panel1.Controls.Add(BtnCategory);
            panel1.Controls.Add(BtnExit);
            panel1.Controls.Add(BtnPayMode);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(263, 450);
            panel1.TabIndex = 0;
            // 
            // BtnProduct
            // 
            BtnProduct.BackgroundImage = Properties.Resources.products1;
            BtnProduct.BackgroundImageLayout = ImageLayout.Zoom;
            BtnProduct.Location = new Point(42, 224);
            BtnProduct.Name = "BtnProduct";
            BtnProduct.Size = new Size(168, 65);
            BtnProduct.TabIndex = 4;
            BtnProduct.UseVisualStyleBackColor = true;
            // 
            // BtnCategory
            // 
            BtnCategory.BackgroundImage = Properties.Resources.category_list_svgrepo_com;
            BtnCategory.BackgroundImageLayout = ImageLayout.Zoom;
            BtnCategory.Location = new Point(42, 160);
            BtnCategory.Name = "BtnCategory";
            BtnCategory.Size = new Size(168, 58);
            BtnCategory.TabIndex = 3;
            BtnCategory.UseVisualStyleBackColor = true;
            // 
            // BtnExit
            // 
            BtnExit.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            BtnExit.BackgroundImage = Properties.Resources.salida;
            BtnExit.BackgroundImageLayout = ImageLayout.Zoom;
            BtnExit.Location = new Point(42, 363);
            BtnExit.Name = "BtnExit";
            BtnExit.Size = new Size(168, 75);
            BtnExit.TabIndex = 2;
            BtnExit.UseVisualStyleBackColor = true;
            // 
            // BtnPayMode
            // 
            BtnPayMode.BackgroundImage = Properties.Resources.buy11;
            BtnPayMode.BackgroundImageLayout = ImageLayout.Zoom;
            BtnPayMode.Location = new Point(42, 88);
            BtnPayMode.Name = "BtnPayMode";
            BtnPayMode.Size = new Size(168, 66);
            BtnPayMode.TabIndex = 1;
            BtnPayMode.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.sell;
            pictureBox1.Location = new Point(42, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(178, 70);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // BtnCustomer
            // 
            BtnCustomer.BackgroundImage = Properties.Resources.client_svgrepo_com;
            BtnCustomer.BackgroundImageLayout = ImageLayout.Zoom;
            BtnCustomer.Location = new Point(42, 295);
            BtnCustomer.Name = "BtnCustomer";
            BtnCustomer.Size = new Size(168, 62);
            BtnCustomer.TabIndex = 5;
            BtnCustomer.UseVisualStyleBackColor = true;
            // 
            // MainView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            IsMdiContainer = true;
            Name = "MainView";
            Text = "SuperMarket";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button BtnPayMode;
        private PictureBox pictureBox1;
        private Button BtnExit;
        private Button BtnCategory;
        private Button BtnProduct;
        private Button BtnCustomer;
    }
}