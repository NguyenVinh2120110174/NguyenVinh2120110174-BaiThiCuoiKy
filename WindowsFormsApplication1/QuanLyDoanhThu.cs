using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    internal class QuanLyDoanhThu
    {
        private string _tenCLB;
        private string _tenNuoc;
        private int _SoLuongVe;
        private double _giaVe;
        private byte[] _Logo;

        public QuanLyDoanhThu(string tenCLB, string tenNuoc, int soLuongVe, double giaVe, byte[] logo)
        {
            _tenCLB = tenCLB;
            _tenNuoc = tenNuoc;
            _SoLuongVe = soLuongVe;
            _giaVe = giaVe;
            _Logo = logo;
        }

        public string TenCLB { get => _tenCLB; set => _tenCLB = value; }
        public string TenNuoc { get => _tenNuoc; set => _tenNuoc = value; }
        public int SoLuongVe { get => _SoLuongVe; set => _SoLuongVe = value; }
        public double GiaVe { get => _giaVe; set => _giaVe = value; }
        public byte[] Logo { get => _Logo; set => _Logo = value; }

        public double DoanhThu()
        {
            return SoLuongVe * GiaVe;
        }
    }
}

