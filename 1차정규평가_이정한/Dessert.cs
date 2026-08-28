
public class Dessert : Menu
{
    const float DISCOUNT_RATE = 0.9f;
    public Dessert(string name, int price) : base(name, price, MenuType.Dessert) { }

    public override int ReturnPrice()
    {
        if(_orderCount >= 3)
        {
            return (int)(base.ReturnPrice() * DISCOUNT_RATE);
        }
        return base.ReturnPrice();
    }
}