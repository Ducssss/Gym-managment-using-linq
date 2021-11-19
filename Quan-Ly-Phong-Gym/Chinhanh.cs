using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Ly_Phong_Gym
{
    public class Chinhanh
    {
        public int maChiNhanh { get; set; }
        public Gym gym { get; set; }
        public string diaChi { get; set; }
       

        public Chinhanh(int maChiNhanh, Gym gym, string diaChi)
        {
            this.maChiNhanh = maChiNhanh;
            this.gym = gym;
            this.diaChi = diaChi;
         
        }

        public Chinhanh(Chinhanh cn)
        {
            maChiNhanh = cn.maChiNhanh;
            gym = cn.gym;
            diaChi = cn.diaChi;
        }
    }
}
