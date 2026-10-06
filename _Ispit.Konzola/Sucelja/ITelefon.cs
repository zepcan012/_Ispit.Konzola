
namespace _Ispit.Konzola.Sucelja
{
    internal interface ITelefon
    {
        string Model { get;}
        string Poziv(string telefonski_broj);
    }
}
