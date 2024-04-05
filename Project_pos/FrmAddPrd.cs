using MySql.Data.MySqlClient;
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
    public partial class FrmAddPrd : Form
    {
        public FrmAddPrd()
        {
            InitializeComponent();
            LbName.Text = Global.SellPrdName;
            LoadCb();
            NudQty.Value=1;
        }
        
        public void LoadCb()
        {
            var database = new Database();
            if (database.Connect_Db())
            {
                string query1 = "SELECT * FROM orderlevel";             

                MySqlCommand command1 = new MySqlCommand(query1, database.connection);
      
                MySqlDataAdapter adapter1 = new MySqlDataAdapter();
                adapter1.SelectCommand = command1;

                DataTable dt1 = new DataTable();
                adapter1.Fill(dt1);

                CbLev.DataSource = dt1;
                CbLev.DisplayMember = "orderlevel_level";
                CbLev.ValueMember = "level_id";

            }
        }
        private void FrmAddPrd_Load(object sender, EventArgs e)
        {

        }

        private void BtClose_Click(object sender, EventArgs e)
        {
            this.Close();
           
        }

        private bool Checkdataintable(DataTable dataTable, string targetID,string SellPrdLev)
        {
            foreach (DataRow row in dataTable.Rows)
            {
                string currentID = Convert.ToString(row["รหัสสินค้า"]);
                string sweet = Convert.ToString(row["ความหวาน"]);
                if (currentID == targetID&& sweet == SellPrdLev)
                {
                    return true;
                }
            }
            return false;
        }

        private int FineQuantityByID(string id)
        {
            foreach (DataRow row in Global.dtprd.Rows)
            {
                string currentID = Convert.ToString(row["รหัสสินค้า"]);

                if (currentID == id)
                {
                    int quantityInGridView = Convert.ToInt32(row["จำนวน"]);
                    return quantityInGridView;
                }
            }
            return -1;
        }

        private void UpdateQuantityByID(string id, int newQuantity, float totalprice)
        {
            foreach (DataRow row in Global.dtprd.Rows)
            {
                string currentID = Convert.ToString(row["รหัสสินค้า"]);
                if (currentID == id)
                {
                    row["จำนวน"] = newQuantity;
                    row["ราคารวม"] = totalprice;
                    break;
                }
            }
        }


        private void BtAddPrd_Click(object sender, EventArgs e)
        {
            if (NudQty.Value == 0)
            {
                MessageBox.Show("กรุณากรอกจำนวนที่ต้องการเพิ่ม");
            }
            else
            {
                Global.SellPrdQty = Convert.ToInt32(NudQty.Value);
                Global.SellPrdLev = CbLev.SelectedValue.ToString();
                Global.SellPrdPriceTotal = Global.SellPrdQty * Global.SellPrdPrice;
                DialogResult result = MessageBox.Show("คุณต้องการที่จะเพิ่ม" + Global.SellPrdName + " จำนวน" + Global.SellPrdQty + "แก้ว ใช่หรือไม่", "ยืนยัน", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                DataRow newRow = Global.dtprd.NewRow();
                if (result == DialogResult.Yes)
                {

                    if (!Global.dtprd.Columns.Contains("รหัสสินค้า"))
                    {
                        Global.dtprd.Columns.Add("รหัสสินค้า", typeof(string));
                        Global.dtprd.Columns.Add("สินค้า", typeof(string));
                        Global.dtprd.Columns.Add("ราคา", typeof(string));
                        Global.dtprd.Columns.Add("จำนวน", typeof(string));
                        Global.dtprd.Columns.Add("ราคารวม", typeof(string));
                        Global.dtprd.Columns.Add("ความหวาน", typeof(string));
                     
                    }


                    bool check1 = Checkdataintable(Global.dtprd,Global.SellPrdId,Global.SellPrdLev);
                    if (check1 == true) {
                       int oldqty = FineQuantityByID(Global.SellPrdId);
                       int totalqty = oldqty + Global.SellPrdQty;
                        Global.SellPrdPriceTotal = totalqty * Global.SellPrdPrice;                        
                        UpdateQuantityByID(Global.SellPrdId,totalqty, Global.SellPrdPriceTotal);



                        FrmSell FrmSell = Application.OpenForms.OfType<FrmSell>().FirstOrDefault();
                        FrmSell.RefreshGrid();


                    }
                    else
                    {

                        newRow["รหัสสินค้า"] = Global.SellPrdId;
                        newRow["สินค้า"] = Global.SellPrdName;
                        newRow["ราคา"] = Global.SellPrdPrice;
                        newRow["จำนวน"] = Global.SellPrdQty;
                        newRow["ราคารวม"] = Global.SellPrdPriceTotal;
                        newRow["ความหวาน"] = Global.SellPrdLev;

                       
                        FrmSell FrmSell = Application.OpenForms.OfType<FrmSell>().FirstOrDefault();
                        if (FrmSell != null)
                        {
                            FrmSell.AddDataToDataTable(newRow);
                            FrmSell.RefreshGrid();
                        }

                    }

                   
                    this.Close();
                }
                else
                {
                    Global.SellPrdId = "";
                    Global.SellPrdName = "";
                    Global.SellPrdPrice = 0;
                    Global.SellPrdCatID = "";
                    Global.SellPrdQty = 0;
                    Global.SellPrdLev = "";
                    Global.SellPrdPriceTotal = 0;
                }
            }
        }

        private void FrmAddPrd_FormClosed(object sender, FormClosedEventArgs e)
        {
            Global.SellPrdId = "";
            Global.SellPrdName = "";
            Global.SellPrdPrice = 0;
            Global.SellPrdCatID = "";
        }




    }
}
