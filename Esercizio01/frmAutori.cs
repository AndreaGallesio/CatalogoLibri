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
    public partial class frmAutori : Form
    {
        bool seleziona = true;
        public frmAutori()
        {
            InitializeComponent();
        }

        private void frmAutori_Load(object sender, EventArgs e)
        {
            clsAutoriController listaAutori = new clsAutoriController();


            caricaAutori(listaAutori.elencoAutori());
        }

        private void chiudiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void caricaAutori(List<clsAutori> lista)
        {
            // Carico la DGV
            dgvAutori.DataSource = lista;
            dgvAutori.Columns[0].HeaderText = "Id";
            dgvAutori.Columns[1].HeaderText = "Cognome";
            dgvAutori.Columns[2].HeaderText = "Nome";
            dgvAutori.Columns[3].HeaderText = "Data";
            dgvAutori.Columns[4].HeaderText = "Foto";
            dgvAutori.Columns[5].HeaderText = "Validità";
            dgvAutori.ClearSelection();

            // Carico la COMBO
            seleziona = false;
            cmbAutori.DataSource = lista;
            cmbAutori.DisplayMember = "CognAutore";
            cmbAutori.ValueMember = "IdAutore";
            cmbAutori.SelectedIndex = -1;
            seleziona = true;
        }

        private void chkAnnullati_CheckedChanged(object sender, EventArgs e)
        {
            visElencoAutori();
        }
        private void visElencoAutori()
        {
            clsAutoriController listaAutori = new clsAutoriController();

            dgvAutori.DataSource = null;
            cmbAutori.DataSource = null;

            if (chkAnnullati.Checked)
                caricaAutori(listaAutori.elencoAutoriAnnullati());
            else
                caricaAutori(listaAutori.elencoAutori());
        }

        private void cmbAutori_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbAutori.SelectedIndex != -1 && cmbAutori.ValueMember != string.Empty && seleziona)
            {
                clsAutoriController detAutore = new clsAutoriController();
                clsAutori modAutore = new clsAutori();

                btnConferma.Text = "M O D I F I C A";


                detAutore.Autore.IdAutore = Convert.ToInt32(cmbAutori.SelectedValue);
                modAutore = detAutore.datiAutore();

                txtId.Text = modAutore.IdAutore.ToString();
                txtCognome.Text = modAutore.CognAutore.ToString();
                txtNome.Text = modAutore.NomeAutore.ToString();
                DataAutore.Text = modAutore.DatNasAutore.ToString();
                txtFoto.Text = modAutore.FotoAutore.ToString();

                if (modAutore.ValAutore == 'A')
                    chkAnnullato.Checked = true;

                gestioneVideo(false);
                txtId.ReadOnly = true;
            }
        }
        private void gestioneVideo(bool abilita)
        {
            grbElenco.Enabled = abilita;
            cmbAutori.Enabled = abilita;
            txtId.ReadOnly = abilita;
            grbAutore.Enabled = !abilita;
        }

        private void btnAggiungi_Click(object sender, EventArgs e)
        {
            gestioneVideo(false);

            txtId.ReadOnly = true;

            txtCognome.Focus();
        }

        private void btnConferma_Click(object sender, EventArgs e)
        {
            bool errore = false;

            if (chkDatiAutore())
            {
                clsAutoriController insAutore = new clsAutoriController();
                if (btnConferma.Text == "M O D I F I C A")
                {
                    insAutore.Autore.IdAutore = Convert.ToInt32(txtId.Text);
                }
                insAutore.Autore.CognAutore = txtCognome.Text;
                insAutore.Autore.NomeAutore = txtNome.Text;
                insAutore.Autore.DatNasAutore = DateTime.Parse(DataAutore.Text);
                insAutore.Autore.FotoAutore = txtFoto.Text;

                if (chkAnnullato.Checked)
                    insAutore.Autore.ValAutore = 'A';

                if (btnConferma.Text == "C O N F E R M A")
                    errore = insAutore.aggiungi();

                else
                    errore = insAutore.modifica();

                if (!errore)
                {
                    pulisciVideo();
                    visElencoAutori();
                }

                MessageBox.Show(insAutore.msgErrore);
            }
        }
        private bool chkDatiAutore()
        {
            bool esito = true;

            if (txtId.Text == string.Empty && btnConferma.Text == "M O D I F I C A")
            {
                MessageBox.Show("L'id non è stato inserito");
                txtId.Focus();
                esito = false;
            }
            else if (txtCognome.Text == string.Empty)
            {
                MessageBox.Show("Il Cognome non è stata inserita");
                txtCognome.Focus();
                esito = false;
            }
            else if (txtNome.Text == string.Empty)
            {
                MessageBox.Show("Il Nome non è stata inserita");
                txtNome.Focus();
                esito = false;
            }
            else if (DataAutore.Text == string.Empty)
            {
                MessageBox.Show("La Data non è stata inserita");
                DataAutore.Focus();
                esito = false;
            }
            else if (txtFoto.Text == string.Empty)
            {
                MessageBox.Show("La Foto non è stata inserita");
                txtFoto.Focus();
                esito = false;
            }

            return esito;
        }
        private void pulisciVideo()
        {
            txtId.Text = string.Empty;
            txtCognome.Text = string.Empty;
            txtNome.Text = string.Empty;
            DataAutore.Text = string.Empty;
            txtFoto.Text = string.Empty;
            chkAnnullato.Checked = false;
            btnConferma.Text = "C O N F E R M A";
            gestioneVideo(true);
        }
    }
}
