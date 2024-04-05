namespace Project_pos
{
    partial class FrmSell
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
            this.panSell = new System.Windows.Forms.Panel();
            this.BtAddProOpen = new Project_pos.CustomButton();
            this.BtDelPro = new Project_pos.CustomButton();
            this.LbEmpSell = new System.Windows.Forms.Label();
            this.LbProSell = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.customButton1 = new Project_pos.CustomButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.LbNETprice = new System.Windows.Forms.Label();
            this.LbSellPriceTotal = new System.Windows.Forms.Label();
            this.Lbdis = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.DgvPrd = new System.Windows.Forms.DataGridView();
            this.Clear = new Project_pos.CustomButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panAddPro = new System.Windows.Forms.Panel();
            this.DgvPro = new System.Windows.Forms.DataGridView();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.DtEndAddPro = new System.Windows.Forms.DateTimePicker();
            this.DtStartAddPro = new System.Windows.Forms.DateTimePicker();
            this.TxbaAddPro = new System.Windows.Forms.TextBox();
            this.TxDetailAddPro = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.TxDisAddPro = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.TxIdAddPro = new System.Windows.Forms.TextBox();
            this.LbIdPro = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtAddPanAddPro = new Project_pos.CustomButton();
            this.BtClosePanAddPro = new Project_pos.CustomButton();
            this.label15 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label22 = new System.Windows.Forms.Label();
            this.panShowProduct = new System.Windows.Forms.Panel();
            this.TxIdFind = new System.Windows.Forms.TextBox();
            this.CbCatFind = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RaAll = new System.Windows.Forms.RadioButton();
            this.RaId = new System.Windows.Forms.RadioButton();
            this.RaCat = new System.Windows.Forms.RadioButton();
            this.BtFind = new Project_pos.CustomButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LbTopic = new System.Windows.Forms.Label();
            this.FlpProduct = new System.Windows.Forms.FlowLayoutPanel();
            this.panMain.SuspendLayout();
            this.panSell.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPrd)).BeginInit();
            this.panAddPro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPro)).BeginInit();
            this.panShowProduct.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panMain
            // 
            this.panMain.Controls.Add(this.panAddPro);
            this.panMain.Controls.Add(this.panSell);
            this.panMain.Controls.Add(this.panShowProduct);
            this.panMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panMain.Location = new System.Drawing.Point(0, 0);
            this.panMain.Name = "panMain";
            this.panMain.Size = new System.Drawing.Size(1024, 681);
            this.panMain.TabIndex = 0;
            // 
            // panSell
            // 
            this.panSell.Controls.Add(this.BtAddProOpen);
            this.panSell.Controls.Add(this.BtDelPro);
            this.panSell.Controls.Add(this.LbEmpSell);
            this.panSell.Controls.Add(this.LbProSell);
            this.panSell.Controls.Add(this.label4);
            this.panSell.Controls.Add(this.label3);
            this.panSell.Controls.Add(this.customButton1);
            this.panSell.Controls.Add(this.panel3);
            this.panSell.Controls.Add(this.DgvPrd);
            this.panSell.Controls.Add(this.Clear);
            this.panSell.Controls.Add(this.panel2);
            this.panSell.Controls.Add(this.label1);
            this.panSell.Location = new System.Drawing.Point(717, 262);
            this.panSell.Name = "panSell";
            this.panSell.Size = new System.Drawing.Size(392, 681);
            this.panSell.TabIndex = 7;
            // 
            // BtAddProOpen
            // 
            this.BtAddProOpen.BackColor = System.Drawing.Color.RoyalBlue;
            this.BtAddProOpen.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.BtAddProOpen.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BtAddProOpen.BorderRadius = 22;
            this.BtAddProOpen.BorderSize = 0;
            this.BtAddProOpen.FlatAppearance.BorderSize = 0;
            this.BtAddProOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtAddProOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtAddProOpen.ForeColor = System.Drawing.Color.White;
            this.BtAddProOpen.Location = new System.Drawing.Point(196, 81);
            this.BtAddProOpen.Name = "BtAddProOpen";
            this.BtAddProOpen.Size = new System.Drawing.Size(72, 28);
            this.BtAddProOpen.TabIndex = 38;
            this.BtAddProOpen.Text = "เลือก";
            this.BtAddProOpen.TextColor = System.Drawing.Color.White;
            this.BtAddProOpen.UseVisualStyleBackColor = false;
            this.BtAddProOpen.Click += new System.EventHandler(this.BtAddProOpen_Click);
            // 
            // BtDelPro
            // 
            this.BtDelPro.BackColor = System.Drawing.Color.Crimson;
            this.BtDelPro.BackgroundColor = System.Drawing.Color.Crimson;
            this.BtDelPro.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BtDelPro.BorderRadius = 22;
            this.BtDelPro.BorderSize = 0;
            this.BtDelPro.FlatAppearance.BorderSize = 0;
            this.BtDelPro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtDelPro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtDelPro.ForeColor = System.Drawing.Color.White;
            this.BtDelPro.Location = new System.Drawing.Point(274, 81);
            this.BtDelPro.Name = "BtDelPro";
            this.BtDelPro.Size = new System.Drawing.Size(72, 28);
            this.BtDelPro.TabIndex = 37;
            this.BtDelPro.Text = "ล้าง";
            this.BtDelPro.TextColor = System.Drawing.Color.White;
            this.BtDelPro.UseVisualStyleBackColor = false;
            this.BtDelPro.Click += new System.EventHandler(this.BtDelPro_Click);
            // 
            // LbEmpSell
            // 
            this.LbEmpSell.AutoSize = true;
            this.LbEmpSell.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbEmpSell.Location = new System.Drawing.Point(135, 55);
            this.LbEmpSell.Name = "LbEmpSell";
            this.LbEmpSell.Size = new System.Drawing.Size(48, 18);
            this.LbEmpSell.TabIndex = 36;
            this.LbEmpSell.Text = "Name";
            // 
            // LbProSell
            // 
            this.LbProSell.AutoSize = true;
            this.LbProSell.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbProSell.Location = new System.Drawing.Point(132, 87);
            this.LbProSell.Name = "LbProSell";
            this.LbProSell.Size = new System.Drawing.Size(48, 18);
            this.LbProSell.TabIndex = 35;
            this.LbProSell.Text = "00000";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 18);
            this.label4.TabIndex = 34;
            this.label4.Text = "รหัสพนักงาน  :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 18);
            this.label3.TabIndex = 33;
            this.label3.Text = "รหัสโปรโมชั่น :";
            // 
            // customButton1
            // 
            this.customButton1.BackColor = System.Drawing.Color.RoyalBlue;
            this.customButton1.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.customButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.customButton1.BorderRadius = 40;
            this.customButton1.BorderSize = 0;
            this.customButton1.FlatAppearance.BorderSize = 0;
            this.customButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customButton1.ForeColor = System.Drawing.Color.White;
            this.customButton1.Location = new System.Drawing.Point(183, 619);
            this.customButton1.Name = "customButton1";
            this.customButton1.Size = new System.Drawing.Size(86, 50);
            this.customButton1.TabIndex = 32;
            this.customButton1.Text = "บันทึกรายการ";
            this.customButton1.TextColor = System.Drawing.Color.White;
            this.customButton1.UseVisualStyleBackColor = false;
            this.customButton1.Click += new System.EventHandler(this.customButton1_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Crimson;
            this.panel3.Controls.Add(this.LbNETprice);
            this.panel3.Controls.Add(this.LbSellPriceTotal);
            this.panel3.Controls.Add(this.Lbdis);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Location = new System.Drawing.Point(32, 507);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(329, 84);
            this.panel3.TabIndex = 31;
            // 
            // LbNETprice
            // 
            this.LbNETprice.AutoSize = true;
            this.LbNETprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbNETprice.ForeColor = System.Drawing.Color.White;
            this.LbNETprice.Location = new System.Drawing.Point(212, 52);
            this.LbNETprice.Name = "LbNETprice";
            this.LbNETprice.Size = new System.Drawing.Size(49, 24);
            this.LbNETprice.TabIndex = 33;
            this.LbNETprice.Text = "0.00";
            // 
            // LbSellPriceTotal
            // 
            this.LbSellPriceTotal.AutoSize = true;
            this.LbSellPriceTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbSellPriceTotal.ForeColor = System.Drawing.Color.White;
            this.LbSellPriceTotal.Location = new System.Drawing.Point(212, 4);
            this.LbSellPriceTotal.Name = "LbSellPriceTotal";
            this.LbSellPriceTotal.Size = new System.Drawing.Size(49, 24);
            this.LbSellPriceTotal.TabIndex = 32;
            this.LbSellPriceTotal.Text = "0.00";
            // 
            // Lbdis
            // 
            this.Lbdis.AutoSize = true;
            this.Lbdis.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbdis.ForeColor = System.Drawing.Color.White;
            this.Lbdis.Location = new System.Drawing.Point(212, 28);
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
            this.label7.Location = new System.Drawing.Point(105, 52);
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
            this.label5.Location = new System.Drawing.Point(109, 4);
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
            this.label6.Location = new System.Drawing.Point(129, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 24);
            this.label6.TabIndex = 28;
            this.label6.Text = "ส่วนลด :";
            // 
            // DgvPrd
            // 
            this.DgvPrd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvPrd.Location = new System.Drawing.Point(32, 120);
            this.DgvPrd.Name = "DgvPrd";
            this.DgvPrd.Size = new System.Drawing.Size(329, 387);
            this.DgvPrd.TabIndex = 29;
            this.DgvPrd.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvPrd_CellValueChanged);
            // 
            // Clear
            // 
            this.Clear.BackColor = System.Drawing.Color.Crimson;
            this.Clear.BackgroundColor = System.Drawing.Color.Crimson;
            this.Clear.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.Clear.BorderRadius = 40;
            this.Clear.BorderSize = 0;
            this.Clear.FlatAppearance.BorderSize = 0;
            this.Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear.ForeColor = System.Drawing.Color.White;
            this.Clear.Location = new System.Drawing.Point(275, 619);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(86, 50);
            this.Clear.TabIndex = 30;
            this.Clear.Text = "ล้างรายการ";
            this.Clear.TextColor = System.Drawing.Color.White;
            this.Clear.UseVisualStyleBackColor = false;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel2.Location = new System.Drawing.Point(152, 18);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(235, 10);
            this.panel2.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Image = global::Project_pos.Properties.Resources.personal;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(9, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 24);
            this.label1.TabIndex = 20;
            this.label1.Text = "     การขายสินค้า";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panAddPro
            // 
            this.panAddPro.Controls.Add(this.DgvPro);
            this.panAddPro.Controls.Add(this.label13);
            this.panAddPro.Controls.Add(this.label14);
            this.panAddPro.Controls.Add(this.DtEndAddPro);
            this.panAddPro.Controls.Add(this.DtStartAddPro);
            this.panAddPro.Controls.Add(this.TxbaAddPro);
            this.panAddPro.Controls.Add(this.TxDetailAddPro);
            this.panAddPro.Controls.Add(this.label16);
            this.panAddPro.Controls.Add(this.TxDisAddPro);
            this.panAddPro.Controls.Add(this.label17);
            this.panAddPro.Controls.Add(this.TxIdAddPro);
            this.panAddPro.Controls.Add(this.LbIdPro);
            this.panAddPro.Controls.Add(this.label2);
            this.panAddPro.Controls.Add(this.BtAddPanAddPro);
            this.panAddPro.Controls.Add(this.BtClosePanAddPro);
            this.panAddPro.Controls.Add(this.label15);
            this.panAddPro.Controls.Add(this.panel6);
            this.panAddPro.Controls.Add(this.label22);
            this.panAddPro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panAddPro.Location = new System.Drawing.Point(632, 0);
            this.panAddPro.Name = "panAddPro";
            this.panAddPro.Size = new System.Drawing.Size(392, 681);
            this.panAddPro.TabIndex = 39;
            // 
            // DgvPro
            // 
            this.DgvPro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvPro.Location = new System.Drawing.Point(13, 329);
            this.DgvPro.Name = "DgvPro";
            this.DgvPro.Size = new System.Drawing.Size(367, 268);
            this.DgvPro.TabIndex = 51;
            this.DgvPro.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvPro_CellClick);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(60, 292);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(89, 18);
            this.label13.TabIndex = 50;
            this.label13.Text = "วันหมดส่วนลด";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(60, 244);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(83, 18);
            this.label14.TabIndex = 49;
            this.label14.Text = "วันเริ่มส่วนลด";
            // 
            // DtEndAddPro
            // 
            this.DtEndAddPro.CustomFormat = "yyyy-MM-dd";
            this.DtEndAddPro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtEndAddPro.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtEndAddPro.Location = new System.Drawing.Point(168, 289);
            this.DtEndAddPro.Name = "DtEndAddPro";
            this.DtEndAddPro.Size = new System.Drawing.Size(159, 24);
            this.DtEndAddPro.TabIndex = 48;
            // 
            // DtStartAddPro
            // 
            this.DtStartAddPro.Checked = false;
            this.DtStartAddPro.CustomFormat = "yyyy-MM-dd";
            this.DtStartAddPro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtStartAddPro.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtStartAddPro.Location = new System.Drawing.Point(171, 241);
            this.DtStartAddPro.Name = "DtStartAddPro";
            this.DtStartAddPro.Size = new System.Drawing.Size(159, 24);
            this.DtStartAddPro.TabIndex = 47;
            // 
            // TxbaAddPro
            // 
            this.TxbaAddPro.Enabled = false;
            this.TxbaAddPro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxbaAddPro.Location = new System.Drawing.Point(298, 131);
            this.TxbaAddPro.Name = "TxbaAddPro";
            this.TxbaAddPro.Size = new System.Drawing.Size(32, 24);
            this.TxbaAddPro.TabIndex = 46;
            this.TxbaAddPro.Text = "บาท";
            // 
            // TxDetailAddPro
            // 
            this.TxDetailAddPro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxDetailAddPro.Location = new System.Drawing.Point(171, 170);
            this.TxDetailAddPro.Multiline = true;
            this.TxDetailAddPro.Name = "TxDetailAddPro";
            this.TxDetailAddPro.Size = new System.Drawing.Size(159, 55);
            this.TxDetailAddPro.TabIndex = 45;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(60, 173);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(110, 18);
            this.label16.TabIndex = 44;
            this.label16.Text = "รายละเอียดส่วนลด";
            // 
            // TxDisAddPro
            // 
            this.TxDisAddPro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxDisAddPro.Location = new System.Drawing.Point(171, 131);
            this.TxDisAddPro.Name = "TxDisAddPro";
            this.TxDisAddPro.Size = new System.Drawing.Size(118, 24);
            this.TxDisAddPro.TabIndex = 43;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(60, 136);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(47, 18);
            this.label17.TabIndex = 42;
            this.label17.Text = "ส่วนลด";
            // 
            // TxIdAddPro
            // 
            this.TxIdAddPro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxIdAddPro.Location = new System.Drawing.Point(171, 93);
            this.TxIdAddPro.Name = "TxIdAddPro";
            this.TxIdAddPro.Size = new System.Drawing.Size(159, 24);
            this.TxIdAddPro.TabIndex = 41;
            // 
            // LbIdPro
            // 
            this.LbIdPro.AutoSize = true;
            this.LbIdPro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbIdPro.Location = new System.Drawing.Point(60, 95);
            this.LbIdPro.Name = "LbIdPro";
            this.LbIdPro.Size = new System.Drawing.Size(86, 18);
            this.LbIdPro.TabIndex = 40;
            this.LbIdPro.Text = "รหัสโปรโมชั่น";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 24);
            this.label2.TabIndex = 39;
            this.label2.Text = "เลือกโปรโมชั่น";
            // 
            // BtAddPanAddPro
            // 
            this.BtAddPanAddPro.BackColor = System.Drawing.Color.RoyalBlue;
            this.BtAddPanAddPro.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.BtAddPanAddPro.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BtAddPanAddPro.BorderRadius = 22;
            this.BtAddPanAddPro.BorderSize = 0;
            this.BtAddPanAddPro.FlatAppearance.BorderSize = 0;
            this.BtAddPanAddPro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtAddPanAddPro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtAddPanAddPro.ForeColor = System.Drawing.Color.White;
            this.BtAddPanAddPro.Location = new System.Drawing.Point(230, 610);
            this.BtAddPanAddPro.Name = "BtAddPanAddPro";
            this.BtAddPanAddPro.Size = new System.Drawing.Size(72, 41);
            this.BtAddPanAddPro.TabIndex = 38;
            this.BtAddPanAddPro.Text = "เลือก";
            this.BtAddPanAddPro.TextColor = System.Drawing.Color.White;
            this.BtAddPanAddPro.UseVisualStyleBackColor = false;
            this.BtAddPanAddPro.Click += new System.EventHandler(this.BtAddPanAddPro_Click);
            // 
            // BtClosePanAddPro
            // 
            this.BtClosePanAddPro.BackColor = System.Drawing.Color.Crimson;
            this.BtClosePanAddPro.BackgroundColor = System.Drawing.Color.Crimson;
            this.BtClosePanAddPro.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BtClosePanAddPro.BorderRadius = 22;
            this.BtClosePanAddPro.BorderSize = 0;
            this.BtClosePanAddPro.FlatAppearance.BorderSize = 0;
            this.BtClosePanAddPro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtClosePanAddPro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtClosePanAddPro.ForeColor = System.Drawing.Color.White;
            this.BtClosePanAddPro.Location = new System.Drawing.Point(308, 610);
            this.BtClosePanAddPro.Name = "BtClosePanAddPro";
            this.BtClosePanAddPro.Size = new System.Drawing.Size(72, 41);
            this.BtClosePanAddPro.TabIndex = 37;
            this.BtClosePanAddPro.Text = "ยกเลิก";
            this.BtClosePanAddPro.TextColor = System.Drawing.Color.White;
            this.BtClosePanAddPro.UseVisualStyleBackColor = false;
            this.BtClosePanAddPro.Click += new System.EventHandler(this.BtClosePanAddPro_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(11, 86);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(0, 18);
            this.label15.TabIndex = 33;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel6.Location = new System.Drawing.Point(152, 18);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(235, 10);
            this.panel6.TabIndex = 21;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Image = global::Project_pos.Properties.Resources.personal;
            this.label22.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label22.Location = new System.Drawing.Point(9, 11);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(145, 24);
            this.label22.TabIndex = 20;
            this.label22.Text = "     การขายสินค้า";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panShowProduct
            // 
            this.panShowProduct.Controls.Add(this.TxIdFind);
            this.panShowProduct.Controls.Add(this.CbCatFind);
            this.panShowProduct.Controls.Add(this.groupBox1);
            this.panShowProduct.Controls.Add(this.BtFind);
            this.panShowProduct.Controls.Add(this.panel1);
            this.panShowProduct.Controls.Add(this.LbTopic);
            this.panShowProduct.Controls.Add(this.FlpProduct);
            this.panShowProduct.Dock = System.Windows.Forms.DockStyle.Left;
            this.panShowProduct.Location = new System.Drawing.Point(0, 0);
            this.panShowProduct.Name = "panShowProduct";
            this.panShowProduct.Size = new System.Drawing.Size(632, 681);
            this.panShowProduct.TabIndex = 6;
            // 
            // TxIdFind
            // 
            this.TxIdFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxIdFind.Location = new System.Drawing.Point(301, 44);
            this.TxIdFind.Name = "TxIdFind";
            this.TxIdFind.Size = new System.Drawing.Size(246, 26);
            this.TxIdFind.TabIndex = 25;
            // 
            // CbCatFind
            // 
            this.CbCatFind.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbCatFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbCatFind.FormattingEnabled = true;
            this.CbCatFind.Location = new System.Drawing.Point(301, 76);
            this.CbCatFind.Name = "CbCatFind";
            this.CbCatFind.Size = new System.Drawing.Size(246, 28);
            this.CbCatFind.TabIndex = 24;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RaAll);
            this.groupBox1.Controls.Add(this.RaId);
            this.groupBox1.Controls.Add(this.RaCat);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(283, 71);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ค้นหาด้วย";
            // 
            // RaAll
            // 
            this.RaAll.AutoSize = true;
            this.RaAll.Checked = true;
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
            // RaId
            // 
            this.RaId.AutoSize = true;
            this.RaId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RaId.Location = new System.Drawing.Point(202, 37);
            this.RaId.Name = "RaId";
            this.RaId.Size = new System.Drawing.Size(72, 20);
            this.RaId.TabIndex = 1;
            this.RaId.Text = "รหัสสินค้า";
            this.RaId.UseVisualStyleBackColor = true;
            this.RaId.CheckedChanged += new System.EventHandler(this.RaId_CheckedChanged);
            // 
            // RaCat
            // 
            this.RaCat.AutoSize = true;
            this.RaCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RaCat.Location = new System.Drawing.Point(105, 37);
            this.RaCat.Name = "RaCat";
            this.RaCat.Size = new System.Drawing.Size(88, 20);
            this.RaCat.TabIndex = 0;
            this.RaCat.Text = "ประเภทสินค้า";
            this.RaCat.UseVisualStyleBackColor = true;
            this.RaCat.CheckedChanged += new System.EventHandler(this.RaCat_CheckedChanged);
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
            this.BtFind.Location = new System.Drawing.Point(553, 41);
            this.BtFind.Name = "BtFind";
            this.BtFind.Size = new System.Drawing.Size(70, 71);
            this.BtFind.TabIndex = 22;
            this.BtFind.Text = "ค้นหา";
            this.BtFind.TextColor = System.Drawing.Color.White;
            this.BtFind.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtFind.UseVisualStyleBackColor = false;
            this.BtFind.Click += new System.EventHandler(this.BtFind_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Location = new System.Drawing.Point(155, 18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(468, 10);
            this.panel1.TabIndex = 19;
            // 
            // LbTopic
            // 
            this.LbTopic.AutoSize = true;
            this.LbTopic.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbTopic.Image = global::Project_pos.Properties.Resources.coffee_cup__1_;
            this.LbTopic.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LbTopic.Location = new System.Drawing.Point(12, 11);
            this.LbTopic.Name = "LbTopic";
            this.LbTopic.Size = new System.Drawing.Size(143, 24);
            this.LbTopic.TabIndex = 18;
            this.LbTopic.Text = "     รายการสินค้า";
            this.LbTopic.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FlpProduct
            // 
            this.FlpProduct.AutoScroll = true;
            this.FlpProduct.BackColor = System.Drawing.Color.White;
            this.FlpProduct.Location = new System.Drawing.Point(9, 120);
            this.FlpProduct.Name = "FlpProduct";
            this.FlpProduct.Size = new System.Drawing.Size(614, 549);
            this.FlpProduct.TabIndex = 0;
            // 
            // FrmSell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1024, 681);
            this.Controls.Add(this.panMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmSell";
            this.Text = "FrmSell";
            this.Load += new System.EventHandler(this.FrmSell_Load);
            this.panMain.ResumeLayout(false);
            this.panSell.ResumeLayout(false);
            this.panSell.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPrd)).EndInit();
            this.panAddPro.ResumeLayout(false);
            this.panAddPro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPro)).EndInit();
            this.panShowProduct.ResumeLayout(false);
            this.panShowProduct.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panMain;
        private System.Windows.Forms.Panel panSell;
        private System.Windows.Forms.Panel panShowProduct;
        private System.Windows.Forms.FlowLayoutPanel FlpProduct;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LbTopic;
        private System.Windows.Forms.TextBox TxIdFind;
        private System.Windows.Forms.ComboBox CbCatFind;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RaAll;
        private System.Windows.Forms.RadioButton RaId;
        private System.Windows.Forms.RadioButton RaCat;
        private CustomButton BtFind;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label LbNETprice;
        private System.Windows.Forms.Label LbSellPriceTotal;
        private System.Windows.Forms.Label Lbdis;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView DgvPrd;
        private CustomButton Clear;
        private CustomButton customButton1;
        private System.Windows.Forms.Label LbEmpSell;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private CustomButton BtAddProOpen;
        private CustomButton BtDelPro;
        private System.Windows.Forms.Label LbProSell;
        private System.Windows.Forms.Panel panAddPro;
        private System.Windows.Forms.Label label2;
        private CustomButton BtAddPanAddPro;
        private CustomButton BtClosePanAddPro;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker DtEndAddPro;
        private System.Windows.Forms.DateTimePicker DtStartAddPro;
        private System.Windows.Forms.TextBox TxbaAddPro;
        private System.Windows.Forms.TextBox TxDetailAddPro;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox TxDisAddPro;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox TxIdAddPro;
        private System.Windows.Forms.Label LbIdPro;
        private System.Windows.Forms.DataGridView DgvPro;
    }
}