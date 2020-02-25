using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JRPGTest
{
    class PlayerUnit:Unit
    {
        //player values
        public int exp;

        //TODO create an Equipment class, probably one that holds all the equipment for one unit
        //Equipment equipment;

        public PlayerUnit(int level, string name, string title, int maxHP, int maxAP, int strength, int defense, int magic, int resilience,
            int speed, int agility, int skill, int luck, int exp) :
            base(level,name,title,maxHP, maxAP, strength, defense, magic, resilience, speed, agility, skill, luck)
        {
            this.exp = exp;
            //equipment = new Equipment(...);
        }
    }
}
