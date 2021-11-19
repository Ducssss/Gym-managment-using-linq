using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Ly_Phong_Gym
{
    public enum Loaithe
    {
        Gold, Platinum, Delta, Premium
    }
    public enum Trangthai { conhoatdong,hethoatdong}
    public class The
    {

        public int ma_the { get; set; }
        /*public TaiKhoan taiKhoan { get; set; }*/
        public Loaithe loaithe { get; set; }
        public string ngayCap { get; set; }
        public string thoiHan { get; set; }
        public Trangthai trangthai { get; set; }
        public The(int ma_the, Loaithe loaithe, string ngayCap, string thoiHan, Trangthai trangthai)
        {
            this.ma_the = ma_the;
            this.loaithe = loaithe;
            this.ngayCap = ngayCap;
            this.thoiHan = thoiHan;
            this.trangthai = trangthai;
        }

        public The(The the)
        {
            ma_the = the.ma_the;
            loaithe = the.loaithe;
            ngayCap = the.ngayCap;
            thoiHan = the.thoiHan;
            trangthai = the.trangthai;
        }
    }
}
