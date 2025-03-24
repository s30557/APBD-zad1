namespace ConsoleApp1;

public class Program
{
    public static void Main(string[] args)
    {
        Kontenerowiec statek = new Kontenerowiec(25, 5, 50);

        
        KontenerPlyny kontenerPaliwo = new KontenerPlyny(2.5, 1000, 3.5, 2000);
        KontenerPlyny kontenerMleko = new KontenerPlyny(2.5, 1000, 3.5, 2000);
        KontenerGaz kontenerHel = new KontenerGaz(2.5, 1000, 3.5, 500, 5);
        KontenerChlod kontenerBanany = new KontenerChlod(2.5, 1000, 3.5, 5000, 13.3);
        
        
        kontenerPaliwo.Zaladuj(900, "Paliwo", true); 
        kontenerMleko.Zaladuj(1800, "Mleko", false); 
        kontenerHel.Zaladuj(400, "Hel"); 
        kontenerBanany.Zaladuj(4000, "Bananas"); 
        
        
        
        
        Console.WriteLine(kontenerPaliwo.ToString());
        Console.WriteLine(kontenerMleko.ToString());
        Console.WriteLine(kontenerHel.ToString());
        Console.WriteLine(kontenerBanany.ToString());

        
        statek.DodajKontener(kontenerPaliwo);
        statek.DodajKontener(kontenerMleko);
        statek.DodajKontener(kontenerHel);
        statek.DodajKontener(kontenerBanany);

        
        Console.WriteLine(statek);
        
    }
}