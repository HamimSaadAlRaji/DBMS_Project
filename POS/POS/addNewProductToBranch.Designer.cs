namespace POS
{
    partial class addNewProductToBranch
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
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.BranchID = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nullTextIdentifier = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.productID = new System.Windows.Forms.Label();
            this.productNameTextBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(555, 348);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(193, 48);
            this.button1.TabIndex = 36;
            this.button1.Text = "<- Back";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(55, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 20);
            this.label4.TabIndex = 35;
            this.label4.Text = " ";
            // 
            // BranchID
            // 
            this.BranchID.AutoSize = true;
            this.BranchID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BranchID.Location = new System.Drawing.Point(184, 55);
            this.BranchID.Name = "BranchID";
            this.BranchID.Size = new System.Drawing.Size(0, 20);
            this.BranchID.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(53, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.TabIndex = 33;
            this.label3.Text = "BranchID:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // nullTextIdentifier
            // 
            this.nullTextIdentifier.AutoSize = true;
            this.nullTextIdentifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nullTextIdentifier.ForeColor = System.Drawing.Color.Red;
            this.nullTextIdentifier.Location = new System.Drawing.Point(526, 238);
            this.nullTextIdentifier.Name = "nullTextIdentifier";
            this.nullTextIdentifier.Size = new System.Drawing.Size(0, 20);
            this.nullTextIdentifier.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(55, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 20);
            this.label2.TabIndex = 30;
            this.label2.Text = " ";
            // 
            // productID
            // 
            this.productID.AutoSize = true;
            this.productID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productID.Location = new System.Drawing.Point(53, 111);
            this.productID.Name = "productID";
            this.productID.Size = new System.Drawing.Size(89, 20);
            this.productID.TabIndex = 28;
            this.productID.Text = "Product ID:";
            // 
            // productNameTextBox
            // 
            this.productNameTextBox.Location = new System.Drawing.Point(209, 113);
            this.productNameTextBox.Name = "productNameTextBox";
            this.productNameTextBox.Size = new System.Drawing.Size(284, 20);
            this.productNameTextBox.TabIndex = 27;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(555, 111);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(193, 48);
            this.button2.TabIndex = 26;
            this.button2.Text = "Add Product";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // addNewProductToBranch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BranchID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nullTextIdentifier);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.productID);
            this.Controls.Add(this.productNameTextBox);
            this.Controls.Add(this.button2);
            this.Name = "addNewProductToBranch";
            this.Text = "addNewProductToBranch";
            this.Load += new System.EventHandler(this.addNewProductToBranch_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label BranchID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label nullTextIdentifier;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label productID;
        private System.Windows.Forms.TextBox productNameTextBox;
        private System.Windows.Forms.Button button2;
    }
}