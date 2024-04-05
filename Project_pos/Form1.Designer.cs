namespace Project_pos
{
    partial class FrmMain
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
            this.panContent = new System.Windows.Forms.Panel();
            this.panSlidBar = new System.Windows.Forms.Panel();
            this.panSellListAt = new System.Windows.Forms.Panel();
            this.BtSellList = new System.Windows.Forms.Button();
            this.BtLogout = new System.Windows.Forms.Button();
            this.panSweetAt = new System.Windows.Forms.Panel();
            this.BtSweet = new System.Windows.Forms.Button();
            this.panProAt = new System.Windows.Forms.Panel();
            this.BtPro = new System.Windows.Forms.Button();
            this.panCatAt = new System.Windows.Forms.Panel();
            this.BtCat = new System.Windows.Forms.Button();
            this.lamanag = new System.Windows.Forms.Label();
            this.lbsell = new System.Windows.Forms.Label();
            this.panEmpAt = new System.Windows.Forms.Panel();
            this.BtEmp = new System.Windows.Forms.Button();
            this.panPrdAt = new System.Windows.Forms.Panel();
            this.panSellAt = new System.Windows.Forms.Panel();
            this.panLogo = new System.Windows.Forms.Panel();
            this.LbLogo = new System.Windows.Forms.Label();
            this.BtPrd = new System.Windows.Forms.Button();
            this.BtSell = new System.Windows.Forms.Button();
            this.LbNameLogin = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panMain.SuspendLayout();
            this.panSlidBar.SuspendLayout();
            this.panLogo.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panMain
            // 
            this.panMain.Controls.Add(this.panContent);
            this.panMain.Controls.Add(this.panSlidBar);
            this.panMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panMain.Location = new System.Drawing.Point(0, 0);
            this.panMain.Name = "panMain";
            this.panMain.Size = new System.Drawing.Size(1264, 681);
            this.panMain.TabIndex = 0;
            // 
            // panContent
            // 
            this.panContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panContent.Location = new System.Drawing.Point(240, 0);
            this.panContent.Name = "panContent";
            this.panContent.Size = new System.Drawing.Size(1024, 681);
            this.panContent.TabIndex = 2;
            // 
            // panSlidBar
            // 
            this.panSlidBar.BackColor = System.Drawing.Color.DodgerBlue;
            this.panSlidBar.Controls.Add(this.panel1);
            this.panSlidBar.Controls.Add(this.panSellListAt);
            this.panSlidBar.Controls.Add(this.BtSellList);
            this.panSlidBar.Controls.Add(this.BtLogout);
            this.panSlidBar.Controls.Add(this.panSweetAt);
            this.panSlidBar.Controls.Add(this.BtSweet);
            this.panSlidBar.Controls.Add(this.panProAt);
            this.panSlidBar.Controls.Add(this.BtPro);
            this.panSlidBar.Controls.Add(this.panCatAt);
            this.panSlidBar.Controls.Add(this.BtCat);
            this.panSlidBar.Controls.Add(this.lamanag);
            this.panSlidBar.Controls.Add(this.lbsell);
            this.panSlidBar.Controls.Add(this.panEmpAt);
            this.panSlidBar.Controls.Add(this.BtEmp);
            this.panSlidBar.Controls.Add(this.panPrdAt);
            this.panSlidBar.Controls.Add(this.panSellAt);
            this.panSlidBar.Controls.Add(this.panLogo);
            this.panSlidBar.Controls.Add(this.BtPrd);
            this.panSlidBar.Controls.Add(this.BtSell);
            this.panSlidBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panSlidBar.Location = new System.Drawing.Point(0, 0);
            this.panSlidBar.Name = "panSlidBar";
            this.panSlidBar.Size = new System.Drawing.Size(240, 681);
            this.panSlidBar.TabIndex = 0;
            // 
            // panSellListAt
            // 
            this.panSellListAt.BackColor = System.Drawing.Color.AliceBlue;
            this.panSellListAt.Location = new System.Drawing.Point(0, 203);
            this.panSellListAt.Name = "panSellListAt";
            this.panSellListAt.Size = new System.Drawing.Size(15, 38);
            this.panSellListAt.TabIndex = 19;
            // 
            // BtSellList
            // 
            this.BtSellList.BackColor = System.Drawing.Color.DodgerBlue;
            this.BtSellList.FlatAppearance.BorderSize = 0;
            this.BtSellList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtSellList.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtSellList.ForeColor = System.Drawing.Color.White;
            this.BtSellList.Image = global::Project_pos.Properties.Resources.mark;
            this.BtSellList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtSellList.Location = new System.Drawing.Point(29, 203);
            this.BtSellList.Name = "BtSellList";
            this.BtSellList.Size = new System.Drawing.Size(210, 38);
            this.BtSellList.TabIndex = 18;
            this.BtSellList.Text = "รายการขาย";
            this.BtSellList.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtSellList.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtSellList.UseVisualStyleBackColor = false;
            this.BtSellList.Click += new System.EventHandler(this.BtSellList_Click);
            // 
            // BtLogout
            // 
            this.BtLogout.BackColor = System.Drawing.Color.Crimson;
            this.BtLogout.FlatAppearance.BorderSize = 0;
            this.BtLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtLogout.ForeColor = System.Drawing.Color.White;
            this.BtLogout.Image = global::Project_pos.Properties.Resources.logout1;
            this.BtLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtLogout.Location = new System.Drawing.Point(0, 639);
            this.BtLogout.Name = "BtLogout";
            this.BtLogout.Size = new System.Drawing.Size(240, 42);
            this.BtLogout.TabIndex = 17;
            this.BtLogout.Text = "ออกจากระบบ";
            this.BtLogout.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtLogout.UseVisualStyleBackColor = false;
            this.BtLogout.Click += new System.EventHandler(this.BtLogout_Click);
            // 
            // panSweetAt
            // 
            this.panSweetAt.BackColor = System.Drawing.Color.AliceBlue;
            this.panSweetAt.Location = new System.Drawing.Point(0, 529);
            this.panSweetAt.Name = "panSweetAt";
            this.panSweetAt.Size = new System.Drawing.Size(15, 38);
            this.panSweetAt.TabIndex = 16;
            // 
            // BtSweet
            // 
            this.BtSweet.BackColor = System.Drawing.Color.DodgerBlue;
            this.BtSweet.FlatAppearance.BorderSize = 0;
            this.BtSweet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtSweet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtSweet.ForeColor = System.Drawing.Color.White;
            this.BtSweet.Image = global::Project_pos.Properties.Resources.sugar;
            this.BtSweet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtSweet.Location = new System.Drawing.Point(29, 529);
            this.BtSweet.Name = "BtSweet";
            this.BtSweet.Size = new System.Drawing.Size(210, 38);
            this.BtSweet.TabIndex = 15;
            this.BtSweet.Text = "ระดับความหวาน";
            this.BtSweet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtSweet.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtSweet.UseVisualStyleBackColor = false;
            this.BtSweet.Click += new System.EventHandler(this.BtSweet_Click);
            // 
            // panProAt
            // 
            this.panProAt.BackColor = System.Drawing.Color.AliceBlue;
            this.panProAt.Location = new System.Drawing.Point(0, 481);
            this.panProAt.Name = "panProAt";
            this.panProAt.Size = new System.Drawing.Size(15, 38);
            this.panProAt.TabIndex = 14;
            // 
            // BtPro
            // 
            this.BtPro.BackColor = System.Drawing.Color.DodgerBlue;
            this.BtPro.FlatAppearance.BorderSize = 0;
            this.BtPro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtPro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtPro.ForeColor = System.Drawing.Color.White;
            this.BtPro.Image = global::Project_pos.Properties.Resources.promotion;
            this.BtPro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtPro.Location = new System.Drawing.Point(29, 481);
            this.BtPro.Name = "BtPro";
            this.BtPro.Size = new System.Drawing.Size(210, 38);
            this.BtPro.TabIndex = 13;
            this.BtPro.Text = "โปรโมชั่น";
            this.BtPro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtPro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtPro.UseVisualStyleBackColor = false;
            this.BtPro.Click += new System.EventHandler(this.BtPro_Click);
            // 
            // panCatAt
            // 
            this.panCatAt.BackColor = System.Drawing.Color.AliceBlue;
            this.panCatAt.Location = new System.Drawing.Point(0, 435);
            this.panCatAt.Name = "panCatAt";
            this.panCatAt.Size = new System.Drawing.Size(15, 38);
            this.panCatAt.TabIndex = 12;
            // 
            // BtCat
            // 
            this.BtCat.BackColor = System.Drawing.Color.DodgerBlue;
            this.BtCat.FlatAppearance.BorderSize = 0;
            this.BtCat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtCat.ForeColor = System.Drawing.Color.White;
            this.BtCat.Image = global::Project_pos.Properties.Resources.options;
            this.BtCat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtCat.Location = new System.Drawing.Point(29, 435);
            this.BtCat.Name = "BtCat";
            this.BtCat.Size = new System.Drawing.Size(210, 38);
            this.BtCat.TabIndex = 11;
            this.BtCat.Text = "หมวดหมู่สินค้า";
            this.BtCat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtCat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtCat.UseVisualStyleBackColor = false;
            this.BtCat.Click += new System.EventHandler(this.BtCat_Click);
            // 
            // lamanag
            // 
            this.lamanag.AutoSize = true;
            this.lamanag.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lamanag.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lamanag.Location = new System.Drawing.Point(-3, 311);
            this.lamanag.Name = "lamanag";
            this.lamanag.Size = new System.Drawing.Size(192, 25);
            this.lamanag.TabIndex = 10;
            this.lamanag.Text = "การจัดการข้อมูลร้านค้า";
            // 
            // lbsell
            // 
            this.lbsell.AutoSize = true;
            this.lbsell.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbsell.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbsell.Location = new System.Drawing.Point(0, 125);
            this.lbsell.Name = "lbsell";
            this.lbsell.Size = new System.Drawing.Size(89, 25);
            this.lbsell.TabIndex = 1;
            this.lbsell.Text = "ขายสินค้า";
            // 
            // panEmpAt
            // 
            this.panEmpAt.BackColor = System.Drawing.Color.AliceBlue;
            this.panEmpAt.Location = new System.Drawing.Point(0, 343);
            this.panEmpAt.Name = "panEmpAt";
            this.panEmpAt.Size = new System.Drawing.Size(15, 38);
            this.panEmpAt.TabIndex = 8;
            // 
            // BtEmp
            // 
            this.BtEmp.BackColor = System.Drawing.Color.DodgerBlue;
            this.BtEmp.FlatAppearance.BorderSize = 0;
            this.BtEmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtEmp.ForeColor = System.Drawing.Color.White;
            this.BtEmp.Image = global::Project_pos.Properties.Resources.manager;
            this.BtEmp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtEmp.Location = new System.Drawing.Point(29, 343);
            this.BtEmp.Name = "BtEmp";
            this.BtEmp.Size = new System.Drawing.Size(210, 38);
            this.BtEmp.TabIndex = 6;
            this.BtEmp.Text = "พนักงาน";
            this.BtEmp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtEmp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtEmp.UseVisualStyleBackColor = false;
            this.BtEmp.Click += new System.EventHandler(this.BtEmp_Click);
            // 
            // panPrdAt
            // 
            this.panPrdAt.BackColor = System.Drawing.Color.AliceBlue;
            this.panPrdAt.Location = new System.Drawing.Point(0, 387);
            this.panPrdAt.Name = "panPrdAt";
            this.panPrdAt.Size = new System.Drawing.Size(15, 38);
            this.panPrdAt.TabIndex = 5;
            // 
            // panSellAt
            // 
            this.panSellAt.BackColor = System.Drawing.Color.AliceBlue;
            this.panSellAt.Location = new System.Drawing.Point(0, 161);
            this.panSellAt.Name = "panSellAt";
            this.panSellAt.Size = new System.Drawing.Size(15, 38);
            this.panSellAt.TabIndex = 4;
            // 
            // panLogo
            // 
            this.panLogo.BackColor = System.Drawing.Color.RoyalBlue;
            this.panLogo.Controls.Add(this.LbLogo);
            this.panLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panLogo.Location = new System.Drawing.Point(0, 0);
            this.panLogo.Name = "panLogo";
            this.panLogo.Size = new System.Drawing.Size(240, 85);
            this.panLogo.TabIndex = 3;
            // 
            // LbLogo
            // 
            this.LbLogo.AutoSize = true;
            this.LbLogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbLogo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LbLogo.Location = new System.Drawing.Point(12, 18);
            this.LbLogo.Name = "LbLogo";
            this.LbLogo.Size = new System.Drawing.Size(213, 42);
            this.LbLogo.TabIndex = 0;
            this.LbLogo.Text = "ORBE Cafe";
            // 
            // BtPrd
            // 
            this.BtPrd.BackColor = System.Drawing.Color.DodgerBlue;
            this.BtPrd.FlatAppearance.BorderSize = 0;
            this.BtPrd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtPrd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtPrd.ForeColor = System.Drawing.Color.White;
            this.BtPrd.Image = global::Project_pos.Properties.Resources.coffee_cup__1_;
            this.BtPrd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtPrd.Location = new System.Drawing.Point(29, 387);
            this.BtPrd.Name = "BtPrd";
            this.BtPrd.Size = new System.Drawing.Size(210, 38);
            this.BtPrd.TabIndex = 2;
            this.BtPrd.Text = "สินค้า";
            this.BtPrd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtPrd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtPrd.UseVisualStyleBackColor = false;
            this.BtPrd.Click += new System.EventHandler(this.BtPrd_Click);
            // 
            // BtSell
            // 
            this.BtSell.BackColor = System.Drawing.Color.DodgerBlue;
            this.BtSell.FlatAppearance.BorderSize = 0;
            this.BtSell.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtSell.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtSell.ForeColor = System.Drawing.Color.White;
            this.BtSell.Image = global::Project_pos.Properties.Resources.personal;
            this.BtSell.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtSell.Location = new System.Drawing.Point(29, 161);
            this.BtSell.Name = "BtSell";
            this.BtSell.Size = new System.Drawing.Size(210, 38);
            this.BtSell.TabIndex = 1;
            this.BtSell.Text = "การขาย";
            this.BtSell.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtSell.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtSell.UseVisualStyleBackColor = false;
            this.BtSell.Click += new System.EventHandler(this.BtSell_Click);
            // 
            // LbNameLogin
            // 
            this.LbNameLogin.AutoSize = true;
            this.LbNameLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbNameLogin.ForeColor = System.Drawing.Color.Crimson;
            this.LbNameLogin.Location = new System.Drawing.Point(13, 6);
            this.LbNameLogin.Name = "LbNameLogin";
            this.LbNameLogin.Size = new System.Drawing.Size(0, 20);
            this.LbNameLogin.TabIndex = 20;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.AliceBlue;
            this.panel1.Controls.Add(this.LbNameLogin);
            this.panel1.Location = new System.Drawing.Point(-1, 84);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(241, 38);
            this.panel1.TabIndex = 21;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.panMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmMain";
            this.Text = "ORBE Cafe";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMain_FormClosed);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.panMain.ResumeLayout(false);
            this.panSlidBar.ResumeLayout(false);
            this.panSlidBar.PerformLayout();
            this.panLogo.ResumeLayout(false);
            this.panLogo.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panMain;
        private System.Windows.Forms.Panel panSlidBar;
        private System.Windows.Forms.Panel panContent;
        private System.Windows.Forms.Label LbLogo;
        private System.Windows.Forms.Button BtSell;
        private System.Windows.Forms.Panel panLogo;
        private System.Windows.Forms.Panel panSellAt;
        private System.Windows.Forms.Label lamanag;
        private System.Windows.Forms.Label lbsell;
        private System.Windows.Forms.Panel panEmpAt;
        private System.Windows.Forms.Button BtEmp;
        private System.Windows.Forms.Panel panPrdAt;
        private System.Windows.Forms.Button BtPrd;
        private System.Windows.Forms.Panel panCatAt;
        private System.Windows.Forms.Button BtCat;
        private System.Windows.Forms.Panel panProAt;
        private System.Windows.Forms.Button BtPro;
        private System.Windows.Forms.Panel panSweetAt;
        private System.Windows.Forms.Button BtSweet;
        private System.Windows.Forms.Button BtLogout;
        private System.Windows.Forms.Panel panSellListAt;
        private System.Windows.Forms.Button BtSellList;
        private System.Windows.Forms.Label LbNameLogin;
        private System.Windows.Forms.Panel panel1;
    }
}

