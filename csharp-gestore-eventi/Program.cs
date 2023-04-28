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

//chiedere all’utente se e quante prenotazioni vuole fare e provare ad effettuarle
Console.WriteLine("Vuoi prenotare dei posti? (si/no)");
string InputUtente = Console.ReadLine();
