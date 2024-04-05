namespace Project_pos
{
    partial class FrmPrd
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Lbdataproduct = new System.Windows.Forms.Label();
            this.DgvProduct = new System.Windows.Forms.DataGridView();
            this.panProcess = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtCancel = new Project_pos.CustomButton();
            this.BtSave = new Project_pos.CustomButton();
            this.BtDel = new Project_pos.CustomButton();
            this.BtEdit = new Project_pos.CustomButton();
            this.BtAdd = new Project_pos.CustomButton();
            this.GbImg = new System.Windows.Forms.GroupBox();
            this.BtImport = new Project_pos.CustomButton();
            this.PicProduct = new System.Windows.Forms.PictureBox();
            this.Txba = new System.Windows.Forms.TextBox();
            this.GbStatus = new System.Windows.Forms.GroupBox();
            this.RaClose = new System.Windows.Forms.RadioButton();
            this.RaOpent = new System.Windows.Forms.RadioButton();
            this.TxDtl = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxCat = new System.Windows.Forms.ComboBox();
            this.TxPrice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxId = new System.Windows.Forms.TextBox();
            this.LbId = new System.Windows.Forms.Label();
            this.LbTopic = new System.Windows.Forms.Label();
            this.RaAll = new System.Windows.Forms.RadioButton();
            this.RaCat = new System.Windows.Forms.RadioButton();
            this.RaId = new System.Windows.Forms.RadioButton();
            this.BtFind = new Project_pos.CustomButton();
            this.TxIdFind = new System.Windows.Forms.TextBox();
            this.CbCatFind = new System.Windows.Forms.ComboBox();
            this.panMain.SuspendLayout();
            this.panData.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProduct)).BeginInit();
            this.panProcess.SuspendLayout();
            this.GbImg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicProduct)).BeginInit();
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
            this.panData.Controls.Add(this.TxIdFind);
            this.panData.Controls.Add(this.CbCatFind);
            this.panData.Controls.Add(this.groupBox1);
            this.panData.Controls.Add(this.BtFind);
            this.panData.Controls.Add(this.Lbdataproduct);
            this.panData.Controls.Add(this.DgvProduct);
            this.panData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panData.Location = new System.Drawing.Point(445, 0);
            this.panData.Name = "panData";
            this.panData.Size = new System.Drawing.Size(579, 681);
            this.panData.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel2.Location = new System.Drawing.Point(112, 19);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(443, 10);
            this.panel2.TabIndex = 22;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RaAll);
            this.groupBox1.Controls.Add(this.RaId);
            this.groupBox1.Controls.Add(this.RaCat);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(21, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(283, 71);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ค้นหาด้วย";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Lbdataproduct
            // 
            this.Lbdataproduct.AutoSize = true;
            this.Lbdataproduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbdataproduct.Location = new System.Drawing.Point(17, 10);
            this.Lbdataproduct.Name = "Lbdataproduct";
            this.Lbdataproduct.Size = new System.Drawing.Size(98, 24);
            this.Lbdataproduct.TabIndex = 17;
            this.Lbdataproduct.Text = "ข้อมูลสินค้า";
            // 
            // DgvProduct
            // 
            this.DgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvProduct.Location = new System.Drawing.Point(21, 133);
            this.DgvProduct.Name = "DgvProduct";
            this.DgvProduct.Size = new System.Drawing.Size(536, 527);
            this.DgvProduct.TabIndex = 0;
            this.DgvProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvProduct_CellClick);
            // 
            // panProcess
            // 
            this.panProcess.Controls.Add(this.panel1);
            this.panProcess.Controls.Add(this.BtCancel);
            this.panProcess.Controls.Add(this.BtSave);
            this.panProcess.Controls.Add(this.BtDel);
            this.panProcess.Controls.Add(this.BtEdit);
            this.panProcess.Controls.Add(this.BtAdd);
            this.panProcess.Controls.Add(this.GbImg);
            this.panProcess.Controls.Add(this.Txba);
            this.panProcess.Controls.Add(this.GbStatus);
            this.panProcess.Controls.Add(this.TxDtl);
            this.panProcess.Controls.Add(this.label4);
            this.panProcess.Controls.Add(this.label3);
            this.panProcess.Controls.Add(this.TxCat);
            this.panProcess.Controls.Add(this.TxPrice);
            this.panProcess.Controls.Add(this.label2);
            this.panProcess.Controls.Add(this.TxName);
            this.panProcess.Controls.Add(this.label1);
            this.panProcess.Controls.Add(this.TxId);
            this.panProcess.Controls.Add(this.LbId);
            this.panProcess.Controls.Add(this.LbTopic);
            this.panProcess.Dock = System.Windows.Forms.DockStyle.Left;
            this.panProcess.Location = new System.Drawing.Point(0, 0);
            this.panProcess.Name = "panProcess";
            this.panProcess.Size = new System.Drawing.Size(445, 681);
            this.panProcess.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Location = new System.Drawing.Point(161, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(263, 10);
            this.panel1.TabIndex = 17;
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
            this.BtCancel.Location = new System.Drawing.Point(355, 617);
            this.BtCancel.Name = "BtCancel";
            this.BtCancel.Size = new System.Drawing.Size(72, 43);
            this.BtCancel.TabIndex = 16;
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
            this.BtSave.Location = new System.Drawing.Point(268, 617);
            this.BtSave.Name = "BtSave";
            this.BtSave.Size = new System.Drawing.Size(72, 43);
            this.BtSave.TabIndex = 15;
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
            this.BtDel.Location = new System.Drawing.Point(181, 617);
            this.BtDel.Name = "BtDel";
            this.BtDel.Size = new System.Drawing.Size(72, 43);
            this.BtDel.TabIndex = 14;
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
            this.BtEdit.Location = new System.Drawing.Point(94, 617);
            this.BtEdit.Name = "BtEdit";
            this.BtEdit.Size = new System.Drawing.Size(72, 43);
            this.BtEdit.TabIndex = 13;
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
            this.BtAdd.Location = new System.Drawing.Point(7, 617);
            this.BtAdd.Name = "BtAdd";
            this.BtAdd.Size = new System.Drawing.Size(72, 43);
            this.BtAdd.TabIndex = 2;
            this.BtAdd.Text = "เพิ่ม";
            this.BtAdd.TextColor = System.Drawing.Color.White;
            this.BtAdd.UseVisualStyleBackColor = false;
            this.BtAdd.Click += new System.EventHandler(this.BtAdd_Click);
            // 
            // GbImg
            // 
            this.GbImg.Controls.Add(this.BtImport);
            this.GbImg.Controls.Add(this.PicProduct);
            this.GbImg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbImg.Location = new System.Drawing.Point(25, 363);
            this.GbImg.Name = "GbImg";
            this.GbImg.Size = new System.Drawing.Size(402, 236);
            this.GbImg.TabIndex = 12;
            this.GbImg.TabStop = false;
            this.GbImg.Text = "รูปสินค้า";
            // 
            // BtImport
            // 
            this.BtImport.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.BtImport.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.BtImport.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BtImport.BorderRadius = 21;
            this.BtImport.BorderSize = 0;
            this.BtImport.FlatAppearance.BorderSize = 0;
            this.BtImport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtImport.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtImport.ForeColor = System.Drawing.Color.White;
            this.BtImport.Location = new System.Drawing.Point(282, 83);
            this.BtImport.Name = "BtImport";
            this.BtImport.Size = new System.Drawing.Size(100, 73);
            this.BtImport.TabIndex = 1;
            this.BtImport.Text = "Import\r\n IMG";
            this.BtImport.TextColor = System.Drawing.Color.White;
            this.BtImport.UseVisualStyleBackColor = false;
            this.BtImport.Click += new System.EventHandler(this.BtImport_Click);
            // 
            // PicProduct
            // 
            this.PicProduct.Image = global::Project_pos.Properties.Resources.coffee_cup;
            this.PicProduct.Location = new System.Drawing.Point(31, 25);
            this.PicProduct.Name = "PicProduct";
            this.PicProduct.Size = new System.Drawing.Size(235, 192);
            this.PicProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicProduct.TabIndex = 0;
            this.PicProduct.TabStop = false;
            // 
            // Txba
            // 
            this.Txba.Enabled = false;
            this.Txba.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txba.Location = new System.Drawing.Point(334, 146);
            this.Txba.Name = "Txba";
            this.Txba.Size = new System.Drawing.Size(93, 26);
            this.Txba.TabIndex = 12;
            this.Txba.Text = "       บาท";
            // 
            // GbStatus
            // 
            this.GbStatus.Controls.Add(this.RaClose);
            this.GbStatus.Controls.Add(this.RaOpent);
            this.GbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbStatus.Location = new System.Drawing.Point(38, 300);
            this.GbStatus.Name = "GbStatus";
            this.GbStatus.Size = new System.Drawing.Size(389, 56);
            this.GbStatus.TabIndex = 11;
            this.GbStatus.TabStop = false;
            this.GbStatus.Text = "สถานะสินค้า";
            // 
            // RaClose
            // 
            this.RaClose.AutoSize = true;
            this.RaClose.Location = new System.Drawing.Point(203, 21);
            this.RaClose.Name = "RaClose";
            this.RaClose.Size = new System.Drawing.Size(92, 24);
            this.RaClose.TabIndex = 1;
            this.RaClose.TabStop = true;
            this.RaClose.Text = "ปิดการขาย";
            this.RaClose.UseVisualStyleBackColor = true;
            // 
            // RaOpent
            // 
            this.RaOpent.AutoSize = true;
            this.RaOpent.Location = new System.Drawing.Point(84, 21);
            this.RaOpent.Name = "RaOpent";
            this.RaOpent.Size = new System.Drawing.Size(98, 24);
            this.RaOpent.TabIndex = 0;
            this.RaOpent.TabStop = true;
            this.RaOpent.Text = "เปิดการขาย";
            this.RaOpent.UseVisualStyleBackColor = true;
            // 
            // TxDtl
            // 
            this.TxDtl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxDtl.Location = new System.Drawing.Point(146, 239);
            this.TxDtl.Multiline = true;
            this.TxDtl.Name = "TxDtl";
            this.TxDtl.Size = new System.Drawing.Size(281, 55);
            this.TxDtl.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "รายละเอียดสินค้า";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "หมวดหมู่";
            // 
            // TxCat
            // 
            this.TxCat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TxCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxCat.FormattingEnabled = true;
            this.TxCat.Location = new System.Drawing.Point(146, 190);
            this.TxCat.Name = "TxCat";
            this.TxCat.Size = new System.Drawing.Size(281, 28);
            this.TxCat.TabIndex = 7;
            // 
            // TxPrice
            // 
            this.TxPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxPrice.Location = new System.Drawing.Point(146, 146);
            this.TxPrice.Name = "TxPrice";
            this.TxPrice.Size = new System.Drawing.Size(182, 26);
            this.TxPrice.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "ราคาสินค้า";
            // 
            // TxName
            // 
            this.TxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxName.Location = new System.Drawing.Point(146, 101);
            this.TxName.Name = "TxName";
            this.TxName.Size = new System.Drawing.Size(281, 26);
            this.TxName.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "ชื่อสินค้า";
            // 
            // TxId
            // 
            this.TxId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxId.Location = new System.Drawing.Point(146, 56);
            this.TxId.Name = "TxId";
            this.TxId.Size = new System.Drawing.Size(281, 26);
            this.TxId.TabIndex = 2;
            // 
            // LbId
            // 
            this.LbId.AutoSize = true;
            this.LbId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbId.Location = new System.Drawing.Point(21, 59);
            this.LbId.Name = "LbId";
            this.LbId.Size = new System.Drawing.Size(66, 20);
            this.LbId.TabIndex = 1;
            this.LbId.Text = "รหัสสินค้า";
            // 
            // LbTopic
            // 
            this.LbTopic.AutoSize = true;
            this.LbTopic.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbTopic.Location = new System.Drawing.Point(21, 10);
            this.LbTopic.Name = "LbTopic";
            this.LbTopic.Size = new System.Drawing.Size(143, 24);
            this.LbTopic.TabIndex = 0;
            this.LbTopic.Text = "รายละเอียดสินค้า";
            // 
            // RaAll
            // 
            this.RaAll.AutoSize = true;
            this.RaAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RaAll.Location = new System.Drawing.Point(6, 37);
            this.RaAll.Name = "RaAll";
            this.RaAll.Size = new System.Drawing.Size(87, 20);
            this.RaAll.TabIndex = 2;
            this.RaAll.TabStop = true;
            this.RaAll.Text = "แสดงทั้งหมด";
            this.RaAll.UseVisualStyleBackColor = true;
            this.RaAll.CheckedChanged += new System.EventHandler(this.RaAll_CheckedChanged);
            // 
            // RaCat
            // 
            this.RaCat.AutoSize = true;
            this.RaCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RaCat.Location = new System.Drawing.Point(105, 37);
            this.RaCat.Name = "RaCat";
            this.RaCat.Size = new System.Drawing.Size(88, 20);
            this.RaCat.TabIndex = 0;
            this.RaCat.TabStop = true;
            this.RaCat.Text = "ประเภทสินค้า";
            this.RaCat.UseVisualStyleBackColor = true;
            this.RaCat.CheckedChanged += new System.EventHandler(this.RaCat_CheckedChanged);
            // 
            // RaId
            // 
            this.RaId.AutoSize = true;
            this.RaId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RaId.Location = new System.Drawing.Point(202, 37);
            this.RaId.Name = "RaId";
            this.RaId.Size = new System.Drawing.Size(72, 20);
            this.RaId.TabIndex = 1;
            this.RaId.TabStop = true;
            this.RaId.Text = "รหัสสินค้า";
            this.RaId.UseVisualStyleBackColor = true;
            this.RaId.CheckedChanged += new System.EventHandler(this.RaId_CheckedChanged);
            // 
            // BtFind
            // 
            this.BtFind.BackColor = System.Drawing.Color.RoyalBlue;
            this.BtFind.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.BtFind.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BtFind.BorderRadius = 21;
            this.BtFind.BorderSize = 0;
            this.BtFind.FlatAppearance.BorderSize = 0;
            this.BtFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtFind.ForeColor = System.Drawing.Color.White;
            this.BtFind.Image = global::Project_pos.Properties.Resources.loupe;
            this.BtFind.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtFind.Location = new System.Drawing.Point(487, 50);
            this.BtFind.Name = "BtFind";
            this.BtFind.Size = new System.Drawing.Size(70, 71);
            this.BtFind.TabIndex = 18;
            this.BtFind.Text = "ค้นหา";
            this.BtFind.TextColor = System.Drawing.Color.White;
            this.BtFind.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtFind.UseVisualStyleBackColor = false;
            this.BtFind.Click += new System.EventHandler(this.BtFind_Click);
            // 
            // TxIdFind
            // 
            this.TxIdFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxIdFind.Location = new System.Drawing.Point(310, 53);
            this.TxIdFind.Name = "TxIdFind";
            this.TxIdFind.Size = new System.Drawing.Size(171, 26);
            this.TxIdFind.TabIndex = 21;
            this.TxIdFind.TextChanged += new System.EventHandler(this.TxIdFind_TextChanged);
            // 
            // CbCatFind
            // 
            this.CbCatFind.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbCatFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbCatFind.FormattingEnabled = true;
            this.CbCatFind.Location = new System.Drawing.Point(310, 85);
            this.CbCatFind.Name = "CbCatFind";
            this.CbCatFind.Size = new System.Drawing.Size(171, 28);
            this.CbCatFind.TabIndex = 20;
            this.CbCatFind.SelectedIndexChanged += new System.EventHandler(this.CbCatFind_SelectedIndexChanged);
            // 
            // FrmPrd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 681);
            this.Controls.Add(this.panMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPrd";
            this.Text = "FrmPrd";
            this.Load += new System.EventHandler(this.FrmPrd_Load);
            this.panMain.ResumeLayout(false);
            this.panData.ResumeLayout(false);
            this.panData.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProduct)).EndInit();
            this.panProcess.ResumeLayout(false);
            this.panProcess.PerformLayout();
            this.GbImg.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PicProduct)).EndInit();
            this.GbStatus.ResumeLayout(false);
            this.GbStatus.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panMain;
        private System.Windows.Forms.Panel panProcess;
        private System.Windows.Forms.Panel panData;
        private System.Windows.Forms.Label LbTopic;
        private System.Windows.Forms.Label LbId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox TxCat;
        private System.Windows.Forms.TextBox TxPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxId;
        private System.Windows.Forms.TextBox TxDtl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox GbStatus;
        private System.Windows.Forms.RadioButton RaClose;
        private System.Windows.Forms.RadioButton RaOpent;
        private System.Windows.Forms.TextBox Txba;
        private System.Windows.Forms.GroupBox GbImg;
        private CustomButton BtImport;
        private System.Windows.Forms.PictureBox PicProduct;
        private CustomButton BtAdd;
        private CustomButton BtEdit;
        private CustomButton BtCancel;
        private CustomButton BtSave;
        private CustomButton BtDel;
        private System.Windows.Forms.DataGridView DgvProduct;
        private System.Windows.Forms.Label Lbdataproduct;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox TxIdFind;
        private System.Windows.Forms.ComboBox CbCatFind;
        private System.Windows.Forms.RadioButton RaAll;
        private System.Windows.Forms.RadioButton RaId;
        private System.Windows.Forms.RadioButton RaCat;
        private CustomButton BtFind;
    }
}