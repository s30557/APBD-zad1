public class KontenerPlyny : Kontener
{
    public KontenerPlyny(double w, double k, double g, double maxW) 
        : base(w, k, g, maxW)
    {
        this.numerS = "KON-L-" + counter++;
    }

    public void Zaladuj(double kg, String nazwa, bool niebezpieczny)
    {
        double limit = niebezpieczny ? 0.5 * wagaM : 0.9 * wagaM;
        if (wagaL + kg > limit)
        {
            throw new OverfillException("Błąd: kontener przekroczył bezpieczny ładunek");
        }
            wagaL += kg;
    }
}