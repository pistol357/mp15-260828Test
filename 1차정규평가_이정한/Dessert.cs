
public class Dessert : Menu
{
    const int DISCOUNT_ORDER_COUNT = 3;
    const float DISCOUNT_RATE = 0.1f;
    public Dessert(string name, int price) : base(name, price, MenuType.Dessert) { }

    public override int ReturnPrice()
    {
        if (_orderCount >= DISCOUNT_ORDER_COUNT)
        {
            return (int)(_price * _orderCount * (1- DISCOUNT_RATE));
        }
        return _price * _orderCount;
    }

    public override void PrintMenuInfo()
    {
        Console.WriteLine($"{Name} ({MenuType})  {Price}원 [{DISCOUNT_ORDER_COUNT}개 이상 구매 시 {DISCOUNT_RATE * 100}% 할인]");
    }
}