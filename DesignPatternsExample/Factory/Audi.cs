﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class Audi : ICar
    {
        public int GetSpeed()
        {
            return 90;
        }
    }
}
