using System;

namespace ATMConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            /////////////////////////////////////////////////////////////////////////////////variables

            string pokus = " -----------------------------------------------";
            string pokus2 = "|-----------------------------------------------|";
            string pressEnter = "Press ENTER for continuation";

            bool verified = false;

            string[] manNames = new string[5];
            manNames[0] = "James";
            manNames[1] = "Rob";
            manNames[2] = "Karel";
            manNames[3] = "John";
            manNames[4] = "Michael";

            string[] womanNames = new string[5];
            womanNames[0] = "Mary";
            womanNames[1] = "Patricia";
            womanNames[2] = "Jennifer";
            womanNames[3] = "Linda";
            womanNames[4] = "Elizabeth";

            int maxChars = pokus.Length;

            ////////////////////////////////////////////////////////////////////////////RANDOMS///////////////////////////////////////////////////////////////////////////////////////////////

            Random random = new Random();
            
            string randomName = manNames[random.Next(0, manNames.Length)];
            string randomWomanName = womanNames[random.Next(0, manNames.Length)];
            string randomCardNumber = string.Format("{0} {1} {2} {3}", random.Next(5000, 6000), random.Next(3000, 4000), random.Next(2000, 3000), random.Next(7000, 8000));
            string randomDate = string.Format("{0}/{1}", random.Next(20, 30), random.Next(1, 12));
            
            int randomDigitCode = random.Next(400, 700);
            int randomPin = random.Next(500, 600);

            ////////////////////////////////////////////////////////////////////////////WOMEN CREATOR///////////////////////////////////////////////////////////////////////////////////////////////

            User UseressSetOne = new User(womanNames[random.Next(0, womanNames.Length)],

                string.Format("{0} {1} {2} {3}", random.Next(5000, 6000), random.Next(3000, 4000), random.Next(2000, 3000), random.Next(7000, 8000)), string.Format("{0}/{1}", random.Next(20, 30), random.Next(1, 12)),
                random.Next(400, 700),
                randomPin);

            User UseressSetTwo = new User(womanNames[random.Next(0, womanNames.Length)],
                string.Format("{0} {1} {2} {3}", random.Next(5000, 6000), random.Next(3000, 4000), random.Next(2000, 3000), random.Next(7000, 8000)),
                string.Format("{0}/{1}", random.Next(20, 30), random.Next(1, 12)),
                random.Next(400, 700),
                random.Next(500, 600));

            User UseressSetThree = new User(womanNames[random.Next(0, womanNames.Length)],
                string.Format("{0} {1} {2} {3}", random.Next(5000, 6000), random.Next(3000, 4000), random.Next(2000, 3000), random.Next(7000, 8000)),
                string.Format("{0}/{1}", random.Next(20, 30), random.Next(1, 12)),
                random.Next(400, 700),
                random.Next(500, 600));

            User UseressSetFour = new User(womanNames[random.Next(0, womanNames.Length)],
                string.Format("{0} {1} {2} {3}", random.Next(5000, 6000), random.Next(3000, 4000), random.Next(2000, 3000), random.Next(7000, 8000)),
                string.Format("{0}/{1}", random.Next(20, 30), random.Next(1, 12)),
                random.Next(400, 700),
                random.Next(500, 600));

            User UseressSetFive = new User(womanNames[random.Next(0, womanNames.Length)],
                string.Format("{0} {1} {2} {3}", random.Next(5000, 6000), random.Next(3000, 4000), random.Next(2000, 3000), random.Next(7000, 8000)),
                string.Format("{0}/{1}", random.Next(20, 30), random.Next(1, 12)),
                random.Next(400, 700),
                random.Next(500, 600));

            User[] womenSet = new User[5];
            womenSet[0] = UseressSetOne;
            womenSet[1] = UseressSetTwo;
            womenSet[2] = UseressSetThree;
            womenSet[3] = UseressSetFour;
            womenSet[4] = UseressSetFive;

            ////////////////////////////////////////////////////////////////////////////MEN CREATOR///////////////////////////////////////////////////////////////////////////////////////////////

            User UserSetOne = new User(manNames[random.Next(0, manNames.Length)],
                string.Format("{0} {1} {2} {3}", random.Next(5000, 6000), random.Next(3000, 4000), random.Next(2000, 3000), random.Next(7000, 8000)),
                string.Format("{0}/{1}", random.Next(20, 30), random.Next(1, 12)),
                random.Next(400, 700),
                random.Next(5000, 6000));

            User UserSetTwo = new User(manNames[random.Next(0, manNames.Length)],
                string.Format("{0} {1} {2} {3}", random.Next(5000, 6000), random.Next(3000, 4000), random.Next(2000, 3000), random.Next(7000, 8000)),
                string.Format("{0}/{1}", random.Next(20, 30), random.Next(1, 12)),
                random.Next(400, 700),
                random.Next(5000, 6000));

            User UserSetThree = new User(manNames[random.Next(0, manNames.Length)],
                string.Format("{0} {1} {2} {3}", random.Next(5000, 6000), random.Next(3000, 4000), random.Next(2000, 3000), random.Next(7000, 8000)),
                string.Format("{0}/{1}", random.Next(20, 30), random.Next(1, 12)),
                random.Next(400, 700),
                random.Next(5000, 6000));

            User UserSetFour = new User(manNames[random.Next(0, manNames.Length)],
                string.Format("{0} {1} {2} {3}", random.Next(5000, 6000), random.Next(3000, 4000), random.Next(2000, 3000), random.Next(7000, 8000)),
                string.Format("{0}/{1}", random.Next(20, 30), random.Next(1, 12)),
                random.Next(400, 700),
                random.Next(5000, 6000));

            User UserSetFive = new User(manNames[random.Next(0, manNames.Length)],
                string.Format("{0} {1} {2} {3}", random.Next(5000, 6000), random.Next(3000, 4000), random.Next(2000, 3000), random.Next(7000, 8000)),
                string.Format("{0}/{1}", random.Next(20, 30), random.Next(1, 12)),
                random.Next(400, 700),
                random.Next(5000, 6000));

            User[] menSet = new User[5];
            menSet[0] = UserSetOne;
            menSet[1] = UserSetTwo;
            menSet[2] = UserSetThree;
            menSet[3] = UserSetFour;
            menSet[4] = UserSetFive;

            ////////////////////////////////////////////////////////////////////////////CONSOLE USER CHECK///////////////////////////////////////////////////////////////////////////////////////////////
            //used for User validitiy control
            //commented for clear app

            //ConsoleUserCheck();

            ///////////////////////////////////////////////////////////////////////////////HEADER////////////////////////////////////////////////////////////////////////////////////////////////////////

            ATMHeader();

            ////////////////////////////////////////////////////////////////////////////INSERT CARD//////////////////////////////////////////////////////////////////////////////////////////////////////

            InsertCard();
            User customer = menSet[random.Next(0, menSet.Length)];

            ////////////////////////////////////////////////////////////////////////////CARD INFORMATION////////////////////////////////////////////////////////////////////////////////////////////////

            CardInformation();
            Console.ReadKey();

            ////////////////////////////////////////////////////////////////////////////CARD VERIFICATION////////////////////////////////////////////////////////////////////////////////////////////////

            CardVerification();
            Console.ReadKey();

            ////////////////////////////////////////////////////////////////////////////PIN VERIFICATION////////////////////////////////////////////////////////////////////////////////////////////////

            PinVerification();

            BasicUserInterfaceLoop(verified);

            Console.ReadKey();

            ////////////////////////////////////////////////////////////////////////////FUNCTION DECLARATION////////////////////////////////////////////////////////////////////////////////////////////////

            void ATMHeader()
            {

                Console.ForegroundColor = ConsoleColor.DarkCyan;

                Console.WriteLine(" -----------------------------------------------");
                Console.WriteLine("|------___------____________----____------___---|");
                Console.WriteLine("|-----/   \\----|____    ____|--|    \\---/    |--|");
                Console.WriteLine("|----/     \\--------|  |-------|     \\-/     |--|");
                Console.WriteLine("|---/  /_\\  \\-------|  |-------|  |\\     /|  |--|");
                Console.WriteLine("|--/  _____  \\------|  |-------|  |-\\   /-|  |--|");
                Console.WriteLine("|-/__/     \\__\\-----|__|-------|__|--\\_/--|__|--|");
                Console.WriteLine("|-----------------------------------------------|");

                Console.ForegroundColor = ConsoleColor.DarkYellow;
            }

            void InsertCard()
            {
                string insertCard = "For CARD insert press ENTER";
                string cardInserted = "CARD Inserted";

                Console.WriteLine("|" + SpaceCreator(insertCard.Length) + insertCard + SpaceCreator(insertCard.Length) + "|");
                Console.WriteLine("|-----------------------------------------------|");
                Console.ReadKey();

            }
            ////////////////////////////////////////////////////////////////////////////////////CARDD INFORMATION/////////////////////////////////////////////////////////////////////////////////////////
            void CardInformation()
            {
                Console.WriteLine("|                                               |");
                Console.WriteLine("|" + DashCreator(customer.cardNumber.Length) + customer.cardNumber + DashCreator(customer.cardNumber.Length) + "|");
                Console.WriteLine("|" + DashCreator(customer.validationDate.Length) + customer.validationDate + DashCreatorV2(customer.validationDate.Length) + "|");
                Console.WriteLine("|" + DashCreator(Convert.ToString(customer.threeDigitCode).Length) + customer.threeDigitCode + DashCreator(Convert.ToString(customer.threeDigitCode).Length) + "|");
                Console.WriteLine("|-----------------------------------------------|");
                Console.WriteLine("|" + SpaceCreator(pressEnter.Length) + pressEnter + SpaceCreatorV2(pressEnter.Length) + "|");
                Console.WriteLine("|-----------------------------------------------|");
            }
            ////////////////////////////////////////////////////////////////////////////////////CARD VERIFICATION/////////////////////////////////////////////////////////////////////////////////////////
            void CardVerification()
            {
                string cardVerification = "CARD VERIFICATION";
                string verification = "!!!VERIFIED!!!";
                
                Random random = new Random();
                Console.WriteLine("|                                               |");
                Console.WriteLine("|" + SpaceCreator(cardVerification.Length) +cardVerification + SpaceCreator(cardVerification.Length) + "|");

                bool verificationSuccessful = customer.GetNumber() == UserSetOne.GetNumber() || customer.GetNumber() == UserSetTwo.GetNumber() || customer.GetNumber() == UserSetThree.GetNumber() || customer.GetNumber() == UserSetFour.GetNumber() || customer.GetNumber() == UserSetFive.GetNumber();

                Console.WriteLine("|" + SpaceCreator(verification.Length) + verification + SpaceCreatorV2(verification.Length) + "|");
                Console.WriteLine("|                                               |");
                Console.WriteLine("|-----------------------------------------------|");
                Console.WriteLine("|" + SpaceCreator(pressEnter.Length) + pressEnter + SpaceCreatorV2(pressEnter.Length) + "|");
                Console.WriteLine("|-----------------------------------------------|");
            }
            ////////////////////////////////////////////////////////////////////////////////////PIN VERIFICATION/////////////////////////////////////////////////////////////////////////////////////////

            void PinVerification()
            {
                string prompt = "Enter PIN by pressing Enter";
                string pinVerification = "PIN Verification!";
                string pinVerified = "!!!VERIFIED!!!";
                string wrongPin = "Wrong PIN, try again";

                int pinForVeification = 0;

                Console.WriteLine("|                                               |");
                Console.WriteLine("|" + SpaceCreator(prompt.Length) + prompt + SpaceCreator(prompt.Length) + "|");

                Console.ReadKey();
                Console.WriteLine("|                                               |");
                Console.WriteLine("|" + SpaceCreator(pinVerification.Length) + pinVerification + SpaceCreator(pinVerification.Length) + "|");


                //MEN CHECK
                if (customer.GetNumber() == UserSetOne.GetNumber())
                {
                    pinForVeification = UserSetOne.GetPin();
                }

                else if (customer.GetNumber() == UserSetTwo.GetNumber())
                {
                    pinForVeification = UserSetTwo.GetPin();
                }

                else if (customer.GetNumber() == UserSetThree.GetNumber())
                {
                    pinForVeification = UserSetThree.GetPin();
                }

                else if (customer.GetNumber() == UserSetFour.GetNumber())
                {
                    pinForVeification = UserSetFour.GetPin();
                }

                else if (customer.GetNumber() == UserSetFive.GetNumber())
                {
                    pinForVeification = UserSetFive.GetPin();
                }

                if (pinForVeification == customer.GetPin())
                {
                    verified = true;
                }
                //WOMEN CHECK
                if (customer.GetNumber() == UseressSetOne.GetNumber())
                {
                    pinForVeification = UserSetOne.GetPin();
                }

                else if (customer.GetNumber() == UseressSetTwo.GetNumber())
                {
                    pinForVeification = UserSetTwo.GetPin();
                }

                else if (customer.GetNumber() == UseressSetThree.GetNumber())
                {
                    pinForVeification = UserSetThree.GetPin();
                }

                else if (customer.GetNumber() == UseressSetFour.GetNumber())
                {
                    pinForVeification = UserSetFour.GetPin();
                }

                else if (customer.GetNumber() == UseressSetFive.GetNumber())
                {
                    pinForVeification = UserSetFive.GetPin();
                }

                if (pinForVeification == customer.GetPin())
                {
                    verified = true;
                }

                if (verified == true)
                {
                    Console.WriteLine("|" + SpaceCreator(pinVerified.Length) + pinVerified + SpaceCreatorV2(pinVerified.Length) + "|");
                    Console.WriteLine("|                                               |");
                    Console.WriteLine("|-----------------------------------------------|");
                    Console.WriteLine("|" + SpaceCreator(pressEnter.Length) + pressEnter + SpaceCreatorV2(pressEnter.Length) + "|");
                    Console.WriteLine("|-----------------------------------------------|");
                }
                else if(verified == false)
                {
                    Console.WriteLine("|" + SpaceCreator(wrongPin.Length) + wrongPin + SpaceCreatorV2(wrongPin.Length) + "|");
                    Console.WriteLine("|-----------------------------------------------|");
                    Console.WriteLine("|" + SpaceCreator(pressEnter.Length) + pressEnter + SpaceCreatorV2(pressEnter.Length) + "|");
                    Console.WriteLine("|-----------------------------------------------|");
                }
                Console.ReadKey();
            }

            void BasicUserInterfaceLoop(bool log)
            {
                int controlInt = 0;

                string welcomeATM = "Welcome to your ATM";
                string forContinuation = "For continuation,";
                string pleasePress = "please press folowing digits.";
                string choiceOne = "1 for Account information";
                string choiceTwo = "2 for Funds Withdrawal";
                string choiceThree = "3 for Fast Withdrawal";
                string choiceFour = "4 for Last Five Transactions";
                string exit = "5 for EXIT";

                User Costumer = new User(customer.GetName(), customer.GetNumber(), customer.GetValidationDate(), customer.GetThreeDigitCode(), customer.GetPin());
                Console.WriteLine(pokus2);
                Console.WriteLine("|" + SpaceCreator(welcomeATM.Length) + welcomeATM + SpaceCreator(welcomeATM.Length) + "|");
                Console.WriteLine("|" + SpaceCreator(forContinuation.Length) + forContinuation + SpaceCreator(forContinuation.Length) + "|");
                Console.WriteLine("|" + SpaceCreator(pleasePress.Length) + pleasePress + SpaceCreator(pleasePress.Length) + "|");
                Console.WriteLine("|" + SpaceCreator(choiceOne.Length) + choiceOne + SpaceCreator(choiceOne.Length) + "|");
                Console.WriteLine("|" + SpaceCreator(choiceTwo.Length) + choiceTwo + SpaceCreatorV2(choiceTwo.Length) + "|");
                Console.WriteLine("|" + SpaceCreator(choiceThree.Length) + choiceThree + SpaceCreator(choiceThree.Length) + "|");
                Console.WriteLine("|" + SpaceCreator(choiceFour.Length) + choiceFour + SpaceCreatorV2(choiceFour.Length) + "|");
                Console.WriteLine("|" + SpaceCreator(exit.Length) + exit + SpaceCreatorV2(exit.Length) + "|");
                Console.WriteLine(pokus2);

                //UI loop 
                while (log == true)
                {

                    try
                    {
                        Console.SetCursorPosition((Console.WindowWidth - 73) / 2, Console.CursorTop);
                        controlInt = int.Parse(Console.ReadLine());
                    }

                    catch (Exception)
                    {
                        string inputValid = "Your input is not valid. Try input number";
                        Console.WriteLine("|" + DashCreator(inputValid.Length) + inputValid + DashCreator(inputValid.Length) + "|");
                        Console.WriteLine("|                                               |");
                    }

                    string acocountInformation = "Account Information";
                    string fundsW = "Funds Withdrawal";
                    string fundsWb = "How much do you want to withdraw?";

                    string lastF = "Last five transactions";

                    switch (controlInt)
                    {
                        //account information
                        case 1:
                            Console.WriteLine("|" + SpaceCreator(acocountInformation.Length) + acocountInformation + SpaceCreator(acocountInformation.Length) + "|");
                            Costumer.GetAccountStatus();
                            break;
                        //funds withdrawal
                        case 2:
                            Console.WriteLine("|" + SpaceCreator(fundsW.Length) + fundsW + SpaceCreatorV2(fundsW.Length) + "|");
                            Console.WriteLine("|" + SpaceCreator(fundsWb.Length) + fundsWb + SpaceCreator(fundsWb.Length) + "|");
                            Console.SetCursorPosition((Console.WindowWidth - 73) / 2, Console.CursorTop);
                            double withdrawAmount = double.Parse(Console.ReadLine());
                            Costumer.FundsWithdrawal(withdrawAmount);
                            break;
                        //fast withdrawal
                        case 3:
                            Costumer.FastWithdrawal();
                            break;
                        //last five transactions
                        case 4:
                            Console.WriteLine("|" + DashCreator(lastF.Length) + lastF + DashCreatorV2(21) + "|");
                            customer.LastFiveTransactions();
                            break;
                        case 5:
                            log = false;
                            break;
                    }
                }

                Console.WriteLine("|" + SpaceCreator(40) + "Thank you for your time, have a nice day" + SpaceCreatorV2(40) + "|");
            
            }

            string DashCreator(int customerLength)
            {
                int maxChars = 48;
                string dashes = "";

                for (int i = 0; i < (maxChars - customerLength) / 2; i++)
                {
                    dashes = dashes + "-";
                }

                return dashes;
            }

            string DashCreatorV2(int customerLength)
            {
                int maxChars = 48;
                string dashes = "";

                for (int i = 1; i < (maxChars - customerLength) / 2; i++)
                {
                    dashes = dashes + "-";
                }

                return dashes;
            }
            ////////////////////////////////////////////////////////////////////////////////////CHAR CREATORS/////////////////////////////////////////////////////////////////////////////////////////

            string SpaceCreator(int customerLength)
            {
                int maxChars = 48;
                string dashes = "";

                for (int i = 0; i < (maxChars - customerLength) / 2; i++)
                {

                    dashes = dashes + " ";

                }

                return dashes;
            }

            string SpaceCreatorV2(int customerLength)
            {
                int maxChars = 48;
                string dashes = "";

                for (int i = 1; i < (maxChars - customerLength) / 2; i++)
                {
                    dashes = dashes + " ";
                }

                return dashes;
            }

            void ConsoleUserCheck()
            {
                int number = 0;

                while (number < womenSet.Length)
                {
                    Console.WriteLine(womenSet[number].GetName() + "                        " + menSet[number].GetName() + "\n" + womenSet[number].GetNumber() + "             " + menSet[number].GetNumber() + "\n" + womenSet[number].GetValidationDate() + "                             " + menSet[number].GetValidationDate() + "\n" + womenSet[number].GetThreeDigitCode() + "                            " + menSet[number].GetThreeDigitCode() + "\n" + Convert.ToString(womenSet[number].GetPin() + "                            " + Convert.ToString(menSet[number].GetPin())));
                    number = number + 1; ;
                }
            }
        }
    }
}
