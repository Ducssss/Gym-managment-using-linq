package mypack;

public class Giaodich {
    public int trans_ID;
    public String trans_name;
    public int money;
    public String date;
    public Thanhvien thanhvien;

    public Giaodich(int trans_ID, String trans_name, int money, String date, Thanhvien thanhvien) {
        this.trans_ID = trans_ID;
        this.trans_name = trans_name;
        this.money = money;
        this.date = date;
        this.thanhvien = thanhvien;
    }

    public Giaodich(Giaodich ts) {
        trans_ID = ts.trans_ID;
        trans_name = ts.trans_name;
        money = ts.money;
        date = ts.date;
        thanhvien = ts.thanhvien;
    }

    public int getTrans_ID() {
        return this.trans_ID;
    }

    public void setTrans_ID(int trans_ID) {
        this.trans_ID = trans_ID;
    }

    public String getTrans_name() {
        return this.trans_name;
    }

    public void setTrans_name(String trans_name) {
        this.trans_name = trans_name;
    }

    public int getMoney() {
        return this.money;
    }

    public void setMoney(int money) {
        this.money = money;
    }

    public String getDate() {
        return this.date;
    }

    public void setDate(String date) {
        this.date = date;
    }

    public Thanhvien getThanhvien() {
        return this.thanhvien;
    }

    public void setThanhvien(Thanhvien thanhvien) {
        this.thanhvien = thanhvien;
    }

}
