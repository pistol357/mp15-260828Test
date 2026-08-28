
public class Dessert : Menu
{
    const float DISCOUNT_RATE = 0.9f;
    public Dessert(string name, int price) : base(name, price, MenuType.Dessert) { }

    public override int ReturnPrice()
    {
        if (_orderCount >= 3)
        {
            return (int)(_price * _orderCount * DISCOUNT_RATE);
        }
        return _price * _orderCount;
    }

    public override void PrintMenuInfo()
    {
        Console.WriteLine($"{Name} ({MenuType})  {Price}원 [3개 이상 구매 시 10% 할인]");
    }
}