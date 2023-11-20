using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoblinsAndGuis
{
    internal class Time
    {
        DateTime time1 = DateTime.Now;
        DateTime time2 = DateTime.Now;
        public float dt;

        public void Update()
        {
            time2 = DateTime.Now;
            dt = (time2.Ticks - time1.Ticks) / 10000000f;
            time1 = time2;
        }
    }
}
