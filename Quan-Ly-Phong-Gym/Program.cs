using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Quan_Ly_Phong_Gym
{
    class Program
    {
        static List<Gym> gym = new List<Gym>();
        static List<Chinhanh> chiNhanh = new List<Chinhanh>();
        static List<Baocaodoanhthu> baocaodoanhthu = new List<Baocaodoanhthu>();
        static List<Giaodich> giaodich = new List<Giaodich>();
        static List<Thanhvien> thanhvien = new List<Thanhvien>();
        static List<Lichtap> tkb = new List<Lichtap>();
        static List<LoaiSP> loaiSP = new List<LoaiSP>();
        static List<Nhanvien> nhanvien = new List<Nhanvien>();
        static List<QlSanpham> qlsp = new List<QlSanpham>();
        static List<Sanpham> sp = new List<Sanpham>();
        static List<The> the = new List<The>();
        public static void Taodanhsachthe()
        {
            the.Add(new The(9704155217830672, Loaithe.Gold,"22-10-2021","1 thang",Trangthai.conhoatdong));
            the.Add(new The(9704156217890575, Loaithe.Delta, "22-10-2021", "6 thang", Trangthai.hethoatdong));
            the.Add(new The(9704153415835619, Loaithe.Platinum, "22-10-2021", "3 thang", Trangthai.conhoatdong));
            the.Add(new The(9704153415730533, Loaithe.Premium, "22-10-2021", "2 thang", Trangthai.conhoatdong));
            the.Add(new The(9704153429583021, Loaithe.Platinum, "22-10-2021", "1 thang", Trangthai.conhoatdong));
            the.Add(new The(9704156217890504, Loaithe.Platinum, "22-10-2021", "1 thang", Trangthai.hethoatdong));
        }
        public static void Taodanhsachphonggym()
        { 
            gym.Add(new Gym(001, "Duc-uyen co so 1"));
            gym.Add(new Gym(002, "Duc-uyen co so 2"));
            gym.Add(new Gym(003, "Duc-uyen co so 3"));
            gym.Add(new Gym(004, "Duc-uyen co so 4"));
            gym.Add(new Gym(005, "Duc-uyen co so 5"));
            gym.Add(new Gym(006, "Duc-uyen co so 6"));
        }
        public static void Taochinhanh()
        {
            chiNhanh.Add(new Chinhanh(213, gym[0], "Quan 1"));
            chiNhanh.Add(new Chinhanh(214, gym[0], "Quan 9"));
            chiNhanh.Add(new Chinhanh(216, gym[4], "Quan Thu Duc"));
            chiNhanh.Add(new Chinhanh(217, gym[0], "Quan Binh Thanh"));
            chiNhanh.Add(new Chinhanh(316, gym[1], "Quan 1"));
            chiNhanh.Add(new Chinhanh(322, gym[1], "Quan 3"));
            chiNhanh.Add(new Chinhanh(315, gym[5], "Quan 9"));
            chiNhanh.Add(new Chinhanh(336, gym[1], "Quan Thu Duc"));
            chiNhanh.Add(new Chinhanh(413, gym[2], "Quan 8"));
            chiNhanh.Add(new Chinhanh(411, gym[2], "Quan 9"));
            chiNhanh.Add(new Chinhanh(571, gym[3], "Quan 1"));
            chiNhanh.Add(new Chinhanh(599, gym[3], "Quan 9"));
        }
        public static void TaoloaiSP()
        {
            loaiSP.Add(new LoaiSP(711085122, "Thuc pham chuc nang"));
            loaiSP.Add(new LoaiSP(711085128, "Dung cu the hinh"));
        }
        public static void Taosanpham()
        {
            sp.Add(new Sanpham(711085122, "Whey Protein", loaiSP[0], 300000, chiNhanh[1],loaitinhtrang.tot));
            sp.Add(new Sanpham(711085122, "Barbell", loaiSP[1], 1000000, chiNhanh[7], loaitinhtrang.tot));
            sp.Add(new Sanpham(711085122, "BCAA", loaiSP[0], 250000, chiNhanh[1], loaitinhtrang.quahan));
            sp.Add(new Sanpham(711085122, "Dumbbells", loaiSP[1], 3500000, chiNhanh[4], loaitinhtrang.huhong));
            sp.Add(new Sanpham(711085122, "Pre workout", loaiSP[0], 520000, chiNhanh[8], loaitinhtrang.tot));
            sp.Add(new Sanpham(711085122, "Kettlebell", loaiSP[1], 5000000, chiNhanh[6], loaitinhtrang.huhong));
            sp.Add(new Sanpham(711085122, "Dau ca Omega 3", loaiSP[0], 1000000, chiNhanh[5], loaitinhtrang.quahan));
            sp.Add(new Sanpham(711085122, "Weight Plates", loaiSP[1], 710000, chiNhanh[1], loaitinhtrang.huhong));
            sp.Add(new Sanpham(711085122, "Vitamin và khoáng chất", loaiSP[0], 600000, chiNhanh[4], loaitinhtrang.quahan));
            sp.Add(new Sanpham(711085122, "May chay bo", loaiSP[0], 35000000, chiNhanh[1], loaitinhtrang.tot));
        }
        public static void Xeplich()
        {
            tkb.Add(new Lichtap("43BOL8509f", "PH3", "Dance", "20-10-2021", "7", "9"));
            tkb.Add(new Lichtap("bXQkTsmjAm", "PH1", "Yoga", "20-10-2021", "7", "9"));
            tkb.Add(new Lichtap("WRj8z3zlYN", "PH2", "Kickboxing", "20-10-2021", "19", "21"));
            tkb.Add(new Lichtap("loBuMOjiLd", "PH1", "Yoga", "21-10-2021", "7", "9"));
            tkb.Add(new Lichtap("6vxWfiaIgS", "PH3", "Dance", "20-10-2021", "16", "18"));
            tkb.Add(new Lichtap("6vxWfiaIgS", "PH4", "Fit Ball", "21-10-2021", "9", "11"));
            tkb.Add(new Lichtap("Qz0FQn4Eds", "PH4", "Yoga", "21-10-2021", "16", "18"));
            tkb.Add(new Lichtap("24PEYBUMqZ", "PH1", "Fit Ball", "22-10-2021", "7", "9"));
            tkb.Add(new Lichtap("FkMrbCnzr3", "PH2", "Dance", "22-10-2021", "16", "18"));
            tkb.Add(new Lichtap("FkMrbCnzr3", "PH1", "Kickboxing", "22-10-2021", "19", "21"));
        }
        public static void Taothanhvien()//1 6 9 11
        {
            thanhvien.Add(new Thanhvien(998401467833, "Nguyen Van A", true, "521/14 Cach Mang Thang 8", "7819166574", the[0], tkb[7], chiNhanh[9]));
            thanhvien.Add(new Thanhvien(412621804844, "Bui Thi G",    false,"2/9 Tu Mo",                "3503132044", the[4], tkb[0], chiNhanh[5]));
            thanhvien.Add(new Thanhvien(034803538615, "Tran Van D",   true, "785/80 Nguyen Kiem",       "2958565427", the[4], tkb[4], chiNhanh[3]));
            thanhvien.Add(new Thanhvien(610348461299, "Nguyen Thi D", false,"524 Le Quang Dinh",        "8903560125", the[1], tkb[8], chiNhanh[1]));
            thanhvien.Add(new Thanhvien(716110654689, "Hoang Thi A",  false,"594 Nguyen Kiem",          "7024709856", the[2], tkb[4], chiNhanh[9]));
            thanhvien.Add(new Thanhvien(680004705490, "Phan Thi H",   false,"334/64 Chu Van An",        "8958825384", the[0], tkb[3], chiNhanh[6]));
            thanhvien.Add(new Thanhvien(139447593705, "Ly Van E",     true, "226/15 Nguyen Thai Son",   "4447015263", the[4], tkb[8], chiNhanh[2]));
            thanhvien.Add(new Thanhvien(201867690135, "Le Thi R",     false,"150 Dang Van Bi",          "3558743834", the[0], tkb[4], chiNhanh[4]));
            thanhvien.Add(new Thanhvien(005892218193, "Vo Thi U",     false,"25/14 Ly Thuong Kiet",     "9699626970", the[0], tkb[2], chiNhanh[11]));
            thanhvien.Add(new Thanhvien(336375368077, "Chu Van J",    true, "214/22 Duong So 6",        "9627148492", the[3], tkb[9], chiNhanh[7]));
            thanhvien.Add(new Thanhvien(287165352304, "Ho Thi I",     false,"465/30 Tran Hung Dao",     "6906623185", the[4], tkb[4], chiNhanh[0]));
            thanhvien.Add(new Thanhvien(229319933926, "Lai Van Y",    true, "195 Vo Van Ngan",          "1064619458", the[2], tkb[0], chiNhanh[1]));
            thanhvien.Add(new Thanhvien(073521329738, "Duong Thi B",  false,"112 Le Van Viet",          "9924086803", the[0], tkb[9], chiNhanh[3]));
            thanhvien.Add(new Thanhvien(341671974708, "Huynh Thi K",  false,"25/6 Ly thuong Kiet",      "9924086803", the[3], tkb[4], chiNhanh[6]));
            thanhvien.Add(new Thanhvien(369022312258, "Dao Van L",    true, "543 Cach Mang Thang 8",    "9924086803", the[2], tkb[4], chiNhanh[4]));
        }
        public static void Taonhanvien()
        {
            nhanvien.Add(new Nhanvien())
        }
        public static void Quanlisanpham()
        {

        }
        public static void Danhsachgiaodich()
        {

        }
        public static void Danhsachbaocaodoanhthu()
        {

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
