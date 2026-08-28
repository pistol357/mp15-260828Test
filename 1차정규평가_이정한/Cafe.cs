
public sealed class Cafe
{
    const string CAFE_NAME = "정한 카페";
    private int _totalSales;
    private int _orderTimes;

    public int TotalSales
    {
        get
        {
            return _totalSales;
        }

        set
        {
            _totalSales = value;
        }
    }

    public int OrderTimes
    {
        get
        {
            return _orderTimes;
        }

        set
        {
            _orderTimes = value;
        }
    }

    public void PrintCafeName()
    {
        Console.WriteLine("----------------------------------------");
        Console.WriteLine($"{CAFE_NAME} 주문 키오스크");
        Console.WriteLine("----------------------------------------");
    }

    public void CloseCafe()
    {
        Console.WriteLine($"총 주문 건수 : {_orderTimes}");
        Console.WriteLine($"총 매출액 : {_totalSales}");
    }
}