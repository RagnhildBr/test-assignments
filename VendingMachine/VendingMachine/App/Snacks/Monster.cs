[System.Diagnostics.CodeAnalysis.SuppressMessage("Design", "CA1050:Declare types in namespaces", Justification = "<Pending>")]
public class Monster : Snack
{

    public Monster(decimal price, int remaining) : base("Monster", price, remaining)
    {
    }

    public override int Remaining { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    public override bool RemoveItem()
    {
        if (this.Remaining > 0)
        {
            this.Remaining--;
            return true;
        }

        return false;
    }
}
