using System;
using System.ComponentModel.Design;

namespace RouletteLogic
{
    public class GameLogic
    {
        public int[] RedArray = new[] {1, 3, 5, 7, 9, 12, 14, 16, 18, 19, 21, 23, 25, 27, 30, 32, 34, 36};
        public int[] BlackArray = new[] {2,4,6,8,10,11,13,15,17,20,22,24,26,28,29,31,33,35};
        public int[] Column01Array = new[] { 1,4,7,10,13,16,19,22,25,28,31,34 };
        public int[] Column02Array = new[] { 2,5,8,11,14,17,20,23,26,29,32,35};
        public int[] Column03Array = new[] { 3,6,9,12,15,18,21,24,27,30,33,36 };
        public int[] FullArray = new[]
        {
            1, 3, 5, 7, 9, 12, 14, 16, 18, 19, 21, 23, 25, 27, 30, 32, 34, 36, 2, 4, 6, 8, 10, 11, 13, 15, 17, 20, 22,
            24, 26, 28, 29, 31, 33, 35
        };
        
        public int[] Double01Array = new[] {1, 2, 3, 4, 5, 6};
        public int[] Double02Array = new[] { 7,8,9,10,11,12};
        public int[] Double03Array = new[] { 13,14,15,16,17,18};
        public int[] Double04Array = new[] { 19,20,21,22,23,24};
        public int[] Double05Array = new[] { 25,26,27,28,29,30};
        public int[] Double06Array = new[] { 31,32,33,34,35,36};

        #region
        public int[] Corner1 = new[] { 1, 2, 4, 5 };
        public int[] Corner2 = new[] { 2, 3, 5, 6 };
        public int[] Corner3 = new[] { 4, 5, 7, 8 };
        public int[] Corner4 = new[] { 5, 6, 8, 9 };
        public int[] Corner5 = new[] { 7, 8, 10, 11 };
        public int[] Corner6 = new[] { 8, 9, 11, 12 };
        public int[] Corner7 = new[] { 10, 11, 13, 14 };
        public int[] Corner8 = new[] { 11, 12, 14, 15 };
        public int[] Corner9 = new[] { 13, 14, 16, 17 };
        public int[] Corner10 = new[] { 14, 15, 17, 18 };
        public int[] Corner11 = new[] { 16, 17, 19, 20 };
        public int[] Corner12 = new[] { 17, 18, 20, 21 };
        public int[] Corner13 = new[] { 19, 20, 22, 23 };
        public int[] Corner14 = new[] { 20, 21, 23, 24 };
        public int[] Corner15 = new[] { 22, 23, 25, 26 };
        public int[] Corner16 = new[] { 23, 24, 26, 27 };
        public int[] Corner17 = new[] { 25, 26, 28, 29 };
        public int[] Corner18 = new[] { 26, 27, 29, 30 };
        public int[] Corner19 = new[] { 28, 29, 31, 32 };
        public int[] Corner20 = new[] { 29, 30, 32, 33 };
        public int[] Corner21 = new[] { 31, 32, 34, 35 };
        public int[] Corner22 = new[] { 32, 33, 35, 36 };
        #endregion
        Random random = new Random();
        private int result { get; set; }
        public int Winnings { get; set; }

        public bool IsOdd(int num)
        {
            if ((num%2)>0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public int NumberResult()
        {
            result = FullArray[random.Next(0, FullArray.Length)];
            return result;
        }
        public string SplitWinningMath(int splitChoice01,int splitchoice02, int result, int bet)
        {
            //Numbers
            if (splitChoice01 == result || splitchoice02 == result)
            {
                this.Winnings = bet * 3;
                return $"Congrats you win {Winnings:C} for the Split Bet";
            }
            else
            {
                return "You didnt cash out on the Split Bet";
            }
        }
        public string NumbersWinningMath(int playerChoice, int result, int bet, int ColorChoice)
        {
            //Numbers
            if (playerChoice == result)
            {
                this.Winnings = bet * 3;
                return $"Congrats you win {Winnings:C} for the Number Bet";
            }
            else
            {
                return "You didnt cash out on the Number Bet";
            }
        }
        public string ODDWinningMath(int playerChoice, int result, int bet, int ColorChoice)
        {
            
            
            if (IsOdd(result) == true)
            {
                this.Winnings = bet * 2;
                return $"Congrats you win {Winnings:C} for the Odd Bet";
            }
            else
            {
                return "You didnt cash out on the Odd Bet";
            }
        }
        public string EvenWinningMath(int playerChoice, int result, int bet, int ColorChoice)
        {
            
            if (IsOdd(result) == false)
            {
                this.Winnings = bet * 2;
                return $"Congrats you win {Winnings:C} for the Even Bet";
            }
            
            else
            {
                return "You didnt cash out on the Even Bet";
            }
        }
        public string REDWinningMath(int playerChoice, int result, int bet, int ColorChoice)
        {
            for (int i = 0; i < RedArray.Length; i++)
            {
                if (result == RedArray[i])
                {
                    this.Winnings = bet * 2;
                    return $"Congrats you win {Winnings:C} for the Color Bet";
                    break;
                }
                else
                {
                    return "You didnt cash out on Color Bet";
                }
            }
           
            return null;
        }
        public string BLACKWinningMath(int playerChoice, int result, int bet, int ColorChoice)
        {
            
            for (int i = 0; i < BlackArray.Length; i++)
            {
                if (result == BlackArray[i])
                {
                    this.Winnings = bet * 2;
                    return $"Congrats you win {Winnings:C} for the Color Bet";
                    break;
                }
                else
                {
                    return "You didnt cash out on the Color Bet";
                }
            }

            return null;
        }
        public string HIGHWinningMath(int playerChoice, int result, int bet, int ColorChoice)
        {
            
            if (result >18)
            {
                this.Winnings = bet * 2;
                return $"Congrats you win {Winnings:C} for the High Bet";
            }

            else
            {
                return "You didnt cash out on the High Bet";
            }
        }
        public string LowWinningMath(int playerChoice, int result, int bet, int ColorChoice)
        {
           
            if (result <= 18)
            {
                this.Winnings = bet * 2;
                return $"Congrats you win {Winnings:C} for the low Bet";
            }
            else
            {
                return "You didnt cash out on the low Bet";
            }
        }
        public string TopDozenWinningMath(int playerChoice, int result, int bet, int ColorChoice)
        {
            //Dozens
            if (result>=25)
            {
                this.Winnings = bet * 2;
                return $"Congrats you win {Winnings:C} for the Dozen Bet";
            }
            else
            {
                return "You didnt cash out on the High Dozen Bet";
            }

        }
        public string MidDozenWinningMath(int playerChoice, int result, int bet, int ColorChoice)
        {
            
            if (result <= 24&& result >= 13)
            {
                this.Winnings = bet * 2;
                return $"Congrats you win {Winnings:C} for the Dozen Bet";
            }
            else
            {
                return "You didnt cash out on the Mid Dozen Bet";
            }

        }
        public string LowDozenWinningMath(int playerChoice, int result, int bet, int ColorChoice)
        {
           

            if (result<=12)
            {
                this.Winnings = bet * 2;
                return $"Congrats you win {Winnings:C} for the Dozen Bet";
            }
            else
            {
                return "You didnt cash out on the low Dozen Bet";
            }

        }
        public string Column01WinningMath(int playerChoice, int result, int bet, int ColorChoice)
        {
            //Column1
            for (int i = 0; i < Column01Array.Length; i++)
            {
                if (result == Column01Array[i])
                {
                    this.Winnings = bet * 2;
                    return $"Congrats you win {Winnings:C} for the Column Bet";
                    
                }
                else
                {
                    return "You didnt cash out on the Column Bet";
                }
            }
            return "Play again!!!";
            
        }
        public string Column02WinningMath(int playerChoice, int result, int bet, int ColorChoice)
        {

            //Column2
            for (int i = 0; i < Column02Array.Length; i++)
            {
                if (result== Column02Array[i])
                {
                    this.Winnings = bet * 2;
                    return $"Congrats you win {Winnings:C} for the Column Bet";
                    break;
                }
                else
                {
                    return "You didnt cash out on the Column Bet";
                }
            }
           
            return "Play again!!!";

        }
        public string Column03WinningMath(int playerChoice, int result, int bet, int ColorChoice)
        {
            
            for (int i = 0; i < Column03Array.Length; i++)
            {
                if (result== Column03Array[i])
                {
                    this.Winnings = bet * 2;
                    return $"Congrats you win {Winnings:C} for the Column Bet";
                    break;
                }
                else
                {
                    return "You didnt cash out on the Column Bet";
                }
            }

            return "Play again!!!";

        }
        #region //Street Bets
        public string Street01WinningMath(int playerChoice, int result, int bet, int ColorChoice)
        {
            if (result == 1 || result == 2 || result == 3)
            {
                this.Winnings = bet * 2;
                return $"Congrats you win {Winnings:C} for the Street Bet";
            }
            else return "You didnt cash out on the Street Bet";

        }
        public string Street02WinningMath(int playerChoice, int result, int bet, int ColorChoice)
        {
            if (result == 4 || result == 5 || result == 6)
            {
                this.Winnings = bet * 2;
                return $"Congrats you win {Winnings:C} for the Street Bet";
            }
            else return "You didnt cash out on the Street Bet";
        }
        public string Street03WinningMath(int playerChoice, int result, int bet, int ColorChoice)
        {
            if (result == 7 || result == 8 || result == 9)
            {
                this.Winnings = bet * 2;
                return $"Congrats you win {Winnings:C} for the Street Bet";
            }
            else return "You didnt cash out on the Street Bet";
        }
        public string Street04WinningMath(int playerChoice, int result, int bet, int ColorChoice)
        {
            if (result == 10 || result == 11 || result == 12)
            {
                this.Winnings = bet * 2;
                return $"Congrats you win {Winnings:C} for the Street Bet";
            }
            else return "You didnt cash out on the Street Bet";
        }
        public string Street05WinningMath(int playerChoice, int result, int bet, int ColorChoice)
        {
            if (result == 13 || result == 14 || result == 15)
            {
                this.Winnings = bet * 2;
                return $"Congrats you win {Winnings:C} for the Street Bet";
            }
            else return "You didnt cash out on the Street Bet";
        }
        public string Street06WinningMath(int playerChoice, int result, int bet, int ColorChoice)
        {
            if (result == 16 || result == 17 || result == 18)
            {
                this.Winnings = bet * 2;
                return $"Congrats you win {Winnings:C} for the Street Bet";
            }
            else return "You didnt cash out on the Street Bet";
        }
        public string Street07WinningMath(int playerChoice, int result, int bet, int ColorChoice)
        {
            if (result == 19 || result == 20 || result == 21)
            {
                this.Winnings = bet * 2;
                return $"Congrats you win {Winnings:C} for the Street Bet";
            }
            else return "You didnt cash out on the Street Bet";
        }
        public string Street08WinningMath(int playerChoice, int result, int bet, int ColorChoice)
        {
            if (result == 22 || result == 23 || result == 24)
            {
                this.Winnings = bet * 2;
                return $"Congrats you win {Winnings:C} for the Street Bet";
            }
            else return "You didnt cash out on the Street Bet";

        }
        public string Street09WinningMath(int playerChoice, int result, int bet, int ColorChoice)
        {
            if (result == 25 || result == 26 || result == 27)
            {
                this.Winnings = bet * 2;
                return $"Congrats you win {Winnings:C} for the Street Bet";
            }
            else return "You didnt cash out on the Street Bet";
        }
        public string Street10WinningMath(int playerChoice, int result, int bet, int ColorChoice)
        {
            if (result == 28 || result == 29 || result == 30)
            {
                this.Winnings = bet * 2;
                return $"Congrats you win {Winnings:C} for the Street Bet";
            }
            else return "You didnt cash out on the Street Bet";
        }
        public string Street11WinningMath(int playerChoice, int result, int bet, int ColorChoice)
        {
            if (result == 31 || result == 32 || result == 33)
            {
                this.Winnings = bet * 2;
                return $"Congrats you win {Winnings:C} for the Street Bet";
            }
            else return "You didnt cash out on the Street Bet";
        }
        public string Street12WinningMath(int playerChoice, int result, int bet, int ColorChoice)
        {
            if (result == 34 || result == 35 || result == 36)
            {
                this.Winnings = bet * 2;
                return $"Congrats you win {Winnings:C} for the Street Bet";
            }
            else return "You didnt cash out on the Street Bet";
        }
        #endregion
        #region Double Row Bets
        public string DoubleRow01WinningMath(int playerChoice, int result, int bet, int ColorChoice)
        {
            for (int i = 0; i < Double01Array.Length; i++)
            {
                if (result == Double01Array[i])
                {
                    this.Winnings = bet * 2;
                    return $"Congrats you win {Winnings:C} for the Double Row Bet";
                    break;
                }
                else
                {
                    return "You didnt cash out on the Double Row Bet";
                }
            }

            return null;
        }
        public string DoubleRow02WinningMath(int playerChoice, int result, int bet, int ColorChoice)
        {
            for (int i = 0; i < Double02Array.Length; i++)
            {
                if (result == Double02Array[i])
                {
                    this.Winnings = bet * 2;
                    return $"Congrats you win {Winnings:C} for the Double Row Bet";
                    break;
                }
                else
                {
                    return "You didnt cash out on the Double Row Bet";
                }
            }

            return null;
        }
        public string DoubleRow03WinningMath(int playerChoice, int result, int bet, int ColorChoice)
        {
            for (int i = 0; i < Double03Array.Length; i++)
            {
                if (result == Double03Array[i])
                {
                    this.Winnings = bet * 2;
                    return $"Congrats you win {Winnings:C} for the Double Row Bet";
                    break;
                }
                else
                {
                    return "You didnt cash out on the Double Row Bet";
                }
            }

            return null;
        }
        public string DoubleRow04WinningMath(int playerChoice, int result, int bet, int ColorChoice)
        {
            for (int i = 0; i < Double04Array.Length; i++)
            {
                if (result == Double04Array[i])
                {
                    this.Winnings = bet * 2;
                    return $"Congrats you win {Winnings:C} for the Double Row Bet";
                    break;
                }
                else
                {
                    return "You didnt cash out on the Double Row Bet";
                }
            }

            return null;
        }
        public string DoubleRow05WinningMath(int playerChoice, int result, int bet, int ColorChoice)
        {
            for (int i = 0; i < Double05Array.Length; i++)
            {
                if (result == Double05Array[i])
                {
                    this.Winnings = bet * 2;
                    return $"Congrats you win {Winnings:C} for the Double Row Bet";
                    break;
                }
                else
                {
                    return "You didnt cash out on the Double Row Bet";
                }
            }

            return null;
        }
        public string DoubleRow06WinningMath(int playerChoice, int result, int bet, int ColorChoice)
        {
            for (int i = 0; i < Double06Array.Length; i++)
            {
                if (result == Double06Array[i])
                {
                    this.Winnings = bet * 2;
                    return $"Congrats you win {Winnings:C} for the Double Row Bet";
                    break;
                }
                else
                {
                    return "You didnt cash out on the Double Row Bet";
                }
            }

            return null;
        }
        #endregion
        

    }



}
