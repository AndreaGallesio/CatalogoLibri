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
    public partial class frmOfferteLibro : Form
    {
        public frmOfferteLibro()
        {
            InitializeComponent();
        }

        private void chiudiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmOfferteLibro_Load(object sender, EventArgs e)
        {
            clsOfferteController listaOfferte = new clsOfferteController();

            cmbOfferte.DataSource = listaOfferte.elencoOfferte();
            cmbOfferte.DisplayMember = "DesOfferta";
            cmbOfferte.ValueMember = "IdOfferta";
            cmbOfferte.SelectedIndex = -1;

            cmbIdOffLibro.DataSource = listaOfferte.elencoOfferte();
            cmbIdOffLibro.DisplayMember = "DesOfferta";
            cmbIdOffLibro.ValueMember = "IdOfferta";
            cmbIdOffLibro.SelectedIndex = -1;

            clsRepartiController listaReparti = new clsRepartiController();

            cmbCodRepLibro.DataSource = listaReparti.elencoReparti();
            cmbCodRepLibro.DisplayMember = "DesReparto";
            cmbCodRepLibro.ValueMember = "CodReparto";
            cmbCodRepLibro.SelectedIndex = -1;

            clsEditoriController listaEditori = new clsEditoriController();

            cmbIdEdLibro.DataSource = listaEditori.elencoEditori();
            cmbIdEdLibro.DisplayMember = "NomeEditore";
            cmbIdEdLibro.ValueMember = "IdEditore";
            cmbIdEdLibro.SelectedIndex = -1;

            btnModifica.Enabled = false;
        }

        private void btnModifica_Click(object sender, EventArgs e)
        {
            gestioneVideo(false);

            txtId.ReadOnly = true;

            txtTitolo.Focus();
        }
        private void gestioneVideo(bool abilita)
        {
            grbModifica.Enabled = !abilita;

            txtId.ReadOnly = abilita;

        }

        private void btnConferma_Click(object sender, EventArgs e)
        {
            if (chkDatiLibro())
            {
                clsLibroController modLibro = new clsLibroController();

                modLibro.Libro.IdLibro = Convert.ToInt32(txtId.Text);
                modLibro.Libro.TitoloLibro = txtTitolo.Text;
                modLibro.Libro.ImgLibro = txtImmagine.Text;
                modLibro.Libro.PrezzoLibro = Convert.ToInt32(nudPrezzo.Value);
                modLibro.Libro.DataLibro = Convert.ToDateTime(DataLibro.Text);
                modLibro.Libro.NPagineLibro = Convert.ToInt32(nudPagine.Value);
                modLibro.Libro.CodRepLibro = cmbCodRepLibro.SelectedValue.ToString();
                modLibro.Libro.IdOffLibro = Convert.ToInt32(cmbIdOffLibro.SelectedValue);
                modLibro.Libro.IdEdiLibro = Convert.ToInt32(cmbIdEdLibro.SelectedValue);
                if (chkAnnullato.Checked)
                {
                    modLibro.Libro.ValLibro = 'A';
                }


                if (!modLibro.modifica())
                {
                    MessageBox.Show("Libro Modifiato");
                    modLibro.Libro.CodRepLibro = cmbCodRepLibro.SelectedValue.ToString();
                    pulisciVideo();
                    caricaElenco(modLibro.elencoLibriRicercato());
                }
                else
                    MessageBox.Show("Modifica non avvenuta");
            }
        }
        private void pulisciVideo()
        {
            txtId.Text = string.Empty;
            txtTitolo.Text = string.Empty;
            txtImmagine.Text = string.Empty;
            nudPrezzo.Value = 0;
            nudPagine.Value = 0;
            cmbCodRepLibro.SelectedIndex = -1;
            cmbIdEdLibro.SelectedIndex = -1;
            cmbIdOffLibro.SelectedIndex = -1;

            chkAnnullato.Checked = false;
            gestioneVideo(true);
        }
        private bool chkDatiLibro()
        {
            bool esito = true;

            if (txtId.Text == string.Empty && btnConferma.Text == "M O D I F I C A")
            {
                MessageBox.Show("L'id non è stato inserito");
                txtId.Focus();
                esito = false;
            }
            else if (txtTitolo.Text == string.Empty)
            {
                MessageBox.Show("Il Nome non è stata inserita");
                txtTitolo.Focus();
                esito = false;
            }
            else if (txtImmagine.Text == string.Empty)
            {
                MessageBox.Show("L'Immagine non è stata inserita");
                txtImmagine.Focus();
                esito = false;
            }
            else if (nudPrezzo.Value == 0)
            {
                MessageBox.Show("Il Prezzo non è stata inserita");
                nudPrezzo.Focus();
                esito = false;
            }
            else if (nudPagine.Value == 0)
            {
                MessageBox.Show("Le Pagine non è stata inserita");
                nudPagine.Focus();
                esito = false;
            }
            else if (cmbCodRepLibro.SelectedIndex == -1)
            {
                MessageBox.Show("Il Codice Reparto non è stata inserita");
                cmbCodRepLibro.Focus();
                esito = false;
            }
            else if (cmbIdOffLibro.SelectedIndex == -1)
            {
                MessageBox.Show("Le Offerte non è stata inserita");
                cmbIdOffLibro.Focus();
                esito = false;
            }
            else if (cmbIdEdLibro.SelectedIndex == -1)
            {
                MessageBox.Show("Le Offerte non è stata inserita");
                cmbIdEdLibro.Focus();
                esito = false;
            }

            return esito;
        }

        private void cmbOfferte_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool errore = false;

            if (cmbOfferte.SelectedIndex != -1 && cmbOfferte.ValueMember != string.Empty)
            {
                clsOfferteController offerta = new clsOfferteController();

                offerta.Offerte.DesOfferta = cmbOfferte.Text;
                errore = offerta.getOfferte();

                if (!errore)
                {
                    clsLibroController listaLibri = new clsLibroController();

                    listaLibri.Libro.IdOffLibro = offerta.Offerte.IdOfferta;

                    caricaElenco(listaLibri.elencoLibriRicercatoOfferta());

                    btnModifica.Enabled = true;
                }
            }
        }
        private void caricaElenco(List<clsLibri> lista)
        {
            // Carico la DGV
            dgvLibri.DataSource = lista;
            dgvLibri.Columns[0].HeaderText = "Id";
            dgvLibri.Columns[1].HeaderText = "Titolo";
            dgvLibri.Columns[2].HeaderText = "Immagine";
            dgvLibri.Columns[3].HeaderText = "Prezzo";
            dgvLibri.Columns[4].HeaderText = "Data";
            dgvLibri.Columns[5].HeaderText = "Pagine";
            dgvLibri.Columns[6].HeaderText = "Codice Reparto";
            dgvLibri.Columns[7].HeaderText = "Id Offerta";
            dgvLibri.Columns[8].HeaderText = "Id Editore";
            dgvLibri.Columns[9].HeaderText = "Validità";
            dgvLibri.ClearSelection();
        }

        private void dgvLibri_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            grbElenco.Visible = true;

            txtId.Text = dgvLibri.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtTitolo.Text = dgvLibri.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtImmagine.Text = dgvLibri.Rows[e.RowIndex].Cells[2].Value.ToString();
            nudPrezzo.Value = Convert.ToInt32(dgvLibri.Rows[e.RowIndex].Cells[3].Value.ToString());
            DataLibro.Text = dgvLibri.Rows[e.RowIndex].Cells[4].Value.ToString();
            nudPagine.Value = Convert.ToInt32(dgvLibri.Rows[e.RowIndex].Cells[5].Value.ToString());
            cmbCodRepLibro.SelectedValue = dgvLibri.Rows[e.RowIndex].Cells[6].Value.ToString();

            clsOfferteController offerta = new clsOfferteController();
            offerta.Offerte.IdOfferta = Convert.ToInt32(dgvLibri.Rows[e.RowIndex].Cells[7].Value);
            offerta.getOffertaId();
            cmbIdOffLibro.Text = offerta.Offerte.DesOfferta;

            clsEditoriController editore = new clsEditoriController();
            editore.Editore.IdEditore = Convert.ToInt32(dgvLibri.Rows[e.RowIndex].Cells[8].Value);
            editore.getEditoreId();
            cmbIdEdLibro.Text = editore.Editore.NomeEditore;

            if (dgvLibri.Rows[e.RowIndex].Cells[9].Value.ToString() == "A")
                chkAnnullato.Checked = true;
            else
                chkAnnullato.Checked = false;
        }
    }
}
