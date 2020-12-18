using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsFarmacia
{
    class Farmaco
    {
        //nome del farmaco
        string nome;
        //casa farmaceutica produttrice del farmaco
        string casaFarmaceutica;
        //codice del farmaco
        string codice;
        //prezzo del farmaco
        double prezzo;
        //scadenza del farmaco
        string scadenza;

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
                    throw new ArgumentException("nomeFarmaco");
                }
            }
        }

        //proprietà del campo casaFarmaceutica
        public string CasaFarmaceutica
        {
            get { return casaFarmaceutica; }
            set
            {
                if (!String.IsNullOrWhiteSpace(value))
                {
                    casaFarmaceutica = value;
                }
                else
                {
                    throw new ArgumentException("casaFarmaceutica");
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
                    throw new ArgumentException("codiceFarmaco");
                }
            }
        }

        //proprietà del campo prezzo
        public double Prezzo
        {
            get { return prezzo; }
            set
            {
                if (value > 0)
                {
                    prezzo = value;
                }
                else
                {
                    throw new ArgumentException("prezzoFarmaco");
                }
            }
        }

        //proprietà del campo scadenza
        public string Scadenza
        {
            get { return scadenza; }
            set
            {
                scadenza = value;
            }
        }

        //costruttore
        public Farmaco(string nome, string casaFarmaceutica, string codice, double prezzo, string scadenza)
        {
            try
            {
                Nome = nome;
                CasaFarmaceutica = casaFarmaceutica;
                Codice = codice;
                Prezzo = prezzo;
                Scadenza = scadenza;
            }
            catch
            {
                throw;
            }
        }
    }
}