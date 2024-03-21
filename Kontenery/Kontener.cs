namespace cw3.Kontenery;

public abstract class Kontener : cw3.Interfaces.IKontener {
    protected double load_mass { get; set; }
    protected int height;
    private double own_mass;
    protected int depth;
    protected string con_type;
    protected int id {get;}
    protected double max_load {get; set; }

    static private int iden_id = 0;

    public string serial {
        get {
            return "KON-" + con_type + "-" + Convert.ToString(id);
        }
    }

    protected Kontener(int height, int depth, double own_mass, double max_load, string type) {
        iden_id += 1;
        this.height = height;
        this.depth = depth;
        this.own_mass = own_mass;
        this.max_load = max_load;
        this.id = iden_id;
        this.load_mass = 0;
        con_type = type;
    }

    virtual public void empty() {
        this.load_mass = 0;
    }
    
    virtual public void load(double mass) {
        if(this.max_load < mass)
            throw new cw3.Exceptions.OverfillException();
        this.load_mass = mass;
    }
    virtual public string to_string() {
        return $"{this.serial}{Environment.NewLine}" + 
               $"[Height : Depth] : [{this.height} : {this.depth}]{Environment.NewLine}" +
               $"[Own Mass : Max Load : Current load] : [{this.own_mass} : {this.max_load} : {this.load_mass}]{Environment.NewLine}";
    }
}
