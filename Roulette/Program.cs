using System;
using RouletteLogic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            GameLogic gamelogic = new GameLogic();
            Writer writer = new Writer();
            int playerNumber= 0;
            int exit = 0;
            int exitt = 0;
            int playerColorChoice = 0;
            int tryparse;
            int gameexit = 0;
            int playerBet=0;
            int PlayerMoney = 100000;
            int splitchoice01;
            int splitchoice02;
            while (gameexit == 0)
            {
                gamelogic.Winnings = 0;
                int Number = 0;
                int Color = 0;
                int EvenOdd = 0;
                int HighLow = 0;
                int Dozen = 0;
                int Column = 0;
                int Street = 0;
                int DoubleRow = 0;
                int Split = 0;
                int Corner = 0;
                Console.WriteLine(writer.Greeting());
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine(writer.Odds(PlayerMoney));
                int betexit = 0;
                while (betexit == 0)
                {
                    Console.Clear();
                    Console.WriteLine(writer.Odds(PlayerMoney));
                    Console.WriteLine(writer.ChooseBet());
                    string tempchoice00 = Console.ReadLine();
                    int.TryParse(tempchoice00, out tryparse);
                    int ChooseBet = tryparse;
                    
                    switch (ChooseBet)
                    {
                        case 1: //Color
                            while (exitt == 0)
                            {
                                Console.WriteLine(writer.ChooseColor());
                                string tempchoice = Console.ReadLine();
                                int.TryParse(tempchoice, out tryparse);
                                playerColorChoice = tryparse;
                                if (playerColorChoice != 1 && playerColorChoice != 2)
                                {
                                    Console.WriteLine(writer.ChooseAgain());
                                }

                                if (playerColorChoice == 1)
                                {
                                    exitt = 1;
                                    Color = 1;
                                }

                                if (playerColorChoice == 2)
                                {
                                    exitt = 1;
                                    Color = 2;
                                }
                            }

                            break;
                        case 2: //Number
                            while (exit == 0)
                            {

                                Console.WriteLine($"{writer.NumberChoice(playerColorChoice)}");
                                string tempchoice2 = Console.ReadLine();
                                int.TryParse(tempchoice2, out tryparse);
                                playerNumber = tryparse;
                                int i;
                                for (i = 0; i < gamelogic.BlackArray.Length; i++)
                                {
                                    if (playerNumber == gamelogic.BlackArray[i])
                                    {
                                        exit = 1;
                                        Number = 1;
                                        break;
                                    }
                                }

                                for (i = 0; i < gamelogic.RedArray.Length; i++)
                                {
                                    if (playerNumber == gamelogic.RedArray[i])
                                    {
                                        exit = 1;
                                        Number = 2;
                                        break;
                                    }
                                }
                            }

                            break;
                        case 3: //EvenOdd
                            int oddexit = 0;
                            while (oddexit == 0)
                            {
                                Console.WriteLine(writer.ChooseEvenOdd());
                                string evenoddchoice3 = Console.ReadLine();
                                int.TryParse(evenoddchoice3, out tryparse);
                                int evenoddBet = tryparse;
                                if (evenoddBet == 1)
                                {
                                    oddexit = 1;
                                    EvenOdd = 1;
                                }

                                if (evenoddBet == 2)
                                {
                                    oddexit = 1;
                                    EvenOdd = 2;
                                }
                            }

                            break;
                        case 4: //High Low
                            int highexit = 0;
                            while (highexit == 0)
                            {
                                Console.WriteLine(writer.Choosehighlow());
                                string evenoddchoice3 = Console.ReadLine();
                                int.TryParse(evenoddchoice3, out tryparse);
                                int highlowBet = tryparse;
                                if (highlowBet == 1)
                                {
                                    highexit = 1;
                                    HighLow = 1;
                                }

                                if (highlowBet == 2)
                                {
                                    highexit = 1;
                                    HighLow = 2;
                                }
                            }

                            break;
                        case 5: //Dozen
                            int dozenexit = 0;
                            while (dozenexit == 0)
                            {
                                Console.WriteLine(writer.ChooseDozen());
                                string dozenchoice3 = Console.ReadLine();
                                int.TryParse(dozenchoice3, out tryparse);
                                int dozenBet = tryparse;
                                if (dozenBet == 1)
                                {
                                    dozenexit = 1;
                                    Dozen = 1;
                                }

                                if (dozenBet == 2)
                                {
                                    dozenexit = 1;
                                    Dozen = 2;
                                }

                                if (dozenBet == 3)
                                {
                                    dozenexit = 1;
                                    Dozen = 3;
                                }
                            }

                            break;
                        case 6: //Column
                            int columnexit = 0;
                            while (columnexit == 0)
                            {
                                Console.WriteLine(writer.ChooseColumn());
                                string columnchoice3 = Console.ReadLine();
                                int.TryParse(columnchoice3, out tryparse);
                                int columnBet = tryparse;
                                if (columnBet == 1)
                                {
                                    columnexit = 1;
                                    Column = 1;
                                }

                                if (columnBet == 2)
                                {
                                    columnexit = 1;
                                    Column = 2;
                                }

                                if (columnBet == 3)
                                {
                                    columnexit = 1;
                                    Column = 3;
                                }
                            }

                            break;
                        case 7: //Street
                            int streetexit = 0;
                            while (streetexit == 0)
                            {
                                Console.WriteLine(writer.ChooseStreet());
                                string streetchoice3 = Console.ReadLine();
                                int.TryParse(streetchoice3, out tryparse);
                                int streetBet = tryparse;
                                if (streetBet == 1)
                                {
                                    streetexit = 1;
                                    Street = 1;
                                }

                                if (streetBet == 2)
                                {
                                    streetexit = 1;
                                    Street = 2;
                                }

                                if (streetBet == 3)
                                {
                                    streetexit = 1;
                                    Street = 3;
                                }

                                if (streetBet == 4)
                                {
                                    streetexit = 1;
                                    Street = 4;
                                }

                                if (streetBet == 5)
                                {
                                    streetexit = 1;
                                    Street = 5;
                                }

                                if (streetBet == 6)
                                {
                                    streetexit = 1;
                                    Street = 6;
                                }

                                if (streetBet == 7)
                                {
                                    streetexit = 1;
                                    Street = 7;
                                }

                                if (streetBet == 8)
                                {
                                    streetexit = 1;
                                    Street = 8;
                                }

                                if (streetBet == 9)
                                {
                                    streetexit = 1;
                                    Street = 9;
                                }

                                if (streetBet == 10)
                                {
                                    streetexit = 1;
                                    Street = 10;
                                }

                                if (streetBet == 11)
                                {
                                    streetexit = 1;
                                    Street = 11;
                                }

                                if (streetBet == 12)
                                {
                                    streetexit = 1;
                                    Street = 12;
                                }
                            }

                            break;
                        case 8: //Double Rows
                            int doubleexit = 0;
                            while (doubleexit == 0)
                            {
                                Console.WriteLine(writer.ChooseDoubleRow());
                                string doublechoice3 = Console.ReadLine();
                                int.TryParse(doublechoice3, out tryparse);
                                int doubleBet = tryparse;
                                if (doubleBet == 1)
                                {
                                    doubleexit = 1;
                                    DoubleRow = 1;
                                }

                                if (doubleBet == 2)
                                {
                                    doubleexit = 1;
                                    DoubleRow = 2;
                                }

                                if (doubleBet == 3)
                                {
                                    doubleexit = 1;
                                    DoubleRow = 3;
                                }
                            }

                            break;
                        case 9: //Split
                            int splitexit = 0;
                            while (splitexit == 0)
                            {
                                Console.WriteLine(writer.ChooseSplit());
                                string evenoddchoice3 = Console.ReadLine();
                                int.TryParse(evenoddchoice3, out tryparse);
                                splitchoice01 = tryparse;
                                Console.WriteLine(writer.ChooseSplit2(splitchoice01, gamelogic.Column01Array, gamelogic.Column02Array, gamelogic.Column03Array));
                                string splitchoice3 = Console.ReadLine();
                                int.TryParse(splitchoice3, out tryparse);
                                splitchoice02 = tryparse;
                                if (splitchoice02 == (splitchoice01 - 1)|| splitchoice02 == (splitchoice01 + 1)||splitchoice02 == (splitchoice01 - 3) || splitchoice02 == (splitchoice01 + 3))
                                {
                                    splitexit = 1;
                                    Split = 1;
                                }
                                else
                                {
                                    Console.WriteLine("Choose a correct pair");
                                }
                            }
                            break;
                        case 10: //Corner
                            break;
                        case 11:
                            betexit = 1;
                            break;
                    }

                    if (ChooseBet != 11)
                    {
                        Console.WriteLine(writer.BetAmount());
                        string tempchoice3 = Console.ReadLine();
                        int.TryParse(tempchoice3, out tryparse);
                        playerBet = tryparse;
                        PlayerMoney -= playerBet;
                    }
                }
                Console.Clear();
                Console.WriteLine(writer.Rolling(PlayerMoney));
                int result = gamelogic.NumberResult();
                Console.ReadKey();
                Console.Clear();
                PlayerMoney += gamelogic.Winnings;
                Console.WriteLine(writer.Result(result, PlayerMoney,gamelogic.Winnings));
                Console.ReadKey();
                #region Bet Results
                if(Number ==1){Console.WriteLine(gamelogic.NumbersWinningMath(playerNumber, result, playerBet, playerColorChoice));}
                if(EvenOdd==1)Console.WriteLine(gamelogic.ODDWinningMath(playerNumber, result, playerBet, playerColorChoice));
                if (EvenOdd == 2) Console.WriteLine(gamelogic.EvenWinningMath(playerNumber, result, playerBet, playerColorChoice));
                if (HighLow == 1) Console.WriteLine(gamelogic.HIGHWinningMath(playerNumber, result, playerBet, playerColorChoice));
                if (HighLow == 2) Console.WriteLine(gamelogic.LowWinningMath(playerNumber, result, playerBet, playerColorChoice));
                if (Dozen == 1) Console.WriteLine(gamelogic.TopDozenWinningMath(playerNumber, result, playerBet, playerColorChoice));
                if (Dozen == 2) Console.WriteLine(gamelogic.MidDozenWinningMath(playerNumber, result, playerBet, playerColorChoice));
                if (Dozen == 3) Console.WriteLine(gamelogic.LowDozenWinningMath(playerNumber, result, playerBet, playerColorChoice));
                if (Column == 1) Console.WriteLine(gamelogic.Column01WinningMath(playerNumber, result, playerBet, playerColorChoice));
                if (Column == 2) Console.WriteLine(gamelogic.Column02WinningMath(playerNumber, result, playerBet, playerColorChoice));
                if (Column == 3) Console.WriteLine(gamelogic.Column03WinningMath(playerNumber, result, playerBet, playerColorChoice));
                if (Color == 1) Console.WriteLine(gamelogic.BLACKWinningMath(playerNumber, result, playerBet, playerColorChoice));
                if (Color == 2) Console.WriteLine(gamelogic.REDWinningMath(playerNumber, result, playerBet, playerColorChoice));
                if (Street == 1) Console.WriteLine(gamelogic.Street01WinningMath(playerNumber, result, playerBet, playerColorChoice));
                if (Street == 2) Console.WriteLine(gamelogic.Street02WinningMath(playerNumber, result, playerBet, playerColorChoice));
                if (Street == 3) Console.WriteLine(gamelogic.Street03WinningMath(playerNumber, result, playerBet, playerColorChoice));
                if (Street == 4) Console.WriteLine(gamelogic.Street04WinningMath(playerNumber, result, playerBet, playerColorChoice));
                if (Street == 5) Console.WriteLine(gamelogic.Street05WinningMath(playerNumber, result, playerBet, playerColorChoice));
                if (Street == 6) Console.WriteLine(gamelogic.Street06WinningMath(playerNumber, result, playerBet, playerColorChoice));
                if (Street == 7) Console.WriteLine(gamelogic.Street07WinningMath(playerNumber, result, playerBet, playerColorChoice));
                if (Street == 8) Console.WriteLine(gamelogic.Street08WinningMath(playerNumber, result, playerBet, playerColorChoice));
                if (Street == 9) Console.WriteLine(gamelogic.Street09WinningMath(playerNumber, result, playerBet, playerColorChoice));
                if (Street == 10) Console.WriteLine(gamelogic.Street10WinningMath(playerNumber, result, playerBet, playerColorChoice));
                if (Street == 11) Console.WriteLine(gamelogic.Street11WinningMath(playerNumber, result, playerBet, playerColorChoice));
                if (Street == 12) Console.WriteLine(gamelogic.Street12WinningMath(playerNumber, result, playerBet, playerColorChoice));
                if (DoubleRow == 1) Console.WriteLine(gamelogic.DoubleRow01WinningMath(playerNumber, result, playerBet, playerColorChoice));
                if (DoubleRow == 2) Console.WriteLine(gamelogic.DoubleRow02WinningMath(playerNumber, result, playerBet, playerColorChoice));
                if (DoubleRow == 3) Console.WriteLine(gamelogic.DoubleRow03WinningMath(playerNumber, result, playerBet, playerColorChoice));
                if (DoubleRow == 4) Console.WriteLine(gamelogic.DoubleRow04WinningMath(playerNumber, result, playerBet, playerColorChoice));
                if (DoubleRow == 5) Console.WriteLine(gamelogic.DoubleRow05WinningMath(playerNumber, result, playerBet, playerColorChoice));
                if (DoubleRow == 6) Console.WriteLine(gamelogic.DoubleRow06WinningMath(playerNumber, result, playerBet, playerColorChoice));
                if (Split == 1) Console.WriteLine(gamelogic.SplitWinningMath(playerNumber, result, playerBet, playerColorChoice));
                #endregion

                Console.ReadKey();
                Console.Clear();
                Console.WriteLine(writer.PlayAgain());
                string tempchoice4 = Console.ReadLine();
                int.TryParse(tempchoice4, out tryparse);
                int playagain = tryparse;
                if (playagain == 1)
                {
                    break;
                }
                if (playagain == 2)
                {
                    gameexit = 1;
                }

                
            }
        }

        
    }
}
