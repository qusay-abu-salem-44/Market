namespace Market
{
    partial class frmlogin
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
            this.lblusername = new System.Windows.Forms.Label();
            this.lblpassowrd = new System.Windows.Forms.Label();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnlogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblusername
            // 
            this.lblusername.AutoSize = true;
            this.lblusername.Location = new System.Drawing.Point(75, 105);
            this.lblusername.Name = "lblusername";
            this.lblusername.Size = new System.Drawing.Size(148, 32);
            this.lblusername.TabIndex = 0;
            this.lblusername.Text = "user name";
            // 
            // lblpassowrd
            // 
            this.lblpassowrd.AutoSize = true;
            this.lblpassowrd.Location = new System.Drawing.Point(121, 251);
            this.lblpassowrd.Name = "lblpassowrd";
            this.lblpassowrd.Size = new System.Drawing.Size(136, 32);
            this.lblpassowrd.TabIndex = 1;
            this.lblpassowrd.Text = "password";
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(280, 102);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(281, 38);
            this.txtusername.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(278, 248);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.Size = new System.Drawing.Size(283, 38);
            this.textBox2.TabIndex = 3;
            // 
            // btnlogin
            // 
            this.btnlogin.Location = new System.Drawing.Point(213, 399);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(161, 64);
            this.btnlogin.TabIndex = 4;
            this.btnlogin.Text = "Login";
            this.btnlogin.UseVisualStyleBackColor = true;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // frmlogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 680);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.lblpassowrd);
            this.Controls.Add(this.lblusername);
            this.Name = "frmlogin";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblusername;
        private System.Windows.Forms.Label lblpassowrd;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnlogin;
    }
}

