﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matematik
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DortIslem dortıslem = new DortIslem();
            dortıslem.Topla(5, 6);
            dortıslem.Topla(6, 9);
        }
    }
}
