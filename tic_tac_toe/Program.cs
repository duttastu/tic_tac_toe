﻿namespace tic_tac_toe
{
    internal class Program
    {
        static char[,] playField =
        {
            {'1','2','3'}, //row 0
            {'4','5','6'}, //row 1
            {'7','8','9'} // row 2
        };
        
        static int turns = 0;
        static void Main(string[] args)
        {
            int player = 2;
            int input = 0;
            bool inputCorrect = true;
           /* SetField();*/
            

            //Run code as  long as the program runs
            do
            {
                if (player == 2)
                {
                    player = 1;
                    EnterXorO( 'O', input );
                }
                    
                else if (player == 1) 
                {
                    player = 2;
                    EnterXorO('X', input);
                }
                SetField();
                #region
                //Check Winning condition
                char[] playerChars = { 'X', 'O' };
                foreach (char playerChar in playerChars)
                {
                    if (((playField[0, 0] == playerChar) && (playField[0, 1] == playerChar) && (playField[0, 2] == playerChar))
                        || ((playField[1, 0] == playerChar) && (playField[1, 1] == playerChar) && (playField[1, 2] == playerChar))
                        || ((playField[2, 0] == playerChar) && (playField[2, 1] == playerChar) && (playField[2, 2] == playerChar))
                        || ((playField[0, 0] == playerChar) && (playField[1, 0] == playerChar) && (playField[2, 0] == playerChar))
                        || ((playField[0, 1] == playerChar) && (playField[1, 1] == playerChar) && (playField[2, 1] == playerChar))
                        || ((playField[0, 0] == playerChar) && (playField[0, 1] == playerChar) && (playField[0, 2] == playerChar))
                        || ((playField[0, 2] == playerChar) && (playField[1, 2] == playerChar) && (playField[2, 2] == playerChar))
                        || ((playField[0, 0] == playerChar) && (playField[1, 1] == playerChar) && (playField[2, 2] == playerChar))
                        || ((playField[0, 2] == playerChar) && (playField[1, 1] == playerChar) && (playField[2, 0] == playerChar))
                        )


                    {
                        if (playerChar == 'X')
                        {
                            Console.WriteLine("\nPlayer 2 has won!");
                        }
                        else
                        {
                            Console.WriteLine("\nPlayer 1 has won!");
                        }
                        Console.WriteLine("Please press any key to reset the game");
                        Console.ReadKey();
                        Reset();
                        break;
                    }
                    else if (turns == 10)
                    {
                        Console.WriteLine("\nDRAWW");
                        Console.WriteLine("Please press any key to reset the game");
                        Console.ReadKey();
                        Reset();
                        break;
                    }
                }



                #endregion

                #region
                //test if field is already raken
                do
                {
                    Console.WriteLine("\nPlayer{0}: Choose your field! ", player);
                    try
                    {
                        input = Convert.ToInt32(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("Please enter a number");
                    }
                    if ((input == 1) && (playField[0, 0] == '1'))
                        inputCorrect = true;
                    else if((input == 2) && (playField[0,1]=='2'))
                        inputCorrect = true;
                    else if ((input == 3) && (playField[0, 2] == '3'))
                        inputCorrect = true;
                    else if ((input == 4) && (playField[1, 0] == '4'))
                        inputCorrect = true;
                    else if ((input == 5) && (playField[1, 1] == '5'))
                        inputCorrect = true;
                    else if ((input ==6) && (playField[1, 2] == '6'))
                        inputCorrect = true;
                    else if ((input == 7) && (playField[2, 0] == '7'))
                        inputCorrect = true;
                    else if ((input == 8) && (playField[2, 1] == '8'))
                        inputCorrect = true;
                    else if ((input ==9) && (playField[2, 2] == '9'))
                        inputCorrect = true;
                    else
                    {
                        Console.WriteLine("\nIncorrect Input! Please add another field");
                        
                        inputCorrect= false;
                    }


                } while(!inputCorrect);
                #endregion

            } while (true);

        }
        public static void Reset()
        {
            char[,] playFieldInitial =
            {
            {'1','2','3'}, //row 0
            {'4','5','6'}, //row 1
            {'7','8','9'} // row 2
             };
            playField = playFieldInitial;
            SetField();
            turns = 0;  
        }
        public static void SetField()
        {
            Console.Clear();
            Console.WriteLine("    |    |    ");
            //todo replace numvers with variable
            Console.WriteLine("  {0} | {1}  | {2}", playField[0, 0], playField[0, 1], playField[0, 2]);
            Console.WriteLine("____|____|____");
            Console.WriteLine("    |    |    ");
            //todo replace numvers with variable
            Console.WriteLine("  {0} | {1}  | {2}", playField[1, 0], playField[1, 1], playField[1, 2]);
            Console.WriteLine("____|____|____");
            Console.WriteLine("    |    |    ");
            //todo replace numvers with variable
            Console.WriteLine("  {0} | {1}  | {2}", playField[2, 0], playField[2, 1], playField[2, 2]);
            Console.WriteLine("____|____|____");
            Console.WriteLine("    |    |    ");
            turns++;


        }
        
        public static void EnterXorO(char playersign, int input)
        {
            
            
                switch (input)
            {
                case 1:
                    playField[0, 0] = playersign;
                    break;
                case 2:
                    playField[0, 1] = playersign;
                    break;
                case 3:
                    playField[0, 2] = playersign;
                    break;
                case 4:
                    playField[1, 0] = playersign;
                    break;
                case 5:
                    playField[1, 1] = playersign;
                    break;
                case 6:
                    playField[1, 2] = playersign;
                    break;
                case 7:
                    playField[2, 0] = playersign;
                    break;
                case 8:
                    playField[2, 1] = playersign;
                    break;
                case 9:
                    playField[2, 2] = playersign;
                    break;


            }
            
        }
        }
    }

