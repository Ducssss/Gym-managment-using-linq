package mypack;

public class QlSanpham {
    public int mahang;
    public String thoiDiemDat;
    public Sanpham sanpham;
    public Thanhvien thanhvien;

    public QlSanpham(int mahang, String thoiDiemDat, Sanpham sanpham, Thanhvien thanhvien) {
        this.mahang = mahang;
        this.thoiDiemDat = thoiDiemDat;
        this.sanpham = sanpham;
        this.thanhvien = thanhvien;
    }

    public QlSanpham(QlSanpham qs) {
        mahang = qs.mahang;
        thoiDiemDat = qs.thoiDiemDat;
        sanpham = qs.sanpham;
        thanhvien = qs.thanhvien;
    }

    public int getMahang() {
        return this.mahang;
    }

    public void setMahang(int mahang) {
        this.mahang = mahang;
    }

    public String getThoiDiemDat() {
        return this.thoiDiemDat;
    }

    public void setThoiDiemDat(String thoiDiemDat) {
        this.thoiDiemDat = thoiDiemDat;
    }

    public Sanpham getSanpham() {
        return this.sanpham;
    }

    public void setSanpham(Sanpham sanpham) {
        this.sanpham = sanpham;
    }

    public Thanhvien getThanhvien() {
        return this.thanhvien;
    }

    public void setThanhvien(Thanhvien thanhvien) {
        this.thanhvien = thanhvien;
    }

}
