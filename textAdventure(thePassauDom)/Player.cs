﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace textAdventure_thePassauDom_
{
    internal class Player : Ihpsp
    {
        public string Name { get; set; }
        public int hp { get; set; }
        public int sp { get; set; }
        public int klass { get; set; }
        public int damage { get; set; }
    }
}
