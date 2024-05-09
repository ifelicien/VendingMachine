using Product;
using Currency;
class Program{
    
    public static void Main(string[] args){
        List<Item> items = new List<Item> {};

        //create products 
        Item coke = new Item("Coke", .95, 30);
        Item doritos = new Item("Doritos", .75, 30);
        Item snickers = new Item("Snickers", .55, 30);
        Item chexMix = new Item("Chex Mix", .60, 30);
        Item pepsi = new Item("Pepsi", .90, 30);
        
        Console.WriteLine($"Menu:\n1. {coke.GetName()}       {coke.GetPrice()}");
        Console.WriteLine($"2. {doritos.GetName()}    {doritos.GetPrice()}");
        Console.WriteLine($"3. {snickers.GetName()}   {snickers.GetPrice()}");
        Console.WriteLine($"4. {chexMix.GetName()}   {chexMix.GetPrice()}");
        Console.WriteLine($"5. {pepsi.GetName()}      {pepsi.GetPrice()}");

        Console.WriteLine("Enter item number: ");
        string input = Console.ReadLine();
        if(int.TryParse(input, out int selection)){

            switch (selection){
            
            case 1:
                items.Add(coke);
                Console.WriteLine($"{coke.GetName()}.");
                double ItemCost = coke.GetPrice();
                break;

            case 2:
                items.Add(doritos);
                Console.WriteLine($"{doritos.GetName()}.");
                break;

            case 3:
                items.Add(snickers);
                Console.WriteLine($"{snickers.GetName()}.");
                break;

            case 4:
                items.Add(chexMix);
                Console.WriteLine($"{chexMix.GetName()}.");
                break;

            case 5:
                items.Add(pepsi);
                Console.WriteLine($"{pepsi.GetName()}.");
                break;
            case 6:
                DisplayTotals();
                break;

            default:
            Console.WriteLine("Invalid input");
            break;
            }
        }else {
            Console.WriteLine("Invalid input");
        }
    }

    public static bool ValidateCoin(double CoinPaid){
        double[] money = {.01, .05, .10, .25, 1.00, 5.00};
        
        foreach(double coin in money){
            if (coin == CoinPaid){
                return true;
            }
        }
        return false;
    }

    public static bool CheckAmountPaid(double sellingPrice, double[] paid){
        double TotalPaid = 0;
        
        for (int i = 0; i < paid.Length; i++){
            TotalPaid += paid[i];
        }
        return TotalPaid >= sellingPrice;
    }

//each time item is sold add to list, can use list.length to get total sales and return price for calculating profit
//
    public static double CalculateCost(double SellingPrice){
        const double CostFactor = 0.35;
        double cost = SellingPrice * CostFactor;

        return cost;
    }

    public static double CalculateOverhead(double SellingPrice){
        const double OverheadFactor = 0.05;
        double laborCost = SellingPrice * OverheadFactor;

        return laborCost;
    }

    public static void CalculateProfit(){

    }

     public static double CalculateLaborCost(double SellingPrice){
        const double FactorLabor = 0.25;
        double laborCost = SellingPrice * FactorLabor;

        return laborCost;
    }

     public static int CalculateTotalSales(List<Item> items){
        return items.Count;
    }

    public static void DisplayTotals(){
        // display total cost, labor cost, overhead, profit, total sales, total sales per item
        // CalculateCost();
        // CalculateLaborCost();
        // CalculateOverhead();
        // CalculateProfit();
        // CalculateTotalSales();
    }

}
