using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMConsoleApp
{
    class User: ICard
    {
        public string name { get; set; }
        public string cardNumber {  get; set; }
        public string validationDate {  get; set; }
        public int threeDigitCode {  get; set; }
        public int pin {  get; set; }
        public bool pass {get; set;}

        //function variables
        
        public double accountStatus = 100000.00;

        public string lastFiveTransactions = "200 300 250 400 500";

        public int i = 0;

        public int choiceInt = 0;

        public User(string name, string cardNumber, string validationDate, int threeDigitCode, int pin)
        {
            this.name = name;
            this.cardNumber = cardNumber;
            this.validationDate = validationDate;
            this.threeDigitCode = threeDigitCode;
            this.pin = pin;
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
        public string GetName()
        {
            return name;
        }
        public string GetNumber()
        {
            return cardNumber;
        }

        public string GetValidationDate()
        {
            return validationDate;
        }

        public int GetThreeDigitCode()
        {
            return threeDigitCode;
        }

        public int GetPin()
        {
            return pin;
        }

        //PIN
        public void EnterPin(int pin)
        {
            int controlPin = pin;
            if (this.pin == controlPin)
            {
                pass = true;
                pass = true;
            }
        }

        public void GetAccountStatus()
        {
            string accBalance = "Account Balance:";
            

                Console.WriteLine("|" + SpaceCreator(accBalance.Length + Convert.ToString(accountStatus).Length) + accBalance + accountStatus + "$" + SpaceCreatorV2(accBalance.Length + Convert.ToString(accountStatus).Length + 1) + "|");
            
            //return string.Format("{0} {1}$", accBalance, accountStatus);
        }

        public void FundsWithdrawal(double withdrawalAmount)
        {
            string balanceAfterAWithdrawal = "Your BALANCE after withdrawal";

            if (withdrawalAmount < 1000)
            {

                lastFiveTransactions = lastFiveTransactions + Convert.ToString(withdrawalAmount) + "\n";

                Withdrawal(withdrawalAmount);

                i = i + 1;

                Console.WriteLine("|" + SpaceCreator(Convert.ToString(balanceAfterAWithdrawal).Length) + balanceAfterAWithdrawal + SpaceCreator(Convert.ToString(balanceAfterAWithdrawal).Length) + "|");
                Console.WriteLine("|" + SpaceCreator(Convert.ToString(accountStatus).Length) + accountStatus + SpaceCreator(Convert.ToString(accountStatus).Length) + "|");

            }

            else if(withdrawalAmount > 1000)
            {
                string aboveLimit = "You are above daily limit";
                Console.WriteLine("|" + SpaceCreator(aboveLimit.Length) + aboveLimit + SpaceCreator(aboveLimit.Length) + "|");
            }
        }

        public void FastWithdrawal()
        {
            double twentyFive = 25.00;
            double fifty = 50.00;
            double seventyFive = 75.00;

            string fastOne = "Fast withdrawal 25$";
            string fastTwo = "Fast withdrawal 50$";
            string fastThree = "Fast withdrawal 75$";

            string fastW = "Fast withdrawal";
            string fastWPressOne = "Press 1 for 25$";
            string fastWPressTwo = "2 for 50$";
            string fastWPressThree = "3 for 75$";

            string balanceAfterAWithdrawal = "Your BALANCE after withdrawal";

            Console.WriteLine("|" + DashCreator(fastW.Length) + fastW + DashCreator(fastW.Length) + "|");
            Console.WriteLine("|" + SpaceCreator(fastWPressOne.Length) + fastWPressOne + SpaceCreator(fastWPressOne.Length) + "|");
            Console.WriteLine("|" + SpaceCreator(fastWPressTwo.Length) + fastWPressTwo + SpaceCreator(fastWPressTwo.Length) + "|");
            Console.WriteLine("|" + SpaceCreator(fastWPressThree.Length) + fastWPressThree + SpaceCreator(fastWPressThree.Length) + "|");
            
            Console.SetCursorPosition((Console.WindowWidth - 73) / 2, Console.CursorTop);
            int i = int.Parse(Console.ReadLine());

            switch (i)
            {
                case 1:
                    Console.WriteLine("|" + SpaceCreator(fastThree.Length) + fastOne + SpaceCreator(fastThree.Length) + "|");
                    Withdrawal(twentyFive);
                    Console.WriteLine("|" + DashCreator(Convert.ToString(balanceAfterAWithdrawal).Length) + balanceAfterAWithdrawal + DashCreator(Convert.ToString(balanceAfterAWithdrawal).Length) + "|");
                    Console.WriteLine("|" + SpaceCreator(Convert.ToString(accountStatus).Length) + accountStatus + "$" + SpaceCreatorV2(Convert.ToString(accountStatus).Length) + "|");
                    break;

                case 2:
                    Console.WriteLine("|" + SpaceCreator(fastThree.Length) + fastTwo + SpaceCreator(fastThree.Length) + "|");
                    Withdrawal(fifty);
                    Console.WriteLine("|" + DashCreator(Convert.ToString(balanceAfterAWithdrawal).Length) + balanceAfterAWithdrawal + DashCreator(Convert.ToString(balanceAfterAWithdrawal).Length) + "|");
                    Console.WriteLine("|" + SpaceCreator(Convert.ToString(accountStatus).Length) + accountStatus + "$" + SpaceCreatorV2(Convert.ToString(accountStatus).Length) + "|");
                    break;

                case 3:
                    Console.WriteLine("|" + SpaceCreator(fastThree.Length) + fastThree + SpaceCreator(fastThree.Length) + "|");
                    Withdrawal(seventyFive);
                    Console.WriteLine("|" + DashCreator(Convert.ToString(balanceAfterAWithdrawal).Length) + balanceAfterAWithdrawal + DashCreator(Convert.ToString(balanceAfterAWithdrawal).Length) + "|");
                    Console.WriteLine("|" + SpaceCreator(Convert.ToString(accountStatus).Length) + accountStatus + "$" + SpaceCreatorV2(Convert.ToString(accountStatus).Length) + "|");
                    break;
            }
        }

        public void LastFiveTransactions()
        {
            Console.WriteLine("|" + SpaceCreator(lastFiveTransactions.Length) + lastFiveTransactions + SpaceCreatorV2(lastFiveTransactions.Length) + "|");   
        }

        public override string ToString()
        {
            return string.Format("{0}\n{1}\n{2} {3} {4}", name, cardNumber, validationDate, threeDigitCode, pin);
        }

        private void Withdrawal(double amount)
        {
            accountStatus = accountStatus - amount;
        }
    }
}

    