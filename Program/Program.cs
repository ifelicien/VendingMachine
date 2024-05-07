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
        
        Money penny = new Money("Penny", .01);
        Money nickel = new Money("Nickel", .05);
        Money dime = new Money("Dime", .10);
        Money quarter = new Money("Quarter", .25);
        Money oneDollar = new Money("One Dollar", 1.00);
        Money fiveDollar = new Money("Five Dollar", 5.00);

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
        
        default:
        Console.WriteLine("Invalid input");
        break;
        }

    }

}
