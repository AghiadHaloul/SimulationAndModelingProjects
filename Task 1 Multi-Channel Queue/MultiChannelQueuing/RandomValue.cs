using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiChannelQueuing
{
    public class RandomValue
    {
        static Random r = new Random();//For randomly selecting the server.
        public static int getRandom(int min, int max)
        {
            r = new Random();
            return r.Next(min, max);
        }
    }
}
