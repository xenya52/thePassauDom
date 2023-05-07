using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace textAdventure_thePassauDom_
{
    internal class Human : Ientity, Ihpsp
    {
        public string EntityName { get; set; } = "";
        public string EntityLittleDescription { get; set; } = "";
        public int EntityHP { get; set; }
        public int hp { get; set; }
        public int sp { get; set; }
        public void EntityDescription()
        {
            Console.WriteLine(EntityName + ", " + EntityLittleDescription);
            Console.ReadKey();
        }
    }
}
