namespace ConsoleApp1;

public class KontenerGaz : Kontener
{
    private double cisnienie;
    
    public KontenerGaz(double w, double k, double g, double maxW, double cisnienie) 
        : base(w, k, g, maxW)
    {
        this.cisnienie = cisnienie;
        this.numerS = "KON-G-" + counter++;
    }
    
    public void Zaladuj(double kg, String nazwa)
    {
        if (wagaL + kg > wagaM)
        {
            throw new OverfillException("Przekroczono maksymalną ładowność kontenera!");
        }
        else
        {
            wagaL += kg;
            cisnienie += 1;
        }
    }

    public void Oproznienie()
    {
        wagaL *= 0.05; 
        cisnienie -= 1;
    }
    
    public override string ToString()
    {
        return "Kontener " + "(numer:"+numerS+", głebokość:"+glebokosc+", waga kontenera:"+wagaK+", wysokosc:"+wysokosc+", maksymalna waga ladunku:"+wagaM+", waga ładunku:"+wagaL+", cisnienie:"+cisnienie +")";
    }
    
    
    
}