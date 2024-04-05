using MySql.Data.MySqlClient;
using System;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Project_pos
{
    public partial class FrmPrd : Form
    {
        public OpenFileDialog opnfd = new OpenFileDialog();
        public string FilenameFromRow;
        public string filename;
        public string filenameUpload;
        public string path = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));

        public FrmPrd()
        {
            InitializeComponent();
        }

        private void FrmPrd_Load(object sender, EventArgs e)
        {
            Refresh_Grid();
            Disable_Screen();
            BtSave.Enabled = false;
            Ra_disble();
            RaAll.Checked = true;
        }
        private void Clear_Data()
        {
            TxId.Clear();
            TxName.Clear();
            TxDtl.Clear();
            TxPrice.Clear();
        }
        private void Enable_Screen()
        {
            TxId.Enabled = true;
            TxName.Enabled = true;
            TxPrice.Enabled = true;
            TxCat.Enabled = true;
            TxDtl.Enabled = true;
            BtImport.Enabled = true;
            RaOpent.Enabled = true;
            RaClose.Enabled = true;
        }
        private void Disable_Screen()
        {
            TxId.Enabled = false;
            TxName.Enabled = false;
            TxPrice.Enabled = false;
            TxCat.Enabled = false;
            TxDtl.Enabled = false;
            BtImport.Enabled = false;
            RaOpent.Enabled = false;
            RaClose.Enabled = false;
        }
        private void Refresh_Grid()
        {
            var database = new Database();
            if (database.Connect_Db())
            {
                string query1 = "SELECT * FROM products";
                string CateQuery = "SELECT * FROM categories";
                string CateFindQuery = "SELECT * FROM categories";

                MySqlCommand command1 = new MySqlCommand(query1, database.connection);
                MySqlCommand command2 = new MySqlCommand(CateQuery, database.connection);
                MySqlCommand command3 = new MySqlCommand(CateFindQuery, database.connection);


                MySqlDataAdapter adapter1 = new MySqlDataAdapter();
                adapter1.SelectCommand = command1;
                MySqlDataAdapter adapter2 = new MySqlDataAdapter();
                adapter2.SelectCommand = command2;
                MySqlDataAdapter adapter3 = new MySqlDataAdapter();
                adapter3.SelectCommand = command3;


                DataTable dt1 = new DataTable();
                adapter1.Fill(dt1);
                DataTable dt2 = new DataTable();
                adapter2.Fill(dt2);
                DataTable dt3 = new DataTable();
                adapter3.Fill(dt3);

                foreach (DataRow row in dt1.Rows)
                {
                    string employeeLevel = row["product_status"].ToString();
                    if (employeeLevel == "O")
                    {
                        row["product_status"] = "เปิดการขาย";
                    }
                    else if (employeeLevel == "C")
                    {
                        row["product_status"] = "ปิดการขาย";
                    }
                }
                DgvProduct.DataSource = dt1;
                DgvProduct.Columns["product_id"].HeaderText = "รหัสสินค้า";
                DgvProduct.Columns["product_name"].HeaderText = "ชื่อสินค้า";
                DgvProduct.Columns["product_detail"].HeaderText = "รายละเอียด";
                DgvProduct.Columns["product_price"].Visible = false;
                //DgvProduct.Columns["categorie_id "].HeaderText = "หมวกหมู่";
                DgvProduct.Columns["product_status"].HeaderText = "สถานะ";
                /// Categories Combobox
                TxCat.DataSource = dt2;
                TxCat.DisplayMember = "categorie_name";
                TxCat.ValueMember = "categorie_id";

                CbCatFind.DataSource = dt3; 
                CbCatFind.DisplayMember = "categorie_name";
                CbCatFind.ValueMember = "categorie_id";

            }
        }

        private void DgvProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // ตรวจสอบว่าเราคลิกที่แถวที่มีข้อมูลหรือไม่
                if (e.RowIndex >= 0 && DgvProduct.Rows[e.RowIndex].Cells["categorie_id"].Value != null)
                {
                    TxId.Text = DgvProduct.Rows[e.RowIndex].Cells["product_id"].Value.ToString();
                    TxName.Text = DgvProduct.Rows[e.RowIndex].Cells["product_name"].Value.ToString();
                    TxDtl.Text = DgvProduct.Rows[e.RowIndex].Cells["product_detail"].Value.ToString();
                    TxPrice.Text = DgvProduct.Rows[e.RowIndex].Cells["product_price"].Value.ToString();

                    TxCat.SelectedValue = DgvProduct.Rows[e.RowIndex].Cells["categorie_id"].Value.ToString();

                    // ตรวจสอบสถานะสินค้าและตั้งค่า RadioButton ตามนั้น
                    if (DgvProduct.Rows[e.RowIndex].Cells["product_status"].Value.ToString() == "เปิดการขาย")
                    {
                        RaOpent.Checked = true;
                        RaClose.Checked = false;
                    }
                    else if (DgvProduct.Rows[e.RowIndex].Cells["product_status"].Value.ToString() == "ปิดการขาย")
                    {
                        RaOpent.Checked = false;
                        RaClose.Checked = true;
                    }

                    // ตั้งค่าที่อยู่ของรูปภาพและแสดงภาพใน PictureBox
                    path = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));
                    FilenameFromRow = DgvProduct.Rows[e.RowIndex].Cells["product_img"].Value.ToString();
                    //PicProduct.Image = new Bitmap(path + "\\Image\\" + FilenameFromRow);
                    PicProduct.Image = Bitmap.FromFile(path + "\\Image\\" + FilenameFromRow);


                    // ปิดการใช้งานปุ่มบันทึก
                    BtSave.Enabled = false;
                }
                else
                {
                    MessageBox.Show("กรุณาเลือกแถวที่มีข้อมูล", "เลือกข้อมูลไม่ถูกต้อง", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("เกิดข้อผิดพลาด: " + ex.Message);
            }
        }

        private void BtImport_Click(object sender, EventArgs e)
        {
            opnfd.Filter = "Image Files (*.jpg;*.jpeg;*.gif;*.png)|*.jpg;*.jpeg;*.gif;*.png";

            if (opnfd.ShowDialog() == DialogResult.OK)
            {
                if (File.Exists(opnfd.FileName))
                {
                    try
                    {
                        string selectedFileName = System.IO.Path.GetFileNameWithoutExtension(opnfd.FileName);
                        string fileExtension = System.IO.Path.GetExtension(opnfd.FileName);

                        // สร้างชื่อไฟล์ใหม่โดยรวมกับวันที่และเวลา
                        string newFileName = selectedFileName + "_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + fileExtension;

                        string destinationFilePath = Path.Combine(path + "\\Image\\", newFileName);

                        if (File.Exists(destinationFilePath))
                        {
                            MessageBox.Show("A file with the same name already exists. Please choose a different file name.", "Duplicate File Name", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            PicProduct.Image = new Bitmap(opnfd.FileName);
                            filenameUpload = newFileName;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error loading image: " + ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("The selected file does not exist.");
                }
            }
        }

        private void BtSave_Click(object sender, EventArgs e)
        {
            // ตรวจสอบว่ามีการเลือกไฟล์รูปภาพหรือไม่
            if (!string.IsNullOrEmpty(filenameUpload))
            {
                // คัดลอกไฟล์รูปภาพไปยังโฟลเดอร์ที่เก็บรูปภาพ
                string destinationPath = Path.Combine(path, "Image", filenameUpload);
                File.Copy(opnfd.FileName, destinationPath, true);
            }

            var database = new Database();
            string query = "SELECT * FROM products WHERE product_id ='" + TxId.Text + "'";
            MySqlCommand command = new MySqlCommand(query, database.connection);
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            adapter.SelectCommand = command;
            DataTable dt = new DataTable();
            int rowAffected = adapter.Fill(dt);
            if (database.Connect_Db())
            {
                try
                {
                    char status = RaOpent.Checked ? 'O' : RaClose.Checked ? 'C' : 'a';

                    if (filenameUpload != "")
                    {
                        filename = filenameUpload;
                    }

                    if (string.IsNullOrWhiteSpace(TxId.Text) || string.IsNullOrWhiteSpace(TxName.Text) ||
                        string.IsNullOrWhiteSpace(TxPrice.Text) || string.IsNullOrWhiteSpace(TxCat.Text) ||
                        status == 'a')
                    {
                        MessageBox.Show("กรุณากรอกข้อมูลให้ครบทุกช่อง");
                        return;
                    }

                    if (!int.TryParse(TxId.Text, out _))
                    {
                        MessageBox.Show("รหัสสินค้าต้องเป็นตัวเลข");
                        return;
                    }

                    if (string.IsNullOrEmpty(filename))
                    {
                        MessageBox.Show("กรุณาอัพโหลดรูปภาพ");
                        return;
                    }

                    if (!float.TryParse(TxPrice.Text, out _))
                    {
                        MessageBox.Show("ราคาต้องเป็นตัวเลขเเท่านั้น");
                        return;
                    }

                    if (TxId.Text.Length > 5)
                    {
                        MessageBox.Show("กรุณากรอกรหัสไม่เกิน 5 ตัวอักษร");
                        return;
                    }
                    if (TxName.Text.Length > 20)
                    {
                        MessageBox.Show("กรุณากรอกชื่อไม่เกิน 20 ตัวอักษร");
                        return;
                    }
                  


                    if (rowAffected == 0)
                    {
                        query = "INSERT INTO products (product_id, product_name, product_detail, product_price, categorie_id, product_status, product_img) " +
                                "VALUES (@ProductId, @ProductName, @ProductDetail, @ProductPrice, @CategoryId, @ProductStatus, @ProductImg)";
                    }
                    else
                    {
                        query = "UPDATE products SET " +
                                "product_name = @ProductName, " +
                                "product_detail = @ProductDetail, " +
                                "product_price = @ProductPrice, " +
                                "categorie_id = @CategoryId, " +
                                "product_status = @ProductStatus, " +
                                "product_img = @ProductImg " +
                                "WHERE product_id = @ProductId";
                    }

                    using (var command1 = new MySqlCommand(query, database.connection))
                    {
                        command1.Parameters.AddWithValue("@ProductId", TxId.Text);
                        command1.Parameters.AddWithValue("@ProductName", TxName.Text);
                        command1.Parameters.AddWithValue("@ProductDetail", TxDtl.Text);
                        command1.Parameters.AddWithValue("@ProductPrice", TxPrice.Text);
                        command1.Parameters.AddWithValue("@CategoryId", TxCat.SelectedValue);
                        command1.Parameters.AddWithValue("@ProductStatus", status);
                        command1.Parameters.AddWithValue("@ProductImg", filename);

                        int rowsAffected = command1.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("บันทึกข้อมูลสำเร็จ");
                            Refresh_Grid();
                            Clear_Data();
                            Disable_Screen();
                            path = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));
                            PicProduct.Image = new Bitmap(path + "\\Resources\\coffee-cup.png");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("เกิดข้อผิดพลาด: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("ไม่สามารถเชื่อมต่อฐานข้อมูลได้");
            }
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
                        string query = "DELETE FROM products WHERE product_id = '" + TxId.Text + "'";
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
                BtSave.Enabled = false;
                TxId.Focus();
                RaClose.Checked = false;
                RaOpent.Checked = false;
                path = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));
                PicProduct.Image = new Bitmap(path + "\\Resources\\coffee-cup.png");

            }
        }

        private void BtCancel_Click(object sender, EventArgs e)
        {
            Clear_Data();
            Disable_Screen();
            Refresh_Grid();
            path = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));
            PicProduct.Image = new Bitmap(path + "\\Resources\\coffee-cup.png");
            filename = "";
            FilenameFromRow = "";
            BtSave.Enabled = false;
        }

        private void BtEdit_Click(object sender, EventArgs e)
        {
            filenameUpload = "";
            filename = FilenameFromRow;
            Enable_Screen();
            TxName.Focus();
            TxId.Enabled = false;
            BtSave.Enabled = true;
            opnfd.FileName = "";
        }

        private void BtAdd_Click(object sender, EventArgs e)
        {
            Clear_Data();
            Refresh_Grid();
            Enable_Screen();
            TxId.Focus();
            path = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));
            PicProduct.Image = new Bitmap(path + "\\Resources\\coffee-cup.png");
            BtSave.Enabled = true;

            filename = "";
            filenameUpload = "";
            FilenameFromRow = "";
            opnfd.Reset();
        }

        private void Ra_disble()
        {
            TxIdFind.Enabled = false;
            CbCatFind.Enabled = false;
        }

        private void BtFind_Click(object sender, EventArgs e)
        {
            var database = new Database();
            if (database.Connect_Db())
            {
                string query1All = "SELECT * FROM products";
                MySqlCommand command1 = new MySqlCommand(query1All, database.connection);
                MySqlDataAdapter adapter1 = new MySqlDataAdapter(command1);
                DataTable dt1 = new DataTable();
                adapter1.Fill(dt1);

                if (RaAll.Checked)
                {
                    DgvProduct.DataSource = dt1;
                }
                else if (RaCat.Checked)
                {
                    if (!string.IsNullOrWhiteSpace(CbCatFind.SelectedValue?.ToString()))
                    {
                        string categoryId = CbCatFind.SelectedValue.ToString();
                        string categoryQuery = "SELECT * FROM products WHERE categorie_id = @CategoryId";
                        MySqlCommand command2 = new MySqlCommand(categoryQuery, database.connection);
                        command2.Parameters.AddWithValue("@CategoryId", categoryId);
                        MySqlDataAdapter adapter2 = new MySqlDataAdapter(command2);
                        DataTable dt2 = new DataTable();
                        adapter2.Fill(dt2);

                        if (dt2.Rows.Count > 0)
                        {
                            DgvProduct.DataSource = dt2;
                        }
                        else
                        {
                            MessageBox.Show("ไม่พบสินค้าที่ค้นหา");
                            Refresh_Grid();
                        }
                    }
                    else
                    {
                        MessageBox.Show("กรุณาเลือกหมวดหมู่สินค้า");
                    }
                }
                else if (RaId.Checked)
                {
                    if (!string.IsNullOrWhiteSpace(TxIdFind.Text) && int.TryParse(TxIdFind.Text, out int productId))
                    {
                        string idQuery = "SELECT * FROM products WHERE product_id = @ProductId";
                        MySqlCommand command3 = new MySqlCommand(idQuery, database.connection);
                        command3.Parameters.AddWithValue("@ProductId", productId);
                        MySqlDataAdapter adapter3 = new MySqlDataAdapter(command3);
                        DataTable dt3 = new DataTable();
                        adapter3.Fill(dt3);

                        if (dt3.Rows.Count > 0)
                        {
                            DgvProduct.DataSource = dt3;
                        }
                        else
                        {
                            MessageBox.Show("ไม่พบสินค้าที่ค้นหา");
                            Refresh_Grid();
                        }
                    }
                    else
                    {
                        MessageBox.Show("กรุณากรอกรหัสสินค้าที่ต้องการค้นหา");
                    }
                }
            }
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

        private void RaAll_CheckedChanged(object sender, EventArgs e)
        {
            Ra_disble();
            TxIdFind.Clear();
        }

        private void TxIdFind_TextChanged(object sender, EventArgs e)
        {

        }

        private void CbCatFind_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }



    }
}
