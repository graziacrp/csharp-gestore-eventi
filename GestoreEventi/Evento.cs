using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace GestoreEventi
{

    //Milestone 1
    internal class Evento
    {
        //Attributi
        private string titolo;
        private DateTime data;
        private int capienzaMaxEvento;
        private int postiPrenotati;

        public Evento(string titolo, DateTime data, int capienzaMaxEvento) : base(titolo)
        {
            this.titolo = titolo;
            this.data = data;
            this.capienzaMaxEvento = capienzaMaxEvento;
            postiPrenotati = 0;
        }

        //Getter e setter

        public string GetTitolo()
        {
            return titolo;
        }
        public DateTime GetData()
        {
            return data;
        }

        public string SetTitolo(string nuovotitolo)
        {
            if (nuovotitolo == "")
            {
                throw new Exception("Il titolo non può essere vuoto");
            }
            return nuovotitolo;
        }

        public DateTime SetData(DateTime nuovadata)
        {
            DateTime dataattuale = DateTime.Now;

            if (dataattuale > nuovadata)
            {
                throw new Exception("La data è passata");
            }
            return nuovadata;
        }
        public int GetCapienzaMaxEvento()
        {
            return capienzaMaxEvento;
        }
        public int SetCapienzaMaxEvento(int capienzaMaxEvento)
        {
            if (capienzaMaxEvento < 0)
            {
                throw new Exception("Il numero non può essere negativo");
            }
            return capienzaMaxEvento;
        }

        public int GetPostiPrenotati()
        {
            return postiPrenotati;
        }

        // Metodi 

        public void PrenotaPosti(int numeroPostiDaAggiungere, DateTime data)
        {
            DateTime oraattuale = DateTime.Now;

            if (postiPrenotati + numeroPostiDaAggiungere > capienzaMaxEvento)
            {
                throw new Exception("Sto prenotando più posti di quanti ce ne possano essere");
            }
            else
            {
                postiPrenotati = postiPrenotati + numeroPostiDaAggiungere;
                Console.WriteLine("Ho aggiunto altri posti");

            }

            private void DisdiciPosti(int numeroPostiDaDisdire, DateTime data)
            {
                DateTime oraattuale = DateTime.Now;

                if (postiPrenotati - numeroPostiDaDisdire < 0)
                {
                    throw new Exception("I posti disdetti sono in eccesso");
                }
                else
                {
                    postiPrenotati = postiPrenotati - numeroPostiDaDisdire;
                    Console.WriteLine("Ho disdetto i posti");
                }
            }

            public string ToString()
            {
                data.ToString("dd/mm/aa");
                string conversioneInStringa = "";

                conversioneInStringa = data.ToString("dd/mm/aa") + "" + "titolo" + this.titolo;

                return conversioneInStringa;
            }
        }
    }

    //Milestone 2



    




