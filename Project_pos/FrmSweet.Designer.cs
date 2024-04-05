namespace Project_pos
{
    partial class FrmSweet
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvSweet = new System.Windows.Forms.DataGridView();
            this.panProcess = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxName = new System.Windows.Forms.TextBox();
            this.TxID = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbtopic = new System.Windows.Forms.Label();
            this.BtCancel = new Project_pos.CustomButton();
            this.BtSave = new Project_pos.CustomButton();
            this.BtDel = new Project_pos.CustomButton();
            this.BtEdit = new Project_pos.CustomButton();
            this.BtAdd = new Project_pos.CustomButton();
            this.panMain.SuspendLayout();
            this.panData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSweet)).BeginInit();
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
            this.panData.Controls.Add(this.panel1);
            this.panData.Controls.Add(this.label3);
            this.panData.Controls.Add(this.dgvSweet);
            this.panData.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panData.Location = new System.Drawing.Point(0, 225);
            this.panData.Name = "panData";
            this.panData.Size = new System.Drawing.Size(1024, 456);
            this.panData.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Location = new System.Drawing.Point(200, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(801, 10);
            this.panel1.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "ข้อมูลระดับความหวาน";
            // 
            // dgvSweet
            // 
            this.dgvSweet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSweet.Location = new System.Drawing.Point(22, 55);
            this.dgvSweet.Name = "dgvSweet";
            this.dgvSweet.Size = new System.Drawing.Size(979, 377);
            this.dgvSweet.TabIndex = 0;
            this.dgvSweet.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSweet_CellClick);
            // 
            // panProcess
            // 
            this.panProcess.Controls.Add(this.BtCancel);
            this.panProcess.Controls.Add(this.BtSave);
            this.panProcess.Controls.Add(this.BtDel);
            this.panProcess.Controls.Add(this.BtEdit);
            this.panProcess.Controls.Add(this.BtAdd);
            this.panProcess.Controls.Add(this.label2);
            this.panProcess.Controls.Add(this.label1);
            this.panProcess.Controls.Add(this.TxName);
            this.panProcess.Controls.Add(this.TxID);
            this.panProcess.Controls.Add(this.panel3);
            this.panProcess.Controls.Add(this.lbtopic);
            this.panProcess.Dock = System.Windows.Forms.DockStyle.Top;
            this.panProcess.Location = new System.Drawing.Point(0, 0);
            this.panProcess.Name = "panProcess";
            this.panProcess.Size = new System.Drawing.Size(1024, 225);
            this.panProcess.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(90, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 20);
            this.label2.TabIndex = 27;
            this.label2.Text = "รหัสระดับความหวาน";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(90, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 26;
            this.label1.Text = "ระดับความหวาน";
            // 
            // TxName
            // 
            this.TxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxName.Location = new System.Drawing.Point(226, 153);
            this.TxName.Name = "TxName";
            this.TxName.Size = new System.Drawing.Size(268, 26);
            this.TxName.TabIndex = 25;
            // 
            // TxID
            // 
            this.TxID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxID.Location = new System.Drawing.Point(226, 97);
            this.TxID.Name = "TxID";
            this.TxID.Size = new System.Drawing.Size(268, 26);
            this.TxID.TabIndex = 24;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel3.Location = new System.Drawing.Point(182, 32);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(819, 10);
            this.panel3.TabIndex = 23;
            // 
            // lbtopic
            // 
            this.lbtopic.AutoSize = true;
            this.lbtopic.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtopic.Image = global::Project_pos.Properties.Resources.sugar;
            this.lbtopic.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbtopic.Location = new System.Drawing.Point(17, 24);
            this.lbtopic.Name = "lbtopic";
            this.lbtopic.Size = new System.Drawing.Size(167, 25);
            this.lbtopic.TabIndex = 1;
            this.lbtopic.Text = "    ระดับความหวาน";
            this.lbtopic.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.BtCancel.Location = new System.Drawing.Point(869, 89);
            this.BtCancel.Name = "BtCancel";
            this.BtCancel.Size = new System.Drawing.Size(72, 90);
            this.BtCancel.TabIndex = 32;
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
            this.BtSave.Location = new System.Drawing.Point(782, 89);
            this.BtSave.Name = "BtSave";
            this.BtSave.Size = new System.Drawing.Size(72, 90);
            this.BtSave.TabIndex = 31;
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
            this.BtDel.Location = new System.Drawing.Point(695, 89);
            this.BtDel.Name = "BtDel";
            this.BtDel.Size = new System.Drawing.Size(72, 90);
            this.BtDel.TabIndex = 30;
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
            this.BtEdit.Location = new System.Drawing.Point(608, 89);
            this.BtEdit.Name = "BtEdit";
            this.BtEdit.Size = new System.Drawing.Size(72, 90);
            this.BtEdit.TabIndex = 29;
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
            this.BtAdd.Location = new System.Drawing.Point(521, 89);
            this.BtAdd.Name = "BtAdd";
            this.BtAdd.Size = new System.Drawing.Size(72, 90);
            this.BtAdd.TabIndex = 28;
            this.BtAdd.Text = "เพิ่ม";
            this.BtAdd.TextColor = System.Drawing.Color.White;
            this.BtAdd.UseVisualStyleBackColor = false;
            this.BtAdd.Click += new System.EventHandler(this.BtAdd_Click);
            // 
            // FrmSweet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 681);
            this.Controls.Add(this.panMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmSweet";
            this.Text = "FrmSweet";
            this.Load += new System.EventHandler(this.FrmSweet_Load);
            this.panMain.ResumeLayout(false);
            this.panData.ResumeLayout(false);
            this.panData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSweet)).EndInit();
            this.panProcess.ResumeLayout(false);
            this.panProcess.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panMain;
        private System.Windows.Forms.Panel panProcess;
        private CustomButton BtCancel;
        private CustomButton BtSave;
        private CustomButton BtDel;
        private CustomButton BtEdit;
        private CustomButton BtAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxName;
        private System.Windows.Forms.TextBox TxID;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbtopic;
        private System.Windows.Forms.Panel panData;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvSweet;
    }
}