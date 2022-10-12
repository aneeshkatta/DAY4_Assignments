using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UseCase2SnakeLadder
{
   public class UC2_SnakeLadder
    {
        public static void RollDice()

        {
            int START_POSITION = 0;
            int END_POSITION = 100;
            int dieRoll;

            Random random = new Random();
            dieRoll = random.Next(1, 7);
            Console.WriteLine("Number on die is: " + dieRoll);
        }
    }
}
