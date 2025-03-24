namespace ConsoleApp1;

public class KontenerChlod : Kontener
{
    private double temperatura;
    private string produkt;

    private static Dictionary<string, double> TempProd = new Dictionary<string, double>
    {
        { "Bananas", 13.3 },
        { "Chocolate", 18 },
        { "Fish", 2 },
        { "Meat", -15 },
        { "Ice cream", -18 },
        { "Frozen pizza", -30 },
        { "Cheese", 7.2 },
        { "Sausages", 5 },
        { "Butter", 20.5 },
        { "Eggs", 19 }
    };
    
    public KontenerChlod(double w, double k, double g, double maxW, double temp) 
        : base(w, k, g, maxW)
    {
        this.temperatura = temp;
        this.numerS = "KON-C-" + counter++;
    }
    
    public void Zaladuj(double kg, string prod)
    {
        if (produkt != null && produkt != prod)
        {
            throw new Exception("Kontener może przechowywać tylko jeden rodzaj produktu");
        }
        if (wagaL + kg > wagaM)
        {
            throw new OverfillException("Błąd: kontener przepełniony");
        }
        if (!TempProd.ContainsKey(prod))
        {
            throw new Exception("Nieznany produkt, brak informacji o wymaganej temperaturze!");
        }
        double wymaganatemp = TempProd[prod];
        double dol = wymaganatemp*0.9;
        double gora = wymaganatemp*1.1;
        if (temperatura < dol || temperatura > gora)
        {
            throw new Exception("Nieprawidłowa temperatura dla produktu " + prod);
        }
        
        produkt = prod;
        wagaL += kg;
    }
    
    public override string ToString()
    {
        return "Kontener " + "(numer:"+numerS+", głebokość:"+glebokosc+", waga kontenera:"+wagaK+", wysokosc:"+wysokosc+", maksymalna waga ladunku:"+wagaM+", waga ładunku:"+wagaL+", temperatura:"+temperatura +")";
    }
    
    
}