using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace textAdventure_thePassauDom_
{
    internal interface Ientity
    {
        public string EntityName { get; set; }
        public string EntityLittleDescription { get; set; }
        public int EntityHP { get; set; }
        public void EntityDescription();
    }
}
