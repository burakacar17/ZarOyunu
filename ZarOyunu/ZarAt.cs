using System;
using System.Collections.Generic;
using System.Text;

namespace ZarOyunu
{
    class ZarAt
    {
        int maxZarNumber;

        public ZarAt(int maxZarNumber)
        {
            this.maxZarNumber = maxZarNumber;
        }

       public int go()
        {
            Random random = new Random();
            int rnd = random.Next(1, maxZarNumber + 1);
            return rnd;
        }


    }
}
