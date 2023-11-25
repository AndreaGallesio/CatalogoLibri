using Esercizio01.Control;
using Esercizio01.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Esercizio01
{
    public partial class frmNuovoLibro : Form
    {
        bool seleziona = true;
        public frmNuovoLibro()
        {
            InitializeComponent();
        }

        private void frmNuovoLibro_Load(object sender, EventArgs e)
        {
            clsRepartiController listaReparti = new clsRepartiController();
            caricaCodRepLibro(listaReparti.elencoReparti());

            clsOfferteController listaOfferte = new clsOfferteController();
            caricaIdOffLibro(listaOfferte.elencoOfferte());

            clsEditoriController listaEditore = new clsEditoriController();
            caricaIdEdiLibro(listaEditore.elencoEditori());

        }

        private void caricaCodRepLibro(List<clsReparto> lista)
        {

            // Carico la COMBO
            seleziona = false;
            cmbCodRepLibro.DataSource = lista;
            cmbCodRepLibro.DisplayMember = "CodReparto";
            cmbCodRepLibro.ValueMember = "CodReparto";
            cmbCodRepLibro.SelectedIndex = -1;
            seleziona = true;
        }
        private void caricaIdOffLibro(List<clsOfferte> lista)
        {

            // Carico la COMBO
            seleziona = false;
            cmbIdOffLibro.DataSource = lista;
            cmbIdOffLibro.DisplayMember = "DesOfferta";
            cmbIdOffLibro.ValueMember = "IdOfferta";
            cmbIdOffLibro.SelectedIndex = -1;
            seleziona = true;
        }
        private void caricaIdEdiLibro(List<clsEditori> lista)
        {

            // Carico la COMBO
            seleziona = false;
            cmbIdEdLibro.DataSource = lista;
            cmbIdEdLibro.DisplayMember = "NomeEditore";
            cmbIdEdLibro.ValueMember = "IdEditore";
            cmbIdEdLibro.SelectedIndex = -1;
            seleziona = true;
        }

        private void chiudiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConferma_Click(object sender, EventArgs e)
        {            
                bool errore = false;

                if (chkDatiLibri())
                {
                    clsRepartiController reparto = new clsRepartiController();
                    reparto.Reparto.DesReparto = cmbCodRepLibro.Text;
                    errore = reparto.getReparto();

                    clsOfferteController offerte = new clsOfferteController();
                    offerte.Offerte.DesOfferta = cmbIdOffLibro.Text;
                    errore = offerte.getOfferte();

                    clsEditoriController editore = new clsEditoriController();
                    editore.Editore.NomeEditore = cmbIdEdLibro.Text;
                    errore = editore.getEditore();

                    if (!errore)
                    {
                        clsLibroController libro = new clsLibroController();
                        libro.Libro.TitoloLibro = txtTitolo.Text;
                        libro.Libro.ImgLibro = txtImmagine.Text;
                        libro.Libro.PrezzoLibro = Convert.ToInt32(nudPrezzo.Value);
                        libro.Libro.DataLibro = Convert.ToDateTime(DataLibro.Text);
                        libro.Libro.NPagineLibro = Convert.ToInt32(nudPrezzo.Value);
                        libro.Libro.CodRepLibro = reparto.Reparto.CodReparto;
                        libro.Libro.IdEdiLibro = editore.Editore.IdEditore;
                        libro.Libro.IdOffLibro = offerte.Offerte.IdOfferta;
                        if (chkAnnullato.Checked) libro.Libro.ValLibro = 'A';
                        else libro.Libro.ValLibro = ' ';

                        errore = libro.aggiungi();

                        if (!errore)
                        {
                            MessageBox.Show(libro.msgErrore);
                        }

                        pulisciVideo();
                    }
                }            
        }

        private void pulisciVideo()
        {
            txtId.Text = string.Empty;
            txtTitolo.Text = string.Empty;
            txtImmagine.Text = string.Empty;
            nudPrezzo.Value = 0;
            DataLibro.Text = string.Empty;
            nudPagine.Value = 0;
            cmbCodRepLibro.SelectedIndex = -1;
            cmbIdEdLibro.SelectedIndex = -1;
            cmbIdOffLibro.SelectedIndex = -1;
            chkAnnullato.Checked = false;
            btnConferma.Text = "M O D I F I C A";
            gestioneVideo(true);
        }

        private bool chkDatiLibri()
        {
            bool esito = true;

             if (txtTitolo.Text == string.Empty)
            {
                MessageBox.Show("Il Titolo non è stata inserita");
                txtTitolo.Focus();
                esito = false;
            }
            else if (txtImmagine.Text == string.Empty)
            {
                MessageBox.Show("L'immagine non è stata inserita");
                txtImmagine.Focus();
                esito = false;
            }
            else if (nudPrezzo.Text == string.Empty)
            {
                MessageBox.Show("Il Prezzo non è stata inserita");
                nudPrezzo.Focus();
                esito = false;
            }
            else if (DataLibro.Text == string.Empty)
            {
                MessageBox.Show("La Data non è stata inserita");
                DataLibro.Focus();
                esito = false;
            }
            else if (nudPagine.Text == string.Empty)
            {
                MessageBox.Show("Le Pagine non è stata inserita");
                nudPagine.Focus();
                esito = false;
            }
            else if (cmbCodRepLibro.Text == string.Empty)
            {
                MessageBox.Show("Il codice del reparto non è stata inserita");
                cmbCodRepLibro.Focus();
                esito = false;
            }
            else if (cmbIdOffLibro.Text == string.Empty)
            {
                MessageBox.Show("L'Id dell'Offerta non è stata inserita");
                cmbIdOffLibro.Focus();
                esito = false;
            }
            else if (cmbIdEdLibro.Text == string.Empty)
            {
                MessageBox.Show("L'id dell'editore non è stata inserita");
                cmbIdEdLibro.Focus();
                esito = false;
            }

            return esito;
        }

        private void btnAggiungi_Click(object sender, EventArgs e)
        {
            gestioneVideo(false);

            txtId.ReadOnly = true;

            txtTitolo.Focus();
        }

        private void gestioneVideo(bool abilita)
        {
            grbEditore.Enabled = !abilita;
           
            txtId.ReadOnly = abilita;

        }

        private void cmbCodRepLibro_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cmbIdEdLibro_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
