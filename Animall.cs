using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WolfIsland
{
    internal abstract class Animall
    {
        private Random random = new Random();
        public const int MaxFiald = 20;
        public int X { get; private set; }
        public int Y { get; private set; }
        abstract public Animall Reprodaction();
        protected int[,] Map = new int[,] { { -1, -1 }, { 0, -1 }, { 1, -1 }, { -1, 0 }, { 0, 1 }, {1, 0}, { -1, 1 }, { 1, 1 } };
        public void Muve(int m)
        {
            if (m != 8)
            {
                X = (Map[m, 0] + X >= 0 &&
                Map[m, 0] + X < MaxFiald) ? X + Map[m, 0] : X;
                Y =  (Map[m, 1] + Y >= 0 &&
                Map[m, 1] + Y < MaxFiald) ? Y + Map[m, 1] : Y;
            }
        }
        public Animall(int X, int Y)
        {
            this.X = X;
            this.Y = Y;

        }
        public Animall()
        {
            X = random.Next(MaxFiald -1);
            Y = random.Next(MaxFiald -1);
        }
    }
}
