﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace textAdventure_thePassauDom_
{
    internal interface Iitems
    {
        string Name { get; set; }
        string Description { get; set; }
        int HpChange { get; set; }
        int SpChange { get; set; }
    }
}
