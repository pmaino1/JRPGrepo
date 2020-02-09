using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JRPGTest
{
    class ConsoleView
    {
        private BattleManager battleManager;

        public ConsoleView()
        {

        }

        public void LinkWithBattleManager(BattleManager bm)
        {
            battleManager = bm;
        }

        public void tickDisplay()
        {

        }
    }
}
