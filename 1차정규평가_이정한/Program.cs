// https://github.com/pistol357/mp15-260828Test

using System;

class Program
{
    const int MENU_COUNT = 6;

    static void Main(string[] args)
    {
        Cafe cafe = new Cafe();

        MenuList menuList = new MenuList(MENU_COUNT);
        menuList.AddMenu(new Drink("아메리카노", 5000));
        menuList.AddMenu(new Drink("카라멜 마끼아또", 6000));
        menuList.AddMenu(new Drink("아이스티", 5000));
        menuList.AddMenu(new Dessert("티라미수", 3800));
        menuList.AddMenu(new Dessert("쿠키", 1000));
        menuList.AddMenu(new Goods("텀블러", 7000));

        Cart<Menu> cart = new Cart<Menu>();

        while (true)
        {
            Console.Clear();
            cafe.PrintCafeName();
            menuList.PrintMenuList();
            cart.PrintCart();
            int action = PrintCustomerAction();

            if (action == (int)CustomerActionList.AddMenuToCart)
            {
                int menuToCart = ConsoleInput.ReadIntInRange("장바구니에 담을 메뉴를 선택해주세요. : ", 1, MENU_COUNT);
                int menuToCartCount = ConsoleInput.ReadIntAtLeast("몇 개 담을까요? : ", 1);
                cart.AddMenuToCart(menuList, menuToCart, menuToCartCount);
            }
            else if (action == (int)CustomerActionList.RemoveMenuFromCart)
            {
                if (!cart.IsCartEmpty())
                {
                    int menuFromCart = ConsoleInput.ReadIntInRange("장바구니에서 뺄 메뉴를 선택해주세요. : ", 1, MENU_COUNT);
                    int menuFromCartCount = ConsoleInput.ReadIntAtLeast("몇 개 뺄까요? : ", 1);
                    cart.RemoveMenuFromCart(menuList, menuFromCart, menuFromCartCount);
                }
                else
                {
                    Console.WriteLine("장바구니가 비어있습니다.");
                }
            }
            else if (action == (int)CustomerActionList.ClearCart)
            {
                cart.ClearCart();
            }
            else if (action == (int)CustomerActionList.Pay)
            {
                if (!cart.IsCartEmpty())
                {
                    int money = ConsoleInput.ReadIntAtLeast("받은 금액 : ", 0);
                    cart.Pay(cafe, money);
                }
                else
                {
                    Console.WriteLine("장바구니가 비어있습니다.");
                }
            }
            else if (action == (int)CustomerActionList.CloseCafe)
            {
                cafe.CloseCafe();
                return;
            }

            ConsoleInput.Pause();
        }
    }

    public static int PrintCustomerAction()
    {
        for(int i = 1; i <= (int)CustomerActionList.CloseCafe; i++)
        {
            switch ((CustomerActionList)i)
            {
                case CustomerActionList.AddMenuToCart:
                    Console.WriteLine($"  {i}. 장바구니에 담기");
                    break;
                case CustomerActionList.RemoveMenuFromCart:
                    Console.WriteLine($"  {i}. 장바구니에서 빼기");
                    break;
                case CustomerActionList.ClearCart:
                    Console.WriteLine($"  {i}. 장바구니 비우기");
                    break;
                case CustomerActionList.Pay:
                    Console.WriteLine($"  {i}. 결제");
                    break;
                case CustomerActionList.CloseCafe:
                    Console.WriteLine($"  {i}. 영업 종료");
                    break;
                default:
                    break;
            }
        }
       
        int action = ConsoleInput.ReadIntInRange("무엇을 원하시나요? : ", 1, (int)CustomerActionList.CloseCafe);
        return action;
    }
}