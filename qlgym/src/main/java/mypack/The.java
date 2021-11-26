package mypack;

public class The {
    public enum Loaithe {
        Gold, Platinum, Delta, Premium
    }

    public enum Trangthai {
        conhoatdong, hethoatdong
    }

    public String ma_the;
    public Loaithe loaithe;
    public String ngayCap;
    public String thoiHan;
    public Trangthai trangthai;

    public The(String ma_the, Loaithe loaithe, String ngayCap, String thoiHan, Trangthai trangthai) {
        this.ma_the = ma_the;
        this.loaithe = loaithe;
        this.ngayCap = ngayCap;
        this.thoiHan = thoiHan;
        this.trangthai = trangthai;
    }

    public The(The the) {
        ma_the = the.ma_the;
        loaithe = the.loaithe;
        ngayCap = the.ngayCap;
        thoiHan = the.thoiHan;
        trangthai = the.trangthai;
    }

    public The(int i, Loaithe gold, String ngayCap2, String thoiHan2, Trangthai conhoatdong) {
    }

    public String getMa_the() {
        return this.ma_the;
    }

    public void setMa_the(String ma_the) {
        this.ma_the = ma_the;
    }

    public Loaithe getLoaithe() {
        return this.loaithe;
    }

    public void setLoaithe(Loaithe loaithe) {
        this.loaithe = loaithe;
    }

    public String getNgayCap() {
        return this.ngayCap;
    }

    public void setNgayCap(String ngayCap) {
        this.ngayCap = ngayCap;
    }

    public String getThoiHan() {
        return this.thoiHan;
    }

    public void setThoiHan(String thoiHan) {
        this.thoiHan = thoiHan;
    }

    public Trangthai getTrangthai() {
        return this.trangthai;
    }

    public void setTrangthai(Trangthai trangthai) {
        this.trangthai = trangthai;
    }

}
