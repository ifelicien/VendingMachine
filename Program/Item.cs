namespace Item;
class Item{

// Properties
    string Name {get; set; };
    double Price {get; set; };
    int Quantity {get; set; };

// Constructor
    public Item (string name, double price, int quantity){
        Name = name.ToLower();
        Price = price;
        Quantity = quantity;
    }

// Getters
    public string get_name(){
        return name;
    }

    public double get_price(){
        return price;
    }
    public int get_quantity(){
        return quantity;
    }

// Setters
    public void set_price(double newPrice){
        Price = newPrice;
    }
    public void set_name(string newName){
        this.Name = newName
    }
    public void set_quantity(int newQuantity){
        Quantity = newQuantity
    }
}

