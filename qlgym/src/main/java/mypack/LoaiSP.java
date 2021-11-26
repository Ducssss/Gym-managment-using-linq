package mypack;

public class LoaiSP {
    public int maLoai;
    public String tenLoai;

    public LoaiSP(int MaLoai, String TenLoai) {
        this.maLoai = MaLoai;
        this.tenLoai = TenLoai;
    }

    public LoaiSP(LoaiSP Loai) {
        tenLoai = Loai.tenLoai;
        maLoai = Loai.maLoai;
    }

    public int getMaLoai() {
        return this.maLoai;
    }

    public void setMaLoai(int maLoai) {
        this.maLoai = maLoai;
    }

    public String getTenLoai() {
        return this.tenLoai;
    }

    public void setTenLoai(String tenLoai) {
        this.tenLoai = tenLoai;
    }

}
