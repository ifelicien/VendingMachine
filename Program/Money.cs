//this class is unused, decided on another method
//this class will be used to verify money type
namespace Currency {
    public class Money {

        string Name;
        double Value;

        public Money(string name, double value){
            Name = name;
            Value = value;
        }

        // Getters
        public string GetName() {
            return Name;
        }

        public double GetValue() {
            return Value;
        }
        
        // Setters
        public void SetName (string name) {
            Name = name;
        }
        public void SetValue(double value) {
            Value = value;
        }
    }
}