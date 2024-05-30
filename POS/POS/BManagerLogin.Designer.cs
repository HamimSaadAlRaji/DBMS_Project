namespace POS
{
    partial class BManagerLogin
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
            this.label1 = new System.Windows.Forms.Label();
            this.branchIDtextBox = new System.Windows.Forms.TextBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.BranchID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.PassMismaatch = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(320, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 60);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // branchIDtextBox
            // 
            this.branchIDtextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.branchIDtextBox.Location = new System.Drawing.Point(237, 134);
            this.branchIDtextBox.Name = "branchIDtextBox";
            this.branchIDtextBox.Size = new System.Drawing.Size(300, 29);
            this.branchIDtextBox.TabIndex = 1;
            this.branchIDtextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTextBox.Location = new System.Drawing.Point(237, 210);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(300, 29);
            this.PasswordTextBox.TabIndex = 1;
            this.PasswordTextBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(300, 289);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(173, 32);
            this.button1.TabIndex = 2;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BranchID
            // 
            this.BranchID.AutoSize = true;
            this.BranchID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BranchID.Location = new System.Drawing.Point(240, 103);
            this.BranchID.Name = "BranchID";
            this.BranchID.Size = new System.Drawing.Size(81, 20);
            this.BranchID.TabIndex = 3;
            this.BranchID.Text = "Branch ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(242, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(300, 327);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(173, 38);
            this.button2.TabIndex = 4;
            this.button2.Text = "<- Back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // PassMismaatch
            // 
            this.PassMismaatch.AutoSize = true;
            this.PassMismaatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassMismaatch.ForeColor = System.Drawing.Color.Red;
            this.PassMismaatch.Location = new System.Drawing.Point(241, 254);
            this.PassMismaatch.Name = "PassMismaatch";
            this.PassMismaatch.Size = new System.Drawing.Size(0, 20);
            this.PassMismaatch.TabIndex = 5;
            this.PassMismaatch.Click += new System.EventHandler(this.PassMismaatch_Click);
            // 
            // BManagerLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PassMismaatch);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BranchID);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.branchIDtextBox);
            this.Controls.Add(this.label1);
            this.Name = "BManagerLogin";
            this.Text = "BManagerLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox branchIDtextBox;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label BranchID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label PassMismaatch;
    }
}