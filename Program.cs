using ConsoleAppPaiementss;

internal class Program
{
    private static void Main(string[] args)
    {
        Paiement paypal1 = new Paypal(50.0, "Achat de logiciel", "oussamanajem@boreal.com");
        Paiement paypal2 = new Paypal(100.0, "Paiement de service", "oussamanajem@boreal2.com");

        paypal1.AfficherDetails();
        paypal2.AfficherDetails();

    }
}