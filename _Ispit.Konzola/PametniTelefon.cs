using _Ispit.Konzola.Sucelja;

namespace _Ispit.Konzola
{
    internal class PametniTelefon : IPametniTelefon
    {
        public string Model { get; private set; }

        public PametniTelefon(string model){
            Model = model;
        }


        public bool ProvjeriAkoJeValidanUrl(string url) {
            foreach (char znak in url) {

                if (char.IsDigit(znak)) {

                    return false;
                }
            }

            return true;
        }

        public string Surfanje(string url) {

            if (ProvjeriAkoJeValidanUrl(url)){

                return "Surfate na stranici: " + url;
            }
            else {

                return "Neispravan url!";
            }
        }

        public bool ProvjeriAkoJeValidanBroj(string telefonski_broj) {

            foreach (char znak in telefonski_broj){

                if (!char.IsDigit(znak)) {

                    return false;
                }
            }

            return true;
        }


        public string Poziv(string telefonski_broj) {

            if (ProvjeriAkoJeValidanBroj(telefonski_broj)){

                return "Zovem broj: " + telefonski_broj;
            }
            else {

                return "Neispravan telefonski broj!";
            }
        }
    }
}
