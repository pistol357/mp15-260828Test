
public class Dessert : Menu
{
    public Dessert(string name, int price) : base(name, price, MenuType.Dessert) { }

    public override int ReturnPrice()
    {
        if(_orderCount >= 3)
        {
            return (int)(base.ReturnPrice() * 0.9);
        }
        return base.ReturnPrice();
    }
}