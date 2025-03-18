using ConsoleApp1;

public class Kontener
{
    private double wagaL; // waga ładunku
    private double wagaM; // maksymalna waga ładunku
    private double wysokosc;
    private double wagaK; // waga konternera
    private double glebokosc;
    private String numerS; // numer seryjny

    public Kontener(double l, double w, double k, double g)
    {
        this.wagaL = l;
        this.wysokosc = w;
        this.wagaK = k;
        this.glebokosc = g;
        numerS = "KON";
    }


    public void Oproznienie()
    {
        wagaL = 0;
    }

    public void Zaladuj(double kg, String num)
    {
        if (wagaL+kg>wagaM)
        {
            throw new OverfillException();
        }
        else
        {
            wagaL += kg;
        }


        
        
    }

    public String toString()
    {
        
        
        
        return numerS + wagaL + wysokosc + wagaK;
    }



}