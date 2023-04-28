// See https://aka.ms/new-console-template for more information

using csharp_gestore_eventi;

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
string InputUtentePrenotazione = Console.ReadLine();

while (InputUtentePrenotazione == "si")
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
    InputUtentePrenotazione = Console.ReadLine();
}

//chiedere all’utente se e quanti posti vuole disdire
//stampare i posti residui e quelli prenotati
