using System;
using System.Collections.Generic;
using System.Text;

namespace RouletteLogic
{
    public class Writer
    {
        public string Greeting()
        {
            return "\n\nWelcome to the Jones Casino, please have a seat and get ready for the next Roulette roll.";
        }
        public string Odds(int playermoney)
        {
            string menu = $@"#****************************************************************************************************************#
#					         Bets Explained							 #
#****************************************************************************************************************#
# RED/BLACK- Simple. You’re making a bet on whether a red number or a black number will win. 			 #	
#	    These are marked “red” or “black” on the table.							 #
#  ODD/EVEN- You’re betting on whether an even or odd number is selected. This is marked as 			 #
#           “even” and “odd” on the table.									 #
#  High/Low- You’re betting on whether the number selected will fall within 1-18 (low) or 19-36 (high).          #  
#            Both are even money bets.										 #
#   Columns- This is a bet on the outcome being a number within one of the three columns of twelve numbers       #
#            that span the longest side of the roulette table.							 #
#    Dozens- This bet covers a dozen numbers, too. But, in order						 #
#    Street- This is a bet on any number within a row of three numbers.						 #
#    Split - This is the opposite of a straight bet. Instead of betting on one number, you’re placing a bet      #
#            on the line that separates two numbers.If either number comes up, you win.				 #
#    Corner- This bet is similar to the split bet. But instead of two numbers, you’re betting that one of        #
#            four numbers will come up.										 #
#            These numbers also need to touch (to form a square)						 #
#****************************************************************************************************************#
#						  Betting Floor							 #
#****************************************************************************************************************#
#                                                     ODDs							 #
#              ****************************************************************************   *******************#
#              # Numbers:(5/1) Even/Odd:(2/1) Red/Black:(2/1) Low/High:(2/1)  Dozen:(2/1) #   #	Player Money	 #
#              # Column:(2/1)   Street:(2/1)     Split:(2/1) 6Numbers:(2/1) Corner:(2/1)  #   #	{playermoney}		 #
#              ***************************************************************************    *******************#
#  Roulette Table							                                         #
#____________________					                                                         #
# 1st   | 1 | 2 | 3 |     RED: 1, 3, 5, 7, 9, 12, 14, 16, 18, 19, 21, 23, 25, 27, 30, 32, 34, 36        	 #
# 12	| 4 | 5 | 6 |	Black: 2, 4, 6, 8, 10, 11, 13, 15, 17, 20, 22, 24, 26, 28, 29, 31, 33, 35                #
#       | 7 | 8 | 9 |												 #
#_______| 10| 11| 12|												 #
# 2nd   | 13| 14| 15|                                              **********************************************#
# 12	| 16| 17| 18|					           # The Ball Landed on:        		 #
#	| 19| 20| 21|						   #						 #
#_______| 22| 23| 24|                                              **********************************************#
# 3rd	| 25| 26| 27|		                    					             		 #
# 12    | 28| 29| 30|                                              **********************************************#
#	| 31| 32| 33|						   # You win:   			         #
#_______| 34| 35| 36|						   #						 #
#       |___|___|___|                                              **********************************************#
#       |C.1|C.2|C.3|											         #
#****************************************************************************************************************#
#****************************************************************************************************************#";
            return menu;
        }
        public string ChooseColor()
        {
            return "\nPlease choose a color to play...\n" +
                   "1 - Black\n" +
                   "2 - Red";
        }
        public string ChooseBet()
        {
            return "\nChoose what type of bet you want: Color or Number\n" +
                   "1 - Color\n" +
                   "2 - Number\n" +
                   "3 - Even/Odd\n" +
                   "4 - High/Low\n" +
                   "5 - Dozen\n" +
                   "6 - Column\n" +
                   "7 - Street\n" +
                   "8 - Double\n" +
                   "9 - Split\n" +
                   "10 - Corner\n" +
                   "11 - Quit betting";
        }
        public string ChooseEvenOdd()
        {
            return "\n1 - Even\n" +
                   "2 - Odd";
        }
        public string Choosehighlow()
        {
            return "\n1 - High\n" +
                   "2 - Low";
        }
        public string ChooseSplit()
        {
            return "Please choose a number ";
        }
        public string ChooseSplit2(int result, int[] column1, int[] column2, int[] column3)
        {
            string choice = "";
            for (int i = 0; i < column1.Length; i++)
            {
                if (result == column1[i])
                {
                   choice = $"Please choose a second number for the split:\n" +
                $"{result + 1}\n" +
                $"{result + 3}\n" +
                $"{result - 3}\n";
                    if (result == 1)
                    {
                        choice = $"Please choose a second number for the split:\n" +
                                $"{result + 1}\n" +
                                $"{result + 3}\n";


                    }
                    if (result == 34)
                    {
                        choice = $"Please choose a second number for the split:\n" +
                                $"{result + 1}\n" +
                                $"{result - 3}\n";


                    }
                    return choice;
                    break;
                }
                              
            }        
                for (int i = 0; i < column3.Length; i++)
                {
                    if (result == column3[i])
                    {
                        choice = $"Please choose a second number for the split:\n" +
                        $"{result + 3}\n" +
                        $"{result - 1}\n" +
                        $"{result - 3}\n";
                    if (result == 3)
                    {
                        choice = $"Please choose a second number for the split:\n" +
                                $"{result - 1}\n" +
                                $"{result + 3}\n";


                    }
                    if (result == 36)
                    {
                        choice = $"Please choose a second number for the split:\n" +
                                $"{result - 1}\n" +
                                $"{result - 3}\n";


                    }
                    return choice;
                    break;
                }
                    
                }
            for (int i = 0; i < column2.Length; i++)
            {
                if (result == column2[i])
                {
                    choice = $"Please choose a second number for the split:\n" +
                    $"{result + 3}\n" +
                    $"{result - 1}\n" +
                    $"{result - 3}\n" +
                    $"{result +1}";
                    if (result == 2)
                    {
                        choice = $"Please choose a second number for the split:\n" +
                                $"{result + 1}\n" +
                                $"{result - 1}\n" +
                                $"{result - 3}\n";


                    }
                    if (result == 35)
                    {
                        choice = $"Please choose a second number for the split:\n" +
                                $"{result + 1}\n" +
                                $"{result - 1}\n" +
                                $"{result - 3}\n";


                    }
                    return choice;
                    break;
                }
                
            }



                return choice;
        }
        public string ChooseDozen()
        {
            return "\n1 - High (25 - 36)\n" +
                   "2 - Middle (13 - 24)\n" +
                   "3 - Low (1 - 12)";
        }
        public string ChooseStreet()
        {
            return "\n1 - Street 1 (1,2,3)\n" +
                   "2 - Street 2 (4,5,6)\n" +
                   "3 - Street 3 (7,8,9)\n" +
                   "4 - Street 4 (10,11,12)\n" +
                   "5 - Street 5 (13,14,15)\n" +
                   "6 - Street 6 (16,17,18)\n" +
                   "7 - Street 7 (19,20,21)\n" +
                   "8 - Street 8 (22,23,24)\n" +
                   "9 - Street 9 (25,26,27)\n" +
                   "10 - Street 10 (28,29,30)\n" +
                   "11 - Street 11 (31,32,33)\n" +
                   "12 - Street 12 (34,35,36)";
        }
        public string ChooseDoubleRow()
        {
            return "\n1 - Row  1 (1, 2, 3, 4, 5, 6)\n" +
                   "2 - Row  2 (7, 8, 9, 10, 11, 12)\n" +
                   "3 - Row  3 (13, 14, 15, 16, 17, 18)\n" +
                   "4 - Row  4 (19, 20, 21, 22, 23, 24)\n" +
                   "5 - Row  5 (25, 26, 27, 28, 29, 30)\n" +
                   "6 - Row  6 (31, 32, 33, 34, 35, 36)\n";
        }
        public string ChooseColumn()
        {
            return "\n1 - Column 1 (1,4,7,10,13,16,19,22,25,28,31,34)\n" +
                   "2 - Column 2 (2,5,8,11,14,17,20,23,26,29,32,35)\n" +
                   "3 - Column 3 (3,6,9,12,15,18,21,24,27,30,33,36)";
        }
        public string NumberChoice(int PlayerChoice)
        {
            if (PlayerChoice == 1)
            {
                
                return "\nPlease choose a number to play...";
            }
            else
            {
                return "\nPlease choose a number to play...";
            }
        }
        public string ChooseAgain()
        {
            return "\nPlease Choose a correct number";
        }
        public string BetAmount()
        {
            return "\nHow much would you like to bet?";
        }
        public string Rolling(int playermoney)
        {
            return $"\n\n<<<<< ROLLING >>>>>\n\n\n\nPress Enter...";
        }
        public string Result(int result, int playermoney,int winnings)
        {
            string menu = $@"#****************************************************************************************************************#
#						  Betting Floor							 #
#****************************************************************************************************************#
#                                                     ODDs							 #
#              ****************************************************************************   *******************#
#              # Numbers:(5/1) Even/Odd:(2/1) Red/Black:(2/1) Low/High:(2/1)  Dozen:(2/1) #   #	Player Money	 #
#              # Column:(2/1)   Street:(2/1)     Split:(2/1) 6Numbers:(2/1) Corner:(2/1)  #   #	{playermoney}		 #
#              ***************************************************************************    *******************#
#  Roulette Table							                                         #
#____________________					                                                         #
# 1st   | 1 | 2 | 3 |     RED: 1, 3, 5, 7, 9, 12, 14, 16, 18, 19, 21, 23, 25, 27, 30, 32, 34, 36        	 #
# 12	| 4 | 5 | 6 |	Black: 2, 4, 6, 8, 10, 11, 13, 15, 17, 20, 22, 24, 26, 28, 29, 31, 33, 35                #
#       | 7 | 8 | 9 |												 #
#_______| 10| 11| 12|												 #
# 2nd   | 13| 14| 15|                                              **********************************************#
# 12	| 16| 17| 18|					           # The Ball Landed on:########   {result}  ############
#	| 19| 20| 21|						   #						 #
#_______| 22| 23| 24|                                              **********************************************#
# 3rd	| 25| 26| 27|		                    					             		 #
# 12    | 28| 29| 30|                                              **********************************************#
#	| 31| 32| 33|						   #  You win: {winnings}  			         #
#_______| 34| 35| 36|						   #						 #
#       |___|___|___|                                              **********************************************#
#       |C.1|C.2|C.3|											         #
#****************************************************************************************************************#
#****************************************************************************************************************#

Press Enter...";
            return menu;
        }
        public string PlayAgain()
        {
            return "\n\nPlay again?\n1- Yes\n2- No";
        }
        public string BetsExplained()
        {
            return "RED/BLACK- Simple. You’re making a bet on whether a red number or a black number will win. These are marked “red” or “black” on the table.\n" +
                   "ODD/EVEN- You’re betting on whether an even or odd number is selected. This is marked as “even” and “odd” on the table.\n" +
                   "High/Low- You’re betting on whether the number selected will fall within 1-18 (low) or 19-36 (high). Both are even money bets.\n" +
                   "Columns- This is a bet on the outcome being a number within one of the three columns of twelve numbers that span the longest side of the roulette table.\n" +
                   "--Column 1 – This covers the ball landing on the numbers 1, 4, 7, 10, 13, 16, 19, 22, 25, 28, 31, 34\n" +
                   "--Column 2 – This covers the ball landing on numbers 2, 5, 8, 11, 14, 17, 20, 23, 26, 29, 32, 35\n" +
                   "--Column 3 – This covers the ball landing on numbers 3, 6, 9, 12, 15, 18, 21, 24, 27, 30, 33, 36\n" +
                   "Dozens- This bet covers a dozen numbers, too. But, in order\n" +
                   "Street- This is a bet on any number within a row of three numbers.\n" +
                   "Split - This is the opposite of a straight bet. Instead of betting on one number, you’re placing a bet on the line that separates two numbers.\n" +
                   "         If either number comes up, you win.\n" +
                   "Corner- This bet is similar to the split bet. But instead of two numbers, you’re betting that one of four numbers will come up.\n" +
                   "        These numbers also need to touch (to form a square)";
        }
        
    }
}
