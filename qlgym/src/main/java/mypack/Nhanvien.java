package mypack;

import java.util.ArrayList;
import java.util.List;

public class Nhanvien {
    public enum LoaiNV {
        manager, PT, receptionist
    }

    public int ma_nv;
    public String ten_nv;
    public Boolean gioiTinh;
    public String diaChi;
    public long SDT;
    public int tienluong;
    public LoaiNV loaiNV;
    public List<Lichtap> lichlam;
    public Chinhanh chinhanh;

    public Nhanvien(int ma_nv, String ten_nv, Boolean gioiTinh, String diaChi, long SDT, int tienluong, LoaiNV loaiNV,
            ArrayList<Lichtap> lichlam, Chinhanh chinhanh) {
        this.ma_nv = ma_nv;
        this.ten_nv = ten_nv;
        this.gioiTinh = gioiTinh;
        this.diaChi = diaChi;
        this.SDT = SDT;
        this.tienluong = tienluong;
        this.loaiNV = loaiNV;
        this.lichlam = lichlam;
        this.chinhanh = chinhanh;
    }

    public Nhanvien(Nhanvien nv) {
        ma_nv = nv.ma_nv;
        ten_nv = nv.ten_nv;
        gioiTinh = nv.gioiTinh;
        diaChi = nv.diaChi;
        SDT = nv.SDT;
        tienluong = nv.tienluong;
        loaiNV = nv.loaiNV;
        lichlam = nv.lichlam;
        chinhanh = nv.chinhanh;
    }

    public int getMa_nv() {
        return this.ma_nv;
    }

    public void setMa_nv(int ma_nv) {
        this.ma_nv = ma_nv;
    }

    public String getTen_nv() {
        return this.ten_nv;
    }

    public void setTen_nv(String ten_nv) {
        this.ten_nv = ten_nv;
    }

    public boolean isGioiTinh() {
        return this.gioiTinh;
    }

    public boolean getGioiTinh() {
        return this.gioiTinh;
    }

    public void setGioiTinh(boolean gioiTinh) {
        this.gioiTinh = gioiTinh;
    }

    public String getDiaChi() {
        return this.diaChi;
    }

    public void setDiaChi(String diaChi) {
        this.diaChi = diaChi;
    }

    public long getSDT() {
        return this.SDT;
    }

    public void setSDT(long SDT) {
        this.SDT = SDT;
    }

    public int getTienluong() {
        return this.tienluong;
    }

    public void setTienluong(int tienluong) {
        this.tienluong = tienluong;
    }

    public LoaiNV getLoaiNV() {
        return this.loaiNV;
    }

    public void setLoaiNV(LoaiNV loaiNV) {
        this.loaiNV = loaiNV;
    }

    public List<Lichtap> getLichlam() {
        return this.lichlam;
    }

    public void setLichlam(List<Lichtap> lichlam) {
        this.lichlam = lichlam;
    }

    public Chinhanh getChinhanh() {
        return this.chinhanh;
    }

    public void setChinhanh(Chinhanh chinhanh) {
        this.chinhanh = chinhanh;
    }

}
