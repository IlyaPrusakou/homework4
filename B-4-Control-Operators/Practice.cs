using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic.Lesson_4._1
{
    partial class Practice
    {
        //B4-P1/25. If_TimeOfDayGreeting
        public static void B4_P1_25_If_TimeOfDayGreeting()
        {
        }

        //B4-P2/25. If_NumbersComparing
        public static void B4_P2_25_If_NumbersComparing()
        {
        }

        //B4-P3/25. If_PositiveNumbersComparing
        public static void B4_P3_25_If_PositiveNumbersComparing()
        {
        }

        //B4-P4/25. If_Akinator5Numbers
        public static void B4_P4_25_If_Akinator5Numbers()
        {
            
        }

        //B4-P5/25. Switch_DayOfWeek
        public static void B4_P5_25_Switch_DayOfWeek()
        {
        }

        //B4-P6/25. Switch_GameNavigation
        public static void B4_P6_25_Switch_GameNavigation()
        {
            
        }

        //B4-P7/25. For_10OddEven
        public static void B4_P7_25_For_10OddEven()
        {
            
        }


        //B4-P8/25. For_3DevideNumbers
        public static void B4_P8_25_For_3DevideNumbers()
        {
        }


        //B4-P9/25. For_Matrix10x10
        public static void B4_P9_25_For_Matrix10x10()
        {
           
        }


        //B4-P10/25. For_HelloWorld
        public static void B4_P10_25_For_HelloWorld()
        {
        }


        //B4_P11/25. For_Afrochildren
        public static void B4_P11_25_For_Afrochildren()
        {
            
        }


        //B4-P12/25. For_Minus10OddEven
        public static void B4_P12_25_For_Minus10OddEven()
        {
        }


        //B4-P13/25 For_LettersCount
        public static void B4_P13_25_For_LettersCount()
        {
            Console.WriteLine("input your word");
            string s = Console.ReadLine();
            int score = 0;
            for (int i = 0; i < s.Length; i++)
            {
               score = s[i] == 'a' || s[i] == 'A' ? ++score:score;
            }
            Console.WriteLine(score);
        }


        //B4-P14/25 *For_AlphabetBack
        public static void B4_P14_25_For_AlphabetBack()
        {
            char result;
            int rest = 64;
            for (int i = 1; i < 27; i++)
            {
                result = (char)(rest + i);
                Console.WriteLine(Convert.ToString(result).ToUpper() + "  " + Convert.ToString(result).ToLower());
            }
        }


        //B4-P15/25 While_OddEventNumber
        public static void B4_P15_25_While_OddEventNumber()
        {
            
        }


        //B4-P16/25 DoWhile_OddEventNumber
        public static void B4_P16_25_DoWhile_OddEventNumber()
        {
           
        }


        //B4-P17/25 While_HelloWorld
        public static void B4_P17_25_While_HelloWorld()
        {
        }


        //B4-P18/25 While_Multiplier
        public static void B4_P18_25_While_Multiplier()
        {
            Console.WriteLine("Input the base number");
            int x = Convert.ToInt32(Console.ReadLine()); 
            Console.WriteLine("Input the power number");
            int i = Convert.ToInt32(Console.ReadLine());
            int score = 1;
            int result = x;
            while (score < i)
            {
                result *= x;
                score++;
            }
            Console.WriteLine("Answer   " + result);
        }



        //B4-P19/25 While_SolveNumberAdding
        public static void B4_P19_25_While_SolveNumberAdding()
        {
            
        }


        //B4-P20/25 While_DiceGame
        public static void B4_P20_25_While_DiceGame()
        {
            
        }


        //B4-P21/25 *While_DiceGameMultiplePlayers
        public static void dB4_P21_25_While_DiceGameMultiplePlayers()
        {
            bool playerFlag = true;
            int truePlayerscore = 0;
            int falsePlayerscore = 0;
            Random rnd = new Random();
            while (truePlayerscore < 25 && falsePlayerscore < 25)
            {
                while (playerFlag)
                {
                    Console.WriteLine("Input 1 for Player 1 uses bones");
                    string answerPlayer1 = Console.ReadLine();
                    if (answerPlayer1 == "1")
                    {
                        int player1Step = rnd.Next(7);
                        Console.WriteLine("Bones have shown " + player1Step);
                        truePlayerscore += player1Step;
                        Console.WriteLine($"Player 1 score is {truePlayerscore}");
                        playerFlag = !playerFlag;
                    }
                }
                while (!playerFlag)
                {
                    Console.WriteLine("Input 2 for Player 2 uses bones");
                    string answerPlayer2 = Console.ReadLine();
                    if (answerPlayer2 == "2")
                    {
                        int player2Step = rnd.Next(7);
                        Console.WriteLine("Bones have shown " + player2Step);
                        falsePlayerscore += player2Step;
                        Console.WriteLine($"Player 2 score is {falsePlayerscore}");
                        playerFlag = !playerFlag;
                    }
                }
            }
            if (truePlayerscore >= 25)
            {
                Console.WriteLine("Player 1 win");
            }
            else if (falsePlayerscore >= 25)
            {
                Console.WriteLine("Player 2 win");
            }
        }


        //B4-P22_25 *While_Akinator100Numbers
        public static void B4_P22_25_While_Akinator100Numbers()
        {
            List<int> arrayList = new List<int>();
            for (int i = 1; i < 101; i++)
            {
                arrayList.Add(i);
            }
            int leftBorder = 1;
            int rightBorder = arrayList.Count;
            while (!(leftBorder >= rightBorder))
            {
                int midValue = leftBorder + (rightBorder - leftBorder) / 2;
                Console.WriteLine($"Is your number equal {midValue} or less. If equal --- input e, if not equal --- input y/n");
                string answer = Console.ReadLine();
                if (answer == "y")
                {
                    rightBorder = midValue;
                }
                else if (answer == "n")
                {
                    leftBorder = midValue + 1;
                }
                else if (answer == "e")
                {
                    Console.WriteLine($"Your number is {midValue}");
                    break;
                }
                if ((rightBorder - leftBorder) <= 1)
                {
                    Console.WriteLine("Your number is  " + (leftBorder) + "Y?");
                    answer = Console.ReadLine();
                    if (answer == "y")
                    {
                        Console.WriteLine("the number have been solved");
                        break;
                    }
                    else if (answer == "n")
                    {
                        Console.WriteLine("Your number is  " + (rightBorder) );
                        break;
                    } 
                    
                }
            }

        }


        //B4-P23/25 IfElse_Calcultor
        public static void B4_P23_25_IfElse_Calcultor()
        {
            
        }


        //B4-P24_25 Switch_Calculator
        public static void B4_P24_25_Switch_Calculator()
        {
            
        }


        //B4-P25/25 Cycle_WordRevercse
        public static void B4_P25_25_Cycle_WordRevercse()
        {
            List<char> s = new List<char>();
            Console.WriteLine("input your word");
            string input = Console.ReadLine();
            foreach (char value in input)
            {
                s.Add(value);
            }
            
            for (int i = s.Count-1; i > -1; i--)
            {
                Console.Write(s[i]);
            }
            
        }
    }
}
