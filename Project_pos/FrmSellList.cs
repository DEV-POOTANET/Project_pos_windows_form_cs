using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Project_pos
{
    public partial class FrmSellList : Form
    {
        public FrmSellList()
        {

            InitializeComponent(); 
            DgvOrder.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Refresh_Grid();
            Order_detail_data.Text = "";
            Emp_detail.Text = "";
            Pro_detail.Text = "";
        }



        private void Refresh_Grid()
        {
            panMount.Visible = false;
            Database database = new Database();
            if (database.Connect_Db())
            {
                string sql = $"SELECT o.order_id, o.order_dete, o.employee_id, e.employee_fname, o.promotion_id FROM orders o JOIN employees e ON o.employee_id = e.employee_id;";
                MySqlCommand command = new MySqlCommand(sql, database.connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                adapter.SelectCommand = command;

                DataTable dt = new DataTable();
                adapter.Fill(dt);

                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = dt;
                DgvOrder.DataSource = bindingSource;
                DgvOrder.Columns["order_id"].HeaderText = "รหัสออเดอร์";
                DgvOrder.Columns["order_dete"].HeaderText = "วันที่";
                DgvOrder.Columns["employee_id"].HeaderText = "รหัสพนักงาน";
                DgvOrder.Columns["employee_fname"].HeaderText = "ชื่อพนักงาน";
                DgvOrder.Columns["promotion_id"].HeaderText = "รหัสโปรโมชั่น";

            }
        }

        private void customButton1_Click(object sender, EventArgs e)
        {
            if (raAll.Checked)
            {
                Refresh_Grid();
            }
            else if (raday.Checked)
            {
                panMount.Visible = false;
                Database database = new Database();
                if (database.Connect_Db())
                {
                    string sql = $"SELECT o.order_id, o.order_dete, o.employee_id, e.employee_fname, o.promotion_id FROM orders o JOIN employees e ON o.employee_id = e.employee_id WHERE DATE(o.order_dete) = CURDATE();";
                    MySqlCommand command = new MySqlCommand(sql, database.connection);
                    MySqlDataAdapter adapter = new MySqlDataAdapter();
                    adapter.SelectCommand = command;

                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    BindingSource bindingSource = new BindingSource();
                    bindingSource.DataSource = dt;
                    DgvOrder.DataSource = bindingSource;
                    DgvOrder.Columns["order_id"].HeaderText = "รหัสออเดอร์";
                    DgvOrder.Columns["order_dete"].HeaderText = "วันที่";
                    DgvOrder.Columns["employee_id"].HeaderText = "รหัสพนักงาน";
                    DgvOrder.Columns["employee_fname"].HeaderText = "ชื่อพนักงาน";
                    DgvOrder.Columns["promotion_id"].HeaderText = "รหัสโปรโมชั่น";

                    database.Disconnect_db();

                }
            }
            else if (ramo.Checked)
            {
                panMount.Visible = false;
                Database database = new Database();
                if (database.Connect_Db())
                {
                    string sql = $"SELECT o.order_id, o.order_dete, o.employee_id, e.employee_fname, o.promotion_id FROM orders o JOIN employees e ON o.employee_id = e.employee_id WHERE MONTH(o.order_dete) = MONTH(CURDATE()) AND YEAR(o.order_dete) = YEAR(CURDATE());";
                    MySqlCommand command = new MySqlCommand(sql, database.connection);
                    MySqlDataAdapter adapter = new MySqlDataAdapter();
                    adapter.SelectCommand = command;

                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    BindingSource bindingSource = new BindingSource();
                    bindingSource.DataSource = dt;
                    DgvOrder.DataSource = bindingSource;
                    DgvOrder.Columns["order_id"].HeaderText = "รหัสออเดอร์";
                    DgvOrder.Columns["order_dete"].HeaderText = "วันที่";
                    DgvOrder.Columns["employee_id"].HeaderText = "รหัสพนักงาน";
                    DgvOrder.Columns["employee_fname"].HeaderText = "ชื่อพนักงาน";
                    DgvOrder.Columns["promotion_id"].HeaderText = "รหัสโปรโมชั่น";

                    database.Disconnect_db();

                }
            }
            else if (ramo2.Checked)
            {
                int selectedMonth = Convert.ToInt32(comboBox1.SelectedIndex)+1;
                Database database = new Database();
                if (database.Connect_Db())
                {
                    string sql = $"SELECT o.order_id, o.order_dete, o.employee_id, e.employee_fname, o.promotion_id FROM orders o JOIN employees e ON o.employee_id = e.employee_id WHERE MONTH(o.order_dete) = {selectedMonth} AND YEAR(o.order_dete) = YEAR(CURDATE())";
                    MySqlCommand command = new MySqlCommand(sql, database.connection);
                    MySqlDataAdapter adapter = new MySqlDataAdapter();
                    adapter.SelectCommand = command;

                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    BindingSource bindingSource = new BindingSource();
                    bindingSource.DataSource = dt;
                    DgvOrder.DataSource = bindingSource;
                    DgvOrder.Columns["order_id"].HeaderText = "รหัสออเดอร์";
                    DgvOrder.Columns["order_dete"].HeaderText = "วันที่";
                    DgvOrder.Columns["employee_id"].HeaderText = "รหัสพนักงาน";
                    DgvOrder.Columns["employee_fname"].HeaderText = "ชื่อพนักงาน";
                    DgvOrder.Columns["promotion_id"].HeaderText = "รหัสโปรโมชั่น";

                    database.Disconnect_db();

                }
            }

        }

        private void DgvOrder_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
                //if (dgvDtl.Rows[e.RowIndex].Cells["order_id"].Value.ToString() == "")
                //{
                //    MessageBox.Show("กรุณาเลือกที่มีข้อมูลด้วยครับ", "กรุณาเลือกข้อมูลให้ถูกต้อง", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //}
                //else
                //{
                //    string sql = $"SELECT od.order_id ,od.product_id, pd.product_name ,lv.orderlevel_level,od.orderdetail_quantity,pd.product_price FROM orderdetail od JOIN products pd on od.product_id = pd.product_id JOIN orderlevel lv on od.level_id = lv.level_id WHERE order_id = {DgvOrder.Rows[e.RowIndex].Cells["order_id"].Value}";
                //    Database database = new Database();
                //    if (database.Connect_Db())
                //    {
                //        MySqlCommand command = new MySqlCommand(sql, database.connection);
                //        MySqlDataAdapter adapter = new MySqlDataAdapter();
                //        adapter.SelectCommand = command;

                //        DataTable dt = new DataTable();
                //        adapter.Fill(dt);

                //        BindingSource bindingSource = new BindingSource();
                //        bindingSource.DataSource = dt;
                //        dgvDtl.DataSource = bindingSource;
                //    }

                //}

            string sql = $"SELECT od.order_id ,od.product_id, pd.product_name ,lv.orderlevel_level,od.orderdetail_quantity,pd.product_price FROM orderdetail od JOIN products pd on od.product_id = pd.product_id JOIN orderlevel lv on od.level_id = lv.level_id WHERE order_id = {DgvOrder.Rows[e.RowIndex].Cells["order_id"].Value}";
            Database database = new Database();
            if (database.Connect_Db())
            {
                try
                {
                    MySqlCommand command = new MySqlCommand(sql, database.connection);
                    MySqlDataAdapter adapter = new MySqlDataAdapter();
                    adapter.SelectCommand = command;

                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    BindingSource bindingSource = new BindingSource();
                    bindingSource.DataSource = dt;
                    dgvDtl.DataSource = bindingSource;

                    Order_detail_data.Text = DgvOrder.Rows[e.RowIndex].Cells["order_id"].Value.ToString();
                    Emp_detail.Text = DgvOrder.Rows[e.RowIndex].Cells["employee_fname"].Value.ToString();
                    Pro_detail.Text = DgvOrder.Rows[e.RowIndex].Cells["promotion_id"].Value.ToString();

                    decimal total = 0;
                    foreach (DataGridViewRow row in dgvDtl.Rows)
                    {

                        total += Convert.ToDecimal(row.Cells["orderdetail_quantity"].Value) * Convert.ToDecimal(row.Cells["product_price"].Value);
                    }
                    LbTotalPrice.Text = total.ToString();

                    string sql1 = $"SELECT promotion_discount FROM promotions WHERE promotion_id = {DgvOrder.Rows[e.RowIndex].Cells["promotion_id"].Value}";
                    MySqlCommand command1 = new MySqlCommand(sql1, database.connection);
                    MySqlDataAdapter adapter1 = new MySqlDataAdapter();
                    adapter1.SelectCommand = command1;
                    DataTable dt1 = new DataTable();
                    adapter1.Fill(dt1);
                    decimal discount = 0;
                    if (dt1.Rows.Count > 0)
                    {
                        discount = Convert.ToDecimal(dt1.Rows[0]["promotion_discount"]);
                        Lbdis.Text = discount.ToString();
                    }

                    decimal netp = total - discount;
                    Lbnet.Text = netp.ToString();
                }
                catch (Exception ex)
                { 
                }

            }



        }

        private void ramo2_CheckedChanged(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            panMount.Visible = true;
            string[] thaiMonthNames = new string[]
            {
                "มกราคม", "กุมภาพันธ์", "มีนาคม", "เมษายน", "พฤษภาคม", "มิถุนายน",
                "กรกฎาคม", "สิงหาคม", "กันยายน", "ตุลาคม", "พฤศจิกายน", "ธันวาคม"
            };
            for (int month = 0; month < 12; month++)
            {
                comboBox1.Items.Add(thaiMonthNames[month]);
            }
            comboBox1.SelectedIndex = DateTime.Now.Month - 1; 

        }
    }
}
