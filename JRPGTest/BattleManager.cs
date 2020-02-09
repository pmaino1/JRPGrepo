using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JRPGTest.DataStructures;

namespace JRPGTest
{

    //MinPriorityQueue and all related classes were used with credit to https://github.com/aalhour/C-Sharp-Algorithms.
    class BattleManager
    {
        //Turn queue keeps the unit with turnSpeed closest to 0. 1000 to 0.
        public MinPriorityQueue<Unit, int> turnQueue;
        //default turnSpeed value
        private int defaultTurnSpeed = 1000;

        public List<PlayerUnit> playerUnits; //List of player units. Never emptied in a battle.
        public List<EnemyUnit> enemyUnits; //List of enemy units. Emptied when enemy dies.

        private ConsoleView consoleView;

        /*
         * Constructor.
         */
        public BattleManager(ConsoleView cv)
        {
            turnQueue = new MinPriorityQueue<Unit, int>(20);
            consoleView = cv;

            UnitInit();
        }

        public void startMainLoop()
        {
            mainLoop();
        }

        private void mainLoop()
        {

        }

        //Placeholder, full game would have units stored elsewhere
        public void UnitInit()
        {
            PlayerUnit adam = new PlayerUnit(
                84,
                "Adam",
                "The Bearded Buddy",
                422,
                2,
                69,
                7,
                0,
                4,
                98,
                20,
                0,
                87,
                0);
            playerUnits.Add(adam);
            turnQueue.Enqueue(adam,defaultTurnSpeed);

            PlayerUnit dylan = new PlayerUnit(
                2,
                "Dylan",
                "Probably an Alien",
                999,
                2,
                80,
                70,
                10,
                0,
                1,
                47,
                10,
                77,
                0);
            playerUnits.Add(adam);
            turnQueue.Enqueue(adam, defaultTurnSpeed);
        }
    }
}
