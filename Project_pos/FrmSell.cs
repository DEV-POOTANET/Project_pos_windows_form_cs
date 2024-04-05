using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using Microsoft.SqlServer.Server;

namespace Project_pos
{
    public partial class FrmSell : Form
    {
        public string path = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));
        public FrmSell()
        {
            InitializeComponent();
            Ra_disble();
            LocdCombo();
            DisplaySellPan();
            SetupSell();
        }
        private void FrmSell_Load(object sender, EventArgs e)
        {
            ProductListPanal();
            RefreshGrid();
        }
     

        public void SetupSell()
        {
            LbProSell.Text = Global.ProSell;
            LbEmpSell.Text = Global.Id;
        }

        public void DisplaySellPan()
        {
            panSell.Visible = true;
            panSell.Dock = DockStyle.Fill;
            panAddPro.Visible = false;
        }
        public void DisplayAddProPan()
        {
            panAddPro.Visible = true;
            panAddPro.Dock = DockStyle.Fill;
            panSell.Visible = false; 
        }
        private void BtAddProOpen_Click(object sender, EventArgs e)
        {
            DisplayAddProPan();
            DgvPro.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Disable_Screen_AddPro();
            Refresh_Grid_AddPro();
        }
        public void Disable_Screen_AddPro()
        {
            TxIdAddPro.Enabled = false;
            TxDisAddPro.Enabled = false;
            TxDetailAddPro.Enabled = false;
            DtStartAddPro.Enabled = false;
            DtEndAddPro.Enabled = false;
        }
        private void DgvPro_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (DgvPro.Rows[e.RowIndex].Cells["promotion_id"].Value.ToString() == "")
                {
                    MessageBox.Show("กรุณาเลือกที่มีข้อมูลด้วยครับ", "กรุณาเลือกข้อมูลให้ถูกต้อง", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    TxIdAddPro.Text = DgvPro.Rows[e.RowIndex].Cells["promotion_id"].Value.ToString();
                    TxDisAddPro.Text = DgvPro.Rows[e.RowIndex].Cells["promotion_discount"].Value.ToString();
                    TxDetailAddPro.Text = DgvPro.Rows[e.RowIndex].Cells["pomotion_detail"].Value.ToString();
                    DtStartAddPro.Text = DgvPro.Rows[e.RowIndex].Cells["promotion_dete_start"].Value.ToString();
                    DtEndAddPro.Text = DgvPro.Rows[e.RowIndex].Cells["promotion_dete_end"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Refresh_Grid_AddPro()
        {
            var database = new Database();
            if (database.Connect_Db())
            {
                var dateChk = DateTime.Now;
                string query1 = "SELECT promotion_id, promotion_discount, pomotion_detail, promotion_dete_start, promotion_dete_end FROM Promotions WHERE promotion_dete_end > CURDATE()";


                MySqlCommand command1 = new MySqlCommand(query1, database.connection);
                MySqlDataAdapter adapter1 = new MySqlDataAdapter();
                adapter1.SelectCommand = command1;
                DataTable dt1 = new DataTable();
                adapter1.Fill(dt1);
                DgvPro.DataSource = dt1;

                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = dt1;

                DgvPro.DataSource = bindingSource;

                DgvPro.Columns["promotion_id"].HeaderText = "รหัสโปรโมชั่น";
                DgvPro.Columns["promotion_discount"].HeaderText = "ส่วนลด";
                DgvPro.Columns["pomotion_detail"].Visible = false;
                DgvPro.Columns["promotion_dete_start"].Visible = false;
                DgvPro.Columns["promotion_dete_end"].HeaderText = "วันหมดส่วนลด";
               
            }
        }

        private void BtClosePanAddPro_Click(object sender, EventArgs e)
        {
            DisplaySellPan();
        }

        private void BtAddPanAddPro_Click(object sender, EventArgs e)
        {
            if (TxIdAddPro.Text == "")
            {
                MessageBox.Show("กรูณาเลือกโปรโมชั่น");

            }
            else
            {
                Global.ProSell = TxIdAddPro.Text;
                Global.ProSell2 =  decimal.Parse(TxDisAddPro.Text);
                SetupSell();
                DisplaySellPan();
                RefreshGrid();

            }
        }
        private void BtDelPro_Click(object sender, EventArgs e)
        {
            Global.ProSell = "";
            SetupSell();

            Global.ProSell2 = 0;
            RefreshGrid();
        }



        public void LocdCombo()
        {
            var database = new Database();
            if (database.Connect_Db())
            {               
                string CateFindQuery = "SELECT * FROM categories";

                MySqlCommand command3 = new MySqlCommand(CateFindQuery, database.connection);

                MySqlDataAdapter adapter3 = new MySqlDataAdapter();
                adapter3.SelectCommand = command3;

                DataTable dt3 = new DataTable();
                adapter3.Fill(dt3);

                CbCatFind.DataSource = dt3;
                CbCatFind.DisplayMember = "categorie_name";
                CbCatFind.ValueMember = "categorie_id";

            }
        }
        public void LoadUCPrd(DataTable dt1)
        {
            FlpProduct.Controls.Clear();
            foreach (DataRow Row in dt1.Rows)
            {
                UcProduct ucProduct = new UcProduct();

                // ตั้งค่าข้อมูลใน User Control
                ucProduct.PUcPrdID = Row["product_id"].ToString();
                ucProduct.PUcPrdName = Row["product_name"].ToString();
                ucProduct.PUcPrdPrice = float.Parse(Row["product_price"].ToString());
                ucProduct.PUcPrdStatus = Row["product_status"].ToString();
                ucProduct.PUcPrdCatID = Row["categorie_id"].ToString();

                string imagePath = (path + "\\Image\\" + Row["product_img"].ToString());

                if (File.Exists(imagePath))
                {
                    ucProduct.PUcPrdImage = Bitmap.FromFile(imagePath);
                }
                else
                {
                    MessageBox.Show("Image not found: " + imagePath);
                }

                FlpProduct.Controls.Add(ucProduct);

            }
        }
        public void ProductListPanal()
        {
            Database database = new Database();
            if (database.Connect_Db())
            {
                string query = "SELECT * FROM products where product_status LIKE 'O'";

                MySqlCommand mySqlCommand = new MySqlCommand(query, database.connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(mySqlCommand);
                DataTable dt1 = new DataTable();
                adapter.Fill(dt1);

                LoadUCPrd(dt1);

                database.Disconnect_db();
            }
            else
            {
                MessageBox.Show("ไม่สามารถเชื่อมต่อฐานข้อมูลได้");
            }
        }

        private void BtFind_Click(object sender, EventArgs e)
        {
            var database = new Database();
            if (database.Connect_Db())
            {
           
                if (RaAll.Checked)
                {
                    ProductListPanal();
                }
                else if (RaCat.Checked)
                {
                    if (!string.IsNullOrWhiteSpace(CbCatFind.SelectedValue?.ToString()))
                    {
                        string categoryId = CbCatFind.SelectedValue.ToString();
                        string categoryQuery = "SELECT * FROM products WHERE categorie_id = @CategoryId and product_status LIKE 'O'";
                        MySqlCommand command2 = new MySqlCommand(categoryQuery, database.connection);
                        command2.Parameters.AddWithValue("@CategoryId", categoryId);
                        MySqlDataAdapter adapter2 = new MySqlDataAdapter(command2);
                        DataTable dt2 = new DataTable();
                        adapter2.Fill(dt2);

                        if (dt2.Rows.Count > 0)
                        {
                            LoadUCPrd(dt2);
                        }
                        else
                        {
                            MessageBox.Show("ไม่พบสินค้าที่ค้นหา");
                            ProductListPanal();
                        }
                    }
                    else
                    {
                        MessageBox.Show("กรุณาเลือกหมวดหมู่สินค้า");
                    }
                }
                else if (RaId.Checked)
                {
                    if (!string.IsNullOrWhiteSpace(TxIdFind.Text))
                    {
                        string idQuery = "SELECT * FROM products WHERE (product_id LIKE @ProductId or product_name LIKE @ProductId) and  product_status = 'O'";
                        MySqlCommand command3 = new MySqlCommand(idQuery, database.connection);
                        command3.Parameters.AddWithValue("@ProductId","%"+TxIdFind.Text+"%");
                        MySqlDataAdapter adapter3 = new MySqlDataAdapter(command3);
                        DataTable dt3 = new DataTable();
                        adapter3.Fill(dt3);

                        if (dt3.Rows.Count > 0)
                        {
                            LoadUCPrd(dt3);
                        }
                        else
                        {
                            MessageBox.Show("ไม่พบสินค้าที่ค้นหา");
                            ProductListPanal();
                        }
                    }
                    else
                    {
                        MessageBox.Show("กรุณากรอกรหัสสินค้าที่ต้องการค้นหา");
                    }
                }
            }
        }
        private void Ra_disble()
        {
            TxIdFind.Enabled = false;
            CbCatFind.Enabled = false;
        }

        private void RaAll_CheckedChanged(object sender, EventArgs e)
        {
            Ra_disble();
            TxIdFind.Clear();
        }

        private void RaCat_CheckedChanged(object sender, EventArgs e)
        {
            TxIdFind.Enabled = false;
            CbCatFind.Enabled = true;
            TxIdFind.Clear();
        }

        private void RaId_CheckedChanged(object sender, EventArgs e)
        {
            TxIdFind.Enabled = true;
            CbCatFind.Enabled = false;
        }

        public void AddDataToDataTable(DataRow newRow)
        {
            Global.dtprd.Rows.Add(newRow);
            RefreshGrid();


        }
        public void RefreshGrid()
        {
            DgvPrd.DataSource = Global.dtprd;

            decimal total = 0;
            foreach (DataGridViewRow row in DgvPrd.Rows)
            {
                total += Convert.ToDecimal(row.Cells[4].Value);
            }

            LbSellPriceTotal.Text = total.ToString();

            Lbdis.Text = Global.ProSell2.ToString();

            decimal totalnet = (total - Global.ProSell2);
            if (totalnet <0)
            {
                totalnet = 0;
            }
            LbNETprice.Text = totalnet.ToString();

        }

        private void DgvPrd_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            decimal total = 0;
            foreach (DataGridViewRow row in DgvPrd.Rows)
            {
                total += Convert.ToDecimal(row.Cells[4].Value);
            }

            LbSellPriceTotal.Text = total.ToString();
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            DgvPrd.DataSource = null;
            Global.dtprd.Clear();
            Global.ProSell2 = 0;
            Global.ProSell = "";
            LbNETprice.Text = "";
            LbSellPriceTotal.Text = "";
            Lbdis.Text = "";
            LbProSell.Text="";
            RefreshGrid();
            SetupSell();

        }

        private void customButton1_Click(object sender, EventArgs e)
        {
            var database = new Database();
            string query = "";
            long lastid = 0;

            if (Global.ProSell == null)
            {
                Global.ProSell = "0";
            }
            if (DgvPrd.Rows.Count == 0)
            {
                MessageBox.Show("ไม่มีข้อมูล !!");
            }
            else
            {
                if (database.Connect_Db())
                {
                    query = "INSERT INTO `orders`(`order_dete`, `employee_id`, `promotion_id`)" +
                       $"VALUES(" +
                       $"'{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}'," +
                       $"'{Global.Id}'," +
                       $"'{Global.ProSell}'" +
                       $")";
                    try
                    {
                        MySqlCommand commandinsertOrUpdate = new MySqlCommand(query, database.connection);
                        int row = commandinsertOrUpdate.ExecuteNonQuery();
                        if (row > 0)
                        {


                            //MessageBox.Show("บันทึกข้อมูลสำเร็จ");
                            lastid = commandinsertOrUpdate.LastInsertedId;
                        }
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);

                    }
                }


                foreach (DataGridViewRow rows in DgvPrd.Rows)
                {
                    if (!rows.IsNewRow)
                    {
                        query = "INSERT INTO `orderdetail`(`order_id`, `orderdetail_quantity`, `level_id`, `product_id`)" +
                                                               $"VALUES(" +
                                                               //$"'{rowcount.ToString()}'," +
                                                               $"'{lastid}'," +
                                                               $"'{rows.Cells[3].Value}'," +
                                                               $"'{rows.Cells[5].Value}'," +
                                                               $"'{rows.Cells[0].Value}'" +
                                                               $")";



                        // MessageBox.Show(rows.Cells[5].ToString()) ;
                        try
                        {
                            MySqlCommand commandinsertOrUpdate = new MySqlCommand(query, database.connection);
                            int row = commandinsertOrUpdate.ExecuteNonQuery();
                            if (row > 0)
                            {




                            }
                        }
                        catch (Exception ex)
                        {

                            MessageBox.Show(ex.Message);

                        }
                    }
                }

                MessageBox.Show("บันทึกข้อมูลสำเร็จ");

                DgvPrd.DataSource = null;
                Global.dtprd.Clear();
                Global.ProSell2 = 0;
                Global.ProSell = "";
                LbNETprice.Text = "";
                LbSellPriceTotal.Text = "";
                Lbdis.Text = "";
                LbProSell.Text = "";

            }   

        }
    }
}
