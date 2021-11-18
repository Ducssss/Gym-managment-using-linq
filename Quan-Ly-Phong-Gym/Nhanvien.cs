using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Ly_Phong_Gym
{
    enum LoaiNV{ manager,PT,receptionist}
    class Nhanvien
    {
        public int ma_nv { get; set; }
        public string ten_nv { get; set; }
        public bool gioiTinh { get; set; }
        public string diaChi { get; set; }
        public string SDT { get; set; }
        public int tienluong { get; set; }
        public LoaiNV loaiNV { get; set; }
        public Lichtap lichtap { get; set; }
        public Nhanvien(int ma_nv, string ten_nv, bool gioiTinh, string diaChi, string SDT, int tienluong, LoaiNV loaiNV, Lichtap lichtap)
        {
            this.ma_nv = ma_nv;
            this.ten_nv = ten_nv;
            this.gioiTinh = gioiTinh;
            this.diaChi = diaChi;
            this.SDT = SDT;
            this.tienluong = tienluong;
            this.loaiNV = loaiNV;
            this.lichtap = lichtap;
        }
        public Nhanvien(Nhanvien nv)
        {
            ma_nv = nv.ma_nv;
            ten_nv = nv.ten_nv;
            gioiTinh = nv.gioiTinh;
            diaChi = nv.diaChi;
            SDT = nv.SDT;
            tienluong = nv.tienluong;
            loaiNV = nv.loaiNV;
            lichtap = nv.lichtap;
        }
    }
}
