namespace Project_pos
{
    partial class FrmSellList
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
            this.panListDtl = new System.Windows.Forms.Panel();
            this.Emp_detail = new System.Windows.Forms.Label();
            this.Pro_detail = new System.Windows.Forms.Label();
            this.Order_detail_data = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Lbnet = new System.Windows.Forms.Label();
            this.LbTotalPrice = new System.Windows.Forms.Label();
            this.Lbdis = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvDtl = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Lbtopic = new System.Windows.Forms.Label();
            this.panList = new System.Windows.Forms.Panel();
            this.panMount = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.raAll = new System.Windows.Forms.RadioButton();
            this.ramo2 = new System.Windows.Forms.RadioButton();
            this.ramo = new System.Windows.Forms.RadioButton();
            this.raday = new System.Windows.Forms.RadioButton();
            this.customButton1 = new Project_pos.CustomButton();
            this.DgvOrder = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panMain.SuspendLayout();
            this.panListDtl.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDtl)).BeginInit();
            this.panList.SuspendLayout();
            this.panMount.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // panMain
            // 
            this.panMain.Controls.Add(this.panListDtl);
            this.panMain.Controls.Add(this.panList);
            this.panMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panMain.Location = new System.Drawing.Point(0, 0);
            this.panMain.Name = "panMain";
            this.panMain.Size = new System.Drawing.Size(1024, 681);
            this.panMain.TabIndex = 0;
            // 
            // panListDtl
            // 
            this.panListDtl.Controls.Add(this.Emp_detail);
            this.panListDtl.Controls.Add(this.Pro_detail);
            this.panListDtl.Controls.Add(this.Order_detail_data);
            this.panListDtl.Controls.Add(this.panel3);
            this.panListDtl.Controls.Add(this.label4);
            this.panListDtl.Controls.Add(this.label3);
            this.panListDtl.Controls.Add(this.label2);
            this.panListDtl.Controls.Add(this.dgvDtl);
            this.panListDtl.Controls.Add(this.panel2);
            this.panListDtl.Controls.Add(this.Lbtopic);
            this.panListDtl.Location = new System.Drawing.Point(548, 0);
            this.panListDtl.Name = "panListDtl";
            this.panListDtl.Size = new System.Drawing.Size(476, 681);
            this.panListDtl.TabIndex = 3;
            // 
            // Emp_detail
            // 
            this.Emp_detail.AutoSize = true;
            this.Emp_detail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Emp_detail.Location = new System.Drawing.Point(140, 86);
            this.Emp_detail.Name = "Emp_detail";
            this.Emp_detail.Size = new System.Drawing.Size(68, 18);
            this.Emp_detail.TabIndex = 31;
            this.Emp_detail.Text = "Pootanet";
            // 
            // Pro_detail
            // 
            this.Pro_detail.AutoSize = true;
            this.Pro_detail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pro_detail.Location = new System.Drawing.Point(140, 111);
            this.Pro_detail.Name = "Pro_detail";
            this.Pro_detail.Size = new System.Drawing.Size(42, 18);
            this.Pro_detail.TabIndex = 30;
            this.Pro_detail.Text = "P021";
            // 
            // Order_detail_data
            // 
            this.Order_detail_data.AutoSize = true;
            this.Order_detail_data.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Order_detail_data.Location = new System.Drawing.Point(140, 61);
            this.Order_detail_data.Name = "Order_detail_data";
            this.Order_detail_data.Size = new System.Drawing.Size(41, 18);
            this.Order_detail_data.TabIndex = 29;
            this.Order_detail_data.Text = "A001";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Crimson;
            this.panel3.Controls.Add(this.Lbnet);
            this.panel3.Controls.Add(this.LbTotalPrice);
            this.panel3.Controls.Add(this.Lbdis);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Location = new System.Drawing.Point(11, 585);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(447, 84);
            this.panel3.TabIndex = 28;
            // 
            // Lbnet
            // 
            this.Lbnet.AutoSize = true;
            this.Lbnet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbnet.ForeColor = System.Drawing.Color.White;
            this.Lbnet.Location = new System.Drawing.Point(365, 57);
            this.Lbnet.Name = "Lbnet";
            this.Lbnet.Size = new System.Drawing.Size(49, 24);
            this.Lbnet.TabIndex = 33;
            this.Lbnet.Text = "0.00";
            // 
            // LbTotalPrice
            // 
            this.LbTotalPrice.AutoSize = true;
            this.LbTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbTotalPrice.ForeColor = System.Drawing.Color.White;
            this.LbTotalPrice.Location = new System.Drawing.Point(365, 4);
            this.LbTotalPrice.Name = "LbTotalPrice";
            this.LbTotalPrice.Size = new System.Drawing.Size(49, 24);
            this.LbTotalPrice.TabIndex = 32;
            this.LbTotalPrice.Text = "0.00";
            // 
            // Lbdis
            // 
            this.Lbdis.AutoSize = true;
            this.Lbdis.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbdis.ForeColor = System.Drawing.Color.White;
            this.Lbdis.Location = new System.Drawing.Point(365, 28);
            this.Lbdis.Name = "Lbdis";
            this.Lbdis.Size = new System.Drawing.Size(49, 24);
            this.Lbdis.TabIndex = 31;
            this.Lbdis.Text = "0.00";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(258, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 24);
            this.label7.TabIndex = 30;
            this.label7.Text = " ราคาสุทธิ :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(262, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 24);
            this.label5.TabIndex = 29;
            this.label5.Text = " ราคารวม :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(282, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 24);
            this.label6.TabIndex = 28;
            this.label6.Text = "ส่วนลด :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(42, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 18);
            this.label4.TabIndex = 27;
            this.label4.Text = "Employee :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 18);
            this.label3.TabIndex = 25;
            this.label3.Text = "Promotion ID :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(52, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 18);
            this.label2.TabIndex = 24;
            this.label2.Text = "Order ID :";
            // 
            // dgvDtl
            // 
            this.dgvDtl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDtl.Location = new System.Drawing.Point(11, 161);
            this.dgvDtl.Name = "dgvDtl";
            this.dgvDtl.Size = new System.Drawing.Size(447, 430);
            this.dgvDtl.TabIndex = 23;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel2.Location = new System.Drawing.Point(198, 19);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(260, 10);
            this.panel2.TabIndex = 22;
            // 
            // Lbtopic
            // 
            this.Lbtopic.AutoSize = true;
            this.Lbtopic.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbtopic.Location = new System.Drawing.Point(7, 13);
            this.Lbtopic.Name = "Lbtopic";
            this.Lbtopic.Size = new System.Drawing.Size(187, 24);
            this.Lbtopic.TabIndex = 17;
            this.Lbtopic.Text = "รายละเอียดรายการขาย";
            // 
            // panList
            // 
            this.panList.Controls.Add(this.panMount);
            this.panList.Controls.Add(this.groupBox1);
            this.panList.Controls.Add(this.customButton1);
            this.panList.Controls.Add(this.DgvOrder);
            this.panList.Controls.Add(this.label1);
            this.panList.Controls.Add(this.panel1);
            this.panList.Location = new System.Drawing.Point(0, 0);
            this.panList.Name = "panList";
            this.panList.Size = new System.Drawing.Size(549, 681);
            this.panList.TabIndex = 2;
            // 
            // panMount
            // 
            this.panMount.Controls.Add(this.label14);
            this.panMount.Controls.Add(this.comboBox1);
            this.panMount.Location = new System.Drawing.Point(239, 57);
            this.panMount.Name = "panMount";
            this.panMount.Size = new System.Drawing.Size(174, 85);
            this.panMount.TabIndex = 22;
            this.panMount.Visible = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(10, 17);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(64, 18);
            this.label14.TabIndex = 32;
            this.label14.Text = "เลือกเดือน";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(13, 47);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(151, 21);
            this.comboBox1.TabIndex = 31;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.raAll);
            this.groupBox1.Controls.Add(this.ramo2);
            this.groupBox1.Controls.Add(this.ramo);
            this.groupBox1.Controls.Add(this.raday);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(20, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(210, 93);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ตัวเลือกการแสดง";
            // 
            // raAll
            // 
            this.raAll.AutoSize = true;
            this.raAll.Checked = true;
            this.raAll.Location = new System.Drawing.Point(15, 27);
            this.raAll.Name = "raAll";
            this.raAll.Size = new System.Drawing.Size(67, 22);
            this.raAll.TabIndex = 3;
            this.raAll.TabStop = true;
            this.raAll.Text = "ทั้งหมด";
            this.raAll.UseVisualStyleBackColor = true;
            // 
            // ramo2
            // 
            this.ramo2.AutoSize = true;
            this.ramo2.Location = new System.Drawing.Point(110, 55);
            this.ramo2.Name = "ramo2";
            this.ramo2.Size = new System.Drawing.Size(82, 22);
            this.ramo2.TabIndex = 2;
            this.ramo2.Text = "เลือกเดือน";
            this.ramo2.UseVisualStyleBackColor = true;
            this.ramo2.CheckedChanged += new System.EventHandler(this.ramo2_CheckedChanged);
            // 
            // ramo
            // 
            this.ramo.AutoSize = true;
            this.ramo.Location = new System.Drawing.Point(15, 55);
            this.ramo.Name = "ramo";
            this.ramo.Size = new System.Drawing.Size(64, 22);
            this.ramo.TabIndex = 1;
            this.ramo.Text = "เดือนนี้";
            this.ramo.UseVisualStyleBackColor = true;
            // 
            // raday
            // 
            this.raday.AutoSize = true;
            this.raday.Location = new System.Drawing.Point(110, 27);
            this.raday.Name = "raday";
            this.raday.Size = new System.Drawing.Size(51, 22);
            this.raday.TabIndex = 0;
            this.raday.Text = "วันนี้";
            this.raday.UseVisualStyleBackColor = true;
            // 
            // customButton1
            // 
            this.customButton1.BackColor = System.Drawing.Color.RoyalBlue;
            this.customButton1.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.customButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.customButton1.BorderRadius = 21;
            this.customButton1.BorderSize = 0;
            this.customButton1.FlatAppearance.BorderSize = 0;
            this.customButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customButton1.ForeColor = System.Drawing.Color.White;
            this.customButton1.Image = global::Project_pos.Properties.Resources.loupe;
            this.customButton1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.customButton1.Location = new System.Drawing.Point(427, 57);
            this.customButton1.Name = "customButton1";
            this.customButton1.Size = new System.Drawing.Size(100, 85);
            this.customButton1.TabIndex = 20;
            this.customButton1.Text = "ค้นหา";
            this.customButton1.TextColor = System.Drawing.Color.White;
            this.customButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.customButton1.UseVisualStyleBackColor = false;
            this.customButton1.Click += new System.EventHandler(this.customButton1_Click);
            // 
            // DgvOrder
            // 
            this.DgvOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvOrder.Location = new System.Drawing.Point(19, 161);
            this.DgvOrder.Name = "DgvOrder";
            this.DgvOrder.Size = new System.Drawing.Size(508, 508);
            this.DgvOrder.TabIndex = 19;
            this.DgvOrder.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvOrder_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 24);
            this.label1.TabIndex = 18;
            this.label1.Text = "รายการขาย";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Location = new System.Drawing.Point(118, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(409, 10);
            this.panel1.TabIndex = 17;
            // 
            // FrmSellList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 681);
            this.Controls.Add(this.panMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmSellList";
            this.Text = "FrmSellList";
            this.panMain.ResumeLayout(false);
            this.panListDtl.ResumeLayout(false);
            this.panListDtl.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDtl)).EndInit();
            this.panList.ResumeLayout(false);
            this.panList.PerformLayout();
            this.panMount.ResumeLayout(false);
            this.panMount.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvOrder)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panMain;
        private System.Windows.Forms.Panel panListDtl;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label Lbtopic;
        private System.Windows.Forms.Panel panList;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDtl;
        private System.Windows.Forms.DataGridView DgvOrder;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label Emp_detail;
        private System.Windows.Forms.Label Pro_detail;
        private System.Windows.Forms.Label Order_detail_data;
        private System.Windows.Forms.Label Lbnet;
        private System.Windows.Forms.Label LbTotalPrice;
        private System.Windows.Forms.Label Lbdis;
        private CustomButton customButton1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton ramo2;
        private System.Windows.Forms.RadioButton ramo;
        private System.Windows.Forms.RadioButton raday;
        private System.Windows.Forms.Panel panMount;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.RadioButton raAll;
    }
}