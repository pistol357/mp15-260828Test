
public class MenuList
{
    private Menu[] _menuList;
    private int _count = 0;

    public int Count
    {
        get
        {
            return _count;
        }
    }

    public void SetMenuListSize(int size)
    {
        _menuList = new Menu[size];
    }

    public void AddMenu(Menu menu)
    {
        if(Count == _menuList.Length)
        {
            return;
        }
        _menuList[Count] = menu;
    }

    public Menu GetMenu(int index)
    {
        return _menuList[index];
    }

    public void PrintMenuList()
    {
        Console.WriteLine("[메뉴판]");
        foreach(Menu menu in _menuList)
        {
            Console.WriteLine($"  {menu.ID}. {menu.Name} ({menu.MenuType})  {menu.Price}원");
        }
    }
}