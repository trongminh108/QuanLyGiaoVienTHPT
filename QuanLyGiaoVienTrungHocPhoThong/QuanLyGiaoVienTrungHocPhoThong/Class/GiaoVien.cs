using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyGiaoVienTrungHocPhoThong.Class
{
    internal class GiaoVien
    {
        private string maGV;
        private string hoTen;
        private string namSinh;
        private string maMon;
        private string gioiTinh;
        private string luong;
        private string maTruongBM;
        private string sdt;
        private string email;

        public GiaoVien(string maGV, string hoTen, string namSinh, string maMon, string gioiTinh, string luong, string maTruongBM, string sdt, string email)
        {
            this.maGV = maGV;
            this.hoTen = hoTen;
            this.namSinh = namSinh;
            this.maMon = maMon;
            this.gioiTinh = gioiTinh;
            this.luong = luong;
            this.maTruongBM = maTruongBM;
            this.sdt = sdt;
            this.email = email;
        }

        public string MaGV { get => maGV; set => maGV = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        public string NamSinh { get => namSinh; set => namSinh = value; }
        public string MaMon { get => maMon; set => maMon = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public string Luong { get => luong; set => luong = value; }
        public string MaTruongBM { get => maTruongBM; set => maTruongBM = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public string Email { get => email; set => email = value; }
    }
}
