namespace cw3.Kontenery;
using cw3.types;
using cw3.Exceptions;

public class CKontener : Kontener {
    double temp;
    Produkt produkt;
    public CKontener(int height, int depth, double own_mass, double max_load, Produkt prod, double temp) :
        base(height, depth, own_mass, max_load, "C") {
        this.produkt = prod; 
        this.temp = temp;
        if(this.temp < produkt.temp) {
            throw new TooColdException(); 
        }
    }

    public override string to_string() {
        return base.to_string() + $"[{this.produkt.name}, {this.produkt.temp}, {this.temp}]\n";
    }
}
