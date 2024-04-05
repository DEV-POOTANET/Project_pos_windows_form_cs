namespace Project_pos
{
    partial class FrmPro
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
            this.DgvPro = new System.Windows.Forms.DataGridView();
            this.panProcess = new System.Windows.Forms.Panel();
            this.BtCancel = new Project_pos.CustomButton();
            this.BtSave = new Project_pos.CustomButton();
            this.BtDel = new Project_pos.CustomButton();
            this.BtEdit = new Project_pos.CustomButton();
            this.BtAdd = new Project_pos.CustomButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DtEnd = new System.Windows.Forms.DateTimePicker();
            this.DtStart = new System.Windows.Forms.DateTimePicker();
            this.Txba = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TxDetail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxDis = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxId = new System.Windows.Forms.TextBox();
            this.LbId = new System.Windows.Forms.Label();
            this.LbTopic = new System.Windows.Forms.Label();
            this.panMain.SuspendLayout();
            this.panData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPro)).BeginInit();
            this.panProcess.SuspendLayout();
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
            this.panData.Controls.Add(this.DgvPro);
            this.panData.Dock = System.Windows.Forms.DockStyle.Right;
            this.panData.Location = new System.Drawing.Point(445, 0);
            this.panData.Name = "panData";
            this.panData.Size = new System.Drawing.Size(579, 681);
            this.panData.TabIndex = 3;
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
            this.Lbdataproduct.Size = new System.Drawing.Size(128, 24);
            this.Lbdataproduct.TabIndex = 24;
            this.Lbdataproduct.Text = "ข้อมูลโปรโมชั่น";
            // 
            // DgvPro
            // 
            this.DgvPro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvPro.Location = new System.Drawing.Point(23, 58);
            this.DgvPro.Name = "DgvPro";
            this.DgvPro.Size = new System.Drawing.Size(536, 607);
            this.DgvPro.TabIndex = 23;
            this.DgvPro.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvPro_CellClick);
            // 
            // panProcess
            // 
            this.panProcess.Controls.Add(this.BtCancel);
            this.panProcess.Controls.Add(this.BtSave);
            this.panProcess.Controls.Add(this.BtDel);
            this.panProcess.Controls.Add(this.BtEdit);
            this.panProcess.Controls.Add(this.BtAdd);
            this.panProcess.Controls.Add(this.label4);
            this.panProcess.Controls.Add(this.label3);
            this.panProcess.Controls.Add(this.DtEnd);
            this.panProcess.Controls.Add(this.DtStart);
            this.panProcess.Controls.Add(this.Txba);
            this.panProcess.Controls.Add(this.panel1);
            this.panProcess.Controls.Add(this.TxDetail);
            this.panProcess.Controls.Add(this.label2);
            this.panProcess.Controls.Add(this.TxDis);
            this.panProcess.Controls.Add(this.label1);
            this.panProcess.Controls.Add(this.TxId);
            this.panProcess.Controls.Add(this.LbId);
            this.panProcess.Controls.Add(this.LbTopic);
            this.panProcess.Dock = System.Windows.Forms.DockStyle.Left;
            this.panProcess.Location = new System.Drawing.Point(0, 0);
            this.panProcess.Name = "panProcess";
            this.panProcess.Size = new System.Drawing.Size(445, 681);
            this.panProcess.TabIndex = 2;
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 282);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 20);
            this.label4.TabIndex = 30;
            this.label4.Text = "วันหมดส่วนลด";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 29;
            this.label3.Text = "วันเริ่มส่วนลด";
            // 
            // DtEnd
            // 
            this.DtEnd.CustomFormat = "yyyy-MM-dd";
            this.DtEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtEnd.Location = new System.Drawing.Point(144, 279);
            this.DtEnd.Name = "DtEnd";
            this.DtEnd.Size = new System.Drawing.Size(281, 26);
            this.DtEnd.TabIndex = 28;
            // 
            // DtStart
            // 
            this.DtStart.Checked = false;
            this.DtStart.CustomFormat = "yyyy-MM-dd";
            this.DtStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtStart.Location = new System.Drawing.Point(147, 231);
            this.DtStart.Name = "DtStart";
            this.DtStart.Size = new System.Drawing.Size(281, 26);
            this.DtStart.TabIndex = 27;
            // 
            // Txba
            // 
            this.Txba.Enabled = false;
            this.Txba.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txba.Location = new System.Drawing.Point(335, 106);
            this.Txba.Name = "Txba";
            this.Txba.Size = new System.Drawing.Size(93, 26);
            this.Txba.TabIndex = 26;
            this.Txba.Text = "       บาท";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Location = new System.Drawing.Point(235, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(194, 10);
            this.panel1.TabIndex = 25;
            // 
            // TxDetail
            // 
            this.TxDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxDetail.Location = new System.Drawing.Point(147, 154);
            this.TxDetail.Multiline = true;
            this.TxDetail.Name = "TxDetail";
            this.TxDetail.Size = new System.Drawing.Size(281, 55);
            this.TxDetail.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 20);
            this.label2.TabIndex = 23;
            this.label2.Text = "รายละเอียดส่วนลด";
            // 
            // TxDis
            // 
            this.TxDis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxDis.Location = new System.Drawing.Point(147, 106);
            this.TxDis.Name = "TxDis";
            this.TxDis.Size = new System.Drawing.Size(179, 26);
            this.TxDis.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "ส่วนลด";
            // 
            // TxId
            // 
            this.TxId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxId.Location = new System.Drawing.Point(147, 55);
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
            this.LbId.Size = new System.Drawing.Size(91, 20);
            this.LbId.TabIndex = 19;
            this.LbId.Text = "รหัสโปรโมชั่น";
            // 
            // LbTopic
            // 
            this.LbTopic.AutoSize = true;
            this.LbTopic.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbTopic.Image = global::Project_pos.Properties.Resources.promotion;
            this.LbTopic.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LbTopic.Location = new System.Drawing.Point(26, 12);
            this.LbTopic.Name = "LbTopic";
            this.LbTopic.Size = new System.Drawing.Size(209, 24);
            this.LbTopic.TabIndex = 18;
            this.LbTopic.Text = "      รายละเอียดโปรโมชั่น";
            this.LbTopic.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FrmPro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 681);
            this.Controls.Add(this.panMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPro";
            this.Text = "FrmPro";
            this.Load += new System.EventHandler(this.FrmPro_Load);
            this.panMain.ResumeLayout(false);
            this.panData.ResumeLayout(false);
            this.panData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPro)).EndInit();
            this.panProcess.ResumeLayout(false);
            this.panProcess.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panMain;
        private System.Windows.Forms.Panel panData;
        private System.Windows.Forms.Panel panProcess;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TxDetail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxDis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxId;
        private System.Windows.Forms.Label LbId;
        private System.Windows.Forms.Label LbTopic;
        private System.Windows.Forms.DateTimePicker DtStart;
        private System.Windows.Forms.TextBox Txba;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker DtEnd;
        private CustomButton BtCancel;
        private CustomButton BtSave;
        private CustomButton BtDel;
        private CustomButton BtEdit;
        private CustomButton BtAdd;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label Lbdataproduct;
        private System.Windows.Forms.DataGridView DgvPro;
    }
}