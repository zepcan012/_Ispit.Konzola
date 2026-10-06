using _Ispit.Konzola;
using _Ispit.Konzola.Sucelja;

internal class Program
{
    private static void Main(string[] args)
    {
        string modelTelefona;

        Console.WriteLine("Unesite model Vašeg telefona: ");
        modelTelefona = Console.ReadLine();

        PametniTelefon telefon = new PametniTelefon(modelTelefona);

        TestirajTelefon(telefon);
    }

    static void TestirajTelefon(IPametniTelefon telefon) {

        string telefonski_broj;
        string url;
        string rezultat;

        while (true) { 

            Console.WriteLine("Koji broj želite nazvati?");
            telefonski_broj = Console.ReadLine();

            rezultat = telefon.Poziv(telefonski_broj);
            Console.WriteLine(rezultat);
            Console.WriteLine();

            if (rezultat != "Neispravan telefonski broj!") {

                break;
            }

        }


        while (true) {

            Console.WriteLine("Koju Web stranicu želite surfati?");
            url = Console.ReadLine();

            rezultat = telefon.Surfanje(url);
            Console.WriteLine(rezultat);
            Console.WriteLine();

            if (rezultat != "Neispravan url!") {
                break;
            }

        }
        

        
    }
}