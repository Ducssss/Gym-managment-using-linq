using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Quan_Ly_Phong_Gym
{
    class Program
    {
        public static List<Gym> gym = new List<Gym>();
        public static List<Chinhanh> chiNhanh = new List<Chinhanh>();
        public static List<Baocaodoanhthu> baocaodoanhthu = new List<Baocaodoanhthu>();
        public static List<Giaodich> giaodich = new List<Giaodich>();
        public static List<Thanhvien> thanhvien = new List<Thanhvien>();
        public static List<Lichtap> tkb = new List<Lichtap>();
        public static List<LoaiSP> loaiSP = new List<LoaiSP>();
        public static List<Nhanvien> nhanvien = new List<Nhanvien>();
        public static List<QlSanpham> qlsp = new List<QlSanpham>();
        public static List<Sanpham> sp = new List<Sanpham>();
        public static List<The> the = new List<The>();
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
        }
        public static void Taochinhanh()
        {
            chiNhanh.Add(new Chinhanh(213, gym[0], "Quan 1"));
            chiNhanh.Add(new Chinhanh(214, gym[2], "Quan 9"));
            chiNhanh.Add(new Chinhanh(216, gym[1], "Quan Thu Duc"));
            chiNhanh.Add(new Chinhanh(217, gym[0], "Quan Binh Thanh"));
            chiNhanh.Add(new Chinhanh(316, gym[1], "Quan 1"));
            chiNhanh.Add(new Chinhanh(322, gym[0], "Quan 3"));
        }
        public static void TaoloaiSP()
        {
            loaiSP.Add(new LoaiSP(711085122, "Thuc pham chuc nang"));
            loaiSP.Add(new LoaiSP(711085128, "Dung cu the hinh"));
        }
        public static void Taosanpham()
        {
            sp.Add(new Sanpham(711085122, "Whey Protein", loaiSP[0], 300000, chiNhanh[1],loaitinhtrang.tot));
            sp.Add(new Sanpham(711085123, "Barbell", loaiSP[1], 1000000, chiNhanh[2], loaitinhtrang.tot));
            sp.Add(new Sanpham(711085124, "BCAA", loaiSP[0], 250000, chiNhanh[1], loaitinhtrang.quahan));
            sp.Add(new Sanpham(711085125, "Dumbbells", loaiSP[1], 3500000, chiNhanh[4], loaitinhtrang.huhong));
            sp.Add(new Sanpham(711085126, "Pre workout", loaiSP[0], 520000, chiNhanh[0], loaitinhtrang.tot));
            sp.Add(new Sanpham(711085127, "Kettlebell", loaiSP[1], 5000000, chiNhanh[0], loaitinhtrang.huhong));
            sp.Add(new Sanpham(711085128, "Dau ca Omega 3", loaiSP[0], 1000000, chiNhanh[3], loaitinhtrang.quahan));
            sp.Add(new Sanpham(711085129, "Weight Plates", loaiSP[1], 710000, chiNhanh[1], loaitinhtrang.huhong));
            sp.Add(new Sanpham(711085130, "Vitamin và khoáng chất", loaiSP[0], 600000, chiNhanh[4], loaitinhtrang.quahan));
            sp.Add(new Sanpham(711085131, "May chay bo", loaiSP[0], 35000000, chiNhanh[3], loaitinhtrang.tot));
        }
        public static void Taolich()
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


            nhanvien[0].lichlam.Add(tkb[5]); thanhvien[0].lichtap.Add(tkb[5]);
            nhanvien[0].lichlam.Add(tkb[4]); thanhvien[0].lichtap.Add(tkb[4]);
            nhanvien[0].lichlam.Add(tkb[6]); thanhvien[0].lichtap.Add(tkb[6]);
            nhanvien[1].lichlam.Add(tkb[3]); thanhvien[1].lichtap.Add(tkb[2]);
            nhanvien[1].lichlam.Add(tkb[7]); thanhvien[1].lichtap.Add(tkb[4]);
            nhanvien[1].lichlam.Add(tkb[4]); thanhvien[2].lichtap.Add(tkb[3]);
            nhanvien[2].lichlam.Add(tkb[6]); thanhvien[2].lichtap.Add(tkb[8]);
            nhanvien[2].lichlam.Add(tkb[4]); thanhvien[2].lichtap.Add(tkb[1]);
            nhanvien[2].lichlam.Add(tkb[7]); thanhvien[2].lichtap.Add(tkb[0]);
            nhanvien[3].lichlam.Add(tkb[8]); thanhvien[3].lichtap.Add(tkb[0]);
            nhanvien[3].lichlam.Add(tkb[4]); thanhvien[4].lichtap.Add(tkb[9]);
            nhanvien[3].lichlam.Add(tkb[1]); thanhvien[4].lichtap.Add(tkb[6]);
            nhanvien[4].lichlam.Add(tkb[6]); thanhvien[5].lichtap.Add(tkb[5]);
            nhanvien[4].lichlam.Add(tkb[2]); thanhvien[5].lichtap.Add(tkb[4]);
            nhanvien[4].lichlam.Add(tkb[0]); thanhvien[5].lichtap.Add(tkb[9]);
            nhanvien[5].lichlam.Add(tkb[5]); thanhvien[6].lichtap.Add(tkb[0]);
            nhanvien[5].lichlam.Add(tkb[9]); 
            nhanvien[5].lichlam.Add(tkb[3]); 
            nhanvien[6].lichlam.Add(tkb[1]); 
            nhanvien[6].lichlam.Add(tkb[4]); 
            nhanvien[6].lichlam.Add(tkb[5]); 
            nhanvien[7].lichlam.Add(tkb[8]); 
            nhanvien[7].lichlam.Add(tkb[3]); 
            nhanvien[7].lichlam.Add(tkb[2]); 
            nhanvien[8].lichlam.Add(tkb[7]);

            nhanvien[8].lichlam.Add(tkb[5]);  thanhvien[7].lichtap.Add(tkb[0]);
            nhanvien[8].lichlam.Add(tkb[4]);  thanhvien[7].lichtap.Add(tkb[2]);
            nhanvien[9].lichlam.Add(tkb[6]);  thanhvien[7].lichtap.Add(tkb[3]);
            nhanvien[9].lichlam.Add(tkb[3]);  thanhvien[8].lichtap.Add(tkb[3]);
            nhanvien[9].lichlam.Add(tkb[7]);  thanhvien[8].lichtap.Add(tkb[5]);
            nhanvien[10].lichlam.Add(tkb[4]); thanhvien[9].lichtap.Add(tkb[6]);
            nhanvien[10].lichlam.Add(tkb[6]); thanhvien[9].lichtap.Add(tkb[7]);
            nhanvien[10].lichlam.Add(tkb[4]); thanhvien[9].lichtap.Add(tkb[9]);
            nhanvien[11].lichlam.Add(tkb[7]); thanhvien[10].lichtap.Add(tkb[7]);
            nhanvien[11].lichlam.Add(tkb[8]); thanhvien[11].lichtap.Add(tkb[2]);
            nhanvien[11].lichlam.Add(tkb[4]); thanhvien[11].lichtap.Add(tkb[1]);
            nhanvien[12].lichlam.Add(tkb[1]); thanhvien[12].lichtap.Add(tkb[1]);
            nhanvien[12].lichlam.Add(tkb[6]); thanhvien[13].lichtap.Add(tkb[3]);
            nhanvien[12].lichlam.Add(tkb[2]); thanhvien[13].lichtap.Add(tkb[0]);
            nhanvien[13].lichlam.Add(tkb[0]); thanhvien[14].lichtap.Add(tkb[0]);
            nhanvien[13].lichlam.Add(tkb[5]); 
            nhanvien[13].lichlam.Add(tkb[9]);
            nhanvien[14].lichlam.Add(tkb[3]);
            nhanvien[14].lichlam.Add(tkb[1]);
            nhanvien[14].lichlam.Add(tkb[4]);
            nhanvien[15].lichlam.Add(tkb[5]);
            nhanvien[15].lichlam.Add(tkb[8]);
            nhanvien[15].lichlam.Add(tkb[3]);
            nhanvien[16].lichlam.Add(tkb[2]);
            nhanvien[16].lichlam.Add(tkb[7]);
            nhanvien[16].lichlam.Add(tkb[9]);
            nhanvien[17].lichlam.Add(tkb[3]);
            nhanvien[17].lichlam.Add(tkb[1]);
            nhanvien[17].lichlam.Add(tkb[4]);
            nhanvien[18].lichlam.Add(tkb[5]);
            nhanvien[18].lichlam.Add(tkb[8]);
            nhanvien[18].lichlam.Add(tkb[3]);
            nhanvien[19].lichlam.Add(tkb[2]);
            nhanvien[19].lichlam.Add(tkb[7]);
            nhanvien[19].lichlam.Add(tkb[8]);
        }
        public static void Taothanhvien()//1 6 9 11
        {
            thanhvien.Add(new Thanhvien(998401467833, "Nguyen Van A", true, "521/14 Cach Mang Thang 8", "7819166574", the[0], new List<Lichtap>(), chiNhanh[0]));
            thanhvien.Add(new Thanhvien(412621804844, "Bui Thi G",    false,"2/9 Tu Mo",                "3503132044", the[4], new List<Lichtap>(), chiNhanh[5]));
            thanhvien.Add(new Thanhvien(034803538615, "Tran Van D",   true, "785/80 Nguyen Kiem",       "2958565427", the[4], new List<Lichtap>(), chiNhanh[3]));
            thanhvien.Add(new Thanhvien(610348461299, "Nguyen Thi D", false,"524 Le Quang Dinh",        "8903560125", the[1], new List<Lichtap>(), chiNhanh[1]));
            thanhvien.Add(new Thanhvien(716110654689, "Hoang Thi A",  false,"594 Nguyen Kiem",          "7024709856", the[2], new List<Lichtap>(), chiNhanh[0]));
            thanhvien.Add(new Thanhvien(680004705490, "Phan Thi H",   false,"334/64 Chu Van An",        "8958825384", the[0], new List<Lichtap>(), chiNhanh[4]));
            thanhvien.Add(new Thanhvien(139447593705, "Ly Van E",     true, "226/15 Nguyen Thai Son",   "4447015263", the[4], new List<Lichtap>(), chiNhanh[2]));
            thanhvien.Add(new Thanhvien(201867690135, "Le Thi R",     false,"150 Dang Van Bi",          "3558743834", the[0], new List<Lichtap>(), chiNhanh[4]));
            thanhvien.Add(new Thanhvien(005892218193, "Vo Thi U",     false,"25/14 Ly Thuong Kiet",     "9699626970", the[0], new List<Lichtap>(), chiNhanh[1]));
            thanhvien.Add(new Thanhvien(336375368077, "Chu Van J",    true, "214/22 Duong So 6",        "9627148492", the[3], new List<Lichtap>(), chiNhanh[3]));
            thanhvien.Add(new Thanhvien(287165352304, "Ho Thi I",     false,"465/30 Tran Hung Dao",     "6906623185", the[4], new List<Lichtap>(), chiNhanh[0]));
            thanhvien.Add(new Thanhvien(229319933926, "Lai Van Y",    true, "195 Vo Van Ngan",          "1064619458", the[2], new List<Lichtap>(), chiNhanh[1]));
            thanhvien.Add(new Thanhvien(073521329738, "Duong Thi B",  false,"112 Le Van Viet",          "9924086803", the[0], new List<Lichtap>(), chiNhanh[3]));
            thanhvien.Add(new Thanhvien(341671974708, "Huynh Thi K",  false,"25/6 Ly thuong Kiet",      "9924086803", the[3], new List<Lichtap>(), chiNhanh[4]));
            thanhvien.Add(new Thanhvien(369022312258, "Dao Van L",    true, "543 Cach Mang Thang 8",    "9924086803", the[2], new List<Lichtap>(), chiNhanh[4]));
        }
        public static void Taonhanvien()
        { 
            
            nhanvien.Add(new Nhanvien(991125, "Al Morgan", true, "225 Vo Van Ngan", 9712886652, 9000000, LoaiNV.PT, new List<Lichtap>(), chiNhanh[0]));
            nhanvien.Add(new Nhanvien(171856, "Nguyen Tran Van", true, "179 Le Van Chi", 7612588155, 7000000, LoaiNV.receptionist, new List<Lichtap>(), chiNhanh[0]));
            nhanvien.Add(new Nhanvien(648221, "Isidi", true, "05 Duong So 9 ", 6612238395, 9000000, LoaiNV.PT, new List<Lichtap>(), chiNhanh[0]));
            nhanvien.Add(new Nhanvien(702207, "Dao Ngoc Nguyen", false, "170 Duong So 5", 8817726562, 15000000, LoaiNV.manager, new List<Lichtap>(), chiNhanh[0]));
            nhanvien.Add(new Nhanvien(881272, "Tran Van An", true, "23 Vo Thi Sau",7776618935, 15000000, LoaiNV.manager, new List<Lichtap>(), chiNhanh[1]));
            nhanvien.Add(new Nhanvien(715223, "Tieu Phuong ",false, "01 Nguyen Dinh Chieu", 9978792255, 9000000, LoaiNV.PT, new List<Lichtap>(), chiNhanh[1]));
            nhanvien.Add(new Nhanvien(881345, "Bella Le", false, "09 Duong So 7", 6617528898, 7000000, LoaiNV.receptionist, new List<Lichtap>(), chiNhanh[1]));
            nhanvien.Add(new Nhanvien(217665, "Ta Le", true, "225 Duong 168", 9917782527, 9000000, LoaiNV.PT, new List<Lichtap>(), chiNhanh[1]));
            nhanvien.Add(new Nhanvien(912801, "Dominick DecoLai", true, "01 Duong So 8", 7762551993, 15000000, LoaiNV.manager, new List<Lichtap>(), chiNhanh[2]));
            nhanvien.Add(new Nhanvien(991277, "Thuy Lavie", false, "26 Ha Huy Tap",8831796622, 9000000, LoaiNV.PT, new List<Lichtap>(), chiNhanh[2]));
            nhanvien.Add(new Nhanvien(172387, "Jeb Saud", true, "127 Duong So 11", 9935176608, 9000000, LoaiNV.PT, new List<Lichtap>(), chiNhanh[2]));
            nhanvien.Add(new Nhanvien(762558, "Al Morgan", true, "272 Le Van Viet", 6611891755, 9000000, LoaiNV.receptionist, new List<Lichtap>(), chiNhanh[2]));
            nhanvien.Add(new Nhanvien(881335, "Lisa Emma", false, "111 Tam Ha", 19132551668, 9000000, LoaiNV.manager, new List<Lichtap>(), chiNhanh[3]));
            nhanvien.Add(new Nhanvien(225367, "Ryan Long", true, "228 To Ngoc Van",9976615326, 15000000,LoaiNV.PT, new List<Lichtap>(), chiNhanh[3]));
            nhanvien.Add(new Nhanvien(123456, "Linn Nguyen",false, "10 Tam Binh", 9327518865, 7000000, LoaiNV.receptionist, new List<Lichtap>(), chiNhanh[3]));
            nhanvien.Add(new Nhanvien(830159, "Cozy Tran", false, "20 Nguyen Van Linh",8872251619, 15000000, LoaiNV.PT, new List<Lichtap>(), chiNhanh[3]));
            nhanvien.Add(new Nhanvien(897032, "Tu Le", true, "10 Nguyen Van Troi",8819256672, 9000000, LoaiNV.PT, new List<Lichtap>(), chiNhanh[4]));
            nhanvien.Add(new Nhanvien(916513, "Al Morgan", true, "668 Ta Quang Buu",9983358272, 9000000, LoaiNV.PT, new List<Lichtap>(), chiNhanh[4]));
            nhanvien.Add(new Nhanvien(227118, "Victory Dang", true, "05 Nguyen Duy Trinh", 6182259912, 15000000, LoaiNV.manager, new List<Lichtap>(), chiNhanh[4]));
            nhanvien.Add(new Nhanvien(881235, "Davis Tran Dang", true, "115 Duong So 5", 9712886652, 15000000, LoaiNV.receptionist, new List<Lichtap>(), chiNhanh[4]));
            nhanvien.Add(new Nhanvien(777909, "Edison Nguyen", true, "212 Vo Van Thuong", 9712886652, 7000000, LoaiNV.receptionist, new List<Lichtap>(), chiNhanh[5]));
            nhanvien.Add(new Nhanvien(323616, "Jame Tran", true, "01 Le Van Viet", 6612551888, 15000000, LoaiNV.manager, new List<Lichtap>(), chiNhanh[5]));
            nhanvien.Add(new Nhanvien(898772, "Johny Nguyen", true, "102 Hai Ba Trung", 9915538189, 9000000, LoaiNV.PT, new List<Lichtap>(), chiNhanh[5]));
            nhanvien.Add(new Nhanvien(555378, "Evis Phuong",false, "444 Xo Viet Nghe Tinh",554689991, 9000000, LoaiNV.PT, new List<Lichtap>(), chiNhanh[5]));
/*            nhanvien.Add(new Nhanvien(696888, "David Tran Phuong", true, "24 Hoang Dieu",9981776642, 15000000, LoaiNV.manager, new List<Lichtap>(), chiNhanh[7]));
            nhanvien.Add(new Nhanvien(445712, "Oanh Le Phuong", true, "114 Hoang Dieu 2",8895541719, 9000000, LoaiNV.PT, new List<Lichtap>(), chiNhanh[11]));
            nhanvien.Add(new Nhanvien(909353, "Minh Nguyen Ngoc", true, "252 Duong So 6",8569945022, 15000000, LoaiNV.manager, new List<Lichtap>(), chiNhanh[11]));
            nhanvien.Add(new Nhanvien(656532, "Lara Huynh", true, "09 Ly Thuong Kiet",5558819196, 7000000, LoaiNV.receptionist, new List<Lichtap>(), chiNhanh[11]));
            nhanvien.Add(new Nhanvien(888069, "John Tran", true, "101 Tran Phu", 6917853777, 9000000, LoaiNV.PT, new List<Lichtap>(), chiNhanh[11]));
            nhanvien.Add(new Nhanvien(125002, "Hary Ngoc Phuc", false, "177 Chu Van An", 8815776968, 9000000, LoaiNV.PT, new List<Lichtap>(), chiNhanh[2]));
            nhanvien.Add(new Nhanvien(676822, "June Nguyen", true, "02 Nguyen Hue", 3336789125, 9000000, LoaiNV.PT, new List<Lichtap>(), chiNhanh[2]));
            nhanvien.Add(new Nhanvien(314895, "Anh Anh Ngo", false, "916 Lac Long Quan", 4437881526, 15000000, LoaiNV.manager, new List<Lichtap>(), chiNhanh[4]));
            nhanvien.Add(new Nhanvien(101353, "Davika Hoang", true, "666 Au Co",5517982256, 7000000, LoaiNV.receptionist, new List<Lichtap>(), chiNhanh[4]));
            nhanvien.Add(new Nhanvien(2002938, "Desty Tran Nguyen", true, "03 Dang Van Bi",4307179982, 9000000, LoaiNV.PT, new List<Lichtap>(), chiNhanh[4]));
            nhanvien.Add(new Nhanvien(717642,"Bohny Tran", true, "15 Bui Thi Xuan",2021567689, 9000000, LoaiNV.PT, new List<Lichtap>(), chiNhanh[4]));
            nhanvien.Add(new Nhanvien(535991, "Phuong Anh Tran", false, "123 Vo Van Ngan",8826469529, 9000000, LoaiNV.PT, new List<Lichtap>(), chiNhanh[6]));
            nhanvien.Add(new Nhanvien(188522, "Laris Bob", true, "435 Chu Van An",9978814528, 15000000, LoaiNV.manager, new List<Lichtap>(), chiNhanh[6]));
            nhanvien.Add(new Nhanvien(985101, "Jenny Dao",false, "98 Xuan Dieu", 934486998, 9000000, LoaiNV.PT, new List<Lichtap>(), chiNhanh[6]));
            nhanvien.Add(new Nhanvien(989113, "Ricky Huynh", true, "100 Le Hong Phong",943787658, 7000000, LoaiNV.receptionist, new List<Lichtap>(), chiNhanh[6]));*/
        }
        public static void Taoquanlisanpham()
        {

            qlsp.Add(new QlSanpham(711085122, "03/11/2021", sp[0], thanhvien[14]));
            qlsp.Add(new QlSanpham(711085124, "05/11/2021", sp[4], thanhvien[7]));
            qlsp.Add(new QlSanpham(711085131, "09/11/2021", sp[7], thanhvien[5]));
            qlsp.Add(new QlSanpham(711085129, "29/10/2021", sp[5], thanhvien[2]));
            qlsp.Add(new QlSanpham(711085125, "24/10/2021", sp[8], thanhvien[0]));
            qlsp.Add(new QlSanpham(711085130, "21/10/2021", sp[9], thanhvien[1]));
            qlsp.Add(new QlSanpham(711085127, "02/11/2021", sp[6], thanhvien[10]));
            qlsp.Add(new QlSanpham(711085126, "21/11/2021", sp[2], thanhvien[12]));
            qlsp.Add(new QlSanpham(711085129, "16/11/2021", sp[5], thanhvien[6]));
            qlsp.Add(new QlSanpham(711085123, "10/11/2021", sp[4], thanhvien[5]));

        }
        public static void Taodanhsachgiaodich()
        {
            giaodich.Add(new Giaodich(1001, "Giao dich 1001", 400000, "03-10-2021", thanhvien[0]));
            giaodich.Add(new Giaodich(1002, "Giao dich 1002", 400000, "01-10-2021", thanhvien[1]));
            giaodich.Add(new Giaodich(1003, "Giao dich 1003", 400000, "24-09-2021", thanhvien[2]));
            giaodich.Add(new Giaodich(1004, "Giao dich 1004", 2400000, "30-09-2021", thanhvien[3]));
            giaodich.Add(new Giaodich(1005, "Giao dich 1005", 1800000, "05-10-2021", thanhvien[4]));
            giaodich.Add(new Giaodich(1006, "Giao dich 1006", 400000, "09-10-2021", thanhvien[5]));
            giaodich.Add(new Giaodich(1007, "Giao dich 1007", 400000, "02-10-2021", thanhvien[6]));
            giaodich.Add(new Giaodich(1008, "Giao dich 1008", 400000, "15-10-2021", thanhvien[7]));
            giaodich.Add(new Giaodich(1009, "Giao dich 1009", 400000, "12-10-2021", thanhvien[8]));
            giaodich.Add(new Giaodich(1010, "Giao dich 1010", 800000, "10-10-2021", thanhvien[9]));
            giaodich.Add(new Giaodich(1008, "Giao dich 1008", 400000, "25-09-2021", thanhvien[10]));
            giaodich.Add(new Giaodich(1008, "Giao dich 1008", 1800000, "22-09-2021", thanhvien[11]));
            giaodich.Add(new Giaodich(1008, "Giao dich 1008", 400000, "26-09-2021", thanhvien[12]));
            giaodich.Add(new Giaodich(1008, "Giao dich 1008", 800000, "08-10-2021", thanhvien[13]));
            giaodich.Add(new Giaodich(1008, "Giao dich 1008", 1200000, "11-10-2021", thanhvien[14]));




        }
        public static void Taodanhsachbaocaodoanhthu()
        {
            baocaodoanhthu.Add(new Baocaodoanhthu(01, "Doanh thu quý 1", "31/03/2021", chiNhanh[0], 850000000));
            baocaodoanhthu.Add(new Baocaodoanhthu(02, "Doanh thu quý 1", "31/03/2021", chiNhanh[1], 29000000));
            baocaodoanhthu.Add(new Baocaodoanhthu(03, "Doanh thu quý 1", "31/03/2021", chiNhanh[2], 25000000));
            baocaodoanhthu.Add(new Baocaodoanhthu(04, "Doanh thu quý 1", "31/03/2021", chiNhanh[3], 53000000));
            baocaodoanhthu.Add(new Baocaodoanhthu(05, "Doanh thu quý 1", "31/03/2021", chiNhanh[4], 61000000));
            baocaodoanhthu.Add(new Baocaodoanhthu(06, "Doanh thu quý 1", "31/03/2021", chiNhanh[0], 19000000));
            baocaodoanhthu.Add(new Baocaodoanhthu(07, "Doanh thu quý 1", "31/03/2021", chiNhanh[5], 55000000));
            baocaodoanhthu.Add(new Baocaodoanhthu(08, "Doanh thu quý 1", "31/03/2021", chiNhanh[5], 77000000));
            baocaodoanhthu.Add(new Baocaodoanhthu(09, "Doanh thu quý 1", "31/03/2021", chiNhanh[2], 62000000));

            baocaodoanhthu.Add(new Baocaodoanhthu(01, "Doanh thu quý 2", "30/06/2021", chiNhanh[0], 80000000));
            baocaodoanhthu.Add(new Baocaodoanhthu(02, "Doanh thu quý 2", "30/06/2021", chiNhanh[1], 15000000));
            baocaodoanhthu.Add(new Baocaodoanhthu(03, "Doanh thu quý 2", "30/06/2021", chiNhanh[2], 175000000));
            baocaodoanhthu.Add(new Baocaodoanhthu(04, "Doanh thu quý 2", "30/06/2021", chiNhanh[3], 40000000));
            baocaodoanhthu.Add(new Baocaodoanhthu(05, "Doanh thu quý 2", "30/06/2021", chiNhanh[4], 30000000));
            baocaodoanhthu.Add(new Baocaodoanhthu(06, "Doanh thu quý 2", "30/06/2021", chiNhanh[0], 50000000));
            baocaodoanhthu.Add(new Baocaodoanhthu(07, "Doanh thu quý 2", "30/06/2021", chiNhanh[5], 33000000));
            baocaodoanhthu.Add(new Baocaodoanhthu(08, "Doanh thu quý 2", "30/06/2021", chiNhanh[3], 39000000));
            baocaodoanhthu.Add(new Baocaodoanhthu(09, "Doanh thu quý 2", "30/06/2021", chiNhanh[1], 58000000));

            baocaodoanhthu.Add(new Baocaodoanhthu(01, "Doanh thu quý 3", "30/09/2021", chiNhanh[0], 70000000));
            baocaodoanhthu.Add(new Baocaodoanhthu(02, "Doanh thu quý 3", "30/09/2021", chiNhanh[1], 65000000));
            baocaodoanhthu.Add(new Baocaodoanhthu(03, "Doanh thu quý 3", "30/09/2021", chiNhanh[4], 35000000));
            baocaodoanhthu.Add(new Baocaodoanhthu(04, "Doanh thu quý 3", "30/09/2021", chiNhanh[3], 119000000));
            baocaodoanhthu.Add(new Baocaodoanhthu(05, "Doanh thu quý 3", "30/09/2021", chiNhanh[4], 25000000));
            baocaodoanhthu.Add(new Baocaodoanhthu(06, "Doanh thu quý 3", "30/09/2021", chiNhanh[5], 49000000));
            baocaodoanhthu.Add(new Baocaodoanhthu(07, "Doanh thu quý 3", "30/09/2021", chiNhanh[0], 61000000));
            baocaodoanhthu.Add(new Baocaodoanhthu(08, "Doanh thu quý 3", "30/09/2021", chiNhanh[0], 93000000));
            baocaodoanhthu.Add(new Baocaodoanhthu(09, "Doanh thu quý 3", "30/09/2021", chiNhanh[3],14000000));

            baocaodoanhthu.Add(new Baocaodoanhthu(01, "Doanh thu quý 4", "31/12/2021", chiNhanh[0], 50000000));
            baocaodoanhthu.Add(new Baocaodoanhthu(02, "Doanh thu quý 4", "31/12/2021", chiNhanh[1], 100000000));
            baocaodoanhthu.Add(new Baocaodoanhthu(03, "Doanh thu quý 4", "31/12/2021", chiNhanh[2], 75000000));
            baocaodoanhthu.Add(new Baocaodoanhthu(04, "Doanh thu quý 4", "31/12/2021", chiNhanh[3], 30000000));
            baocaodoanhthu.Add(new Baocaodoanhthu(05, "Doanh thu quý 4", "31/12/2021", chiNhanh[4], 60000000));
            baocaodoanhthu.Add(new Baocaodoanhthu(06, "Doanh thu quý 4", "31/12/2021", chiNhanh[5], 10000000));
            baocaodoanhthu.Add(new Baocaodoanhthu(07, "Doanh thu quý 4", "31/12/2021", chiNhanh[0], 25000000));
            baocaodoanhthu.Add(new Baocaodoanhthu(08, "Doanh thu quý 4", "31/12/2021", chiNhanh[0], 37000000));
            baocaodoanhthu.Add(new Baocaodoanhthu(09, "Doanh thu quý 4", "31/12/2021", chiNhanh[1], 42000000));

        }

        // 1. Liệt kê danh sách mã thành viên và tên thành viên của cac phòng gym o Q9
        public static void Linq01()
        {
            // lambda
                var ds = thanhvien.Where(tv => tv.chinhanh.diaChi == "Quan 9" );
                Console.WriteLine("Thông tin mã và tên của các thành viên ở Q9:");
                foreach (var item in ds)
                {
                    Console.WriteLine("{0} - {1}",
                      item.ma_TV, item.ten_TV);
                }
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //Khoi tao database
            Taodanhsachthe();
            Taodanhsachphonggym();
            Taochinhanh();
            TaoloaiSP();
            Taosanpham();
            
            Taonhanvien();
            Taothanhvien();
            Taolich();
            Taoquanlisanpham();
            Taodanhsachgiaodich();
            Taodanhsachbaocaodoanhthu();
            
            
            
            //Ham truy van
            Linq01();
            /*Console.WriteLine("Hello World!");*/
            Console.ReadKey();
        }
    }
}
