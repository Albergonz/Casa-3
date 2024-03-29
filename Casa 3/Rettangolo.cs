﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casa_3
{
    internal class Rettangolo
    {
        public int Altezza { get; set; }
        public int Base { get; set; }

        public float Area()
        {
            return Altezza * Base;
        }

        public float Perimetro()
        {

            return (Base * Altezza * 2);

        }

        public override string ToString()
        {
            return string.Format("Rettangolo di altezza {0} e base{1}", Altezza, Base);
        }
    }
}
