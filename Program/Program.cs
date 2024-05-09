using System.ComponentModel.Design;
using Currency;
using Product;

class Program
{
private static int passcodeAttempts = 0; 
    public static void Main(string[] args)
    {
        List<Item> items = new List<Item> { };
        int InitialQuantity = 30;
        double price = 0;
        int selection = 0;
        int FLAG = -1;  

        //create products

        Item coke = new Item("Coke", .95, InitialQuantity);
        Item doritos = new Item("Doritos", .75, InitialQuantity);
        Item snickers = new Item("Snickers", .55, InitialQuantity);
        Item chexMix = new Item("Chex Mix", .60, InitialQuantity);
        Item pepsi = new Item("Pepsi", .90, InitialQuantity);

        Console
            .WriteLine($"Menu:\n1. {coke.GetName()}       {coke.GetPrice()}");
        Console.WriteLine($"2. {doritos.GetName()}    {doritos.GetPrice()}");
        Console.WriteLine($"3. {snickers.GetName()}   {snickers.GetPrice()}");
        Console.WriteLine($"4. {chexMix.GetName()}   {chexMix.GetPrice()}");
        Console.WriteLine($"5. {pepsi.GetName()}      {pepsi.GetPrice()}");
        Console.WriteLine("6. Display Totals\n-1. to exit program");

        do{
        Console.WriteLine("Enter item number: ");
        string input = Console.ReadLine();
        if (int.TryParse(input, out selection))
        {
            switch (selection)
            {
                case 1:
                    price = coke.GetPrice();
                    items.Add (coke);
                    Console.WriteLine($"{coke.GetName()}.");
                    Console.WriteLine($"Please Pay {coke.GetPrice()}.");

                    InsertCoin (price);

                    break;
                case 2:
                    price = doritos.GetPrice();
                    items.Add (doritos);
                    Console.WriteLine($"{doritos.GetName()}.");
                    Console.WriteLine($"Please Pay {doritos.GetPrice()}.");

                    InsertCoin (price);

                    break;
                case 3:
                    price = snickers.GetPrice();
                    items.Add (snickers);
                    Console.WriteLine($"{snickers.GetName()}.");
                    Console.WriteLine($"Please Pay {snickers.GetPrice()}.");

                    InsertCoin (price);

                    break;
                case 4:
                    price = chexMix.GetPrice();
                    items.Add (chexMix);
                    Console.WriteLine($"{chexMix.GetName()}.");
                    Console.WriteLine($"Please Pay {chexMix.GetPrice()}.");

                    InsertCoin (price);

                    break;
                case 5:
                    price = pepsi.GetPrice();
                    items.Add (pepsi);
                    Console.WriteLine($"{pepsi.GetName()}.");
                    Console.WriteLine($"Please Pay {pepsi.GetPrice()}.");

                    InsertCoin (price);

                    break;
                case 6:
                    DisplayTotals (items);
                    break;
                default:
                if(selection == FLAG){
                    Console.WriteLine("Thank you\n Exiting Program");
                }else{
                    Console.WriteLine("Invalid input");
                }
                    break;
            }
        }
        else
        {
            Console.WriteLine("Invalid input");
        }
        }while (selection != FLAG);
    }

    public static List<double> InsertCoin(double price)
    {
        List<double> payment = new List<double>();
        double TotalInserted = 0;
        Console.WriteLine($"The price is: {price:C}. Please insert coins");

        do
        {
            string input = Console.ReadLine();

            if (double.TryParse(input, out double coin) && ValidateCoin(coin))
            {
                payment.Add (coin);
                TotalInserted += coin;
                Console
                    .WriteLine($"You have inserted: {coin:C}. Total inserted {
                        TotalInserted:C}");
            }
            else
            {
                Console.WriteLine("Invalid coin. Please try again.");
            }
        }
        while (TotalInserted < price);

        if (TotalInserted > price)
        {
            double change = TotalInserted - price;
            Console.WriteLine($"Purchase Complete. Your change is {change:C}");
        }

        return payment;
    }

    //validates if coin input is a valid U.S. coin
    public static bool ValidateCoin(double CoinPaid)
    {
        double[] money = { .01, .05, .10, .25, 1.00, 5.00 };

        foreach (double coin in money)
        {
            if (coin == CoinPaid)
            {
                return true;
            }
        }
        return false;
    }

    //verifies if amount paid is equal to cost of item
    public static bool CheckAmountPaid(double sellingPrice, double[] paid)
    {
        double TotalPaid = 0;

        for (int i = 0; i < paid.Length; i++)
        {
            TotalPaid += paid[i];
        }
        return TotalPaid >= sellingPrice;
    }

    //cost is calculated at 35 percent of the selling price of an item
    public static double CalculateCost(double SellingPrice)
    {
        const double CostFactor = 0.35;
        double cost = SellingPrice * CostFactor;

        return cost;
    }

    //overhead is calculated at 5 percent of the selling price of an item
    public static double CalculateOverhead(double SellingPrice)
    {
        const double OverheadFactor = 0.05;
        double laborCost = SellingPrice * OverheadFactor;

        return laborCost;
    }

    //total profit is the selling price minus (cost , labor, and overhead)
    public static double
    CalculateProfit(
        double sellingPrice,
        double cost,
        double laborCost,
        double overhead
    )
    {
        return sellingPrice - (cost + laborCost + overhead);
    }

    //labor is calculated at 25 percent of the selling price of an item
    public static double CalculateLaborCost(double SellingPrice)
    {
        const double FactorLabor = 0.25;
        double laborCost = SellingPrice * FactorLabor;

        return laborCost;
    }

    //calculates total sales by adding the price of the total items sold
    public static double CalculateTotalSales(List<Item> items)
    {
        return items.Sum(item => item.GetPrice());
    }

    public static void DisplayTotals(List<Item> items)
    {
        const string Passcode = "114499";
        const int MaxAttempts = 3;

        Console.WriteLine("Enter passcode");
        string EnterPasscode = Console.ReadLine();
        
        if(EnterPasscode == Passcode){
        double totalCost = items.Sum(item => CalculateCost(item.GetPrice()));
        double totalLaborCost =
            items.Sum(item => CalculateLaborCost(item.GetPrice()));
        double totalOverhead =
            items.Sum(item => CalculateOverhead(item.GetPrice()));
        double totalProfit =
            items
                .Sum(item =>
                    CalculateProfit(item.GetPrice(),
                    CalculateCost(item.GetPrice()),
                    CalculateLaborCost(item.GetPrice()),
                    CalculateOverhead(item.GetPrice())));
        double totalSales = CalculateTotalSales(items);

        Console.WriteLine($"Total Cost: {totalCost:C}");
        Console.WriteLine($"Total Labor Cost: {totalLaborCost:C}");
        Console.WriteLine($"Total Overhead: {totalOverhead:C}");
        Console.WriteLine($"Total Profit: {totalProfit:C}");
        Console.WriteLine($"Total Sales: {totalSales}");
        } else {
            passcodeAttempts++;
            if(passcodeAttempts >= MaxAttempts) {
                Console.WriteLine("ACCESS LOCKED");
            }
            else{
            Console.WriteLine($"ACCESS DENIED. You have {MaxAttempts - passcodeAttempts} attempts left");
            }
        }
    }
}
