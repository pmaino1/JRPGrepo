using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JRPGTest
{
    class Unit
    {
        public int level;
        public string name;
        public string title;

        //general stats
        public int maxHP; 
        public int maxAP; //number of actions per turn
        public int strength; //damage for physical
        public int defense; //resistance for physical 
        public int magic; //damage for magic
        public int resilience; //resistance for magic
        public int speed; //turn order
        public int agility; //dodge rate, attack count
        public int skill; //critical hit rate, buff/healing effectiveness
        public int luck; //minor critical hit rate, critical hit avoidance

        //in combat stats
        public int currHP;
        public int currAP;
        //public Status statuses;


        //arts
        //public Arts arts;

        //TODO elemental

        //TODO graphic/sound information

        /*
         * <summary>Generic Unit empty constructor.</summary>
         */
        public Unit()
        {
        }

        /*
         * <summary>Generic Unit constructor.</summary>
         */
        public Unit(int level, string name, string title, int maxHP, int maxAP, int strength, int defense, int magic,
            int resilience, int speed, int agility, int skill, int luck)
        {
            this.level = level;
            this.name = name;
            this.title = title;
            this.maxHP = maxHP;
            this.maxAP = maxAP;
            this.strength = strength;
            this.defense = defense;
            this.magic = magic;
            this.resilience = resilience;
            this.speed = speed;
            this.agility = agility;
            this.skill = skill;
            this.luck = luck;

            currHP = maxHP;
            currAP = maxAP;
        }
    }
}
