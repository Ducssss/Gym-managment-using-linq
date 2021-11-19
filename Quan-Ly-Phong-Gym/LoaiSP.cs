using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Ly_Phong_Gym
{
    public class LoaiSP
    {
        public int maLoai { get; set; }
        public string tenLoai { get; set; }

        public LoaiSP(int MaLoai, string TenLoai)
        {
            this.maLoai = MaLoai;
            this.tenLoai = TenLoai;
        }

        public LoaiSP(LoaiSP Loai)
        {
            tenLoai = Loai.tenLoai;
            maLoai = Loai.maLoai;
        }
    }
}
