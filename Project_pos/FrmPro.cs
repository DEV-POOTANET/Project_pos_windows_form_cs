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
using System.Xml.Linq;

namespace Project_pos
{
    public partial class FrmPro : Form
    {
        public FrmPro()
        {
            InitializeComponent();
        }

        private void FrmPro_Load(object sender, EventArgs e)
        {
            Refresh_Grid();
            Disable_Screen();
            DgvPro.Enabled = true;
            DgvPro.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void Clear_Data()
        {
            TxId.Clear();
            TxDis.Clear();
            TxDetail.Clear();
            DtStart.Value = DateTime.Now;
            DtEnd.Value = DateTime.Now;
        }
        private void Enable_Screen()
        {
            TxId.Enabled = true;
            TxDis.Enabled = true;
            TxDetail.Enabled = true;
            DtStart.Enabled = true;
            DtEnd.Enabled = true;
        }
        private void Disable_Screen()
        {
            TxId.Enabled = false;
            TxDis.Enabled = false;
            TxDetail.Enabled = false;
            DtStart.Enabled = false;
            DtEnd.Enabled = false;
        }
        private void Refresh_Grid()
        {
            var database = new Database();
            if (database.Connect_Db())
            {
                string query1 = "SELECT promotion_id, promotion_discount,pomotion_detail,promotion_dete_start,promotion_dete_end FROM Promotions";

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
                DgvPro.Columns["pomotion_detail"].HeaderText = "รายละเอียดส่วนลด";
                DgvPro.Columns["promotion_dete_start"].HeaderText = "วันเริ่มส่วนลด";
                DgvPro.Columns["promotion_dete_end"].HeaderText = "วันหมดส่วนลด";
            }
        }
        private void BtAdd_Click(object sender, EventArgs e)
        {
            Clear_Data();
            Refresh_Grid();
            Enable_Screen();
            TxId.Focus();
            DgvPro.Enabled = false;
        }

        private void BtEdit_Click(object sender, EventArgs e)
        {
            Enable_Screen();
            TxDis.Focus();
            TxId.Enabled = false;
        }

        private void BtDel_Click(object sender, EventArgs e)
        {
            if (TxId.Text == "")
            {

            }
            else if (MessageBox.Show("ต้องการลบข้อมูล !!!", "ลบข้อมูล", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var database = new Database();
                try
                {
                    if (database.Connect_Db())
                    {
                        string query = "DELETE FROM Promotions WHERE promotion_id = '" + TxId.Text + "'";
                        MySqlCommand command = new MySqlCommand(query, database.connection);
                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    TxId.Focus();
                }
                Refresh_Grid();
                Clear_Data();
                Enable_Screen();
                TxId.Focus();
            }
        }

        private void BtSave_Click(object sender, EventArgs e)
        {
            var database = new Database();
            string query = "SELECT * FROM Promotions WHERE promotion_id = '" + TxId.Text + "'";
            MySqlCommand command = new MySqlCommand(query, database.connection);
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            adapter.SelectCommand = command;
            DataTable dt = new DataTable();
            int rowAffected = adapter.Fill(dt);
            if (database.Connect_Db())
            {
                if (TxId.Text == "" || TxDis.Text == "" || TxDetail.Text == "" || DtStart.Text == "" || DtEnd.Text == "")
                {
                    MessageBox.Show("คุณป้อนข้อมูลไม่ครบ !!");
                    TxId.Focus();
                }
                else if (!int.TryParse(TxId.Text, out int ssn))
                {
                    MessageBox.Show("รหัสหมวดหมู่ต้องเป็นตัวเลขเท่านั้น");
                    TxId.Focus();
                }
                else if (!int.TryParse(TxDis.Text, out int ssn2))
                {
                    MessageBox.Show("ส่วนลดต้องเป็นตัวเลขเท่านั้น");
                    TxId.Focus();
                }
                else if (rowAffected == 0)
                {
                    query = "INSERT INTO promotions (promotion_id, promotion_discount,pomotion_detail,promotion_dete_start,promotion_dete_end )" +
                        $"VALUES(" +
                        $"'{TxId.Text}'," +
                        $"'{TxDis.Text}'," +
                        $"'{TxDetail.Text}'," +
                        $"'{DtStart.Text}'," +
                        $"'{DtEnd.Text}'" +
                        $")";
                }
                else
                {
                    query = "UPDATE promotions SET " +
                        $"promotion_discount = '{TxDis.Text}'," +
                        $"pomotion_detail = '{TxDetail.Text}'," +
                        $"promotion_dete_start = '{DtStart.Text}'," +
                        $"promotion_dete_end = '{DtEnd.Text}' " +
                         $"WHERE promotion_id = {TxId.Text}";
                }
                try
                {
                    MySqlCommand commandinsertOrUpdate = new MySqlCommand(query, database.connection);
                    int row = commandinsertOrUpdate.ExecuteNonQuery();
                    if (row > 0)
                    {
                        MessageBox.Show("บันทึกข้อมูลสำเร็จ");
                        Refresh_Grid();
                        Clear_Data();
                        Enable_Screen();
                        TxId.Focus();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    TxDis.Focus();
                }
            }
        }

        private void BtCancel_Click(object sender, EventArgs e)
        {
            Clear_Data();
            Disable_Screen();
            Refresh_Grid();
            DgvPro.Enabled = true;
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
                    TxId.Text = DgvPro.Rows[e.RowIndex].Cells["promotion_id"].Value.ToString();
                    TxDis.Text = DgvPro.Rows[e.RowIndex].Cells["promotion_discount"].Value.ToString();
                    TxDetail.Text = DgvPro.Rows[e.RowIndex].Cells["pomotion_detail"].Value.ToString();
                    DtStart.Text = DgvPro.Rows[e.RowIndex].Cells["promotion_dete_start"].Value.ToString();
                    DtEnd.Text = DgvPro.Rows[e.RowIndex].Cells["promotion_dete_end"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
