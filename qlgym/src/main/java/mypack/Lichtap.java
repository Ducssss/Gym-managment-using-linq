package mypack;

public class Lichtap {
    public String sched_ID;
    public String session;
    public String activity;
    public String date;
    public String time_start;
    public String time_end;

    public Lichtap(String sched_ID, String session, String activity, String date, String time_start, String time_end) {
        this.sched_ID = sched_ID;
        this.session = session;
        this.activity = activity;
        this.date = date;
        this.time_start = time_start;
        this.time_end = time_end;
    }

    public Lichtap(Lichtap lt) {
        sched_ID = lt.sched_ID;
        session = lt.session;
        activity = lt.activity;
        date = lt.date;
        time_start = lt.time_start;
        time_end = lt.time_end;
    }

    public String getSched_ID() {
        return this.sched_ID;
    }

    public void setSched_ID(String sched_ID) {
        this.sched_ID = sched_ID;
    }

    public String getSession() {
        return this.session;
    }

    public void setSession(String session) {
        this.session = session;
    }

    public String getActivity() {
        return this.activity;
    }

    public void setActivity(String activity) {
        this.activity = activity;
    }

    public String getDate() {
        return this.date;
    }

    public void setDate(String date) {
        this.date = date;
    }

    public String getTime_start() {
        return this.time_start;
    }

    public void setTime_start(String time_start) {
        this.time_start = time_start;
    }

    public String getTime_end() {
        return this.time_end;
    }

    public void setTime_end(String time_end) {
        this.time_end = time_end;
    }

}
