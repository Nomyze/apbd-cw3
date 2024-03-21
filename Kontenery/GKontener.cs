namespace cw3.Kontenery;
using cw3.Interfaces;
using cw3.Exceptions;

public class GKontener : Kontener, IHazardNotifier {
    private double psi;

    public GKontener(int height, int depth, double own_mass, double max_load) :
        base(height, depth, own_mass, max_load, "G") {
        psi = 0;
        check_state();
    }
    private void check_state() {
        if(load_mass > max_load) {
            throw new OverfillException();
        }
    }

    override public void empty() {
        this.load_mass *= .05f;
    }
    public override void load(double mass) {
        base.load(mass);
        psi = load_mass / (height * depth);
        check_state();
    }

    public void notify() {
       Console.WriteLine($"Dangerous action. ID: {this.id}"); 
    }
}
