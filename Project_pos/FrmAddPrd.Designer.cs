namespace Project_pos
{
    partial class FrmAddPrd
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
            this.CbLev = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LbName = new System.Windows.Forms.Label();
            this.NudQty = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.BtAddPrd = new Project_pos.CustomButton();
            ((System.ComponentModel.ISupportInitialize)(this.NudQty)).BeginInit();
            this.SuspendLayout();
            // 
            // CbLev
            // 
            this.CbLev.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbLev.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbLev.FormattingEnabled = true;
            this.CbLev.Location = new System.Drawing.Point(136, 50);
            this.CbLev.Name = "CbLev";
            this.CbLev.Size = new System.Drawing.Size(121, 26);
            this.CbLev.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "ระดับความหวาน";
            // 
            // LbName
            // 
            this.LbName.AutoSize = true;
            this.LbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbName.Location = new System.Drawing.Point(13, 9);
            this.LbName.Name = "LbName";
            this.LbName.Size = new System.Drawing.Size(65, 20);
            this.LbName.TabIndex = 3;
            this.LbName.Text = "ชื่อสินค้า";
            // 
            // NudQty
            // 
            this.NudQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NudQty.Location = new System.Drawing.Point(137, 82);
            this.NudQty.Name = "NudQty";
            this.NudQty.Size = new System.Drawing.Size(120, 24);
            this.NudQty.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(80, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "จำนวน";
            // 
            // BtAddPrd
            // 
            this.BtAddPrd.BackColor = System.Drawing.Color.RoyalBlue;
            this.BtAddPrd.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.BtAddPrd.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BtAddPrd.BorderRadius = 20;
            this.BtAddPrd.BorderSize = 0;
            this.BtAddPrd.FlatAppearance.BorderSize = 0;
            this.BtAddPrd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtAddPrd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtAddPrd.ForeColor = System.Drawing.Color.White;
            this.BtAddPrd.Image = global::Project_pos.Properties.Resources.add_to_basket;
            this.BtAddPrd.Location = new System.Drawing.Point(284, 50);
            this.BtAddPrd.Name = "BtAddPrd";
            this.BtAddPrd.Size = new System.Drawing.Size(104, 58);
            this.BtAddPrd.TabIndex = 6;
            this.BtAddPrd.Text = "เพิ่ม";
            this.BtAddPrd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtAddPrd.TextColor = System.Drawing.Color.White;
            this.BtAddPrd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtAddPrd.UseVisualStyleBackColor = false;
            this.BtAddPrd.Click += new System.EventHandler(this.BtAddPrd_Click);
            // 
            // FrmAddPrd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(414, 137);
            this.Controls.Add(this.BtAddPrd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NudQty);
            this.Controls.Add(this.LbName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CbLev);
            this.Name = "FrmAddPrd";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmAddPrd_FormClosed);
            this.Load += new System.EventHandler(this.FrmAddPrd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NudQty)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CbLev;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LbName;
        private System.Windows.Forms.NumericUpDown NudQty;
        private System.Windows.Forms.Label label2;
        private CustomButton BtAddPrd;
    }
}