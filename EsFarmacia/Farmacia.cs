using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsFarmacia
{
    class Farmacia
    {
        //nome della farmacia
        string nome;
        //indirizzo della farmacia
        string indirizzo;
        //codice della farmacia
        string codice;
        //nome del titolare della farmacia
        string titolare;
        //elenco di farmaci della farmacia
        List<Farmaco> elencoFarmaci = new List<Farmaco>();

        //proprietà del campo nome
        public string Nome
        {
            get { return nome; }
            set
            {
                if (!String.IsNullOrWhiteSpace(value))
                {
                    nome = value;
                }
                else
                {
                    throw new ArgumentException("nomeFarmacia");
                }
            }
        }
        //proprietà del campo indirizzo
        public string Indirizzo
        {
            get { return indirizzo; }
            set
            {
                if (!String.IsNullOrWhiteSpace(value))
                {
                    indirizzo = value;
                }
                else
                {
                    throw new ArgumentException("indirizzoFarmacia");
                }
            }
        }
        //proprietà del campo codice
        public string Codice
        {
            get { return codice; }
            set
            {
                if (!String.IsNullOrWhiteSpace(value))
                {
                    codice = value;
                }
                else
                {
                    throw new ArgumentException("codiceFarmacia");
                }
            }
        }
        //proprietà del campo titolare
        public string Titolare
        {
            get { return titolare; }
            set
            {
                if (!String.IsNullOrWhiteSpace(value))
                {
                    titolare = value;
                }
                else 
                { 
                    throw new ArgumentException("titolareFarmacia"); 
                }
            }
        }
        //proprietà del campo elencoFarmaci
        public List<Farmaco> ElencoFarmaci
        {
            get { return elencoFarmaci; }
        }

        //costruttore
        public Farmacia(string nome, string indirizzo, string codice, string titolare)
        {
            Nome = nome;
            Indirizzo = indirizzo;
            Codice = codice;
            Titolare = titolare;
        }

        //metodo che calcola il valore totale dei farmaci posseduti dalla farmacia
        public double TotaleCostoFarmaci()
        {
            double costoTotale = 0;
            foreach(Farmaco farmaco in ElencoFarmaci)
            {
                costoTotale += farmaco.Prezzo;
            }
            return costoTotale;
        }

        //metodo che fornisce i dati del farmaco cercato in base al codice
        public string[] DatiFarmaco(string codiceFarmaco)
        {
            string[] datiFarmaco = new string[5];
            foreach(Farmaco f in ElencoFarmaci)
            {
                if (codiceFarmaco == f.Codice)
                {
                    datiFarmaco[0] = f.Nome;
                    datiFarmaco[1] = f.CasaFarmaceutica;
                    datiFarmaco[2] = f.Codice;
                    datiFarmaco[3] = f.Prezzo.ToString();
                    datiFarmaco[4] = f.Scadenza;

                    break;
                }
            }
            return datiFarmaco;
        }
    }
}