using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//BONUS

namespace csharp_gestore_eventi
{
    public class Conferenza : Evento
    {
        //ATTRIBUTI
        private string relatore;
        private double prezzo;

        //COSTRUTTORE
        public Conferenza(string titolo, string relatore, string dataStringa, int capienzaMassima, double prezzo) : base(titolo, dataStringa, capienzaMassima)
        {
            this.relatore = relatore;
            this.prezzo = prezzo;
        }

        //GETTERS
        public string GetRelatore()
        {
            return this.relatore;
        }

        public double GetPrezzo()
        {
            return this.prezzo;
        }

        //SETTERS
        public void SetRelatore(string relatore)
        {
            this.relatore = relatore;
        }

        public void SetPrezzo(double prezzo)
        {
            this.prezzo = prezzo;
        }

        //METODI
        public string GetPrezzoFormattato(double prezzo)
        {
            return prezzo.ToString("0.00");
        }

        public override string ToString()
        {
            return base.ToString()
                + " - "
                + this.GetRelatore()
                + " - "
                + this.GetPrezzoFormattato(this.GetPrezzo())
                + " euro";
        }
    }
}