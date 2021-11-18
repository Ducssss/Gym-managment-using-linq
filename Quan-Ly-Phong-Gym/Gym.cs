using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Ly_Phong_Gym
{
    class Gym
    {
        public int maphongGym { get; set; }
        public string tenphongGym { get; set; }

        public Gym(int maphongGym, string tenphongGym)
        {
            this.maphongGym = maphongGym;
            this.tenphongGym = tenphongGym;
        }

        public Gym(Gym gym)
        {
            maphongGym = gym.maphongGym;
            tenphongGym = gym.tenphongGym;
        }
    }
}
