namespace VendingMachine
{
    using System;

    public class Menu
    {

        public void Display()
        {
            VendingMachine vm = new VendingMachine();

            PrintHeader();
            while (true)
            {
                int currentInsertedMoney = 0;

                Console.WriteLine();
                Console.WriteLine("Main Menu");
                Console.WriteLine("1] List vending machine items");
                Console.WriteLine("2] Insert money");
                Console.WriteLine("3] Recall purchase");
                Console.WriteLine("4] Purchase a snack");
                Console.WriteLine("Q] Quit");
                Console.Write("What option do you want to select? ");
                string input = Console.ReadLine();

                if (input == "1")
                {
                    Console.WriteLine("Displaying Items");
                    vm.DisplayAllItems();
                }

                else if (input == "2")
                {
                    Console.WriteLine("How much would you like to insert?");
                    string inputAmount = Console.ReadLine();
                    int amount;
                    Int32.TryParse(input, out amount);

                    vm.AddMoney(amount);
                    currentInsertedMoney += amount;
                }

                else if (input == "3")
                {
                    Console.WriteLine("Your purchase is cancelled and your money is returned.");
                    currentInsertedMoney = 0;
                }

                else if (input == "4")
                {
                    Console.WriteLine("What would you like to purchase?");
                    string snackName = Console.ReadLine();
                    vm.RetrieveItem(snackName);
                }

                else if (input.ToUpper() == "Q")
                {
                    Console.WriteLine("Quitting");
                    break;
                }
                else
                {
                    Console.WriteLine("Please try again");
                }

                Console.ReadLine();
                Console.Clear();
            }
        }

        private static void PrintHeader()
        {
            Console.WriteLine("Feel free to try out this half-done vending machine");
        }

    }
}