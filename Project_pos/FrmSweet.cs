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
    public partial class FrmSweet : Form
    {
        public FrmSweet()
        {
            InitializeComponent();
        }

        private void FrmSweet_Load(object sender, EventArgs e)
        {
            Refresh_Grid();
            Disable_Screen();
            dgvSweet.Enabled =true;
            dgvSweet.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

  
        private void Clear_Data()
        {
            TxID.Clear();
            TxName.Clear();
        }
        private void Enable_Screen()
        {
            TxID.Enabled = true;
            TxName.Enabled = true;
            dgvSweet.Enabled = true;
        }
        private void Disable_Screen()
        {
            TxID.Enabled = false;
            TxName.Enabled = false;
            dgvSweet.Enabled = false;
        }
        private void Refresh_Grid()
        {
            var database = new Database();
            if (database.Connect_Db())
            {
                string query1 = "SELECT level_id, orderlevel_level FROM orderlevel";

                MySqlCommand command1 = new MySqlCommand(query1, database.connection);
                MySqlDataAdapter adapter1 = new MySqlDataAdapter();
                adapter1.SelectCommand = command1;
                DataTable dt1 = new DataTable();
                adapter1.Fill(dt1);
                dgvSweet.DataSource = dt1;

                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = dt1;

                dgvSweet.DataSource = bindingSource;

                dgvSweet.Columns["level_id"].HeaderText = "รหัสความหวาน";
                dgvSweet.Columns["orderlevel_level"].HeaderText = "ชื่อความหวาน";
            }
        }

        private void BtAdd_Click(object sender, EventArgs e)
        {
            Clear_Data();
            Refresh_Grid();
            Enable_Screen();
            TxID.Focus();
            dgvSweet.Enabled = false;
        }

        private void BtEdit_Click(object sender, EventArgs e)
        {
            Enable_Screen();
            TxName.Focus();
            TxID.Enabled = false;
        }

        private void BtDel_Click(object sender, EventArgs e)
        {
            if (TxID.Text == "")
            {

            }
            else if (MessageBox.Show("ต้องการลบข้อมูล !!!", "ลบข้อมูล", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var database = new Database();
                try
                {
                    if (database.Connect_Db())
                    {
                        string query = "DELETE FROM orderlevel WHERE level_id = '" + TxID.Text + "'";
                        MySqlCommand command = new MySqlCommand(query, database.connection);
                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    TxID.Focus();
                }
                Refresh_Grid();
                Clear_Data();
                Enable_Screen();
                TxID.Focus();
            }
        }

        private void BtSave_Click(object sender, EventArgs e)
        {
            var database = new Database();
            string query = "SELECT * FROM orderlevel WHERE level_id = '" + TxID.Text + "'";
            MySqlCommand command = new MySqlCommand(query, database.connection);
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            adapter.SelectCommand = command;
            DataTable dt = new DataTable();
            int rowAffected = adapter.Fill(dt);
            if (database.Connect_Db())
            {
                if (TxID.Text == "" || TxName.Text == "")
                {
                    MessageBox.Show("คุณป้อนข้อมูลไม่ครบ !!");
                    TxID.Focus();
                }
                else if (!int.TryParse(TxID.Text, out int ssn))
                {
                    MessageBox.Show("รหัสความหวานต้องเป็นตัวเลขเท่านั้น");
                    TxID.Focus();
                }
                else if (rowAffected == 0)
                {
                    query = "INSERT INTO orderlevel (level_id, orderlevel_level )" +                        
                        $"VALUES(" +
                        $"'{TxID.Text}'," +
                        $"'{TxName.Text}'" +                      
                        $")";
                }
                else
                {
                    query = "UPDATE orderlevel SET " +
                        $"orderlevel_level = '{TxName.Text}'" +    
                         $"WHERE level_id = {TxID.Text}";
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
                        TxID.Focus();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    TxID.Focus();
                }
            }
        }

        private void BtCancel_Click(object sender, EventArgs e)
        {
            Clear_Data();
            Disable_Screen();
            Refresh_Grid();
            dgvSweet.Enabled = true;
        }

        private void dgvSweet_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvSweet.Rows[e.RowIndex].Cells["level_id"].Value.ToString() == "")
                {
                    MessageBox.Show("กรุณาเลือกที่มีข้อมูลด้วยครับ", "กรุณาเลือกข้อมูลให้ถูกต้อง", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    TxID.Text = dgvSweet.Rows[e.RowIndex].Cells["level_id"].Value.ToString();
                    TxName.Text = dgvSweet.Rows[e.RowIndex].Cells["orderlevel_level"].Value.ToString();                    

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
