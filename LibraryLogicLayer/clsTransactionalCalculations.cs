using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryLogicLayer
{
    public class clsTransactionalCalculations
    {

        public static bool CheckAccountBalance(decimal Balance , decimal FineAmount)
        {
            return (Balance >= FineAmount);
        }

        public static double CalculateBookPriceWithPercentage(double BookPrice, double Percentage = 0.2)
        {
            return (BookPrice * Percentage);
        }

        public static double CalculateFineAmountForBorrowingProcess(double BookPrice, decimal TotalPenaltiesAmount = 0 , double Percentage = 0.2)
        {
            return (BookPrice * Percentage + Convert.ToDouble(TotalPenaltiesAmount));
        }

        public static decimal CalculatePurchase(decimal Balance , decimal BookPrice)
        {
            return Balance - BookPrice;
        }

    }
}
