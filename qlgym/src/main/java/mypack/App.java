package mypack;

import java.util.ArrayList;
import java.util.List;
import java.util.stream.Collectors;

import mypack.Sanpham.loaitinhtrang;
import mypack.The.Loaithe;
import mypack.The.Trangthai;
import mypack.Nhanvien.LoaiNV;

/**
 * Hello world!
 */
public final class App {
        public static List<Gym> gym = new ArrayList<Gym>();
        public static List<Chinhanh> chiNhanh = new ArrayList<Chinhanh>();
        public static List<Baocaodoanhthu> baocaodoanhthu = new ArrayList<Baocaodoanhthu>();
        public static List<Giaodich> giaodich = new ArrayList<Giaodich>();
        public static List<Thanhvien> thanhvien = new ArrayList<Thanhvien>();
        public static List<Lichtap> tkb = new ArrayList<Lichtap>();
        public static List<LoaiSP> loaiSP = new ArrayList<LoaiSP>();
        public static List<Nhanvien> nhanvien = new ArrayList<Nhanvien>();
        public static List<QlSanpham> qlsp = new ArrayList<QlSanpham>();
        public static List<Sanpham> sp = new ArrayList<Sanpham>();
        public static List<The> the = new ArrayList<The>();

        public static void Taodanhsachthe() {
                the.add(new The("9704155217830672", Loaithe.Gold, "22-10-2021", "1 thang", Trangthai.conhoatdong));
                the.add(new The("9704156217890575", Loaithe.Delta, "22-10-2021", "6 thang", Trangthai.hethoatdong));
                the.add(new The("9704153415835619", Loaithe.Platinum, "22-10-2021", "3 thang", Trangthai.conhoatdong));
                the.add(new The("9704153415730533", Loaithe.Premium, "22-10-2021", "2 thang", Trangthai.conhoatdong));
                the.add(new The("9704153429583021", Loaithe.Platinum, "22-10-2021", "1 thang", Trangthai.conhoatdong));
                the.add(new The("9704156217890504", Loaithe.Platinum, "22-10-2021", "1 thang", Trangthai.hethoatdong));
        }

        public static void Taodanhsachphonggym() {
                gym.add(new Gym(001, "Duc-uyen co so 1"));
                gym.add(new Gym(002, "Duc-uyen co so 2"));
                gym.add(new Gym(003, "Duc-uyen co so 3"));
        }

        public static void Taochinhanh() {
                chiNhanh.add(new Chinhanh(213, gym.get(0), "Quan 1"));
                chiNhanh.add(new Chinhanh(214, gym.get(2), "Quan 9"));
                chiNhanh.add(new Chinhanh(216, gym.get(1), "Quan Thu Duc"));
                chiNhanh.add(new Chinhanh(217, gym.get(0), "Quan Binh Thanh"));
                chiNhanh.add(new Chinhanh(316, gym.get(1), "Quan 5"));
                chiNhanh.add(new Chinhanh(322, gym.get(0), "Quan 3"));
        }

        public static void TaoloaiSP() {
                loaiSP.add(new LoaiSP(711085122, "Thuc pham chuc nang"));
                loaiSP.add(new LoaiSP(711085128, "Dung cu the hinh"));
        }

        public static void Taosanpham() {
                sp.add(new Sanpham(711085122, "Whey Protein", loaiSP.get(0), 300000, chiNhanh.get(1),
                                loaitinhtrang.tot));
                sp.add(new Sanpham(711085123, "Barbell", loaiSP.get(1), 1000000, chiNhanh.get(2), loaitinhtrang.tot));
                sp.add(new Sanpham(711085124, "BCAA", loaiSP.get(0), 250000, chiNhanh.get(1), loaitinhtrang.quahan));
                sp.add(new Sanpham(711085125, "Dumbbells", loaiSP.get(1), 3500000, chiNhanh.get(4),
                                loaitinhtrang.huhong));
                sp.add(new Sanpham(711085126, "Pre workout", loaiSP.get(0), 520000, chiNhanh.get(0),
                                loaitinhtrang.tot));
                sp.add(new Sanpham(711085127, "Kettlebell", loaiSP.get(1), 5000000, chiNhanh.get(0),
                                loaitinhtrang.huhong));
                sp.add(new Sanpham(711085128, "Dau ca Omega 3", loaiSP.get(0), 1000000, chiNhanh.get(3),
                                loaitinhtrang.quahan));
                sp.add(new Sanpham(711085129, "Weight Plates", loaiSP.get(1), 710000, chiNhanh.get(1),
                                loaitinhtrang.huhong));
                sp.add(new Sanpham(711085130, "Vitamin và khoáng chất", loaiSP.get(0), 600000, chiNhanh.get(4),
                                loaitinhtrang.quahan));
                sp.add(new Sanpham(711085131, "May chay bo", loaiSP.get(0), 35000000, chiNhanh.get(3),
                                loaitinhtrang.tot));
        }

        public static void Taolich() {
                tkb.add(new Lichtap("43BOL8509f", "PH3", "Dance", "20-10-2021", "7", "9"));
                tkb.add(new Lichtap("bXQkTsmjAm", "PH1", "Yoga", "20-10-2021", "7", "9"));
                tkb.add(new Lichtap("WRj8z3zlYN", "PH2", "Kickboxing", "20-10-2021", "19", "21"));
                tkb.add(new Lichtap("loBuMOjiLd", "PH1", "Yoga", "21-10-2021", "7", "9"));
                tkb.add(new Lichtap("6vxWfiaIgS", "PH3", "Dance", "20-10-2021", "16", "18"));
                tkb.add(new Lichtap("6vxWfiaIgS", "PH4", "Fit Ball", "21-10-2021", "9", "11"));
                tkb.add(new Lichtap("Qz0FQn4Eds", "PH4", "Yoga", "21-10-2021", "16", "18"));
                tkb.add(new Lichtap("24PEYBUMqZ", "PH1", "Fit Ball", "22-10-2021", "7", "9"));
                tkb.add(new Lichtap("FkMrbCnzr3", "PH2", "Dance", "22-10-2021", "16", "18"));
                tkb.add(new Lichtap("FkMrbCnzr3", "PH1", "Kickboxing", "22-10-2021", "19", "21"));

                nhanvien.get(0).lichlam.add(tkb.get(5));
                thanhvien.get(0).lichtap.add(tkb.get(5));
                nhanvien.get(0).lichlam.add(tkb.get(4));
                thanhvien.get(0).lichtap.add(tkb.get(4));
                nhanvien.get(0).lichlam.add(tkb.get(6));
                thanhvien.get(0).lichtap.add(tkb.get(6));
                nhanvien.get(1).lichlam.add(tkb.get(3));
                thanhvien.get(1).lichtap.add(tkb.get(2));
                nhanvien.get(1).lichlam.add(tkb.get(7));
                thanhvien.get(1).lichtap.add(tkb.get(4));
                nhanvien.get(1).lichlam.add(tkb.get(4));
                thanhvien.get(2).lichtap.add(tkb.get(3));
                nhanvien.get(2).lichlam.add(tkb.get(6));
                thanhvien.get(2).lichtap.add(tkb.get(8));
                nhanvien.get(2).lichlam.add(tkb.get(4));
                thanhvien.get(2).lichtap.add(tkb.get(1));
                nhanvien.get(2).lichlam.add(tkb.get(7));
                thanhvien.get(2).lichtap.add(tkb.get(0));
                nhanvien.get(3).lichlam.add(tkb.get(8));
                thanhvien.get(3).lichtap.add(tkb.get(0));
                nhanvien.get(3).lichlam.add(tkb.get(4));
                thanhvien.get(4).lichtap.add(tkb.get(9));
                nhanvien.get(3).lichlam.add(tkb.get(1));
                thanhvien.get(4).lichtap.add(tkb.get(6));
                nhanvien.get(4).lichlam.add(tkb.get(6));
                thanhvien.get(5).lichtap.add(tkb.get(5));
                nhanvien.get(4).lichlam.add(tkb.get(2));
                thanhvien.get(5).lichtap.add(tkb.get(4));
                nhanvien.get(4).lichlam.add(tkb.get(0));
                thanhvien.get(5).lichtap.add(tkb.get(9));
                nhanvien.get(5).lichlam.add(tkb.get(5));
                thanhvien.get(6).lichtap.add(tkb.get(0));
                nhanvien.get(5).lichlam.add(tkb.get(9));
                nhanvien.get(5).lichlam.add(tkb.get(3));
                nhanvien.get(6).lichlam.add(tkb.get(1));
                nhanvien.get(6).lichlam.add(tkb.get(4));
                nhanvien.get(6).lichlam.add(tkb.get(5));
                nhanvien.get(7).lichlam.add(tkb.get(8));
                nhanvien.get(7).lichlam.add(tkb.get(3));
                nhanvien.get(7).lichlam.add(tkb.get(2));
                nhanvien.get(8).lichlam.add(tkb.get(7));

                nhanvien.get(8).lichlam.add(tkb.get(5));
                thanhvien.get(7).lichtap.add(tkb.get(0));
                nhanvien.get(8).lichlam.add(tkb.get(4));
                thanhvien.get(7).lichtap.add(tkb.get(2));
                nhanvien.get(9).lichlam.add(tkb.get(6));
                thanhvien.get(7).lichtap.add(tkb.get(3));
                nhanvien.get(9).lichlam.add(tkb.get(3));
                thanhvien.get(8).lichtap.add(tkb.get(3));
                nhanvien.get(9).lichlam.add(tkb.get(7));
                thanhvien.get(8).lichtap.add(tkb.get(5));
                nhanvien.get(10).lichlam.add(tkb.get(4));
                thanhvien.get(9).lichtap.add(tkb.get(6));
                nhanvien.get(10).lichlam.add(tkb.get(6));
                thanhvien.get(9).lichtap.add(tkb.get(7));
                nhanvien.get(10).lichlam.add(tkb.get(4));
                thanhvien.get(9).lichtap.add(tkb.get(9));
                nhanvien.get(11).lichlam.add(tkb.get(7));
                thanhvien.get(10).lichtap.add(tkb.get(7));
                nhanvien.get(11).lichlam.add(tkb.get(8));
                thanhvien.get(11).lichtap.add(tkb.get(2));
                nhanvien.get(11).lichlam.add(tkb.get(4));
                thanhvien.get(11).lichtap.add(tkb.get(1));
                nhanvien.get(12).lichlam.add(tkb.get(1));
                thanhvien.get(12).lichtap.add(tkb.get(1));
                nhanvien.get(12).lichlam.add(tkb.get(6));
                thanhvien.get(13).lichtap.add(tkb.get(3));
                nhanvien.get(12).lichlam.add(tkb.get(2));
                thanhvien.get(13).lichtap.add(tkb.get(0));
                nhanvien.get(13).lichlam.add(tkb.get(0));
                thanhvien.get(14).lichtap.add(tkb.get(0));
                nhanvien.get(13).lichlam.add(tkb.get(5));
                nhanvien.get(13).lichlam.add(tkb.get(9));
                nhanvien.get(14).lichlam.add(tkb.get(3));
                nhanvien.get(14).lichlam.add(tkb.get(1));
                nhanvien.get(14).lichlam.add(tkb.get(4));
                nhanvien.get(15).lichlam.add(tkb.get(5));
                nhanvien.get(15).lichlam.add(tkb.get(8));
                nhanvien.get(15).lichlam.add(tkb.get(3));
                nhanvien.get(16).lichlam.add(tkb.get(2));
                nhanvien.get(16).lichlam.add(tkb.get(7));
                nhanvien.get(16).lichlam.add(tkb.get(9));
                nhanvien.get(17).lichlam.add(tkb.get(3));
                nhanvien.get(17).lichlam.add(tkb.get(1));
                nhanvien.get(17).lichlam.add(tkb.get(4));
                nhanvien.get(18).lichlam.add(tkb.get(5));
                nhanvien.get(18).lichlam.add(tkb.get(8));
                nhanvien.get(18).lichlam.add(tkb.get(3));
                nhanvien.get(19).lichlam.add(tkb.get(2));
                nhanvien.get(19).lichlam.add(tkb.get(7));
                nhanvien.get(19).lichlam.add(tkb.get(8));
        }

        public static void Taothanhvien()// 1 6 9 11
        {
                thanhvien.add(new Thanhvien(998401465, "Nguyen Van A", true, "521/14 Cach Mang Thang 8", "7819166574",
                                the.get(0), new ArrayList<Lichtap>(), chiNhanh.get(0)));
                thanhvien.add(new Thanhvien(412621804, "Bui Thi G", false, "2/9 Tu Mo", "3503132044", the.get(4),
                                new ArrayList<Lichtap>(), chiNhanh.get(5)));
                thanhvien.add(new Thanhvien(734803538, "Tran Van D", true, "785/80 Nguyen Kiem", "2958565427",
                                the.get(4), new ArrayList<Lichtap>(), chiNhanh.get(3)));
                thanhvien.add(new Thanhvien(610348461, "Nguyen Thi D", false, "524 Le Quang Dinh", "8903560125",
                                the.get(1), new ArrayList<Lichtap>(), chiNhanh.get(1)));
                thanhvien.add(new Thanhvien(716110654, "Hoang Thi A", false, "594 Nguyen Kiem", "7024709856",
                                the.get(2), new ArrayList<Lichtap>(), chiNhanh.get(0)));
                thanhvien.add(new Thanhvien(680004705, "Phan Thi H", false, "334/64 Chu Van An", "8958825384",
                                the.get(0), new ArrayList<Lichtap>(), chiNhanh.get(4)));
                thanhvien.add(new Thanhvien(139447593, "Ly Van E", true, "226/15 Nguyen Thai Son", "4447015263",
                                the.get(4), new ArrayList<Lichtap>(), chiNhanh.get(2)));
                thanhvien.add(new Thanhvien(201867690, "Le Thi R", false, "150 Dang Van Bi", "3558743834", the.get(0),
                                new ArrayList<Lichtap>(), chiNhanh.get(4)));
                thanhvien.add(new Thanhvien(105892218, "Vo Thi U", false, "25/14 Ly Thuong Kiet", "9699626970",
                                the.get(0), new ArrayList<Lichtap>(), chiNhanh.get(1)));
                thanhvien.add(new Thanhvien(336375368, "Chu Van J", true, "214/22 Duong So 6", "9627148492", the.get(3),
                                new ArrayList<Lichtap>(), chiNhanh.get(3)));
                thanhvien.add(new Thanhvien(287165352, "Ho Thi I", false, "465/30 Tran Hung Dao", "6906623185",
                                the.get(5), new ArrayList<Lichtap>(), chiNhanh.get(0)));
                thanhvien.add(new Thanhvien(229319933, "Lai Van Y", true, "195 Vo Van Ngan", "1064619458", the.get(2),
                                new ArrayList<Lichtap>(), chiNhanh.get(1)));
                thanhvien.add(new Thanhvien(373521329, "Duong Thi B", false, "112 Le Van Viet", "9924086803",
                                the.get(0), new ArrayList<Lichtap>(), chiNhanh.get(3)));
                thanhvien.add(new Thanhvien(341671974, "Huynh Thi K", false, "25/6 Ly thuong Kiet", "9924086803",
                                the.get(3), new ArrayList<Lichtap>(), chiNhanh.get(4)));
                thanhvien.add(new Thanhvien(369022312, "Dao Van L", true, "543 Cach Mang Thang 8", "9924086803",
                                the.get(2), new ArrayList<Lichtap>(), chiNhanh.get(4)));
        }

        public static void Taonhanvien() {

                nhanvien.add(new Nhanvien(991125, "Al Morgan", true, "225 Vo Van Ngan", 971288665, 9000000, LoaiNV.PT,
                                new ArrayList<Lichtap>(), chiNhanh.get(0)));
                nhanvien.add(new Nhanvien(171856, "Nguyen Tran Van", true, "179 Le Van Chi", 761258815, 7000000,
                                LoaiNV.receptionist, new ArrayList<Lichtap>(), chiNhanh.get(0)));
                nhanvien.add(new Nhanvien(648221, "Isidi", true, "05 Duong So 9 ", 661223839, 9000000, LoaiNV.PT,
                                new ArrayList<Lichtap>(), chiNhanh.get(0)));
                nhanvien.add(new Nhanvien(702207, "Dao Ngoc Nguyen", false, "170 Duong So 5", 881772656, 15000000,
                                LoaiNV.manager, new ArrayList<Lichtap>(), chiNhanh.get(0)));
                nhanvien.add(new Nhanvien(881272, "Tran Van An", true, "23 Vo Thi Sau", 777661893, 15000000,
                                LoaiNV.manager, new ArrayList<Lichtap>(), chiNhanh.get(1)));
                nhanvien.add(new Nhanvien(715223, "Tieu Phuong ", false, "01 Nguyen Dinh Chieu", 997879225, 9000000,
                                LoaiNV.PT, new ArrayList<Lichtap>(), chiNhanh.get(1)));
                nhanvien.add(new Nhanvien(881345, "Bella Le", false, "09 Duong So 7", 661752889, 7000000,
                                LoaiNV.receptionist, new ArrayList<Lichtap>(), chiNhanh.get(1)));
                nhanvien.add(new Nhanvien(217665, "Ta Le", true, "225 Duong 168", 991778252, 9000000, LoaiNV.PT,
                                new ArrayList<Lichtap>(), chiNhanh.get(1)));
                nhanvien.add(new Nhanvien(912801, "Dominick DecoLai", true, "01 Duong So 8", 776255199, 15000000,
                                LoaiNV.manager, new ArrayList<Lichtap>(), chiNhanh.get(2)));
                nhanvien.add(new Nhanvien(991277, "Thuy Lavie", false, "26 Ha Huy Tap", 883179662, 9000000, LoaiNV.PT,
                                new ArrayList<Lichtap>(), chiNhanh.get(2)));
                nhanvien.add(new Nhanvien(172387, "Jeb Saud", true, "127 Duong So 11", 993517660, 9000000, LoaiNV.PT,
                                new ArrayList<Lichtap>(), chiNhanh.get(2)));
                nhanvien.add(new Nhanvien(762558, "Al Morgan", true, "272 Le Van Viet", 661189175, 9000000,
                                LoaiNV.receptionist, new ArrayList<Lichtap>(), chiNhanh.get(2)));
                nhanvien.add(new Nhanvien(881335, "Lisa Emma", false, "111 Tam Ha", 1913255166, 9000000, LoaiNV.manager,
                                new ArrayList<Lichtap>(), chiNhanh.get(3)));
                nhanvien.add(new Nhanvien(225367, "Ryan Long", true, "228 To Ngoc Van", 997661532, 15000000, LoaiNV.PT,
                                new ArrayList<Lichtap>(), chiNhanh.get(3)));
                nhanvien.add(new Nhanvien(123456, "Linn Nguyen", false, "10 Tam Binh", 932751886, 7000000,
                                LoaiNV.receptionist, new ArrayList<Lichtap>(), chiNhanh.get(3)));
                nhanvien.add(new Nhanvien(830159, "Cozy Tran", false, "20 Nguyen Van Linh", 887225161, 15000000,
                                LoaiNV.PT, new ArrayList<Lichtap>(), chiNhanh.get(3)));
                nhanvien.add(new Nhanvien(897032, "Tu Le", true, "10 Nguyen Van Troi", 881925667, 9000000, LoaiNV.PT,
                                new ArrayList<Lichtap>(), chiNhanh.get(4)));
                nhanvien.add(new Nhanvien(916513, "Al Morgan", true, "668 Ta Quang Buu", 998335827, 9000000, LoaiNV.PT,
                                new ArrayList<Lichtap>(), chiNhanh.get(4)));
                nhanvien.add(new Nhanvien(227118, "Victory Dang", true, "05 Nguyen Duy Trinh", 618225991, 15000000,
                                LoaiNV.manager, new ArrayList<Lichtap>(), chiNhanh.get(4)));
                nhanvien.add(new Nhanvien(881235, "Davis Tran Dang", true, "115 Duong So 5", 971288665, 15000000,
                                LoaiNV.receptionist, new ArrayList<Lichtap>(), chiNhanh.get(4)));
                nhanvien.add(new Nhanvien(777909, "Edison Nguyen", true, "212 Vo Van Thuong", 971288665, 7000000,
                                LoaiNV.receptionist, new ArrayList<Lichtap>(), chiNhanh.get(5)));
                nhanvien.add(new Nhanvien(323616, "Jame Tran", true, "01 Le Van Viet", 661255188, 15000000,
                                LoaiNV.manager, new ArrayList<Lichtap>(), chiNhanh.get(5)));
                nhanvien.add(new Nhanvien(898772, "Johny Nguyen", true, "102 Hai Ba Trung", 991553818, 9000000,
                                LoaiNV.PT, new ArrayList<Lichtap>(), chiNhanh.get(5)));
                nhanvien.add(new Nhanvien(555378, "Evis Phuong", false, "444 Xo Viet Nghe Tinh", 554689991, 9000000,
                                LoaiNV.PT, new ArrayList<Lichtap>(), chiNhanh.get(5)));
                /*
                 * nhanvien.add(new Nhanvien(696888, "David Tran Phuong", true,
                 * "24 Hoang Dieu",9981776642, 15000000, LoaiNV.manager, new
                 * ArrayList<Lichtap>(), chiNhanh.get(7))); nhanvien.add(new Nhanvien(445712,
                 * "Oanh Le Phuong", true, "114 Hoang Dieu 2",8895541719, 9000000, LoaiNV.PT,
                 * new ArrayList<Lichtap>(), chiNhanh.get(11))); nhanvien.add(new
                 * Nhanvien(909353, "Minh Nguyen Ngoc", true, "252 Duong So 6",8569945022,
                 * 15000000, LoaiNV.manager, new ArrayList<Lichtap>(), chiNhanh.get(11)));
                 * nhanvien.add(new Nhanvien(656532, "Lara Huynh", true,
                 * "09 Ly Thuong Kiet",5558819196, 7000000, LoaiNV.receptionist, new
                 * ArrayList<Lichtap>(), chiNhanh.get(11))); nhanvien.add(new Nhanvien(888069,
                 * "John Tran", true, "101 Tran Phu", 6917853777, 9000000, LoaiNV.PT, new
                 * ArrayList<Lichtap>(), chiNhanh.get(11))); nhanvien.add(new Nhanvien(125002,
                 * "Hary Ngoc Phuc", false, "177 Chu Van An", 8815776968, 9000000, LoaiNV.PT,
                 * new ArrayList<Lichtap>(), chiNhanh.get(2))); nhanvien.add(new
                 * Nhanvien(676822, "June Nguyen", true, "02 Nguyen Hue", 3336789125, 9000000,
                 * LoaiNV.PT, new ArrayList<Lichtap>(), chiNhanh.get(2))); nhanvien.add(new
                 * Nhanvien(314895, "Anh Anh Ngo", false, "916 Lac Long Quan", 4437881526,
                 * 15000000, LoaiNV.manager, new ArrayList<Lichtap>(), chiNhanh.get(4)));
                 * nhanvien.add(new Nhanvien(101353, "Davika Hoang", true,
                 * "666 Au Co",5517982256, 7000000, LoaiNV.receptionist, new
                 * ArrayList<Lichtap>(), chiNhanh.get(4))); nhanvien.add(new Nhanvien(2002938,
                 * "Desty Tran Nguyen", true, "03 Dang Van Bi",4307179982, 9000000, LoaiNV.PT,
                 * new ArrayList<Lichtap>(), chiNhanh.get(4))); nhanvien.add(new
                 * Nhanvien(717642,"Bohny Tran", true, "15 Bui Thi Xuan",2021567689, 9000000,
                 * LoaiNV.PT, new ArrayList<Lichtap>(), chiNhanh.get(4))); nhanvien.add(new
                 * Nhanvien(535991, "Phuong Anh Tran", false, "123 Vo Van Ngan",8826469529,
                 * 9000000, LoaiNV.PT, new ArrayList<Lichtap>(), chiNhanh.get(6)));
                 * nhanvien.add(new Nhanvien(188522, "Laris Bob", true,
                 * "435 Chu Van An",9978814528, 15000000, LoaiNV.manager, new
                 * ArrayList<Lichtap>(), chiNhanh.get(6))); nhanvien.add(new Nhanvien(985101,
                 * "Jenny Dao",false, "98 Xuan Dieu", 934486998, 9000000, LoaiNV.PT, new
                 * ArrayList<Lichtap>(), chiNhanh.get(6))); nhanvien.add(new Nhanvien(989113,
                 * "Ricky Huynh", true, "100 Le Hong Phong",943787658, 7000000,
                 * LoaiNV.receptionist, new ArrayList<Lichtap>(), chiNhanh.get(6)));
                 */
        }

        public static void Taoquanlisanpham() {

                qlsp.add(new QlSanpham(711085122, "03/11/2021", sp.get(0), thanhvien.get(3)));
                qlsp.add(new QlSanpham(711085124, "05/11/2021", sp.get(4), thanhvien.get(7)));
                qlsp.add(new QlSanpham(711085131, "09/11/2021", sp.get(0), thanhvien.get(5)));
                qlsp.add(new QlSanpham(711085129, "29/10/2021", sp.get(5), thanhvien.get(2)));
                qlsp.add(new QlSanpham(711085125, "24/10/2021", sp.get(0), thanhvien.get(8)));
                qlsp.add(new QlSanpham(711085130, "21/10/2021", sp.get(9), thanhvien.get(1)));
                qlsp.add(new QlSanpham(711085127, "02/11/2021", sp.get(0), thanhvien.get(10)));
                qlsp.add(new QlSanpham(711085126, "21/11/2021", sp.get(2), thanhvien.get(12)));
                qlsp.add(new QlSanpham(711085129, "16/11/2021", sp.get(0), thanhvien.get(11)));
                qlsp.add(new QlSanpham(711085123, "10/11/2021", sp.get(4), thanhvien.get(5)));

        }

        public static void Taodanhsachgiaodich() {
                giaodich.add(new Giaodich(1001, "Giao dich 1001", 400000, "03-10-2021", thanhvien.get(0)));
                giaodich.add(new Giaodich(1002, "Giao dich 1002", 400000, "01-10-2021", thanhvien.get(1)));
                giaodich.add(new Giaodich(1003, "Giao dich 1003", 400000, "24-09-2021", thanhvien.get(2)));
                giaodich.add(new Giaodich(1004, "Giao dich 1004", 2400000, "30-09-2021", thanhvien.get(3)));
                giaodich.add(new Giaodich(1005, "Giao dich 1005", 1800000, "05-10-2021", thanhvien.get(5)));
                giaodich.add(new Giaodich(1006, "Giao dich 1006", 400000, "09-10-2021", thanhvien.get(5)));
                giaodich.add(new Giaodich(1007, "Giao dich 1007", 300000, "02-10-2021", thanhvien.get(2)));
                giaodich.add(new Giaodich(1008, "Giao dich 1008", 1000000, "15-10-2021", thanhvien.get(2)));
                giaodich.add(new Giaodich(1009, "Giao dich 1009", 400000, "12-10-2021", thanhvien.get(4)));
                giaodich.add(new Giaodich(1010, "Giao dich 1010", 800000, "10-10-2021", thanhvien.get(6)));
                giaodich.add(new Giaodich(1008, "Giao dich 1008", 400000, "25-09-2021", thanhvien.get(10)));
                giaodich.add(new Giaodich(1008, "Giao dich 1008", 1800000, "22-09-2021", thanhvien.get(13)));
                giaodich.add(new Giaodich(1008, "Giao dich 1008", 400000, "26-09-2021", thanhvien.get(14)));
                giaodich.add(new Giaodich(1008, "Giao dich 1008", 800000, "08-10-2021", thanhvien.get(13)));
                giaodich.add(new Giaodich(1008, "Giao dich 1008", 1200000, "11-10-2021", thanhvien.get(14)));

        }

        public static void Taodanhsachbaocaodoanhthu() {
                baocaodoanhthu.add(
                                new Baocaodoanhthu("01", "Doanh thu quý 1", "31/03/2021", chiNhanh.get(5), 850000000));
                baocaodoanhthu.add(
                                new Baocaodoanhthu("02", "Doanh thu quý 1", "31/03/2021", chiNhanh.get(1), 29000000));
                baocaodoanhthu.add(
                                new Baocaodoanhthu("03", "Doanh thu quý 1", "31/03/2021", chiNhanh.get(2), 25000000));
                baocaodoanhthu.add(
                                new Baocaodoanhthu("04", "Doanh thu quý 1", "31/03/2021", chiNhanh.get(3), 53000000));
                baocaodoanhthu.add(
                                new Baocaodoanhthu("05", "Doanh thu quý 1", "31/03/2021", chiNhanh.get(4), 61000000));
                baocaodoanhthu.add(
                                new Baocaodoanhthu("06", "Doanh thu quý 1", "31/03/2021", chiNhanh.get(0), 19000000));

                baocaodoanhthu.add(
                                new Baocaodoanhthu("07", "Doanh thu quý 2", "30/06/2021", chiNhanh.get(0), 80000000));
                baocaodoanhthu.add(
                                new Baocaodoanhthu("08", "Doanh thu quý 2", "30/06/2021", chiNhanh.get(1), 15000000));
                baocaodoanhthu.add(
                                new Baocaodoanhthu("09", "Doanh thu quý 2", "30/06/2021", chiNhanh.get(2), 175000000));
                baocaodoanhthu.add(
                                new Baocaodoanhthu("10", "Doanh thu quý 2", "30/06/2021", chiNhanh.get(3), 40000000));
                baocaodoanhthu.add(
                                new Baocaodoanhthu("11", "Doanh thu quý 2", "30/06/2021", chiNhanh.get(4), 30000000));
                baocaodoanhthu.add(
                                new Baocaodoanhthu("12", "Doanh thu quý 2", "30/06/2021", chiNhanh.get(5), 33000000));

                baocaodoanhthu.add(
                                new Baocaodoanhthu("13", "Doanh thu quý 3", "30/09/2021", chiNhanh.get(0), 70000000));
                baocaodoanhthu.add(
                                new Baocaodoanhthu("14", "Doanh thu quý 3", "30/09/2021", chiNhanh.get(1), 65000000));
                baocaodoanhthu.add(
                                new Baocaodoanhthu("15", "Doanh thu quý 3", "30/09/2021", chiNhanh.get(4), 35000000));
                baocaodoanhthu.add(
                                new Baocaodoanhthu("16", "Doanh thu quý 3", "30/09/2021", chiNhanh.get(3), 119000000));
                baocaodoanhthu.add(
                                new Baocaodoanhthu("17", "Doanh thu quý 3", "30/09/2021", chiNhanh.get(5), 49000000));
                baocaodoanhthu.add(
                                new Baocaodoanhthu("18", "Doanh thu quý 3", "30/09/2021", chiNhanh.get(2), 93000000));

                baocaodoanhthu.add(
                                new Baocaodoanhthu("19", "Doanh thu quý 4", "31/12/2021", chiNhanh.get(0), 50000000));
                baocaodoanhthu.add(
                                new Baocaodoanhthu("20", "Doanh thu quý 4", "31/12/2021", chiNhanh.get(1), 100000000));
                baocaodoanhthu.add(
                                new Baocaodoanhthu("21", "Doanh thu quý 4", "31/12/2021", chiNhanh.get(2), 75000000));
                baocaodoanhthu.add(
                                new Baocaodoanhthu("22", "Doanh thu quý 4", "31/12/2021", chiNhanh.get(3), 30000000));
                baocaodoanhthu.add(
                                new Baocaodoanhthu("23", "Doanh thu quý 4", "31/12/2021", chiNhanh.get(4), 60000000));
                baocaodoanhthu.add(
                                new Baocaodoanhthu("24", "Doanh thu quý 4", "31/12/2021", chiNhanh.get(5), 10000000));

        }

        // 1. Liệt kê danh sách mã thành viên và tên thành viên của cac phòng gym o Q9
        public static void Linq1() {
                List<Thanhvien> tv = thanhvien.stream().filter(p -> p.chinhanh.diaChi == "Quan 9")
                                .collect(Collectors.toList());
                for (Thanhvien thanhvien : tv) {
                        System.out.println(ConvertString.removeAccent(thanhvien.ma_TV + " - " + thanhvien.ten_TV));
                }
        }

        // 2.Cho biết tên của những thành viên mua sản phẩm Whey Protein ở phòng gym Q9
        public static void Linq2() {
                List<QlSanpham> Qlsp = qlsp.stream().filter(
                                p -> p.sanpham.Ten_SP == "Whey Protein" && p.thanhvien.chinhanh.diaChi == "Quan 9")
                                .collect(Collectors.toList());
                System.out.println(ConvertString
                                .removeAccent("Thông tin tên của các thành viên mua Whey Protein ở chi nhánh Q9:"));
                for (QlSanpham item : Qlsp) {
                        System.out.println(ConvertString.removeAccent(item.thanhvien.ten_TV));
                }
        }

        // 3.Cho biết tên chi nhánh nào có doanh thu thấp nhất trong quý 1
        public static void Linq3() {
                int k = baocaodoanhthu.stream().takeWhile(p -> p.ten_baocao == "Doanh thu quý 1")
                                .mapToInt(e -> e.doanhthu).min().getAsInt();
                Baocaodoanhthu baocao = baocaodoanhthu.stream().filter(p -> p.doanhthu == k).findFirst().get();
                System.out.println(ConvertString.removeAccent(
                                "Chi nhanh co doanh thu thap nhat trong quy 1 la: " + baocao.chinhanh.diaChi));
        }

        // 4.Cho biết thành viên Nguyễn Văn A đã tham gia những lớp học nào trog phòg
        // gym Q9
        public static void Linq4() {
                Thanhvien tv = thanhvien.stream().filter(p -> p.ten_TV == "Nguyen Van A").findFirst().get();

                for (int i = 0; i < tv.lichtap.size(); i++) {
                        System.out.println(ConvertString.removeAccent(tv.lichtap.get(i).activity));
                }
        }

        // 5.Cho biết các loại thẻ đã hết hạn và tên thành viên sở hữu thẻ
        public static void Linq5() {
                List<Thanhvien> tv = thanhvien.stream().filter(p -> p.the.trangthai == Trangthai.hethoatdong)
                                .collect(Collectors.toList());
                System.out.println(ConvertString
                                .removeAccent("Danh sách thẻ đã hết hạn và tên các thành viên sở hữu thẻ đã hết hạn:"));
                for (Thanhvien item : tv) {
                        System.out.println(ConvertString
                                        .removeAccent("The: " + item.the.loaithe + " - Chu the: " + item.ten_TV));
                }
        }

        public static void Linq6() {

        }

        public static void Linq7() {

        }

        public static void Linq8() {

        }

        public static void Linq9() {

        }

        public static void Linq10() {

        }

        public static void main(String[] args) {
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

                // Linq1();
                // Linq2();
                // Linq3();
                // Linq4();
                // Linq5();
                // Linq6();
                // Linq7();
                // Linq8();
                // Linq9();
                // Linq10();

        }
}
