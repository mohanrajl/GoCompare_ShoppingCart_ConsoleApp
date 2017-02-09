using System;
using System.Linq;

namespace Cart.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintItems();
            string userInput;
            while ((userInput = Console.ReadLine().ToUpper()) != "X")
            {   
                if (string.IsNullOrWhiteSpace(userInput))
                {
                    Console.WriteLine("Please input items");
                }
                else
                {   
                    if (userInput.All(c => Char.IsLetter(c)) && ValidInputItems(userInput))
                    {
                        decimal totalPrice = PriceCalculation.CalculateTotalPrice(userInput);
                        Console.WriteLine("Total Price: " + totalPrice.ToString());
                    }
                    else
                    {
                        Console.WriteLine("Contains invalid Input");
                    }

                    Console.Write("----------------------------------\n\n");
                    Console.WriteLine("Enter items (AA/ABC/AAC/ABCD) to calculate total price or X to exit");
                }
            }
        }

        /// <summary>
        /// Function to validate the input items
        /// </summary>
        /// <param name="userInput">User input.</param>
        /// <returns>Returns boolean value to determine the valid input items.</returns>
        private static bool ValidInputItems(string userInput)
        {
            var inputCharArray = userInput.ToCharArray();
            foreach (var inputChar in inputCharArray)
            {
                if ((inputChar != 'A') && (inputChar != 'B') && (inputChar != 'C') && (inputChar != 'D'))
                {
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        /// Function to print items.
        /// </summary>
        private static void PrintItems()
        {
            Console.Write("   Item     Price       Offer \n\n");
            Console.Write(" ---------------------------------\n\n");
            Console.Write(" A          50          3 for 130 \n\n");
            Console.Write(" B          30          2 for 45 \n\n");
            Console.Write(" C          20            \n\n");
            Console.Write(" D          15            \n\n");
            Console.Write(" ----------------------------------\n\n");
            Console.WriteLine("Enter items (AA/ABC/AAC/ABCD) to calculate total price or X to exit");
        }
    }
}
