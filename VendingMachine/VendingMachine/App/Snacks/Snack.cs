public abstract class Snack
{
    public string Name { get; }

    public decimal Price { get; }

    public abstract int Remaining { get; set; }

    public abstract bool RemoveItem();

    protected Snack(string name, decimal price, int remaining)
    {
        Name = name;
        Price = price;
    }
}