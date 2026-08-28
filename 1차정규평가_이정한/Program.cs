// https://github.com/pistol357/mp15-260828Test

using System;

class Program
{
    const string CAFE_NAME = "정한 카페";

    static void Main(string[] args)
    {
        while (true)
        {
            PrintCustomerAction();
        }
    }

    public static void PrintCustomerAction()
    {
        Console.WriteLine("1. 장바구니에 메뉴 담기   2. 장바구니 전체 비우기   3. 결제   4. 영업 종료");
        int action = ConsoleInput.ReadIntInRange("무엇을 원하시나요? : ", 1, 4);
    }
}