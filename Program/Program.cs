using Product;
using Currency;
class Program{
    
    public static void Main(string[] args){

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
        int selection = int.Parse(input);

        switch (selection){
        
        case 1:
            Console.WriteLine($"{coke.GetName()}.");
            double ItemCost = coke.GetPrice();
            break;
        
        case 2:
            Console.WriteLine($"{doritos.GetName()}.");
            break;
        
        case 3:
            Console.WriteLine($"{snickers.GetName()}.");
            break;
        
        case 4:
            Console.WriteLine($"{chexMix.GetName()}.");
            break;
        
        case 5:
            Console.WriteLine($"{pepsi.GetName()}.");
            break;
        case 6:
            DisplayTotals();
            break;
        
        default:
        Console.WriteLine("Invalid input");
        break;
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

//each time item is sold add to array, can use array.length to get total sales and return price for calculating profit
//
    public static void CalculateCost(double SellingPrice){
        double cost = SellingPrice * 0.35;
    }

    public static void CalculateOverhead(double SellingPrice){
        double laborCost = SellingPrice * 0.05;
    }
    public static void CalculateProfit(){

    }

     public static void CalculateLaborCost(double SellingPrice){
        double laborCost = SellingPrice * 0.25;
    }

     public static void CalculateTotalSales(){
        
    }

    public static void DisplayTotals(){
        // display total cost, labor cost, overhead, profit, total sales, total sales per item
    }

}
