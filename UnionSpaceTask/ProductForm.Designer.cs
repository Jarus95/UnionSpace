namespace UnionSpaceTask
{
    partial class ProductForm
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
            this.ProductArticle = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ProductName = new System.Windows.Forms.Label();
            this.ProductPrice = new System.Windows.Forms.Label();
            this.ProductQty = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ProductArticle
            // 
            this.ProductArticle.AutoSize = true;
            this.ProductArticle.Font = new System.Drawing.Font("Segoe UI", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ProductArticle.Location = new System.Drawing.Point(402, 71);
            this.ProductArticle.Name = "ProductArticle";
            this.ProductArticle.Size = new System.Drawing.Size(140, 45);
            this.ProductArticle.TabIndex = 0;
            this.ProductArticle.Text = "Артикул";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::UnionSpaceTask.Properties.Resources.CI9924_400;
            this.pictureBox1.Location = new System.Drawing.Point(37, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(348, 394);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // ProductName
            // 
            this.ProductName.AutoSize = true;
            this.ProductName.Font = new System.Drawing.Font("Segoe UI", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ProductName.Location = new System.Drawing.Point(402, 143);
            this.ProductName.Name = "ProductName";
            this.ProductName.Size = new System.Drawing.Size(159, 45);
            this.ProductName.TabIndex = 2;
            this.ProductName.Text = "Названия";
            // 
            // ProductPrice
            // 
            this.ProductPrice.AutoSize = true;
            this.ProductPrice.Font = new System.Drawing.Font("Segoe UI", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ProductPrice.Location = new System.Drawing.Point(402, 218);
            this.ProductPrice.Name = "ProductPrice";
            this.ProductPrice.Size = new System.Drawing.Size(95, 45);
            this.ProductPrice.TabIndex = 3;
            this.ProductPrice.Text = "Цена";
            // 
            // ProductQty
            // 
            this.ProductQty.AutoSize = true;
            this.ProductQty.Font = new System.Drawing.Font("Segoe UI", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ProductQty.Location = new System.Drawing.Point(402, 295);
            this.ProductQty.Name = "ProductQty";
            this.ProductQty.Size = new System.Drawing.Size(193, 45);
            this.ProductQty.TabIndex = 4;
            this.ProductQty.Text = "Количество";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(748, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 46);
            this.label1.TabIndex = 5;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ProductQty);
            this.Controls.Add(this.ProductPrice);
            this.Controls.Add(this.ProductName);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ProductArticle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProductForm";
            this.Text = "ProductForm";
            this.Load += new System.EventHandler(this.ProductForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label ProductArticle;
        private PictureBox pictureBox1;
        private Label ProductName;
        private Label ProductPrice;
        private Label ProductQty;
        private Label label1;
    }
}