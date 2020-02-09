using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JRPGTest
{
    class Program
    {
        /*
         * Class Interaction Plan:
         * _______________________
         * Program calls BattleManager.
         * BattleManager main loop will perform combat logic.
         * BattleManager main loop also will feed ConsoleView data and call tickDisplay().
         * Unit series classes will simply store data.
         * ConsoleView handles player input and passes it back to BattleManager.
         */

        private static BattleManager bm;
        private static ConsoleView cv;

        static void Main(string[] args)
        {
            //Initializes the linked classes.
            cv = new ConsoleView();
            bm = new BattleManager(cv);
            cv.LinkWithBattleManager(bm);

            bm.startMainLoop();
        }
    }
}
