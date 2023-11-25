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
    public partial class frmOfferte : Form
    {
        bool seleziona = true;
        public frmOfferte()
        {
            InitializeComponent();
        }

        private void frmOfferte_Load(object sender, EventArgs e)
        {
            clsOfferteController listaOfferte = new clsOfferteController();
            caricaOfferte(listaOfferte.elencoOfferte());
        }
        private void caricaOfferte(List<clsOfferte> lista)
        {
            // Carico la DGV
            dgvOfferte.DataSource = lista;
            dgvOfferte.Columns[0].HeaderText = "Id";
            dgvOfferte.Columns[1].HeaderText = "Descrizione";
            dgvOfferte.Columns[2].HeaderText = "Sconto";
            dgvOfferte.Columns[3].HeaderText = "Validità";
            dgvOfferte.ClearSelection();

            // Carico la COMBO
            seleziona = false;
            cmbOfferte.DataSource = lista;
            cmbOfferte.DisplayMember = "DesOfferta";
            cmbOfferte.ValueMember = "IdOfferta";
            cmbOfferte.SelectedIndex = -1;
            seleziona = true;
        }

        private void chkAnnullati_CheckedChanged(object sender, EventArgs e)
        {
            visElencoOfferte();
        }
        private void visElencoOfferte()
        {
            clsOfferteController listaOfferte = new clsOfferteController();

            dgvOfferte.DataSource = null;
            cmbOfferte.DataSource = null;

            if (chkAnnullati.Checked)
                caricaOfferte(listaOfferte.elencoOfferteAnnullati());
            else
                caricaOfferte(listaOfferte.elencoOfferte());
        }

        private void chiudiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbOfferte_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbOfferte.SelectedIndex != -1 && cmbOfferte.ValueMember != string.Empty && seleziona)
            {
                clsOfferteController detOfferta = new clsOfferteController();
                clsOfferte modOfferta = new clsOfferte();

                btnConferma.Text = "M O D I F I C A";


                detOfferta.Offerte.IdOfferta = Convert.ToInt32(cmbOfferte.SelectedValue);
                modOfferta = detOfferta.datiOfferta();

                txtId.Text = modOfferta.IdOfferta.ToString();
                txtDescrizione.Text = modOfferta.DesOfferta;
                nudSconto.Text = modOfferta.ScontoOfferta.ToString();

                if (modOfferta.ValOfferta == 'A')
                    chkAnnullato.Checked = true;

                gestioneVideo(false);
                txtId.ReadOnly = true;
            }
        }
        private void gestioneVideo(bool abilita)
        {
            grbElenco.Enabled = abilita;
            cmbOfferte.Enabled = abilita;
            txtId.ReadOnly = abilita;
            grbOfferta.Enabled = !abilita;
        }

        private void btnAggiungi_Click(object sender, EventArgs e)
        {
            gestioneVideo(false);

            txtId.ReadOnly = true;

            txtDescrizione.Focus();
        }

        private void btnConferma_Click(object sender, EventArgs e)
        {
            bool errore = false;

            if (chkDatiOfferta())
            {
                clsOfferteController insOfferta = new clsOfferteController();
                if (btnConferma.Text == "M O D I F I C A")
                {
                    insOfferta.Offerte.IdOfferta = Convert.ToInt32(txtId.Text);
                }
                insOfferta.Offerte.DesOfferta = txtDescrizione.Text;
                insOfferta.Offerte.ScontoOfferta = Convert.ToInt32(nudSconto.Text);

                if (chkAnnullato.Checked)
                    insOfferta.Offerte.ValOfferta = 'A';

                if (btnConferma.Text == "C O N F E R M A")
                    errore = insOfferta.aggiungi();

                else
                    errore = insOfferta.modifica();

                if (!errore)
                {
                    pulisciVideo();
                    visElencoOfferte();
                }

                MessageBox.Show(insOfferta.msgErrore);
            }
        }
        private bool chkDatiOfferta()
        {
            bool esito = true;

            if (txtDescrizione.Text == string.Empty && btnConferma.Text == "M O D I F I C A")
            {
                MessageBox.Show("La modifica non è stato inserito");
                txtDescrizione.Focus();
                esito = false;
            }
            else if (nudSconto.Text == string.Empty)
            {
                MessageBox.Show("Lo sconto non è stata inserita");
                nudSconto.Focus();
                esito = false;
            }

            return esito;
        }
        private void pulisciVideo()
        {
            txtId.Text = string.Empty;
            txtDescrizione.Text = string.Empty;
            nudSconto.Text = string.Empty;
            chkAnnullato.Checked = false;
            btnConferma.Text = "C O N F E R M A";
            gestioneVideo(true);
        }

        private void btnAnnulla_Click(object sender, EventArgs e)
        {
            pulisciVideo();
        }

        private void grbElenco_Enter(object sender, EventArgs e)
        {

        }
    }
}
