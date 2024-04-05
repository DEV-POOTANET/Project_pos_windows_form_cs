namespace Project_pos
{
    partial class FrmLogin
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
            this.panMain = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtExit = new System.Windows.Forms.Button();
            this.BtClear = new Project_pos.CustomButton();
            this.BtLogin = new Project_pos.CustomButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CbShowPass = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PicProduct = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.LbId = new System.Windows.Forms.Label();
            this.TxPassword = new System.Windows.Forms.TextBox();
            this.TxUsername = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LbLogo = new System.Windows.Forms.Label();
            this.panMain.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicProduct)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panMain
            // 
            this.panMain.BackColor = System.Drawing.Color.White;
            this.panMain.Controls.Add(this.panel2);
            this.panMain.Controls.Add(this.BtClear);
            this.panMain.Controls.Add(this.BtLogin);
            this.panMain.Controls.Add(this.groupBox1);
            this.panMain.Controls.Add(this.label3);
            this.panMain.Controls.Add(this.panel1);
            this.panMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panMain.Location = new System.Drawing.Point(0, 0);
            this.panMain.Name = "panMain";
            this.panMain.Size = new System.Drawing.Size(1024, 681);
            this.panMain.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.BtExit);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(594, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(430, 37);
            this.panel2.TabIndex = 9;
            // 
            // BtExit
            // 
            this.BtExit.FlatAppearance.BorderSize = 0;
            this.BtExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtExit.Image = global::Project_pos.Properties.Resources.close;
            this.BtExit.Location = new System.Drawing.Point(392, 0);
            this.BtExit.Name = "BtExit";
            this.BtExit.Size = new System.Drawing.Size(38, 37);
            this.BtExit.TabIndex = 10;
            this.BtExit.UseVisualStyleBackColor = true;
            this.BtExit.Click += new System.EventHandler(this.BtExit_Click);
            // 
            // BtClear
            // 
            this.BtClear.BackColor = System.Drawing.Color.Crimson;
            this.BtClear.BackgroundColor = System.Drawing.Color.Crimson;
            this.BtClear.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BtClear.BorderRadius = 40;
            this.BtClear.BorderSize = 0;
            this.BtClear.FlatAppearance.BorderSize = 0;
            this.BtClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtClear.ForeColor = System.Drawing.Color.White;
            this.BtClear.Location = new System.Drawing.Point(647, 533);
            this.BtClear.Name = "BtClear";
            this.BtClear.Size = new System.Drawing.Size(332, 40);
            this.BtClear.TabIndex = 8;
            this.BtClear.Text = "Clear";
            this.BtClear.TextColor = System.Drawing.Color.White;
            this.BtClear.UseVisualStyleBackColor = false;
            this.BtClear.Click += new System.EventHandler(this.BtClear_Click);
            // 
            // BtLogin
            // 
            this.BtLogin.BackColor = System.Drawing.Color.DodgerBlue;
            this.BtLogin.BackgroundColor = System.Drawing.Color.DodgerBlue;
            this.BtLogin.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BtLogin.BorderRadius = 40;
            this.BtLogin.BorderSize = 0;
            this.BtLogin.FlatAppearance.BorderSize = 0;
            this.BtLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtLogin.ForeColor = System.Drawing.Color.White;
            this.BtLogin.Location = new System.Drawing.Point(647, 477);
            this.BtLogin.Name = "BtLogin";
            this.BtLogin.Size = new System.Drawing.Size(332, 40);
            this.BtLogin.TabIndex = 7;
            this.BtLogin.Text = "Login";
            this.BtLogin.TextColor = System.Drawing.Color.White;
            this.BtLogin.UseVisualStyleBackColor = false;
            this.BtLogin.Click += new System.EventHandler(this.BtLogin_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CbShowPass);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.PicProduct);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.LbId);
            this.groupBox1.Controls.Add(this.TxPassword);
            this.groupBox1.Controls.Add(this.TxUsername);
            this.groupBox1.Location = new System.Drawing.Point(647, 185);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(332, 236);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // CbShowPass
            // 
            this.CbShowPass.AutoSize = true;
            this.CbShowPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbShowPass.Location = new System.Drawing.Point(196, 182);
            this.CbShowPass.Name = "CbShowPass";
            this.CbShowPass.Size = new System.Drawing.Size(110, 24);
            this.CbShowPass.TabIndex = 6;
            this.CbShowPass.Text = "แสดงรหัสผ่าน";
            this.CbShowPass.UseVisualStyleBackColor = true;
            this.CbShowPass.CheckedChanged += new System.EventHandler(this.CbShowPass_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Project_pos.Properties.Resources.padlock__1_;
            this.pictureBox1.Location = new System.Drawing.Point(38, 136);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // PicProduct
            // 
            this.PicProduct.Image = global::Project_pos.Properties.Resources.user__1_;
            this.PicProduct.Location = new System.Drawing.Point(38, 65);
            this.PicProduct.Name = "PicProduct";
            this.PicProduct.Size = new System.Drawing.Size(32, 31);
            this.PicProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicProduct.TabIndex = 4;
            this.PicProduct.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(32, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Password";
            // 
            // LbId
            // 
            this.LbId.AutoSize = true;
            this.LbId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbId.Location = new System.Drawing.Point(28, 40);
            this.LbId.Name = "LbId";
            this.LbId.Size = new System.Drawing.Size(83, 20);
            this.LbId.TabIndex = 2;
            this.LbId.Text = "Username";
            // 
            // TxPassword
            // 
            this.TxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxPassword.Location = new System.Drawing.Point(73, 136);
            this.TxPassword.Name = "TxPassword";
            this.TxPassword.Size = new System.Drawing.Size(229, 29);
            this.TxPassword.TabIndex = 1;
            // 
            // TxUsername
            // 
            this.TxUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxUsername.Location = new System.Drawing.Point(73, 67);
            this.TxUsername.Name = "TxUsername";
            this.TxUsername.Size = new System.Drawing.Size(229, 29);
            this.TxUsername.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label3.Location = new System.Drawing.Point(674, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(283, 108);
            this.label3.TabIndex = 5;
            this.label3.Text = "Login";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.LbLogo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(594, 681);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Project_pos.Properties.Resources.coffee_bag;
            this.pictureBox2.Location = new System.Drawing.Point(184, 439);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(168, 146);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 99.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(144, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(265, 152);
            this.label2.TabIndex = 3;
            this.label2.Text = "OR";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 62.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(162, 352);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 95);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cafe";
            // 
            // LbLogo
            // 
            this.LbLogo.AutoSize = true;
            this.LbLogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 99.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbLogo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LbLogo.Location = new System.Drawing.Point(158, 223);
            this.LbLogo.Name = "LbLogo";
            this.LbLogo.Size = new System.Drawing.Size(244, 152);
            this.LbLogo.TabIndex = 1;
            this.LbLogo.Text = "BE";
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 681);
            this.Controls.Add(this.panMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmLogin";
            this.Text = "FrmLogin";
            this.panMain.ResumeLayout(false);
            this.panMain.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicProduct)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panMain;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LbLogo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TxUsername;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxPassword;
        private CustomButton BtClear;
        private CustomButton BtLogin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LbId;
        private System.Windows.Forms.PictureBox PicProduct;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button BtExit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox CbShowPass;
    }
}