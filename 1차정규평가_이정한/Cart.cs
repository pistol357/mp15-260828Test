
public class Cart<T> where T : Menu
{
    private List<T> _cart = new();
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
        T menu = (T)menuList.GetMenu(menuNumber - 1);
        if (_cart.Contains(menu))
        {
            menu.OrderCount += menuCount;
        }
        else
        {
            _cart.Add(menu);
            menu.OrderCount += menuCount;
        }

        GetTotalCost();
    }

    public void RemoveMenuFromCart(MenuList menuList, int menuNumber, int menuCount)
    {
        T menu = (T)menuList.GetMenu(menuNumber - 1);
        if (_cart.Contains(menu))
        {
            menu.OrderCount -= menuCount;
            if(menu.OrderCount == 0)
            {
                _cart.Remove(menu);
            }
        }
        else
        {
            Console.WriteLine($"장바구니에 {menu.Name}(이)가 없습니다.");
        }

        GetTotalCost();
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

    public bool IsCartEmpty()
    {
        return _cart.Count == 0;
    }

    public void GetTotalCost()
    {
        int cost = 0;
        foreach (T item in _cart)
        {
            cost += item.ReturnPrice();
        }
        _totalCost = cost;
    }

    public void Pay(Cafe cafe, int moeny)
    {
        if (moeny < _totalCost)
        {
            Console.WriteLine("금액이 부족합니다.");
        }
        else
        {
            Console.WriteLine($"거스름돈 : {moeny - _totalCost}");
            cafe.TotalSales += _totalCost;
            cafe.OrderTimes++;
            ClearCart();
        }
    }
}