using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

using OfficeOpenXml;
using OfficeOpenXml.Style;
namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


        }
        private byte[] _Logo;
        Modify modify = new Modify();
        QuanLyDoanhThu quanLy = new QuanLyDoanhThu("Tên CLB", "Tên Nước", 100, 10.5, new byte[] { 1, 2, 3, 4 }); // Thay thế các giá trị tương ứng

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox_CLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            double giaVe;
            string tenNuoc;

            switch (comboBox_CLB.SelectedIndex)
            {
                case 0:
                    giaVe = 12.0;
                    tenNuoc = "ANH";
                    break;
                case 1:
                    giaVe = 12.0;
                    tenNuoc = "ANH";
                    break;
                case 2:
                    giaVe = 13.0;
                    tenNuoc = "ANH";
                    break;
                case 3:
                    giaVe = 14.0;
                    tenNuoc = "ANH";
                    break;
                case 4:
                    giaVe = 15.0;
                    tenNuoc = "ANH";
                    break;
                case 5:
                    giaVe = 16.0;
                    tenNuoc = "ANH";
                    break;
                case 6:
                    giaVe = 17.0;
                    tenNuoc = "ANH";
                    break;
                case 7:
                    giaVe = 18.0;
                    tenNuoc = "ANH";
                    break;
                case 8:
                    giaVe = 18.0;
                    tenNuoc = "Việt Nam";
                    break;
                default:
                    giaVe = 0.0;
                    tenNuoc = "";
                    break;
            }

            // Định dạng giá vé để hiển thị số lẻ đầy đủ (15 chữ số thập phân)
            string formattedGiaVe = giaVe.ToString("0.###############");

            textBox_GiaVe.Text = formattedGiaVe;
            textBox_TenNuoc.Text = tenNuoc;
        }




        private void textBox_TimKiemCLB_TextChanged(object sender, EventArgs e)
        {
            string name = textBox_TimKiemCLB.Text.Trim();
            if (name == "")
            {
                Form1_Load(sender, e);
            }
            else
            {
                string query = "Select * from CBL where TenCauLacBo like '%" + name + "%'";
                dataGridView1.DataSource = modify.Table(query);
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = modify.Table("SELECT * FROM CBL");
            DataGridViewImageColumn pic = new DataGridViewImageColumn();
            pic = (DataGridViewImageColumn)dataGridView1.Columns[5];
            pic.ImageLayout = DataGridViewImageCellLayout.Zoom;
            try
            {

                dataGridView1.DataSource = modify.Table("select * from CBL");
                dataGridView1.Columns["SoLuongVe"].DefaultCellStyle.Format = "N0";
                DeleteTextBoxes();
                UpdateTextBoxValues();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi" + ex.Message);
            }
            DataGridViewColumn column = dataGridView1.Columns["SoLuongVe"];

            DeleteTextBoxes();
        }
        //
        private void UpdateTextBoxValues()
        {
            if (dataGridView1.CurrentRow != null)
            {
                comboBox_CLB.Text = dataGridView1.CurrentRow.Cells["TenCauLacBo"].Value.ToString();
                textBox_GiaVe.Text = dataGridView1.CurrentRow.Cells["GiaVe"].Value.ToString();
                textBox_SoLuongVe.Text = dataGridView1.CurrentRow.Cells["SoLuongVe"].Value.ToString();
                textBox_TenNuoc.Text = dataGridView1.CurrentRow.Cells["TenNuoc"].Value.ToString();
            }
        }


        private void textBox_SoLuongVe_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
        private void DeleteTextBoxes()
        {
            comboBox_CLB.SelectedIndex = -1;
            textBox_GiaVe.Text = "";
            textBox_SoLuongVe.Text = "";
            textBox_TenNuoc.Text = "";

        }
        private bool CheckTextBoxes()
        {
            if (comboBox_CLB.SelectedIndex == -1)
            {
                MessageBox.Show("Mời bạn chọn câu lạc bộ!");
                return false;
            }

            if (textBox_SoLuongVe.Text == "")
            {
                MessageBox.Show("Mời bạn nhập số lượng vé!");
                return false;
            }


            return true;
        }

        private void GetValuesTextBoxes()
        {
            string _tenCLB = comboBox_CLB.Text;
            string _tenNuoc = textBox_TenNuoc.Text;
            int _SoLuongVe;
            byte[] _Logo;

            if (!int.TryParse(textBox_SoLuongVe.Text, out _SoLuongVe))
            {
                MessageBox.Show("Số lượng vé không hợp lệ.");
                return;
            }
            double _giaVe;
            if (!double.TryParse(textBox_GiaVe.Text, out _giaVe))
            {
                MessageBox.Show("Giá vé không hợp lệ.");
                return;
            }


            _Logo = ImageToByteArray(pictureBox1);

            quanLy = new QuanLyDoanhThu(_tenCLB, _tenNuoc, _SoLuongVe, _giaVe, _Logo);
        }
        private void Button_SuaAnh_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                _Logo = ImageToByteArray(pictureBox1);
                // Thực hiện xử lý dữ liệu _Logo tại đây
            }
            else
            {
                MessageBox.Show("Không có hình ảnh để chuyển đổi.");
            }
        }

        private byte[] ImageToByteArray(PictureBox pictureBox)
        {
            if (pictureBox.Image != null)
            {
                using (MemoryStream memoryStream = new MemoryStream())
                {
                    pictureBox.Image.Save(memoryStream, pictureBox.Image.RawFormat);
                    return memoryStream.ToArray();
                }
            }
            else
            {
                return null;
            }
        }




        private void button_Them_Click(object sender, EventArgs e)
        {
            if (CheckTextBoxes())
            {
                GetValuesTextBoxes();

                // Chuyển đổi hình ảnh thành mảng byte
                byte[] logoData = ImageToByteArray(pictureBox1); // Thay thế pictureBox1 bằng PictureBox của bạn.

                if (logoData != null)
                {
                    // Kiểm tra xem bản ghi đã tồn tại dựa trên TenCauLacBo
                    if (!RecordExists(quanLy.TenCLB))
                    {
                        string query = "INSERT INTO CBL (TenCauLacBo, TenNuoc, SoLuongVe, GiaVe, TongTien, Logo) VALUES ";
                        query += "(@TenCauLacBo, @TenNuoc, @SoLuongVe, @GiaVe, @TongTien, @Logo)";

                        try
                        {
                            using (SqlConnection connection = Connection.GetSqlConnection())
                            {
                                connection.Open();
                                using (SqlCommand command = new SqlCommand(query, connection))
                                {
                                    command.Parameters.AddWithValue("@TenCauLacBo", quanLy.TenCLB);
                                    command.Parameters.AddWithValue("@TenNuoc", quanLy.TenNuoc);
                                    command.Parameters.AddWithValue("@SoLuongVe", quanLy.SoLuongVe);
                                    command.Parameters.AddWithValue("@GiaVe", quanLy.GiaVe);
                                    command.Parameters.AddWithValue("@TongTien", quanLy.DoanhThu());
                                    command.Parameters.Add("@Logo", SqlDbType.Image).Value = logoData;

                                    int rowsAffected = command.ExecuteNonQuery();
                                    if (rowsAffected > 0)
                                    {
                                        MessageBox.Show("Thêm Thành Công!");
                                        Form1_Load(sender, e);
                                    }
                                    else
                                    {
                                        MessageBox.Show("Thêm không thành công.");
                                    }
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Lỗi Thêm: " + ex.Message);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Câu lạc bộ đã tồn tại.");
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng thêm ảnh.");
                }
            }
        }

        private bool RecordExists(string tenCauLacBo)
        {
            using (SqlConnection connection = Connection.GetSqlConnection())
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM CBL WHERE TenCauLacBo = @TenCauLacBo";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TenCauLacBo", tenCauLacBo);
                    int count = (int)command.ExecuteScalar();
                    return count > 0;
                }
            }
        }




        private void button_Sua_Click(object sender, EventArgs e)
        {
            if (CheckTextBoxes())
            {
                GetValuesTextBoxes();

                string query = "UPDATE CBL SET TenNuoc = @TenNuoc, SoLuongVe = @SoLuongVe, GiaVe = @GiaVe, TongTien = @TongTien, Logo = @Logo ";
                query += "WHERE TenCauLacBo = @TenCLB";

                try
                {
                    if (MessageBox.Show("Bạn có muốn sửa không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        using (SqlConnection connection = Connection.GetSqlConnection())
                        {
                            connection.Open();
                            using (SqlCommand command = new SqlCommand(query, connection))
                            {
                                if (quanLy != null && quanLy.TenNuoc != null)
                                {
                                    command.Parameters.AddWithValue("@TenNuoc", quanLy.TenNuoc);
                                }
                                command.Parameters.AddWithValue("@SoLuongVe", quanLy.SoLuongVe);
                                command.Parameters.AddWithValue("@GiaVe", quanLy.GiaVe);
                                command.Parameters.AddWithValue("@TongTien", quanLy.DoanhThu());

                                // Kiểm tra giá trị của quanLy.Logo trước khi thêm vào tham số
                                if (quanLy.Logo != null)
                                {
                                    SqlParameter logoParameter = new SqlParameter("@Logo", SqlDbType.VarBinary);
                                    logoParameter.Value = quanLy.Logo;
                                    command.Parameters.Add(logoParameter);
                                }
                                else
                                {
                                    // Nếu Logo là null, thì thêm giá trị DBNull.Value cho tham số
                                    command.Parameters.AddWithValue("@Logo", DBNull.Value);
                                }

                                command.Parameters.AddWithValue("@TenCLB", quanLy.TenCLB);

                                int rowsAffected = command.ExecuteNonQuery();
                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("Sửa Thành Công!");
                                    Form1_Load(sender, e);
                                }
                                else
                                {
                                    MessageBox.Show("Sửa không thành công.");
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi Sửa: " + ex.Message);
                }
            }
        }

    


    private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows.Count > 1)
            {
                comboBox_CLB.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                textBox_GiaVe.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                textBox_SoLuongVe.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                textBox_TenNuoc.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                if (dataGridView1.SelectedRows[0].Cells[5].Value.ToString() != "")
                {
                    MemoryStream memoryStream = new MemoryStream((byte[])dataGridView1.SelectedRows[0].Cells[5].Value);
                    pictureBox1.Image = Image.FromStream(memoryStream);
                }
                else
                {
                    pictureBox1.Image = null;
                }
            }
        }
        //
        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0 && dataGridView1.Columns[e.ColumnIndex].Name == "SoLuongVe")
            {
                if (e.Value != null)
                {
                    if (int.TryParse(e.Value.ToString(), out int intValue))
                    {
                        e.Value = intValue;
                        e.FormattingApplied = true;
                    }
                }
            }
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            UpdateTextBoxValues();

        }




        private void button_Xoa_Click(object sender, EventArgs e)
        {
            if (quanLy != null && dataGridView1.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridView1.SelectedRows[0];

                if (selectedRow.Cells[0].Value != null)
                {
                    string choose = selectedRow.Cells[0].Value.ToString();

                    string deleteQuery = "DELETE FROM CBL WHERE TenCauLacBo = '" + choose + "'";
                    string selectQuery = "SELECT * FROM CBL WHERE TenCauLacBo = '" + choose + "'";

                    try
                    {
                        if (MessageBox.Show("Bạn có muốn xóa mã câu lạc bộ " + choose + " không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                        {
                            modify.Command(quanLy, deleteQuery);
                            MessageBox.Show("Xóa Thành Công!");
                            Form1_Load(sender, e);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi Xóa: " + ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Không có dữ liệu để xóa.");
                }
            }
            else
            {
                MessageBox.Show("Không có hàng để xóa hoặc thực hiện xử lý khác.");
            }
        }





        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button_Thoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.Title = "Chọn ảnh";
            openFileDialog1.Filter = "Image Files (*.jpg, *.png, *.bmp)|*.jpg;*.png;*.bmp|All Files (*.*)|*.*";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string imagePath = openFileDialog1.FileName;

                if (System.IO.File.Exists(imagePath))
                {
                    _Logo = File.ReadAllBytes(imagePath);
                    pictureBox1.ImageLocation = imagePath;
                }
            }




        }
    }
}

