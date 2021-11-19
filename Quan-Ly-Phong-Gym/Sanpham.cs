using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Ly_Phong_Gym
{
    public enum loaitinhtrang
    {
        quahan,huhong,tot
    }
    public class Sanpham
    {
        public int ID_SP { get; set; }
        public string Ten_SP { get; set; }
        public LoaiSP loaiSP { get; set; }
        public int giatien { get; set; }
        public Chinhanh chinhanh { get; set; }
        public loaitinhtrang tinhtrang { get; set; }

        public Sanpham(int ID_SP, string Ten_SP, LoaiSP loaiSP,int giatien, Chinhanh chinhanh, loaitinhtrang tinhtrang)
        {
            this.ID_SP = ID_SP;
            this.Ten_SP = Ten_SP;
            this.loaiSP = loaiSP;
            this.giatien = giatien;
            this.chinhanh = chinhanh;
            this.tinhtrang = tinhtrang;
        }

        public Sanpham(Sanpham sp)
        {
            ID_SP = sp.ID_SP;
            Ten_SP = sp.Ten_SP;
            loaiSP = sp.loaiSP;
            giatien = sp.giatien;
            chinhanh = sp.chinhanh;
            tinhtrang = sp.tinhtrang;
        }
    }
}
