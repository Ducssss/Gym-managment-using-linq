using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Ly_Phong_Gym
{
    public class Lichtap
    {
        public int sched_ID { get; set; }
        public string session { get; set; }
        public string activity { get; set; }
        public DateTime? date { get; set; }
        public string time_start { get; set; }
        public string time_end { get; set; }
        /*public client_member client_ { get; set; }
        public Trainor trainor { get; set; }*/
        public Lichtap(int sched_ID, string session,string activity,DateTime date,string time_start,string time_end)
        {
            this.sched_ID = sched_ID;
            this.session = session;
            this.activity = activity;
            this.date = date;
            this.time_start = time_start;
            this.time_end = time_end;
            /*this.client_ = client_;
            this.trainor = trainor;*/
        }
        public Lichtap(Lichtap lt)
        {
            sched_ID = lt.sched_ID;
            session = lt.session;
            activity = lt.activity;
            date = lt.date;
            time_start = lt.time_start;
            time_end = lt.time_end;
            /*client_ = lt.client_;
            trainor = lt.trainor;*/
        }
    }
}
