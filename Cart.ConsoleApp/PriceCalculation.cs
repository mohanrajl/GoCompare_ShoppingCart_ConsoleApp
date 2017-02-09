using System;
using System.Linq;

namespace Cart.ConsoleApp
{
    /// <summary>
    /// Class to do price calculation.
    /// </summary>
    public static class PriceCalculation
    {
        /// <summary>
        /// Calculate total price for the user input.
        /// </summary>
        /// <param name="userInput"></param>
        /// <returns>Returns the total price for user input.</returns>
        public static decimal CalculateTotalPrice(string userInput)
        {
            decimal totalPrice = 0;
            if (!string.IsNullOrWhiteSpace(userInput))
            {
                var userInputs = (userInput.ToCharArray()).GroupBy(x => x);
                foreach (var input in userInputs)
                {
                    switch (input.Key)
                    {
                        case 'A':
                            totalPrice = totalPrice + GetTotalItemPrice(input.Count(), 50, 3, 130);
                            break;
                        case 'B':
                            totalPrice = totalPrice + GetTotalItemPrice(input.Count(), 30, 2, 45);
                            break;
                        case 'C':
                            totalPrice = totalPrice + GetTotalItemPrice(input.Count(), 20, 0, 0);
                            break;
                        case 'D':
                            totalPrice = totalPrice + GetTotalItemPrice(input.Count(), 15, 0, 0);
                            break;
                        default:
                            totalPrice = totalPrice + 0;
                            break;
                    }
                }
            }

            return totalPrice;
        }

        /// <summary>
        /// Function to calculate individual item total price.
        /// </summary>
        /// <param name="numberOfItems">Number of items.</param>
        /// <param name="price">Original Price.</param>
        /// <param name="offerTotal">Number of items in offer.</param>
        /// <param name="offerPrice">Offer price.</param>
        /// <returns>Returns total item price.</returns>
        private static decimal GetTotalItemPrice(int numberOfItems, decimal price, int offerTotal, decimal offerPrice)
        {
            if (offerTotal > 0 && numberOfItems >= offerTotal)
            {
                return (((numberOfItems % offerTotal) * price) + (Convert.ToInt32(numberOfItems / offerTotal) * offerPrice));
            }
            else
            {
                return (numberOfItems * price);
            }
        }
    }
}
