﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Ly_Phong_Gym
{
    class Thanhvien
    {
        public int ma_TV { get; set; }
        public string ten_TV { get; set; }
        public bool gioiTinh { get; set; }
        public string diaChi { get; set; }
        public string SDT { get; set; }
        public The the { get; set; }
        public Lichtap lichtap { get; set; }

        public Thanhvien(int ma_TV, string ten_TV, bool gioiTinh, string DiaChi, string SDT, The the, Lichtap lichtap)
        {
            this.ma_TV = ma_TV;
            this.ten_TV = ten_TV;
            this.gioiTinh = gioiTinh;
            this.diaChi = DiaChi;
            this.SDT = SDT;
            this.the = the;
            this.lichtap = lichtap;
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
        }

    }
}
