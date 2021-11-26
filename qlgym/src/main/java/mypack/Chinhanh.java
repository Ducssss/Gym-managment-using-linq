package mypack;

public class Chinhanh {
    public int maChiNhanh;
    public Gym gym;
    public String diaChi;

    public Chinhanh(int maChiNhanh, Gym gym, String diaChi) {
        this.maChiNhanh = maChiNhanh;
        this.gym = gym;
        this.diaChi = diaChi;

    }

    public Chinhanh(Chinhanh cn) {
        maChiNhanh = cn.maChiNhanh;
        gym = cn.gym;
        diaChi = cn.diaChi;
    }

    public int getMaChiNhanh() {
        return this.maChiNhanh;
    }

    public void setMaChiNhanh(int maChiNhanh) {
        this.maChiNhanh = maChiNhanh;
    }

    public Gym getGym() {
        return this.gym;
    }

    public void setGym(Gym gym) {
        this.gym = gym;
    }

    public String getDiaChi() {
        return this.diaChi;
    }

    public void setDiaChi(String diaChi) {
        this.diaChi = diaChi;
    }

}
