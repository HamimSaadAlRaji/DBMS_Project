﻿namespace POS
{
    partial class CProductOfSupplier
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
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.ProductsOfSuppliers = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(594, 348);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 61);
            this.button4.TabIndex = 9;
            this.button4.Text = "<- Back";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(594, 32);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 61);
            this.button3.TabIndex = 8;
            this.button3.Text = "Add Product";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // ProductsOfSuppliers
            // 
            this.ProductsOfSuppliers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductsOfSuppliers.FormattingEnabled = true;
            this.ProductsOfSuppliers.ItemHeight = 20;
            this.ProductsOfSuppliers.Location = new System.Drawing.Point(64, 28);
            this.ProductsOfSuppliers.Name = "ProductsOfSuppliers";
            this.ProductsOfSuppliers.Size = new System.Drawing.Size(494, 364);
            this.ProductsOfSuppliers.TabIndex = 6;
            // 
            // CProductOfSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.ProductsOfSuppliers);
            this.Name = "CProductOfSupplier";
            this.Text = "CAddProductOfSupplier";
            this.Load += new System.EventHandler(this.CAddProductOfSupplier_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListBox ProductsOfSuppliers;
    }
}