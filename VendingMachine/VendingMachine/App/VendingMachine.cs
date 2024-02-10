namespace VendingMachine
{
    using System;
    using System.Collections.Generic;

    public class VendingMachine
    {
        public List<Snack> AvailableSnacks = new List<Snack>();
        public Decimal Money;

        public VendingMachine()
        {
            this.AvailableSnacks = this.GetSnackItems();
            this.Money = 0;

        }

        public List<Snack> GetSnackItems()
        {
            List<Snack> currentSnacks = new List<Snack>();
            currentSnacks.Add(new Monster(25, 25));

            return currentSnacks;
     
        }

        public void DisplayAllItems()
        {
            foreach (Snack snack in this.AvailableSnacks)
            {
                Console.WriteLine("Name: {0} Price: {1}", snack.Name, snack.Price);
            }
        }

        public void AddMoney(int InsertedMoney)
        {
            this.Money += InsertedMoney;
        }

        public bool ItemExists(String SnackName)
        {
            foreach (Snack snack in this.AvailableSnacks)
            {
                if (snack.Name.Equals(SnackName)) {
                    return true;
                }
            }
            return false;
        }

        public void RetrieveItem(String SnackName)
        {
            if (ItemExists(SnackName))
            {
                var purchasedSnack = this.AvailableSnacks.Find(snack => snack.Name == SnackName);
                if (purchasedSnack.RemoveItem()) {
                    Console.WriteLine("You successfully purchased " + SnackName);
                }

            } else
            {
               Console.WriteLine("Item could not be purchased.");
            }
        }
    }
}