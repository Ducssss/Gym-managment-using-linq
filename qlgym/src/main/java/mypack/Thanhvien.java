package mypack;

import java.util.ArrayList;
import java.util.List;

public class Thanhvien {
    public int ma_TV;
    public String ten_TV;
    public String gioiTinh;
    public String diaChi;
    public String SDT;
    public The the;
    public List<Lichtap> lichtap;
    public Chinhanh chinhanh;

    public Thanhvien(int ma_TV, String ten_TV, Boolean gioiTinh, String diaChi, String SDT, The the,
            ArrayList<Lichtap> lichtap, Chinhanh chinhanh) {
        this.ma_TV = ma_TV;
        this.ten_TV = ten_TV;
        this.gioiTinh = (gioiTinh == true) ? "Nam" : "Nu";
        this.diaChi = diaChi;
        this.SDT = SDT;
        this.the = the;
        this.lichtap = lichtap;
        this.chinhanh = chinhanh;
    }

    public Thanhvien(Thanhvien Thanhvien) {
        ma_TV = Thanhvien.ma_TV;
        ten_TV = Thanhvien.ten_TV;
        gioiTinh = Thanhvien.gioiTinh;
        diaChi = Thanhvien.diaChi;
        SDT = Thanhvien.SDT;
        the = Thanhvien.the;
        lichtap = Thanhvien.lichtap;
        chinhanh = Thanhvien.chinhanh;
    }

    public int getMa_TV() {
        return this.ma_TV;
    }

    public void setMa_TV(int ma_TV) {
        this.ma_TV = ma_TV;
    }

    public String getTen_TV() {
        return this.ten_TV;
    }

    public void setTen_TV(String ten_TV) {
        this.ten_TV = ten_TV;
    }

    public String getGioiTinh() {
        return this.gioiTinh;
    }

    public void setGioiTinh(String gioiTinh) {
        this.gioiTinh = gioiTinh;
    }

    public String getDiaChi() {
        return this.diaChi;
    }

    public void setDiaChi(String diaChi) {
        this.diaChi = diaChi;
    }

    public String getSDT() {
        return this.SDT;
    }

    public void setSDT(String SDT) {
        this.SDT = SDT;
    }

    public The getThe() {
        return this.the;
    }

    public void setThe(The the) {
        this.the = the;
    }

    public List<Lichtap> getLichtap() {
        return this.lichtap;
    }

    public void setLichtap(List<Lichtap> lichtap) {
        this.lichtap = lichtap;
    }

    public Chinhanh getChinhanh() {
        return this.chinhanh;
    }

    public void setChinhanh(Chinhanh chinhanh) {
        this.chinhanh = chinhanh;
    }

}
