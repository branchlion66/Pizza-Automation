﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _210830Win_PizzaOtomasyonu
{
    class Ebat
    {
        public string Adi { get; set; }
        public double Carpan { get; set; }

        public override string ToString()
        {
            return string.Format("{0} - {1}",Adi,Carpan);
        }
    }
}
