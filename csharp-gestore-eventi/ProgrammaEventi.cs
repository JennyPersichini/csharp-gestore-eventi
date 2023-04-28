using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace csharp_gestore_eventi
{
    public class ProgrammaEventi
    {
        //ATTRIBUTI
        private string titolo;
        private List<Evento> eventi;

        //COSTRUTTORE
        public ProgrammaEventi(string titolo)
        {
            this.titolo = titolo;
            this.eventi = new List<Evento>();
        }

        //GETTER
        public string GetTitolo()
        {
            return this.titolo;
        }

        //METODI

        //1. un metodo che aggiunge alla lista del programma eventi un Evento, passato come parametro al metodo
        public void AggiungiEvento(Evento evento)
        {
            this.eventi.Add(evento);
        }

        //2. un metodo che restituisce una lista di eventi con tutti gli eventi presenti in una certa data
        public List<Evento> EventiInData(string dataString)
        {
            DateTime data = DateTime.Parse(dataString);

            List<Evento> ListaEventiInData = new List<Evento>();

            foreach (Evento evento in this.eventi)
            {
                if (evento.GetData() == data)
                {
                    ListaEventiInData.Add(evento);
                }
            }
            return ListaEventiInData;
        }

        //3. un metodo statico che si occupa, presa una lista di eventi, di stamparla in Console,
        //o restituisca la rappresentazione in stringa della lista di eventi


        //4. un metodo che restituisce quanti eventi sono presenti attualmente


        //5. un metodo che svuota la lista di eventi


        //6. un metodo che restituisce una stringa che mostra il titolo del programma e tutti gli eventi aggiunti alla lista
        
    }
}
