using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Ly_Phong_Gym
{
    class Baocaodoanhthu
    {
        public int ma_baocao{get; set;}
        public string ten_baocao { get; set; }
        public string date { get; set; }
        public Chinhanh chinhanh { get; set; }
        public int doanhthu { get; set; }
        public Baocaodoanhthu(int ma_baocao, string ten_baocao, string date, Chinhanh chinhanh, int doanhthu)
        {
            this.ma_baocao = ma_baocao;
            this.ten_baocao = ten_baocao;
            this.date = date;
            this.chinhanh = chinhanh;
            this.doanhthu = doanhthu;
        }
        public Baocaodoanhthu(Baocaodoanhthu bc)
        {
            ma_baocao = bc.ma_baocao;
            ten_baocao = bc.ten_baocao;
            date = bc.date;
            chinhanh = bc.chinhanh;
            doanhthu = bc.doanhthu;
        }
    }
}
