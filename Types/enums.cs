namespace cw3.types;

enum HazardousAction {
    Dangerous50,
    Safe90
};
enum LiquidType {
    Dangerous,
    Safe
};

public struct Produkt {
    public string name;
    public double temp;
    public Produkt(string name, double temp) {
        this.name = name;
        this.temp = temp;
    }
}
