package mypack;

public class Baocaodoanhthu {
    public String ma_baocao;
    public String ten_baocao;
    public String date;
    public Chinhanh chinhanh;
    public int doanhthu;

    public Baocaodoanhthu(String ma_baocao, String ten_baocao, String date, Chinhanh chinhanh, int doanhthu) {
        this.ma_baocao = ma_baocao;
        this.ten_baocao = ten_baocao;
        this.date = date;
        this.chinhanh = chinhanh;
        this.doanhthu = doanhthu;
    }

    public Baocaodoanhthu(Baocaodoanhthu bc) {
        ma_baocao = bc.ma_baocao;
        ten_baocao = bc.ten_baocao;
        date = bc.date;
        chinhanh = bc.chinhanh;
        doanhthu = bc.doanhthu;
    }

    public String getMa_baocao() {
        return this.ma_baocao;
    }

    public void setMa_baocao(String ma_baocao) {
        this.ma_baocao = ma_baocao;
    }

    public String getTen_baocao() {
        return this.ten_baocao;
    }

    public void setTen_baocao(String ten_baocao) {
        this.ten_baocao = ten_baocao;
    }

    public String getDate() {
        return this.date;
    }

    public void setDate(String date) {
        this.date = date;
    }

    public Chinhanh getChinhanh() {
        return this.chinhanh;
    }

    public void setChinhanh(Chinhanh chinhanh) {
        this.chinhanh = chinhanh;
    }

    public int getDoanhthu() {
        return this.doanhthu;
    }

    public void setDoanhthu(int doanhthu) {
        this.doanhthu = doanhthu;
    }

}
