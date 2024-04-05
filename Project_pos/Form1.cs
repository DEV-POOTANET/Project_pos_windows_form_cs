using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_pos
{
    public partial class FrmMain : Form
    {
        public Form sell = new FrmSell();
        public FrmMain()
        {
            InitializeComponent();

            //เรียกหน้าsell เป็นหน้าแรก
            loadform(sell);
            // activit bt sell
            panSellAt.Visible = true;
            panPrdAt.Visible = false;
            panCatAt.Visible = false;
            panEmpAt.Visible = false;
            panProAt.Visible = false;
            panSweetAt.Visible = false;
            panSellListAt.Visible = false;

            LbNameLogin.Text = Global.EmpLavel +" : " +Global.Name;

        }
        private void FrmMain_Load(object sender, EventArgs e)
        {
          

        }

        public void loadform(object Form)
        {
            if (this.panContent.Controls.Count > 0)
                this.panContent.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.panContent.Controls.Add(f);
            this.panContent.Tag = f;
            f.Show();
        }

        private void BtSell_Click(object sender, EventArgs e)
        {
            loadform(sell);

            // activit bt sell
            panSellAt.Visible = true;
            panPrdAt.Visible = false;
            panCatAt.Visible = false;
            panEmpAt.Visible = false;
            panProAt.Visible = false;
            panSweetAt.Visible = false;
            panSellListAt.Visible = false;


        }

        private void BtPrd_Click(object sender, EventArgs e)
        {
            loadform(new FrmPrd());

            // activit bt prd
            panPrdAt.Visible = true;
            panSellAt.Visible = false;
            panCatAt.Visible = false;
            panEmpAt.Visible = false;            
            panProAt.Visible= false;
            panSweetAt.Visible = false;
            panSellListAt.Visible = false;

        }

        private void BtEmp_Click(object sender, EventArgs e)
        {
            if (Global.EmpLavel == "ผู้จัดการ")
            {
                loadform(new FrmEmp());

                // activit bt emp
                panEmpAt.Visible = true;
                panPrdAt.Visible = false;
                panSellAt.Visible = false;
                panCatAt.Visible = false;
                panProAt.Visible = false;
                panSweetAt.Visible = false; 
                panSellListAt.Visible = false;
            }
            else
            {
                MessageBox.Show("เมนูสำหรับผู้จัดการเท่านั้น","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }


        }

        private void BtCat_Click(object sender, EventArgs e)
        {
            if (Global.EmpLavel == "ผู้จัดการ")
            {
                loadform(new FrmCat());

            // activit bt cat
            panCatAt.Visible = true;
            panEmpAt.Visible = false;
            panPrdAt.Visible = false;
            panSellAt.Visible = false;
            panProAt.Visible = false;
            panSweetAt.Visible = false;
            panSellListAt.Visible = false;
            }
            else
            {
                MessageBox.Show("เมนูสำหรับผู้จัดการเท่านั้น","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void BtPro_Click(object sender, EventArgs e)
        {
            if (Global.EmpLavel == "ผู้จัดการ")
            {
                loadform(new FrmCat());
                loadform(new FrmPro());

            // activit bt Pro
            panProAt.Visible = true;
            panCatAt.Visible = false;
            panEmpAt.Visible = false;
            panPrdAt.Visible = false;
            panSellAt.Visible = false;
            panSweetAt.Visible = false;
            }
            else
            {
                MessageBox.Show("เมนูสำหรับผู้จัดการเท่านั้น", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtSweet_Click(object sender, EventArgs e)
        {
            if (Global.EmpLavel == "ผู้จัดการ")
            {
                loadform(new FrmSweet());

            // activit bt Sweet
            panSweetAt.Visible = true;
            panProAt.Visible = false;
            panCatAt.Visible = false;
            panEmpAt.Visible = false;
            panPrdAt.Visible = false;
            panSellAt.Visible = false;
            panSellListAt.Visible = false;
            }
            else
            {
                MessageBox.Show("เมนูสำหรับผู้จัดการเท่านั้น", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtSellList_Click(object sender, EventArgs e)
        {
            loadform(new FrmSellList());

            // activit bt sell list
            panSellListAt.Visible = true;
            panSweetAt.Visible = false;
            panProAt.Visible = false;
            panCatAt.Visible = false;
            panEmpAt.Visible = false;
            panPrdAt.Visible = false;
            panSellAt.Visible = false;
        }

        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            DialogResult result = MessageBox.Show("คุณแน่ใจหรือไม่ว่าต้องการออกจากโปรแกรม?", "ยืนยันการออกจากโปรแกรม", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void BtLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.Show();            
        }

     
    }
}
