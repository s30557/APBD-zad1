namespace ConsoleApp1;

public class Kontenerowiec
{
    
    List<Kontener> kontenery = new List<Kontener>();
    double predkosc;
    int ilosckont;
    double wagakont;

    public Kontenerowiec(double predkosc, int ilosckont, double wagakont)
    {
        this.predkosc = predkosc;
        this.ilosckont = ilosckont;
        this.wagakont = wagakont;
    }

    public void DodajKontener(Kontener k)
    {
        if (kontenery.Count >= ilosckont)
        {
            throw new Exception("Przekroczono maksymalną liczbę kontenerów na statku");
        }
        double aktualnaWaga = 0;
        foreach (var kontener in kontenery)
        {
            aktualnaWaga += kontener.wagaL + kontener.wagaK;
        }
        if (aktualnaWaga + k.wagaL + k.wagaK > wagakont * 1000)
        {
            throw new Exception("Przekroczono maksymalną wagę jaką uniesie kontenerowiec");
        }
        kontenery.Add(k);
    }
    
    public void DodajListeKontenerow(List<Kontener> noweKontenery)
    {
        foreach (var kontener in noweKontenery)
        {
            DodajKontener(kontener);
        }
    }
    
    public void UsunKontener(string numer)
    {
        var kontener = kontenery.FirstOrDefault(k => k.numerS == numer);
        if (kontener == null)
            throw new Exception("Kontener o podanym numerze nie znajduje się na statku");

        kontenery.Remove(kontener);
    }
    
    public void ZastapKontener(string numer, Kontener nowyKontener)
    {
        UsunKontener(numer);
        DodajKontener(nowyKontener);
    }

    public override string ToString()
    {
        return $"Kontenerowiec: maksymalna prędkość {predkosc} węzłów\n" +
               $"Liczba kontenerów: {kontenery.Count}/{ilosckont}\n" +
               $"Waga całkowita ładunku: {kontenery.Sum(k => k.wagaL + k.wagaK)} kg\n";
    }
    
}
