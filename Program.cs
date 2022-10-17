using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace UserCase07_SankeLadder
{
     class Program
    {
        public  int Twoplayer()
        {
            int START_POSITION = 0;
            int WIN_POSITION = 100;
            int CURRENTPOSITION = 0;
            int dierollcount = 0;
            int dieRoll;
            int CURRENTPOSITION_DIFF = 0;
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
                            int ladder = 20;
                            int ladder1 = 40;
                            int Ladderentry = 15;
                            int Ladderentry1 = 30;

                            if (CURRENTPOSITION < 100)
                            {
                                CURRENTPOSITION += dieRoll;
                            }
                            if (CURRENTPOSITION == Ladderentry)
                            {
                                Console.WriteLine("------------------Entered into No.01 Ladder-----------");
                                //Ladder incremt position by 20//
                                CURRENTPOSITION += ladder;
                                //given chance for another dieroll//
                                CURRENTPOSITION += dieRoll;
                            }
                            if (CURRENTPOSITION == Ladderentry1)
                            {
                                Console.WriteLine("------------------Entered into No.02 Ladder------------");
                                //Ladder1 incremt position by 40//
                                CURRENTPOSITION += ladder1;
                                //given chance for another dieroll//
                                CURRENTPOSITION += dieRoll;
                            }
                            if (CURRENTPOSITION > WIN_POSITION)
                            {
                               
                               CURRENTPOSITION_DIFF=CURRENTPOSITION - WIN_POSITION;
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
                            else if (CURRENTPOSITION <= 0)
                            {
                                CURRENTPOSITION = START_POSITION;
                            }
                        }
                        break;
                    default:
                        Console.WriteLine("invalid");
                        break;
                }
                Console.WriteLine("CURRENTPOSITION is " + CURRENTPOSITION);
               
            }
            return CURRENTPOSITION_DIFF;
        }
        public static void Main(string[] args)
        {
           Program Objplayer01 = new Program();
            Console.WriteLine("----------------------------------Player01 game---------------------------");

           int player1game = Objplayer01.Twoplayer();
            Program Objplayer02 = new Program();
            Console.WriteLine("--------------------------------Player02 game---------------------------------");
            int Player2game = Objplayer02.Twoplayer();
            if (player1game > Player2game)
            {
                Console.WriteLine("Player A Won The Game");
                    }
            else
            {
                Console.WriteLine("Player B Won The Game");
            }
        }
    }
}
