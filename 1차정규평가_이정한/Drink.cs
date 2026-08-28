
public class Drink : Menu
{
    public Drink(string name, int price) : base(name, price, MenuType.Drink) { }

    public override int ReturnPrice()
    {
        return _price * _orderCount;
    }
}