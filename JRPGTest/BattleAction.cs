using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JRPGTest
{
    interface BattleAction
    {
        int ApCost { get; set; }

        void executeAction(); 
    }
}
