using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Ly_Phong_Gym
{
    class Giaodich
    {
        public int trans_ID { get; set; }
        public string trans_name { get; set; }
        public int money { get; set; }
        public DateTime? date { get; set; }
        public Thanhvien thanhvien { get; set; }
        public Giaodich(int trans_ID, string trans_name, int money, DateTime date, Thanhvien thanhvien)
        {
            this.trans_ID = trans_ID;
            this.trans_name = trans_name;
            this.money = money;
            this.date = date;
            this.thanhvien = thanhvien;
        }
        public Giaodich(Giaodich ts)
        {
            trans_ID = ts.trans_ID;
            trans_name = ts.trans_name;
            money = ts.money;
            date = ts.date;
            thanhvien = ts.thanhvien;
        }
    }
}
