using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Ly_Phong_Gym
{
    public class QlSanpham
    {
        public int mahang { get; set; }
        public string thoiDiemDat { get; set; }
        public Sanpham sanpham { get; set; }
        public Thanhvien thanhvien { get; set; }

        public QlSanpham(int mahang, string thoiDiemDat, Sanpham sanpham, Thanhvien thanhvien)
        {
            this.mahang = mahang;
            this.thoiDiemDat = thoiDiemDat;
            this.sanpham = sanpham;
            this.thanhvien = thanhvien;
        }

        public QlSanpham(QlSanpham qs)
        {
            mahang = qs.mahang;
            thoiDiemDat = qs.thoiDiemDat;
            sanpham = qs.sanpham;
            thanhvien = qs.thanhvien;
        }
    }
}
