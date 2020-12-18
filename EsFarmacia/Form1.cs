using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EsFarmacia
{

    //Il programma permette di gestire una farmacia. Ogni farmacia ha un elenco di farmaci, ogniuno con vari dati
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //elenco di farmacie
        List<Farmacia> elencoFarmacie = new List<Farmacia>();

        //metodo che aggiorna la tabella delle farmacie 
        public void AggiornaForm()
        {
            //svuoto la tabella e la combobox
            dgvFarmacie.Rows.Clear();
            cbFarmacie.Items.Clear();

            //ricarico i dati delle farmacie nella tabella e nella combobox
            foreach (Farmacia f in elencoFarmacie)
            {
                object[] riga = new object[5];
                riga[0] = f.Nome;
                riga[1] = f.Indirizzo;
                riga[2] = f.Codice;
                riga[3] = f.Titolare;
                riga[4] = f.TotaleCostoFarmaci();
                //aggiungo la farmacia alla tabella
                dgvFarmacie.Rows.Add(riga);
                //aggiungo la farmacia alla combobox
                cbFarmacie.Items.Add(f.Nome);
            }
            cbFarmacie.Text = "";
        }

        //evento click del bottone InserisciFarmacia
        private void btnInserisciFarmacia_Click(object sender, EventArgs e)
        {
            try
            {
                //creo la nuova farmacia
                Farmacia nuovaFarmacia = new Farmacia(txtNomeFarmacia.Text, txtIndirizzoFarmacia.Text, txtCodiceFarmacia.Text, txtTitolareFarmacia.Text);
                //aggiungo la farmacia all'elenco di farmacie
                elencoFarmacie.Add(nuovaFarmacia);

                //svuoto le caselle di testo
                txtNomeFarmacia.Clear();
                txtIndirizzoFarmacia.Clear();
                txtCodiceFarmacia.Clear();
                txtTitolareFarmacia.Clear();
                //aggiorno il form
                AggiornaForm();
            }
            catch(ArgumentException ecc)
            {
                //controllo quale proprietà ha generato l'errore
                switch (ecc.Message)
                {
                    case "nomeFarmacia":
                        MessageBox.Show("Inserire il nome della farmacia");
                        break;
                    case "indirizzoFarmacia":
                        MessageBox.Show("Inserire l'indirizzo della farmacia");
                        break;
                    case "codiceFarmacia":
                        MessageBox.Show("Inserire il codice della farmacia");
                        break;
                    case "titolareFarmacia":
                        MessageBox.Show("Inserire il titolare della farmacia");
                        break;
                }
            }
            catch
            {
                //errore generico nell'inserimento dei dati
                MessageBox.Show("Errore nell'inserimento dei dati della farmacia");
            }
        }

        //evento click del bottone InserisciFarmaco
        private void btnInserisciFarmaco_Click(object sender, EventArgs e)
        {
            try
            {
                //controllo se è stato inserito un valore valido per evitare la generazione di un errore non gestito nella creazione del nuovo farmaco
                if(!double.TryParse(txtPrezzo.Text,out double prezzo))
                {
                    prezzo = -1;
                }
                //creo il nuovo farmaco
                Farmaco nuovoFarmaco = new Farmaco(txtNomeFarmaco.Text, txtCasaFarmaceutica.Text, txtCodiceFarmaco.Text, prezzo, txtScadenza.Text);
                //prendo il nome della farmacia
                string nomeFarmacia = Convert.ToString(cbFarmacie.SelectedItem);
                //controllo se è stata selezionata una farmacia
                if (nomeFarmacia == "")
                {
                    throw new ArgumentException("nomeFarmaciaNonValido");
                }
                //cerco la farmacia scelta e gli aggiungo il nuovo farmaco
                foreach(Farmacia f in elencoFarmacie)
                {
                    if (f.Nome == nomeFarmacia)
                    {
                        f.ElencoFarmaci.Add(nuovoFarmaco);
                        break;
                    }
                }

                //svuoto le textbox
                txtNomeFarmaco.Clear();
                txtCasaFarmaceutica.Clear();
                txtCodiceFarmaco.Clear();
                txtPrezzo.Clear();
                txtScadenza.Clear();
                //aggiorno il form
                AggiornaForm();
            }
            catch (ArgumentException ecc)
            {
                //controllo quale proprietà ha generato l'errore
                switch (ecc.Message)
                {
                    case "nomeFarmaco":
                        MessageBox.Show("Inserire il nome del farmaco");
                        break;
                    case "casaFarmaceutica":
                        MessageBox.Show("Inserire il nome della casa farmaceutica");
                        break;
                    case "codiceFarmaco":
                        MessageBox.Show("Inserire il codice del farmaco");
                        break;
                    case "prezzoFarmaco":
                        MessageBox.Show("Inserire un valore positivo come prezzo del farmaco");
                        break;
                    case "nomeFarmaciaNonValido":
                        MessageBox.Show("Selezionare la farmacia dove aggiungere il farmaco");
                        break;
                }
            }
            catch
            {
                //errore generico nell'inserimento dei dati
                MessageBox.Show("Errore nell'inserimento dei dati del farmaco");
            }
        }

        //evento cellclick della tabella delle farmacie
        private void dgvFarmacie_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //ottego la riga selezionata dall'utente
                DataGridViewSelectedRowCollection rigaScelta = dgvFarmacie.SelectedRows;
                //ottengo il contenuto della prima cella della riga selezionata
                string nomeFarmaciaScelta = rigaScelta[0].Cells[0].FormattedValue.ToString();

                Farmacia farmaciaScelta = null;
                //cerco la farmacia selezionata
                foreach (Farmacia f in elencoFarmacie)
                {
                    if (f.Nome == nomeFarmaciaScelta)
                    {
                        farmaciaScelta = f;
                        break;
                    }
                }

                //svuoto la tabella
                dgvFarmaci.Rows.Clear();
                //aggiungo i farmaci della farmacia alla tabella dei farmaci
                foreach (Farmaco f in farmaciaScelta.ElencoFarmaci)
                {
                    dgvFarmaci.Rows.Add(f.Nome, f.CasaFarmaceutica, f.Codice, Convert.ToString(f.Prezzo), f.Scadenza);
                }
            }
            catch
            {
                //errore generico
                MessageBox.Show("Errore nella visualizzazione dell'elenco di farmaci");
            }
        }
    }
}
