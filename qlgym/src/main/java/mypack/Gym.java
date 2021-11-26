package mypack;

public class Gym {
    public int maphongGym;
    public String tenphongGym;

    public Gym(int maphongGym, String tenphongGym) {
        this.maphongGym = maphongGym;
        this.tenphongGym = tenphongGym;
    }

    public Gym(Gym gym) {
        maphongGym = gym.maphongGym;
        tenphongGym = gym.tenphongGym;
    }

    public int getMaphongGym() {
        return this.maphongGym;
    }

    public void setMaphongGym(int maphongGym) {
        this.maphongGym = maphongGym;
    }

    public String getTenphongGym() {
        return this.tenphongGym;
    }

    public void setTenphongGym(String tenphongGym) {
        this.tenphongGym = tenphongGym;
    }

}
