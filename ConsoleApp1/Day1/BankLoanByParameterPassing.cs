using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

namespace ConsoleApp1.Day1
{
    internal class BankLoanByParameterPassing
    {
        class BankLoan
        {
            public string BankName { get; }
            public float InterestRate { get; }

            public BankLoan(string Bank, float Intrest)
            {
                BankName = Bank;
                InterestRate = Intrest;
            }

            public void IntrestRateOfBanks()
            {
                Console.WriteLine($"Intrest Rate at the {BankName}:{InterestRate}");
            }

            public float Intrestcalc(float Amount)
            {
                float interestAmount = Amount * (InterestRate / 100);
                return Amount + interestAmount;
            }
        }

        public static void Start()
        {
            Console.WriteLine("1-SBI, 2-ICICI, 3-Axis");
            int choice = int.Parse(Console.ReadLine());

            BankLoan selectedBank = null;

            switch (choice)
            {
                case 1:
                    selectedBank = new BankLoan("SBI", 8.0f);
                    break;
                case 2:
                    selectedBank = new BankLoan("ICICI", 7.0f);
                    break;
                case 3:
                    selectedBank = new BankLoan("Axis", 9.0f);
                    break;
                default:
                    Console.WriteLine("Enter The Bank");
                    break;
            }

            if (selectedBank != null)
            {
                selectedBank.IntrestRateOfBanks();

                Console.Write("Enter the amount: ");

                float Amount = float.Parse(Console.ReadLine());
                if (Amount > 0)
                {
                    float price = selectedBank.Intrestcalc(Amount);
                    Console.WriteLine($"Price at {selectedBank.BankName} Bank after applying interest rate: {price}");
                }
                else
                {
                    Console.WriteLine(" Please enter a valid amount.");
                }
            }
        }
    }
}




