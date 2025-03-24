public class Kontener
{
    public double wagaL; // waga ładunku
    public double wagaM; // maksymalna waga ładunku
    public double wysokosc;
    public double wagaK; // waga kontenera
    public double glebokosc;
    public String numerS; // numer seryjny
    public static int counter = 1;

    public Kontener(double w, double k, double g, double maxW)
    {
        this.wagaL = 0;
        this.wysokosc = w;
        this.wagaK = k;
        this.glebokosc = g;
        this.wagaM = maxW;
        this.numerS = "KON-" + counter++;
    }

    public void Oproznienie()
    {
        wagaL = 0;
    }

    public void Zaladuj(double kg)
    {
        if (wagaL + kg > wagaM)
        {
            throw new OverfillException("Błąd: kontener przepełniony");
        }
            wagaL += kg;
    }

    public override string ToString()
    {
        return "Kontener " + "(numer:"+numerS+", głebokość:"+glebokosc+", waga kontenera:"+wagaK+", wysokosc:"+wysokosc+", maksymalna waga ladunku:"+wagaM+", waga ładunku:"+wagaL +")";
    }
}

public class OverfillException : Exception
{
    public OverfillException(string message) : base(message)
    {
    }
}