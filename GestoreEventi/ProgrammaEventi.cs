using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestoreEventi
{
    //Milestone 3
    internal class ProgrammaEventi
    {
       public string Titolo { get; set; }
       public List<Evento> eventi { get; set; }

        //Nel costruttore valorizzare il titolo, passato come parametro, e inizializzare la lista di eventi come una nuova Lista vuota di eventi
        public ProgrammaEventi(string Titolo)
        {
            this.Titolo = Titolo;
            eventi = new List<Evento>();
        }

        //Metodi

        public void AggiungiEvento (Evento evento, List<Evento> lista)
        {
            lista.Add(evento);
        }

        public List<Evento> InDataEventi(DateTime data, List<Evento> lista)
        {
            foreach (Evento evento in eventi )
            {
                if (evento.data == data)
                {
                    AggiungiEvento(evento, lista);
                }
            }

            Console.WriteLine("Stampa la lista:");
            return lista;
        }

        public void SvuotaLista(List<Evento> eventi) {

            eventi.Clear();

        }
    }
}
