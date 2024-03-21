namespace cw3.Kontenery;
using cw3.Interfaces;
using cw3.types;

public class PKontener : Kontener, IHazardNotifier {
    private HazardousAction? haz_act;
    private LiquidType liq;

    public PKontener(int height, int depth, double own_mass, double max_load, char type) :
        base(height, depth, own_mass, max_load, "L") {
        switch(type) {
            case 'd':
                liq = LiquidType.Dangerous;
                break;
            case 's':
                liq = LiquidType.Safe;
                break;
            default:
                throw new ArgumentOutOfRangeException();
        }
        haz_act = null;
    }

    public void notify()
    {
        string mess = "";
        switch(haz_act) {
            case HazardousAction.Dangerous50:
                mess = "Attempt to fill more than 50% with dangerous liquid.";
                break;
            case HazardousAction.Safe90 :
                mess = "Attempt to fill more than 90% with safe liquid.";
                break;
            default:
                return;
        };

        Console.WriteLine(mess + $" ID: {this.id}");
    }

    private void check_state() {
        switch(liq) {
            case LiquidType.Safe:
                if(load_mass > .9 * max_load) {
                    haz_act = HazardousAction.Safe90;
                    notify();                    
                }
                break;
            case LiquidType.Dangerous:
                if(load_mass > .5 * max_load) {
                    haz_act = HazardousAction.Dangerous50;
                    notify();
                }
                break;
            default:
                haz_act = null;
                break;
        }
    }

    override public void load(double mass) {
        base.load(mass);
        check_state();
    }
}
