// https://github.com/pistol357/mp15-260828Test

using System;

class Program
{
    const string CAFE_NAME = "정한 카페";
    const int MENU_COUNT = 5;

    static void Main(string[] args)
    {
        Cafe cafe = new Cafe();

        MenuList menuList = new MenuList();
        menuList.SetMenuListSize(MENU_COUNT);
        menuList.AddMenu(new Drink("아메리카노", 5000));
        menuList.AddMenu(new Drink("카라멜 마끼아또", 6000));
        menuList.AddMenu(new Drink("아이스티", 5000));
        menuList.AddMenu(new Dessert("티라미수", 3800));
        menuList.AddMenu(new Dessert("쿠키", 1000));

        Cart<Menu> cart = new Cart<Menu>();

        while (true)
        {
            Console.Clear();
            PrintCafeName();
            menuList.PrintMenuList();
            cart.PrintCart();
            int action = PrintCustomerAction();

            if (action == (int)CustomerActionList.AddMenuToCart)
            {
                int menuToCart = ConsoleInput.ReadIntInRange("장바구니에 담을 메뉴를 선택해주세요. : ", 1, 5);
                int menuToCartCount = ConsoleInput.ReadIntAtLeast("몇 개 담을까요? : ", 0);
                cart.AddMenuToCart(menuList, menuToCart, menuToCartCount);
            }
            else if (action == (int)CustomerActionList.ClearCart)
            {
                cart.ClearCart();
            }
            else if (action == (int)CustomerActionList.Pay)
            {
                int pay = ConsoleInput.ReadIntAtLeast("받은 금액 : ", 0);

                if (pay < cart.TotalCost)
                {
                    Console.WriteLine("금액이 부족합니다.");
                }
                else
                {
                    Console.WriteLine($"거스름돈 : {pay - cart.TotalCost}");
                    cafe.TotalSales += cart.TotalCost;
                    cafe.OrderTimes++;
                    cart.ClearCart();
                }
            }
            else if (action == (int)CustomerActionList.CloseCafe)
            {
                Console.WriteLine($"총 주문 건수 : {cafe.OrderTimes}");
                Console.WriteLine($"총 매출액 : {cafe.TotalSales}");
                return;
            }
            ConsoleInput.Pause();
        }
    }

    public static void PrintCafeName()
    {
        Console.WriteLine("----------------------------------------");
        Console.WriteLine($"{CAFE_NAME} 주문 키오스크");
        Console.WriteLine("----------------------------------------");
    }

    public static int PrintCustomerAction()
    {
        Console.WriteLine("1. 장바구니에 메뉴 담기   2. 장바구니 전체 비우기   3. 결제   4. 영업 종료");
        int action = ConsoleInput.ReadIntInRange("무엇을 원하시나요? : ", 1, 4);
        return action;
    }
}