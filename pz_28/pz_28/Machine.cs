﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_28
{
    internal class Machine
    {
        public event MyDelegate IncrSpeed;
        public void Counter(int speed) => IncrSpeed?.Invoke(speed);
    }
}
