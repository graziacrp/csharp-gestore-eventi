// See https://aka.ms/new-console-template for more information
using GestoreEventi;

Console.WriteLine("Hello, World!");

//Milestone 2

//Chiedo all'utente di inserire un nuovo evento con tutti i parametri richiesti dal costruttore

Console.WriteLine("Inserisci un nuovo evento, quindi anzitutto il suo titolo");
string titolo = Console.ReadLine();
Console.WriteLine("Ora inserisci anche la data di questo evento");
DateTime data = DateTime.Parse(Console.ReadLine());
Console.WriteLine("Inserisci inoltre la capienza del locale adibito per l'evento, quindi il numero di posti totali);
    int capienzaMax = int.Parse(Console.ReadLine());

Evento e = new Evento(titolo, data, capienzaMax);

//Chiedo all'utente quante prenotazioni vuole fare

Console.WriteLine("Quante prenotazioni vuoi fare?");
int postiPrenotati = int.Parse(Console.ReadLine());

e.PrenotaPosti(postiPrenotati);
Console.WriteLine("");
Console.WriteLine($"Posti prenotati = { postiPrenotati}");
Console.WriteLine($"Posti disponibili = {e.SetCapienzaMaxEvento - postiPrenotati}");
Console.WriteLine("");

//Chiedo all'utente quanti posti vuole disdire

Console.WriteLine("Quanti posti vuoi disdire?");
int numeroPostiDaDisdire = int.Parse(Console.ReadLine());


//Milestone 4

//Creazione nuovo programma di eventi che l'utente vuole organizzare

Console.WriteLine("Quali eventi vuoi aggiungere?");

Console.WriteLine("Inserisci il nome di questi eventi");
string nomeProgramma = Console.ReadLine();

Console.WriteLine("Inserisci il numero degli eventi");
int numeroEventi = int.Parse(Console.ReadLine());
ProgrammaEventi programma = new ProgrammaEventi(nomeProgramma); 








