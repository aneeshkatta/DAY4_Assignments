using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserCase03_SnakeLadder
{
    class Uc03_snakeladder
    {
        public static void usercase03()
        {
            int START_POSITION = 0;
            int END_POSITION = 100;
            int dieRoll;
            Random random = new Random();
            //dieRoll = random.Next(1, 7);
            //Console.WriteLine("Number on die is: " + dieRoll);
            int playercheck = random.Next(1, 3);
            switch (playercheck)
            {
                case 1:
                    Console.WriteLine("No Play-the player stays in the same position");
                    break;
                case 2:
                    Console.WriteLine("the player moves ahead by the number of position received in the die");
                    break;
                case 3:
                    Console.WriteLine("the player moves behind by the number of position received in the die");
                    break;
            }
        }
    }
}
