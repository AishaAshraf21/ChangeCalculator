using System;

namespace BusinessLogic
{
    public class NumberOfCurrencyValues
    {
        // some class level constants

        const int HALVES = 50;
        const int QUARTERS = 20;

        const int DIMES = 10;

        const int NICKELS = 5;

        const int PENNIES = 1;

  
        const int FIFTY = 50;
        const int TWENTY = 20;
        const int TEN = 10;
        const int FIVE = 5;
        const int ONE = 1;

        public double ComputeChange(ref double changeValue, double coinValue)
        {
            //compute the .50 pieces
            if (changeValue >= HALVES)
            {
                coinValue = changeValue / HALVES;
                //compute new value after .50 pieces
                changeValue = changeValue - (coinValue * HALVES);
            }
            //compute the .20 pieces
            else if (changeValue >= QUARTERS)
            {
                coinValue = changeValue / QUARTERS;
                //compute the value after .20 pieces
                changeValue = changeValue - (coinValue * QUARTERS);
            }
            //compute the .10 pieces
            else if (changeValue >= DIMES)
            {
                coinValue = changeValue / DIMES;
                //compute the value after .10 pieces
                changeValue = changeValue - (coinValue * DIMES);
            }
            //compute the .05 pieces
            else if (changeValue >= NICKELS)
            {
                coinValue = changeValue / NICKELS;
                //compute the value after .05 pieces
                changeValue = changeValue - (coinValue * NICKELS);
            }
            //compute the .01 pieces
            else

            {
                coinValue = changeValue / PENNIES;
            }
            //compute the value after .01 pieces
            return coinValue;
        }


        public double ComputeNotes(ref double changeValue, double noteValue)
        {
            
            //compute the 50 pieces
             if (changeValue >= FIFTY)
            {
                noteValue = changeValue / FIFTY;
                //compute the value after .50 pieces
                changeValue = changeValue - (noteValue * FIFTY);
            }
            //compute the .20 pieces
            else if (changeValue >= TWENTY)
            {
                noteValue = changeValue / TWENTY;
                //compute the value after .20 pieces
                changeValue = changeValue - (noteValue * TWENTY);
            }
            else if (changeValue >= TEN)
            {
                noteValue = changeValue / TEN;
                //compute the value after .10 pieces
                changeValue = changeValue - (noteValue * TEN);
            }
            //compute the .05 pieces
            else if (changeValue >= FIVE)

            {

                noteValue = changeValue / FIVE;

                //compute the value after .05 pieces

                changeValue = changeValue - (noteValue * FIVE);

            }
            //compute the .01 pieces
            else
            {
                noteValue = changeValue / ONE;
            }

            //compute the value after .01 pieces

            return noteValue;







        }
    }
}
