package mypack;

public class Sanpham {
    public enum loaitinhtrang {
        quahan, huhong, tot
    }

    public int ID_SP;
    public String Ten_SP;
    public LoaiSP loaiSP;
    public int giatien;
    public Chinhanh chinhanh;
    public loaitinhtrang tinhtrang;

    public Sanpham(int ID_SP, String Ten_SP, LoaiSP loaiSP, int giatien, Chinhanh chinhanh, loaitinhtrang tinhtrang) {
        this.ID_SP = ID_SP;
        this.Ten_SP = Ten_SP;
        this.loaiSP = loaiSP;
        this.giatien = giatien;
        this.chinhanh = chinhanh;
        this.tinhtrang = tinhtrang;
    }

    public Sanpham(Sanpham sp) {
        ID_SP = sp.ID_SP;
        Ten_SP = sp.Ten_SP;
        loaiSP = sp.loaiSP;
        giatien = sp.giatien;
        chinhanh = sp.chinhanh;
        tinhtrang = sp.tinhtrang;
    }

    public int getID_SP() {
        return this.ID_SP;
    }

    public void setID_SP(int ID_SP) {
        this.ID_SP = ID_SP;
    }

    public String getTen_SP() {
        return this.Ten_SP;
    }

    public void setTen_SP(String Ten_SP) {
        this.Ten_SP = Ten_SP;
    }

    public LoaiSP getLoaiSP() {
        return this.loaiSP;
    }

    public void setLoaiSP(LoaiSP loaiSP) {
        this.loaiSP = loaiSP;
    }

    public int getGiatien() {
        return this.giatien;
    }

    public void setGiatien(int giatien) {
        this.giatien = giatien;
    }

    public Chinhanh getChinhanh() {
        return this.chinhanh;
    }

    public void setChinhanh(Chinhanh chinhanh) {
        this.chinhanh = chinhanh;
    }

    public loaitinhtrang getTinhtrang() {
        return this.tinhtrang;
    }

    public void setTinhtrang(loaitinhtrang tinhtrang) {
        this.tinhtrang = tinhtrang;
    }

}
