using System;
using System.Data;
using BusinessLogic;


namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] coins = { 50,20, 10, 5, 1 };
            double[] notes = { 50,20,10,5,1 };
            int   i;
            double amtValue ,noteCount;
            double count ;

            double currencyAmount;

            Console.Write("Enter Currency Amount : ");
            currencyAmount = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("==========================");

            double prodPrice;
            Console.Write("Enter Prod Amount : ");
            prodPrice = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("==========================");

            double reAmount = currencyAmount - prodPrice;

            
            amtValue = reAmount;
            double money;
            money = amtValue;

            NumberOfCurrencyValues businessLogic = new NumberOfCurrencyValues();

            for (i = 0; i < notes.Length; i++)
            {
                if (amtValue >= notes[i])
                {
                    Console.WriteLine("Count of {0} Pound(s) :{1}", notes[i],
                        Math.Floor(noteCount = businessLogic.ComputeNotes(ref money, amtValue)));
                    
                }
                noteCount = amtValue / notes[i];
                amtValue%= notes[i];
                money = amtValue;
            }

            double centAmt = Math.Round(amtValue,2) * 100;
            double cent;
            cent = centAmt;
            for (i = 0; i < coins.Length; i++)
            {
                if (centAmt >= coins[i])
                {
                    Console.WriteLine("Count of {0} Pence(s) :{1}", coins[i],
                        Math.Floor(count = businessLogic.ComputeChange(ref cent, centAmt)));
                }
                count = centAmt / coins[i];
                centAmt %= (int)coins[i];
                cent = centAmt;
            }

            Console.ReadLine();
        }
    }

}