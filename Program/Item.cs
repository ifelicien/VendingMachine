namespace Product {
class Item{

// Properties
    string Name {get; set; }
    double Price {get; set; }
    int Quantity {get; set; }

// Constructor
    public Item (string name, double price, int quantity){
        Name = name;
        Price = price;
        Quantity = quantity;
    }

// Getters
    public string GetName(){
        return Name;
    }

    public double GetPrice(){
        return Price;
    }
    public int GetQuantity(){
        return Quantity;
    }

// Setters
    public void SetPrice(double newPrice){
        Price = newPrice;
    }
    public void SetName(string newName){
        this.Name = newName;
    }
    public void Setuantity(int newQuantity){
        Quantity = newQuantity;
    }
}
}
