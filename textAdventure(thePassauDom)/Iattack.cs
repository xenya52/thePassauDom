using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace textAdventure_thePassauDom_
{
    internal interface Iattack
    {
        //Characteristics
        public string Name { get; set; }
        public string Description { get; set; }
        public int GivenDamage { get; set; }
        public int TakenDamage { get; set; }
        public int ReducedSp { get; set; }
        //Methods
        public void AttackPractise() { }
        public void AttackDescription() { }
    }
}
