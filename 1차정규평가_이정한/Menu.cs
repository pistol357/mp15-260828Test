
public abstract class Menu
{
    protected int _id;
    protected string _name;
    protected int _price;
    protected MenuType _menuType;

    public int ID
    {
        get
        {
            return _id;
        }
    }

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

    public Menu(int id, string name, int price, MenuType menuType)
    {
        _id = id;
        _name = name;
        _price = price;
        _menuType = menuType;
    }
}