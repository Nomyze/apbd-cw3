namespace cw3.Kontenery;

public class Kontenerowiec {
    public List<Kontener> kontenery {get;}
    double max_speed;
    int max_kon_count;
    double max_load;

    public Kontenerowiec(double max_speed, double max_load, int max_count) {
        this.max_load = max_load;
        this.max_speed = max_speed;
        this.max_kon_count = max_count;
        this.kontenery = new List<Kontener>();
    }

    public void load(Kontener kon) {
        this.kontenery.Add(kon);
    }

    public void load(List<Kontener> konArr) {
        this.kontenery.AddRange(konArr);
    }

    public void remove(Kontener kon) {
        this.kontenery.Remove(kon);
    }

    public Kontener get(int i) {
        return kontenery[i];
    }

    public void change(int i, Kontener kon) {
        kontenery[i] = kon;
    }

    public void exchange(Kontenerowiec other, int i) {
        other.load(get(i));
        remove(get(i));
    }

    public void get_info(int i) {
        Console.WriteLine(get(i).to_string());
    }

    public void get_info() {
        string str = "";
        str += $"Max speed: {max_speed}, Max load: {max_load}, Max containers: {max_kon_count}\n"; 
        str += "Loaded:\n";
        foreach(Kontener kon in kontenery) {
            str += kon.to_string();
        }
        Console.WriteLine(str);
    }
}
