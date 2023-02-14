using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WolfIsland
{
    internal class WolfFam : Animall
    {
        Random random = new Random();
        override
        public Animall Reprodaction()
        {
            return null;
        }

        public int Hels { get; private set; } //Свойство волчицы - Здоровье
        public WolfFam()
        {
            Hels = 10;
        }

        public void Muve(List<Rebite> rebites)
        {
            foreach (Rebite rebite in rebites)
            {
                for (int i = 0; i < 8; i++)
                {
                    if (X + Map[i, 0] == rebite.X && Y + Map[i, 1] == rebite.Y)
                    {
                        base.Muve(i);
                    }
                    else
                    {
                        int m = random.Next(0, 7);
                        base.Muve(m);
                    }
                }
            }
            Hels--;
        }
        public void Eat(List<Rebite> rebites)
        {
            for (int i = rebites.Count - 1; i >= 0; i--)
            {
                if (X == rebites[i].X && Y == rebites[i].Y)
                {
                    Hels = 10;
                    rebites.Remove(rebites[i]); 
                }
            }
        }
    }
}
