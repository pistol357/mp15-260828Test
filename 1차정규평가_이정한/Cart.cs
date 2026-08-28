
public class Cart
{
    private List<Menu> _cart = new();
    private int _totalCost = 0;

    public void AddMenuToCart(Menu menu)
    {
        _cart.Add(menu);
        menu.OrderCount++;
    }

    public void ClearCart()
    {
        _cart.Clear();
    }

    public void PrintCart()
    {
        Console.WriteLine("[장바구니]");
        foreach(Menu menu in _cart)
        {
            Console.WriteLine($"  {menu.Name} X {menu.OrderCount} : {menu.ReturnPrice}원");
        }
        Console.WriteLine($"  합계 : {_totalCost}원");
        Console.WriteLine("----------------------------------------");
    }
}