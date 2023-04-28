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
        public Evento(string titolo, string data, int capienzaMassima)
        {
            SetTitolo(titolo);
            SetData(data);
            SetCapienzaMassima(capienzaMassima);

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
        public void SetTitolo(string titolo)
        {
            //inserire gli opportuni controlli in modo che il titolo non sia vuoto
            if (titolo == null || titolo == "")
            {
                throw new Exception("Non puoi lasciare il titolo vuoto");
            }
            this.titolo = titolo;
        }

        public void SetData(string dataString)
        {
            //inserire gli opportuni controlli in modo che la data non sia già passata

            DateTime data = DateTime.Parse(dataString);
            if (data > DateTime.Today)
            {
                this.data = data;
            }
            else
            {
                throw new Exception("La data inserita è già passata");
            }
            this.data = data;
        }

        private void SetCapienzaMassima(int capienzaMassima)
        {
            //inserire gli opportuni controlli in modo che la capienza massima di posti sia un numero positivo
            if (capienzaMassima < 0)
            {
                throw new Exception("Non puoi inserire un valore negativo");
            }
            this.capienzaMassima = capienzaMassima;
        }

        //METODI
        public void PrenotaPosti(int numeroPostiPrenotare)
        {            
            int numeroPostiDisponibili = this.capienzaMassima - this.postiPrenotati;

            //Se l’evento non ha posti(0) o non ha più posti disponibili deve sollevare un’eccezione.
            if (numeroPostiDisponibili == 0)
            {
                throw new Exception("Non ci sono posti disponibili");
            } 
            else if (numeroPostiPrenotare > numeroPostiDisponibili)
            {
                throw new Exception("Non ci sono abbastanza posti");
            }
            else
            {
                this.postiPrenotati += numeroPostiPrenotare;
            }
        }

        public void DisdiciPosti(int numeriPostiDisdire)
        {
            //Se non ci sono i posti da disdire sufficienti, solleva un’eccezione
            if (this.postiPrenotati - numeriPostiDisdire < 0)
            {
                throw new Exception("Non puoi disdire più posti di quelli prenotati");
            }
            this.postiPrenotati -= numeriPostiDisdire;
        }

        public virtual string ToString()
        {
            string dataStringa = this.data.ToString("dd/MM/yyyy");

            return dataStringa 
                + " - " 
                + this.titolo;
           /* return "\n Titolo: "
                + this.titolo
                + "\n Data: "
                + dataStringa
                + "\n Capienza massima: "
                + this.capienzaMassima
                + "\n Posti prenotati: "
                + this.postiPrenotati
                + "\n -----------------------------";*/
        }

    }
}
