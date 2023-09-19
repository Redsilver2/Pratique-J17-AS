using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonProjet2
{
    internal class Money
    {

        public Money()
        {
            Console.WriteLine("\n\n\t\t\tWelcome to the weather tool");

            string userMoneyType = string.Empty;
            bool isValidMoneyType = false;

            while (true)
            {
                Console.WriteLine("\n\nEnter the money type that you have (cad, usd or eu): ");
                userMoneyType = Console.ReadLine();

                switch (userMoneyType.ToLower())
                {
                    case "cad":
                        isValidMoneyType = true;
                        break;

                    case "usd":
                        isValidMoneyType = true;
                        break;

                    case "eu":
                        isValidMoneyType = true;
                        break;

                    default:
                        Console.WriteLine("Invalid type of money.");
                        break;

                }

                if (isValidMoneyType) { break; }
            }

            Console.WriteLine("\n\nHow much do you want to convert: ");
            float userMoneyAmount =  float.Parse(Console.ReadLine());


            string moneyType = string.Empty;
            isValidMoneyType = false;

            while (true)
            {
                Console.WriteLine("\n\nEnter the money type to convert in (cad, usd or eu): ");
                moneyType = Console.ReadLine();

                switch (moneyType.ToLower())
                {
                    case "cad":
                        isValidMoneyType = true;
                        break;
                    
                    case "usd":

                        isValidMoneyType = true;
                        break;
                    
                    case "eu":

                        isValidMoneyType = true;
                        break;

                    default:
                      Console.WriteLine("Invalid type of money.");
                        break;
                }

                if (isValidMoneyType) { break; }
            }

            float conversion = 0;

            switch (userMoneyType.ToLower())
            {
                case "cad":

                    switch (moneyType.ToLower())
                    {
                        case "us":
                            conversion = userMoneyAmount * 0.74f;
                            break;

                        case "eu":
                            conversion = userMoneyAmount * 0.70f;
                            break;
                    }

                    break;

                case "usd":
                    switch (moneyType.ToLower())
                    {
                        case "cad":
                            conversion = userMoneyAmount * 1.34f;
                            break;

                        case "eu":
                            conversion = userMoneyAmount * 0.94f;
                            break;
                    }
                    break;

                case "eu":
                    switch (moneyType.ToLower())
                    {
                        case "cad":
                            conversion = userMoneyAmount * 1.43f;
                            break;

                        case "us":
                            conversion = userMoneyAmount * 1.07f;
                            break;
                    }
                break;
            }

            Console.WriteLine($"\n\t\t\t{Math.Round(userMoneyAmount,2)} {userMoneyType.ToUpper()} is equal to {Math.Round(conversion, 2)} " + moneyType.ToUpper() + ".");
        }
    }
}
