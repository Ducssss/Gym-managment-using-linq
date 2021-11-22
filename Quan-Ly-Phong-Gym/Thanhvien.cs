using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Ly_Phong_Gym
{
    public class Thanhvien
    {
        public long ma_TV { get; set; }
        public string ten_TV { get; set; }
        public string gioiTinh { get; set; }
        public string diaChi { get; set; }
        public string SDT { get; set; }
        public The the { get; set; }
        public ICollection<Lichtap> lichtap { get; set; }
        public Chinhanh chinhanh { get; set; }

        public Thanhvien(long ma_TV, string ten_TV, bool gioiTinh, string diaChi, string SDT, The the, ICollection<Lichtap> lichtap, Chinhanh chinhanh)
        {
            this.ma_TV = ma_TV;
            this.ten_TV = ten_TV;
            this.gioiTinh = (gioiTinh==true)?"Nam":"Nu";
            this.diaChi = diaChi;
            this.SDT = SDT;
            this.the = the;
            this.lichtap = lichtap;
            this.chinhanh = chinhanh;
        }

        public Thanhvien(Thanhvien Thanhvien)
        {
            ma_TV = Thanhvien.ma_TV;
            ten_TV = Thanhvien.ten_TV;
            gioiTinh = Thanhvien.gioiTinh;
            diaChi = Thanhvien.diaChi;
            SDT = Thanhvien.SDT;
            the = Thanhvien.the;
            lichtap = Thanhvien.lichtap;
            chinhanh = Thanhvien.chinhanh;
        }

    }
}
