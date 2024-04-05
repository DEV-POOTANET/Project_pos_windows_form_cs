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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
            bool b = true;
            TxPassword.UseSystemPasswordChar = b;
        }

        private void BtLogin_Click(object sender, EventArgs e)
        {
            Login(TxUsername.Text, TxPassword.Text);    
        }
        public void Login(string username, string password)
        {
            var database = new Database();
            if (database.Connect_Db())
            {
                try
                {
                    string query = "SELECT * FROM employees WHERE employee_username = @username AND employee_password = @password ";
                    
                    MySqlCommand command = new MySqlCommand(query, database.connection);

                    
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", password);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Global.Id = reader["employee_id"].ToString();
                            Global.Name = reader["employee_fname"].ToString();
                            int EmpLevel = Convert.ToInt32(reader["employee_level"]);

                            if (EmpLevel == 1)
                            {
                                Global.EmpLavel = "ผู้จัดการ";
                            }
                            else if (EmpLevel == 2)
                            {
                                Global.EmpLavel = "พนักงาน";
                            }
                            else
                            {
                                MessageBox.Show("ชื่อผู้ใช้หรือรหัสผ่านไม่ถูกต้อง");
                            }
                            MessageBox.Show("เข้าสู่ระบบสำเร็จ ระดับ: " + Global.EmpLavel,"เข้าสู่ระบบสำเร็จ",MessageBoxButtons.OK);
                            FrmMain frmMain = new FrmMain();
                            frmMain.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("ชื่อผู้ใช้หรือรหัสผ่านไม่ถูกต้อง");
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("เกิดข้อผิดพลาดในการเชื่อมต่อกับฐานข้อมูล: " + ex.Message);
                }
                finally
                {
                    database.Disconnect_db();
                }
            }
            else
            {
                MessageBox.Show("ไม่สามารถเชื่อมต่อฐานข้อมูลได้");
            }
        }

        private void BtExit_Click(object sender, EventArgs e)
        {           
                Application.Exit();            
        }

        private void BtClear_Click(object sender, EventArgs e)
        {
            TxUsername.Clear();
            TxPassword.Clear();
        }

        private void CbShowPass_CheckedChanged(object sender, EventArgs e)
        {
            bool b = CbShowPass.Checked;
            TxPassword.UseSystemPasswordChar = !b;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            TxUsername.Text="Pootanet";
            TxPassword.Text="0612161312";
            Login(TxUsername.Text, TxPassword.Text);
        }
    }
}
