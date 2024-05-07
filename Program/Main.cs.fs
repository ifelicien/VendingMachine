using Item;
class Program{
    public void Main(string[] args){
        Item coke = new Item("Coke", .95, 30);
        Item doritos = new Item("Doritos", .75, 30);
        Item snickers = new Item("Snickers", .55, 30);
        Item chexMix = new Item("Chex Mix", .60, 30);
        Item pepsi = new Item("Pepsi", .90, 30);
        Console.WriteLine($"Item:  {coke.get_name()} Price:  {coke.get_price()}");
    }
}
