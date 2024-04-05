using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Project_pos
{
    public partial class FrmEmp : Form
    {
        public FrmEmp()
        {
            InitializeComponent();
        }

        private void FrmEmp_Load(object sender, EventArgs e)
        {
            Refresh_Grid();
            Disable_Screen();
            DgvEmp.Enabled = true;
            DgvEmp.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void Clear_Data()
        {
            TxId.Clear();
            TxFname.Clear();
            TxLname.Clear();
            TxUname.Clear();
            TxPass.Clear();
            RaMa.Checked= false;
            RaEmp.Checked= false;
        }
        private void Enable_Screen()
        {
            TxId.Enabled= true; 
            TxFname.Enabled = true;
            TxLname.Enabled = true;
            TxUname.Enabled = true;
            TxPass.Enabled = true;
            RaMa.Enabled = true;
            RaEmp.Enabled = true;
        }
        private void Disable_Screen()
        {
            TxId.Enabled = false;
            TxFname.Enabled = false;
            TxLname.Enabled = false;
            TxUname.Enabled = false;
            TxPass.Enabled = false;
            RaMa.Enabled = false;
            RaEmp.Enabled = false;
        }
        private void Refresh_Grid()
        {
            var database = new Database();
            if (database.Connect_Db())
            {
                string query1 = "SELECT employee_id, employee_username, employee_password, employee_fname, employee_lname, employee_level FROM employees";

                MySqlCommand command1 = new MySqlCommand(query1, database.connection);
                MySqlDataAdapter adapter1 = new MySqlDataAdapter();
                adapter1.SelectCommand = command1;
                DataTable dt1 = new DataTable();
                adapter1.Fill(dt1);

                foreach (DataRow row in dt1.Rows)
                {
                    string employeeLevel = row["employee_level"].ToString();
                    if (employeeLevel == "1")
                    {
                        row["employee_level"] = "ผู้จัดการ";
                    }
                    else if (employeeLevel == "2")
                    {
                        row["employee_level"] = "พนักงาน";
                    }
                }

                DgvEmp.DataSource = dt1;

                DgvEmp.Columns["employee_id"].HeaderText = "รหัส";
                DgvEmp.Columns["employee_username"].HeaderText = "ชื่อผู้ใช้";
                DgvEmp.Columns["employee_password"].Visible = false;
                DgvEmp.Columns["employee_fname"].HeaderText = "ชื่อ";
                DgvEmp.Columns["employee_lname"].HeaderText = "สกุล";
                DgvEmp.Columns["employee_level"].HeaderText = "ระดับ";
            }
        }

        private void BtAdd_Click(object sender, EventArgs e)
        {
            Clear_Data();
            Refresh_Grid();
            Enable_Screen();
            TxId.Focus();
            DgvEmp.Enabled = false;
        }

        private void BtEdit_Click(object sender, EventArgs e)
        {
            Enable_Screen();
            TxFname.Focus();
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
                        string query = "DELETE FROM employees WHERE employee_id = '" + TxId.Text + "'";
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
                Disable_Screen();
            }
        }

        private void BtSave_Click(object sender, EventArgs e)
        {
            string level = "0";
            var database = new Database();
            string query = "SELECT * FROM employees WHERE employee_id = '" + TxId.Text + "'";
            MySqlCommand command = new MySqlCommand(query, database.connection);
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            adapter.SelectCommand = command;
            DataTable dt = new DataTable();
            int rowAffected = adapter.Fill(dt);

            if (database.Connect_Db())
            {
                if (TxId.Text == "" || TxFname.Text == "" || TxLname.Text == "" || TxUname.Text == "" || TxPass.Text == "")
                {
                    MessageBox.Show("คุณป้อนข้อมูลไม่ครบ !!");
                    TxId.Focus();
                }
                else if (!int.TryParse(TxId.Text, out int ssn))
                {
                    MessageBox.Show("รหัสพนักงานต้องเป็นตัวเลขเท่านั้น");
                    TxId.Focus();
                }
                else if (!RaEmp.Checked && !RaMa.Checked)
                {
                    MessageBox.Show("กรุณาเลือกสิทธิ์การใช้งาน");
                }
                else
                {
                    if (RaEmp.Checked)
                    {
                        level = "2";
                    }
                    else if (RaMa.Checked)
                    {
                        level = "1";
                    }
                    if (rowAffected == 0)
                    {
                        string username = TxUname.Text;
                        string checkUsernameQuery = "SELECT COUNT(*) FROM employees WHERE employee_username = @Username";
                        MySqlCommand checkUsernameCommand = new MySqlCommand(checkUsernameQuery, database.connection);
                        checkUsernameCommand.Parameters.AddWithValue("@Username", username);
                        int usernameCount = Convert.ToInt32(checkUsernameCommand.ExecuteScalar());

                        if (usernameCount > 0)
                        {
                            MessageBox.Show("Username นี้มีอยู่ในระบบแล้ว โปรดเลือก Username อื่น");
                            return;
                        }

                        query = "INSERT INTO employees (employee_id, employee_username,employee_password,employee_fname,employee_lname,employee_level )" +
                            $"VALUES(" +
                            $"'{TxId.Text}'," +
                            $"'{TxUname.Text}'," +
                            $"'{TxPass.Text}'," +
                            $"'{TxFname.Text}'," +
                            $"'{TxLname.Text}'," +
                            $"'{level}'" +
                            $")";
                    }
                    else
                    {
                        string username = TxUname.Text;
                        string employeeid = TxId.Text;
                        string checkUsernameQuery = "SELECT COUNT(*) FROM employees WHERE employee_username = @Username AND employee_id != @EmployeeId";
                        MySqlCommand checkUsernameCommand = new MySqlCommand(checkUsernameQuery, database.connection);
                        checkUsernameCommand.Parameters.AddWithValue("@Username", username);
                        checkUsernameCommand.Parameters.AddWithValue("@EmployeeId", employeeid);
                        int usernameCount = Convert.ToInt32(checkUsernameCommand.ExecuteScalar());

                        if (usernameCount > 0)
                        {
                            MessageBox.Show("Username นี้มีอยู่ในระบบแล้ว โปรดเลือก Username อื่น");
                            return;
                        }

                        query = "UPDATE employees  SET " +
                            $"employee_username = '{TxUname.Text}'," +
                            $"employee_password = '{TxPass.Text}'," +
                            $"employee_fname = '{TxFname.Text}'," +
                            $"employee_lname = '{TxLname.Text}'," +
                            $"employee_level = '{level}' " +
                            $"WHERE employee_id = {TxId.Text}";
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
                            Disable_Screen();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        TxId.Focus();
                    }
                }

                
            }


        }

        private void BtCancel_Click(object sender, EventArgs e)
        {
            Clear_Data();
            Disable_Screen();
            Refresh_Grid();
            DgvEmp.Enabled = true;
        }

        private void DgvEmp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (DgvEmp.Rows[e.RowIndex].Cells["employee_id"].Value.ToString() == "")
                {
                    MessageBox.Show("กรุณาเลือกที่มีข้อมูลด้วยครับ", "กรุณาเลือกข้อมูลให้ถูกต้อง", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    TxId.Text = DgvEmp.Rows[e.RowIndex].Cells["employee_id"].Value.ToString();
                    TxUname.Text = DgvEmp.Rows[e.RowIndex].Cells["employee_username"].Value.ToString();
                    TxPass.Text = DgvEmp.Rows[e.RowIndex].Cells["employee_password"].Value.ToString();
                    TxFname.Text = DgvEmp.Rows[e.RowIndex].Cells["employee_fname"].Value.ToString();
                    TxLname.Text = DgvEmp.Rows[e.RowIndex].Cells["employee_lname"].Value.ToString();
                    if (DgvEmp.Rows[e.RowIndex].Cells["employee_level"].Value.ToString() == "ผู้จัดการ")
                    {
                        RaEmp.Checked = false;
                        RaMa.Checked= true;
                    }else if(DgvEmp.Rows[e.RowIndex].Cells["employee_level"].Value.ToString() == "พนักงาน")
                    {
                        RaEmp.Checked = true;
                        RaMa.Checked = false;
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
