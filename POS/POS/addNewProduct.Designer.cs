namespace POS
{
    partial class addNewProduct
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
            this.nullTextIdentifier = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.priceTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.productNameTextBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.suppName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DescTB = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nullTextIdentifier
            // 
            this.nullTextIdentifier.AutoSize = true;
            this.nullTextIdentifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nullTextIdentifier.ForeColor = System.Drawing.Color.Red;
            this.nullTextIdentifier.Location = new System.Drawing.Point(530, 242);
            this.nullTextIdentifier.Name = "nullTextIdentifier";
            this.nullTextIdentifier.Size = new System.Drawing.Size(0, 20);
            this.nullTextIdentifier.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(59, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "Product Price";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // priceTB
            // 
            this.priceTB.Location = new System.Drawing.Point(213, 168);
            this.priceTB.Multiline = true;
            this.priceTB.Name = "priceTB";
            this.priceTB.Size = new System.Drawing.Size(284, 20);
            this.priceTB.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Product Name:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // productNameTextBox
            // 
            this.productNameTextBox.Location = new System.Drawing.Point(213, 117);
            this.productNameTextBox.Name = "productNameTextBox";
            this.productNameTextBox.Size = new System.Drawing.Size(284, 20);
            this.productNameTextBox.TabIndex = 17;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(559, 115);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(193, 48);
            this.button2.TabIndex = 16;
            this.button2.Text = "Add Product";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(57, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "Supplier Name:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // suppName
            // 
            this.suppName.AutoSize = true;
            this.suppName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.suppName.Location = new System.Drawing.Point(188, 59);
            this.suppName.Name = "suppName";
            this.suppName.Size = new System.Drawing.Size(0, 20);
            this.suppName.TabIndex = 22;
            this.suppName.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(59, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 20);
            this.label4.TabIndex = 24;
            this.label4.Text = "Product Description";
            // 
            // DescTB
            // 
            this.DescTB.Location = new System.Drawing.Point(213, 210);
            this.DescTB.Multiline = true;
            this.DescTB.Name = "DescTB";
            this.DescTB.Size = new System.Drawing.Size(284, 52);
            this.DescTB.TabIndex = 23;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(559, 352);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(193, 48);
            this.button1.TabIndex = 25;
            this.button1.Text = "<- Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // addNewProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DescTB);
            this.Controls.Add(this.suppName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nullTextIdentifier);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.priceTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.productNameTextBox);
            this.Controls.Add(this.button2);
            this.Name = "addNewProduct";
            this.Text = "addNewProduct";
            this.Load += new System.EventHandler(this.addNewProduct_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nullTextIdentifier;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox priceTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox productNameTextBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label suppName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox DescTB;
        private System.Windows.Forms.Button button1;
    }
}