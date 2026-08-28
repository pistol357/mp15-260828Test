
public class Goods : Menu
{
    public Goods(string name, int price) : base(name, price, MenuType.Goods) { }

    public override int ReturnPrice()
    {
        return _price * _orderCount;
    }
}