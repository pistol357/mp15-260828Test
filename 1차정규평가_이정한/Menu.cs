
public abstract class Menu
{
    protected string _name;
    protected int _price;
    protected MenuType _menuType;

    public Menu(string name, int price, MenuType menuType)
    {
        _name = name;
        _price = price;
        _menuType = menuType;
    }
}