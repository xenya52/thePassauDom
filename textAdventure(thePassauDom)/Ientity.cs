using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace textAdventure_thePassauDom_
{
    internal interface Ientity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int HP { get; set; }
        public int Sp { get; set; }
        public void EntityDescription();
    }
}
