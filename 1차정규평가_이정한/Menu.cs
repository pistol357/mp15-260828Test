
public abstract class Menu
{
    protected string _name;
    protected int _price;
    protected MenuType _menuType;

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

    public Menu(string name, int price, MenuType menuType)
    {
        _name = name;
        _price = price;
        _menuType = menuType;
    }

    public virtual int ReturnPrice()
    {
        return Price;
    }
}