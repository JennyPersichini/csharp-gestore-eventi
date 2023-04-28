using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_gestore_eventi
{
    public class Evento
    {
        //ATTRIBUTI
        private string titolo;
        private DateTime data;
        private int capienzaMassima;
        private int postiPrenotati;

        //COSTRUTTORE
        public Evento(string titolo, string dataStringa, int capienzaMassima)
        {
            this.titolo = titolo;
            this.data = dataStringa;
            this.capienzaMassima = capienzaMassima;
            this.postiPrenotati = 0;
        }

        //GETTERS
        public string GetTitolo()
        {
            return this.titolo;
        }
        public DateTime GetData()
        {
            return this.data;
        }
        public int GetCapienzaMassima()
        {
            return this.capienzaMassima;
        }
        public int GetPostiPrenotati()
        {
            return this.postiPrenotati;
        }

        //SETTERS
        


    }
}
