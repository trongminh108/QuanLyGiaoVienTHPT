using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyGiaoVienTrungHocPhoThong.ConstraintCheck
{
    internal class KiemTraThongTin
    {
        public static bool KiemTraMaGV(string magv)
        {
            if (magv.Length != 4)
                return false;
            bool isNum = int.TryParse(magv.Substring(1), out int a);
            if (isNum)
                return true;
            return false;
        }

        public static bool KiemTraMaGV(string magv, string mabomon)
        {
            if (!KiemTraMaGV(magv))
                return false;
            if (mabomon[0] != magv[0])
                return false;
            return true;
        }

        public static bool KiemTraCMND_CCCD(string cmnd)
        {
            bool isNum = int.TryParse(cmnd, out int tmp);
            if (!isNum)
                return false;
            if (cmnd.Length != 9 && cmnd.Length != 12)
                return false;
            return true;
        }

        public static bool KiemTraSDT(string sdt)
        {
            bool isNum = int.TryParse(sdt, out int tmp);
            if (!isNum)
                return false;
            return true;
        }

        public static bool KiemTraEmail(string email)
        {
            return email.EndsWith("@gmail.com");
        }
    }
}