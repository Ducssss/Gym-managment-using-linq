using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Ly_Phong_Gym
{
    public enum LoaiNV{ manager,PT,receptionist}
    public class Nhanvien
    {
        public int ma_nv { get; set; }
        public string ten_nv { get; set; }
        public bool gioiTinh { get; set; }
        public string diaChi { get; set; }
        public long SDT { get; set; }
        public int tienluong { get; set; }
        public LoaiNV loaiNV { get; set; }
        public ICollection<Lichtap> lichlam { get; set; }
        public Chinhanh chinhanh { get; set; }
        public Nhanvien(int ma_nv, string ten_nv, bool gioiTinh, string diaChi, long SDT, int tienluong, LoaiNV loaiNV, ICollection<Lichtap> lichlam,Chinhanh chinhanh)
        {
            this.ma_nv = ma_nv;
            this.ten_nv = ten_nv;
            this.gioiTinh = gioiTinh;
            this.diaChi = diaChi;
            this.SDT = SDT;
            this.tienluong = tienluong;
            this.loaiNV = loaiNV;
            this.lichlam = lichlam;
            this.chinhanh = chinhanh;
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
            lichlam = nv.lichlam;
            chinhanh = nv.chinhanh;
        }
    }
}
