using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace textAdventure_thePassauDom_
{
    internal interface Iplaces
    {
        string Name { get; set; }
        string Description { get; set; }
        string left { get; set; }
        string right { get; set; }
        string slot { get; set; }
    }
}
