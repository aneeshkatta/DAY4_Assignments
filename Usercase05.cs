using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserCase05_SnakeLadder
{
    class Usercase05
    {
        public static void usercase05()
        {
            int START_POSITION = 0;
            int WIN_POSITION = 100;
            int CURRENTPOSITION = 0;
            int dierollcount = 0;
            int dieRoll;
            while (CURRENTPOSITION < WIN_POSITION)
            {
                dierollcount++;
                Random random1 = new Random();
                int checkOptions = random1.Next(0, 3);
                switch (checkOptions)
                {
                    case 0:
                        {
                            Console.WriteLine("There will be no play. Player will be at same position");
                        }
                        break;

                    case 1:
                        {

                            Console.WriteLine("Player will move forward");
                            Random random = new Random();
                            dieRoll = random.Next(1, 7);
                            if (CURRENTPOSITION < 100)
                            {
                                CURRENTPOSITION += dieRoll;
                            }
                            if (CURRENTPOSITION > WIN_POSITION)
                            {
                                int PrevPosition = CURRENTPOSITION;
                                CURRENTPOSITION = WIN_POSITION;
                            }
                        }
                        break;
                    case 2:
                        {
                            Console.WriteLine("Player is bitten by a snake");
                            Random random = new Random();
                            dieRoll = random.Next(1, 7);
                            if (CURRENTPOSITION > 0)
                            {
                                CURRENTPOSITION -= dieRoll;

                            }
                            
                        }
                        break;
                    default:
                        Console.WriteLine("invalid");
                        break;
                }
                Console.WriteLine("CURRENTPOSITION is " + CURRENTPOSITION);

            }
           
        }
    }
}
