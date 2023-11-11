    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Data;
    using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    internal class Modify
    {
        public Modify()
        {

        }
        SqlDataAdapter dataAdapter;
        SqlCommand sqlCommand;
        public DataTable Table(string query) //tra ve bang du lieu
        {
            DataTable dataTable = new DataTable();
            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();
                dataAdapter = new SqlDataAdapter(query, sqlConnection);
                dataAdapter.Fill(dataTable);
                sqlConnection.Close();

            }
            return dataTable;
        }
        //

        public void Command(QuanLyDoanhThu QuanLyDoanhThu, string query)
        {
            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();
                using (SqlCommand sqlCommand = new SqlCommand(query, sqlConnection))
                {
                    sqlCommand.Parameters.AddWithValue("@TenCauLacBo", QuanLyDoanhThu.TenCLB);
                    sqlCommand.Parameters.AddWithValue("@TenNuoc", QuanLyDoanhThu.TenNuoc);
                    sqlCommand.Parameters.AddWithValue("@SoLuongVe", QuanLyDoanhThu.SoLuongVe);
                    sqlCommand.Parameters.AddWithValue("@GiaVe", QuanLyDoanhThu.GiaVe);
                    sqlCommand.Parameters.AddWithValue("@TongTien", QuanLyDoanhThu.DoanhThu());

                    // Kiểm tra giá trị của QuanLyDoanhThu.Logo trước khi thêm vào tham số
                    if (QuanLyDoanhThu.Logo != null)
                    {
                        sqlCommand.Parameters.Add("@Logo", SqlDbType.Image).Value = QuanLyDoanhThu.Logo;
                    }
                    else
                    {
                        // Nếu Logo là null, thì thêm giá trị DBNull.Value cho tham số
                        sqlCommand.Parameters.Add("@Logo", SqlDbType.Image).Value = DBNull.Value;
                    }

                    sqlCommand.ExecuteNonQuery();
                }
                sqlConnection.Close();
            }
        }

    }
}

