
public abstract class Menu
{
    protected string _name;
    protected int _price;
    protected MenuType _menuType;
    protected int _orderCount = 0;

    public string Name
    {
        get
        {
            return _name;
        }
    }

    public int Price
    {
        get
        {
            return _price;
        }
    }

    public MenuType MenuType
    {
        get
        {
            return _menuType;
        }
    }

    public int OrderCount
    {
        get
        {
            return _orderCount;
        }

        set
        {
            _orderCount = value;
            if(_orderCount < 0)
            {
                _orderCount = 0;
            }
        }
    }

    public Menu(string name, int price, MenuType menuType)
    {
        _name = name;
        _price = price;
        _menuType = menuType;
    }

    public virtual int ReturnPrice()
    {
        return _price * _orderCount;
    }

    public virtual void PrintMenuInfo()
    {
        Console.WriteLine($"{Name} ({MenuType})  {Price}원");
    }
}