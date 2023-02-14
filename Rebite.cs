using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WolfIsland
{
    internal class Rebite : Animall
    {
        private Random random = new Random();
        public Rebite()
        {

        }
        public void Muve()
        {
            int m = random.Next(0, 7);
            base.Muve(m);
        }
        override
        public Animall Reprodaction()
        {
            int h = random.Next(1, 5);
            if (h == 3)
            {
                return new Rebite();
            }
            else
            {
                return null;
            }
        }
    }
}
