namespace Project_pos
{
    partial class FrmEmp
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
            this.panData = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Lbdataproduct = new System.Windows.Forms.Label();
            this.DgvEmp = new System.Windows.Forms.DataGridView();
            this.panProcess = new System.Windows.Forms.Panel();
            this.GbStatus = new System.Windows.Forms.GroupBox();
            this.RaEmp = new System.Windows.Forms.RadioButton();
            this.RaMa = new System.Windows.Forms.RadioButton();
            this.TxPass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxUname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxLname = new System.Windows.Forms.TextBox();
            this.BtCancel = new Project_pos.CustomButton();
            this.BtSave = new Project_pos.CustomButton();
            this.BtDel = new Project_pos.CustomButton();
            this.BtEdit = new Project_pos.CustomButton();
            this.BtAdd = new Project_pos.CustomButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.TxFname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxId = new System.Windows.Forms.TextBox();
            this.LbId = new System.Windows.Forms.Label();
            this.LbTopic = new System.Windows.Forms.Label();
            this.panMain.SuspendLayout();
            this.panData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvEmp)).BeginInit();
            this.panProcess.SuspendLayout();
            this.GbStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // panMain
            // 
            this.panMain.Controls.Add(this.panData);
            this.panMain.Controls.Add(this.panProcess);
            this.panMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panMain.Location = new System.Drawing.Point(0, 0);
            this.panMain.Name = "panMain";
            this.panMain.Size = new System.Drawing.Size(1024, 681);
            this.panMain.TabIndex = 0;
            // 
            // panData
            // 
            this.panData.Controls.Add(this.panel2);
            this.panData.Controls.Add(this.Lbdataproduct);
            this.panData.Controls.Add(this.DgvEmp);
            this.panData.Dock = System.Windows.Forms.DockStyle.Right;
            this.panData.Location = new System.Drawing.Point(445, 0);
            this.panData.Name = "panData";
            this.panData.Size = new System.Drawing.Size(579, 681);
            this.panData.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel2.Location = new System.Drawing.Point(148, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(409, 10);
            this.panel2.TabIndex = 29;
            // 
            // Lbdataproduct
            // 
            this.Lbdataproduct.AutoSize = true;
            this.Lbdataproduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbdataproduct.Location = new System.Drawing.Point(19, 15);
            this.Lbdataproduct.Name = "Lbdataproduct";
            this.Lbdataproduct.Size = new System.Drawing.Size(122, 24);
            this.Lbdataproduct.TabIndex = 24;
            this.Lbdataproduct.Text = "ข้อมูลพนักงาน";
            // 
            // DgvEmp
            // 
            this.DgvEmp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvEmp.Location = new System.Drawing.Point(23, 58);
            this.DgvEmp.Name = "DgvEmp";
            this.DgvEmp.Size = new System.Drawing.Size(536, 607);
            this.DgvEmp.TabIndex = 23;
            this.DgvEmp.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvEmp_CellClick);
            // 
            // panProcess
            // 
            this.panProcess.Controls.Add(this.GbStatus);
            this.panProcess.Controls.Add(this.TxPass);
            this.panProcess.Controls.Add(this.label3);
            this.panProcess.Controls.Add(this.TxUname);
            this.panProcess.Controls.Add(this.label4);
            this.panProcess.Controls.Add(this.TxLname);
            this.panProcess.Controls.Add(this.BtCancel);
            this.panProcess.Controls.Add(this.BtSave);
            this.panProcess.Controls.Add(this.BtDel);
            this.panProcess.Controls.Add(this.BtEdit);
            this.panProcess.Controls.Add(this.BtAdd);
            this.panProcess.Controls.Add(this.panel1);
            this.panProcess.Controls.Add(this.label2);
            this.panProcess.Controls.Add(this.TxFname);
            this.panProcess.Controls.Add(this.label1);
            this.panProcess.Controls.Add(this.TxId);
            this.panProcess.Controls.Add(this.LbId);
            this.panProcess.Controls.Add(this.LbTopic);
            this.panProcess.Dock = System.Windows.Forms.DockStyle.Left;
            this.panProcess.Location = new System.Drawing.Point(0, 0);
            this.panProcess.Name = "panProcess";
            this.panProcess.Size = new System.Drawing.Size(445, 681);
            this.panProcess.TabIndex = 4;
            // 
            // GbStatus
            // 
            this.GbStatus.Controls.Add(this.RaEmp);
            this.GbStatus.Controls.Add(this.RaMa);
            this.GbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbStatus.Location = new System.Drawing.Point(28, 312);
            this.GbStatus.Name = "GbStatus";
            this.GbStatus.Size = new System.Drawing.Size(389, 56);
            this.GbStatus.TabIndex = 41;
            this.GbStatus.TabStop = false;
            this.GbStatus.Text = "สิทธิ์การใช้งาน";
            // 
            // RaEmp
            // 
            this.RaEmp.AutoSize = true;
            this.RaEmp.Location = new System.Drawing.Point(203, 21);
            this.RaEmp.Name = "RaEmp";
            this.RaEmp.Size = new System.Drawing.Size(102, 24);
            this.RaEmp.TabIndex = 1;
            this.RaEmp.TabStop = true;
            this.RaEmp.Text = "พนักงานขาย";
            this.RaEmp.UseVisualStyleBackColor = true;
            // 
            // RaMa
            // 
            this.RaMa.AutoSize = true;
            this.RaMa.Location = new System.Drawing.Point(84, 21);
            this.RaMa.Name = "RaMa";
            this.RaMa.Size = new System.Drawing.Size(76, 24);
            this.RaMa.TabIndex = 0;
            this.RaMa.TabStop = true;
            this.RaMa.Text = "ผู้จัดการ";
            this.RaMa.UseVisualStyleBackColor = true;
            // 
            // TxPass
            // 
            this.TxPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxPass.Location = new System.Drawing.Point(143, 261);
            this.TxPass.Name = "TxPass";
            this.TxPass.Size = new System.Drawing.Size(282, 26);
            this.TxPass.TabIndex = 40;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 261);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 20);
            this.label3.TabIndex = 39;
            this.label3.Text = "รหัสผ่าน";
            // 
            // TxUname
            // 
            this.TxUname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxUname.Location = new System.Drawing.Point(143, 210);
            this.TxUname.Name = "TxUname";
            this.TxUname.Size = new System.Drawing.Size(282, 26);
            this.TxUname.TabIndex = 38;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 37;
            this.label4.Text = "ชื่อผู้ใช้";
            // 
            // TxLname
            // 
            this.TxLname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxLname.Location = new System.Drawing.Point(143, 157);
            this.TxLname.Name = "TxLname";
            this.TxLname.Size = new System.Drawing.Size(282, 26);
            this.TxLname.TabIndex = 36;
            // 
            // BtCancel
            // 
            this.BtCancel.BackColor = System.Drawing.Color.Crimson;
            this.BtCancel.BackgroundColor = System.Drawing.Color.Crimson;
            this.BtCancel.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BtCancel.BorderRadius = 21;
            this.BtCancel.BorderSize = 0;
            this.BtCancel.FlatAppearance.BorderSize = 0;
            this.BtCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtCancel.ForeColor = System.Drawing.Color.White;
            this.BtCancel.Location = new System.Drawing.Point(26, 607);
            this.BtCancel.Name = "BtCancel";
            this.BtCancel.Size = new System.Drawing.Size(399, 43);
            this.BtCancel.TabIndex = 35;
            this.BtCancel.Text = "ยกเลิก";
            this.BtCancel.TextColor = System.Drawing.Color.White;
            this.BtCancel.UseVisualStyleBackColor = false;
            this.BtCancel.Click += new System.EventHandler(this.BtCancel_Click);
            // 
            // BtSave
            // 
            this.BtSave.BackColor = System.Drawing.Color.RoyalBlue;
            this.BtSave.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.BtSave.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BtSave.BorderRadius = 21;
            this.BtSave.BorderSize = 0;
            this.BtSave.FlatAppearance.BorderSize = 0;
            this.BtSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtSave.ForeColor = System.Drawing.Color.White;
            this.BtSave.Location = new System.Drawing.Point(234, 538);
            this.BtSave.Name = "BtSave";
            this.BtSave.Size = new System.Drawing.Size(194, 43);
            this.BtSave.TabIndex = 34;
            this.BtSave.Text = "บันทึก";
            this.BtSave.TextColor = System.Drawing.Color.White;
            this.BtSave.UseVisualStyleBackColor = false;
            this.BtSave.Click += new System.EventHandler(this.BtSave_Click);
            // 
            // BtDel
            // 
            this.BtDel.BackColor = System.Drawing.Color.Crimson;
            this.BtDel.BackgroundColor = System.Drawing.Color.Crimson;
            this.BtDel.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BtDel.BorderRadius = 21;
            this.BtDel.BorderSize = 0;
            this.BtDel.FlatAppearance.BorderSize = 0;
            this.BtDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtDel.ForeColor = System.Drawing.Color.White;
            this.BtDel.Location = new System.Drawing.Point(26, 538);
            this.BtDel.Name = "BtDel";
            this.BtDel.Size = new System.Drawing.Size(194, 43);
            this.BtDel.TabIndex = 33;
            this.BtDel.Text = "ลบ";
            this.BtDel.TextColor = System.Drawing.Color.White;
            this.BtDel.UseVisualStyleBackColor = false;
            this.BtDel.Click += new System.EventHandler(this.BtDel_Click);
            // 
            // BtEdit
            // 
            this.BtEdit.BackColor = System.Drawing.Color.Gold;
            this.BtEdit.BackgroundColor = System.Drawing.Color.Gold;
            this.BtEdit.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BtEdit.BorderRadius = 21;
            this.BtEdit.BorderSize = 0;
            this.BtEdit.FlatAppearance.BorderSize = 0;
            this.BtEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtEdit.ForeColor = System.Drawing.Color.White;
            this.BtEdit.Location = new System.Drawing.Point(234, 476);
            this.BtEdit.Name = "BtEdit";
            this.BtEdit.Size = new System.Drawing.Size(194, 43);
            this.BtEdit.TabIndex = 32;
            this.BtEdit.Text = "แก้ไข";
            this.BtEdit.TextColor = System.Drawing.Color.White;
            this.BtEdit.UseVisualStyleBackColor = false;
            this.BtEdit.Click += new System.EventHandler(this.BtEdit_Click);
            // 
            // BtAdd
            // 
            this.BtAdd.BackColor = System.Drawing.Color.RoyalBlue;
            this.BtAdd.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.BtAdd.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BtAdd.BorderRadius = 21;
            this.BtAdd.BorderSize = 0;
            this.BtAdd.FlatAppearance.BorderSize = 0;
            this.BtAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtAdd.ForeColor = System.Drawing.Color.White;
            this.BtAdd.Location = new System.Drawing.Point(26, 476);
            this.BtAdd.Name = "BtAdd";
            this.BtAdd.Size = new System.Drawing.Size(194, 43);
            this.BtAdd.TabIndex = 31;
            this.BtAdd.Text = "เพิ่ม";
            this.BtAdd.TextColor = System.Drawing.Color.White;
            this.BtAdd.UseVisualStyleBackColor = false;
            this.BtAdd.Click += new System.EventHandler(this.BtAdd_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Location = new System.Drawing.Point(235, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(194, 10);
            this.panel1.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 20);
            this.label2.TabIndex = 23;
            this.label2.Text = "สกุลพนักงาน";
            // 
            // TxFname
            // 
            this.TxFname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxFname.Location = new System.Drawing.Point(143, 109);
            this.TxFname.Name = "TxFname";
            this.TxFname.Size = new System.Drawing.Size(282, 26);
            this.TxFname.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "ชื่อพนักงาน";
            // 
            // TxId
            // 
            this.TxId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxId.Location = new System.Drawing.Point(143, 55);
            this.TxId.Name = "TxId";
            this.TxId.Size = new System.Drawing.Size(281, 26);
            this.TxId.TabIndex = 20;
            // 
            // LbId
            // 
            this.LbId.AutoSize = true;
            this.LbId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbId.Location = new System.Drawing.Point(22, 58);
            this.LbId.Name = "LbId";
            this.LbId.Size = new System.Drawing.Size(84, 20);
            this.LbId.TabIndex = 19;
            this.LbId.Text = "รหัสพนักงาน";
            // 
            // LbTopic
            // 
            this.LbTopic.AutoSize = true;
            this.LbTopic.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbTopic.Image = global::Project_pos.Properties.Resources.manager;
            this.LbTopic.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LbTopic.Location = new System.Drawing.Point(26, 12);
            this.LbTopic.Name = "LbTopic";
            this.LbTopic.Size = new System.Drawing.Size(203, 24);
            this.LbTopic.TabIndex = 18;
            this.LbTopic.Text = "      รายละเอียดพนักงาน";
            this.LbTopic.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FrmEmp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 681);
            this.Controls.Add(this.panMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmEmp";
            this.Text = "FrmEmp";
            this.Load += new System.EventHandler(this.FrmEmp_Load);
            this.panMain.ResumeLayout(false);
            this.panData.ResumeLayout(false);
            this.panData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvEmp)).EndInit();
            this.panProcess.ResumeLayout(false);
            this.panProcess.PerformLayout();
            this.GbStatus.ResumeLayout(false);
            this.GbStatus.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panMain;
        private System.Windows.Forms.Panel panData;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label Lbdataproduct;
        private System.Windows.Forms.DataGridView DgvEmp;
        private System.Windows.Forms.Panel panProcess;
        private CustomButton BtCancel;
        private CustomButton BtSave;
        private CustomButton BtDel;
        private CustomButton BtEdit;
        private CustomButton BtAdd;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxFname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxId;
        private System.Windows.Forms.Label LbId;
        private System.Windows.Forms.Label LbTopic;
        private System.Windows.Forms.TextBox TxLname;
        private System.Windows.Forms.TextBox TxPass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxUname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox GbStatus;
        private System.Windows.Forms.RadioButton RaEmp;
        private System.Windows.Forms.RadioButton RaMa;
    }
}