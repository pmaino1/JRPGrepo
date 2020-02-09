using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JRPGTest
{
    class EnemyUnit:Unit
    {
        //enemy values
        public int expDrop;
        //public List<Item> itemDrops;
        //public List<Item> itemSteals;
        //public List<string> description;

        public EnemyUnit(int level, string name, string title, int maxHP, int maxAP, int strength, int defense, int magic, int resilience,
            int speed, int agility, int skill, int luck, int expDrop) :
            base(level,name,title,maxHP,maxAP,strength,defense,magic,resilience,speed,agility,skill,luck)
        {
            this.expDrop = expDrop;
        }
    }
}
