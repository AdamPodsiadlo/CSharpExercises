﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEx.Basics
{
    public class Swapper
    {
        public Swapper(int a, int b)
        {
            A = a;
            B = b;
        }

        public int A { get; set; }
        public int B { get; set; }

        public void Swap()
        {
            int temp = A;
            A = B;
            B = temp;
        }
    }
}
