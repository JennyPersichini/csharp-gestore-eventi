﻿// See https://aka.ms/new-console-template for more information

using csharp_gestore_eventi;

//chiedere all'utente qual è il titolo del suo programma eventi

Console.Write("Inserisci il nome del tuo programma di eventi: ");
string titoloProgrammaUtente = Console.ReadLine();

ProgrammaEventi nuovoProgrammaEventi = new ProgrammaEventi(titoloProgrammaUtente);

//Chiedere poi al vostro utente quanti eventi vuole aggiungere
Console.WriteLine("Quanti eventi contiene il tuo programma? ");
int numeroEventiUtente = int.Parse(Console.ReadLine());

//far inserire ad uno ad uno tutti gli eventi necessari chiedendo man mano tutte le informazioni richieste all’utente,
//finchè non raggiunge il numero di eventi specificato  dall’utente.

while (numeroEventiUtente != nuovoProgrammaEventi.EventiPresenti())
{
    try
    {
        Console.Write("Inserisci il nome dell'evento: ");
        string titoloUtente = Console.ReadLine();

        Console.Write("Inserisci la data dell'evento (dd/MM/yyyy): ");
        string dataUtente = Console.ReadLine();

        Console.Write("Inserisci il numero di posti totali: ");
        int capienzaUtente = int.Parse(Console.ReadLine());

        //Evento(titolo, data, capienzaMassima)
        Evento eventoUtente = new Evento(titoloUtente, dataUtente, capienzaUtente);
        nuovoProgrammaEventi.AggiungiEvento(eventoUtente);

        Console.WriteLine("");
    } 
    catch (Exception e)
    {
    Console.WriteLine(e.Message);
    }
}

//BONUS

Console.Write("Inserisci il nome della conferenza: ");
string titoloConferenzaUtente = Console.ReadLine();

Console.Write("Inserisci il nome del relatore: ");
string relatoreConferenzaUtenteUtente = Console.ReadLine();

Console.Write("Inserisci la data dell'evento (dd/MM/yyyy): ");
string dataConferenzaUtente = Console.ReadLine();

Console.Write("Inserisci il numero di posti totali: ");
int capienzaConferenzaUtente = int.Parse(Console.ReadLine());

Console.Write("Inserisci costo entrata: ");
double prezzaConferenzaUtente = double.Parse(Console.ReadLine());

//Conferenza(titolo, relatore, dataStringa, capienzaMassima, prezzo)
Conferenza conferenzaUtente = new Conferenza(titoloConferenzaUtente, relatoreConferenzaUtenteUtente, dataConferenzaUtente, capienzaConferenzaUtente, prezzaConferenzaUtente);
nuovoProgrammaEventi.AggiungiEvento(conferenzaUtente);

Console.WriteLine("");

//FINE BONUS


//Stampare il numero di eventi presenti nel vostro programma eventi
Console.WriteLine("Totale eventi: " + nuovoProgrammaEventi.EventiPresenti());

//Stampare la lista di eventi inseriti nel vostro programma
Console.WriteLine(nuovoProgrammaEventi);

Console.WriteLine("");

//Chiedere all’utente una data e stampare tutti gli eventi in quella data
Console.Write("Inserisci una data (dd/MM/yyyy): ");
string dataUtente2 = Console.ReadLine();
Console.WriteLine(ProgrammaEventi.StampaInConsole(nuovoProgrammaEventi.EventiInData(dataUtente2)));

//Eliminare tutti gli eventi dal vostro programma
nuovoProgrammaEventi.SvuotaLista();





















/*
//chiedere all’utente di inserire un nuovo evento con tutti i parametri richiesti dal costruttore.

Console.Write("Inserisci il nome dell'evento: ");
string titoloUtente = Console.ReadLine();

Console.Write("Inserisci la data dell'evento (dd/MM/yyyy): ");
string dataUtente = Console.ReadLine();

Console.Write("Inserisci il numero di posti totali: ");
int capienzaUtente = int.Parse(Console.ReadLine());

//Evento(titolo, data, capienzaMassima)
Evento eventoUtente = new Evento(titoloUtente, dataUtente, capienzaUtente);
Console.WriteLine(eventoUtente.ToString());

Console.WriteLine("");

//chiedere all’utente se e quante prenotazioni vuole fare e provare ad effettuarle
Console.WriteLine("Vuoi prenotare dei posti? (si/no) ");
string InputUtente = Console.ReadLine();

while (InputUtente == "si")
{
    Console.WriteLine("Quanti Posti desideri prenotare? ");
    int numeroPostiPrenotare = int.Parse(Console.ReadLine());

    eventoUtente.PrenotaPosti(numeroPostiPrenotare);
    Console.WriteLine("");

    int postiDisponibili = eventoUtente.GetCapienzaMassima() - eventoUtente.GetPostiPrenotati();

    //Stampare a video il numero di posti prenotati e quelli disponibili
    Console.WriteLine("Posti Disponibili Evento: " + postiDisponibili);
    Console.WriteLine("Numero Posti Prenotati: " + eventoUtente.GetPostiPrenotati());
    Console.WriteLine("------------------------------------------");
    Console.WriteLine("");

    Console.WriteLine("Vuoi prenotare altri posti? (si/no) ");
    InputUtente = Console.ReadLine();
}

Console.WriteLine("");

//chiedere all’utente se e quanti posti vuole disdire
Console.WriteLine("Vuoi disdire dei posti? (si/no) ");
InputUtente = Console.ReadLine();

while (InputUtente == "si")
{
    Console.WriteLine("Quanti Posti desideri disdire?");
    int numeriPostiDisdire = int.Parse(Console.ReadLine());

    eventoUtente.DisdiciPosti(numeriPostiDisdire);
    Console.WriteLine("");

    int postiDisponibili = eventoUtente.GetCapienzaMassima() - eventoUtente.GetPostiPrenotati();

    //stampare i posti residui e quelli prenotati
    Console.WriteLine("Posti Disponibili Evento: " + postiDisponibili);
    Console.WriteLine("Numero Posti Prenotati: " + eventoUtente.GetPostiPrenotati());
    Console.WriteLine("------------------------------------------");
    Console.WriteLine("");

    Console.WriteLine("Vuoi disdire altri posti? (si/no) ");
    InputUtente = Console.ReadLine();
}

Console.WriteLine("");
Console.WriteLine("Ok! Arrivederci e Grazie!");
*/

