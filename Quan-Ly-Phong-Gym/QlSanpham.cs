using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Ly_Phong_Gym
{
    class QlSanpham
    {
        public int mahang { get; set; }
        public string thoiDiemDat { get; set; }
        public Sanpham sanpham { get; set; }
        public Gym gym { get; set; }

        public QlSanpham(int mahang, string thoiDiem, Sanpham sanpham, Gym gym)
        {
            this.mahang = mahang;
            this.thoiDiemDat = thoiDiem;
            this.sanpham = sanpham;
            this.gym = gym;
        }

        public QlSanpham(QlSanpham qs)
        {
            this.mahang = qs.mahang;
            this.thoiDiemDat = qs.thoiDiemDat;
            this.sanpham = qs.sanpham;
            this.gym = qs.gym;
        }
    }
}
