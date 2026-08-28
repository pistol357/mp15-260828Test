
public class Cart
{
    private List<Menu> _cart = new();
    private int _totalCost = 0;

    public int TotalCost
    {
        get
        {
            return _totalCost;
        }
    }

    public void AddMenuToCart(MenuList menuList, int menuNumber, int menuCount)
    {
        Menu menu = menuList.GetMenu(menuNumber - 1);
        _cart.Add(menu);
        menu.OrderCount += menuCount;
        _totalCost += menu.ReturnPrice();
    }

    public void ClearCart()
    {
        _cart.Clear();
        _totalCost = 0;
    }

    public void PrintCart()
    {
        Console.WriteLine("[장바구니]");
        foreach(Menu menu in _cart)
        {
            Console.WriteLine($"  {menu.Name} X {menu.OrderCount} : {menu.ReturnPrice()}원");
        }
        Console.WriteLine($"  합계 : {_totalCost}원");
        Console.WriteLine("----------------------------------------");
    }
}