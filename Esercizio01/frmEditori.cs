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
    public partial class frmEditori : Form
    {
        bool seleziona = true;
        public frmEditori()
        {
            InitializeComponent();
        }

        private void chiudiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmEditori_Load(object sender, EventArgs e)
        {
            clsEditoriController listaEditori = new clsEditoriController();

            
            caricaEditori(listaEditori.elencoEditori());
        }
        private void caricaEditori(List<clsEditori> lista)
        {
            // Carico la DGV
            dgvEditori.DataSource = lista;
            dgvEditori.Columns[0].HeaderText = "IdEditore";
            dgvEditori.Columns[1].HeaderText = "Nome";
            dgvEditori.Columns[2].HeaderText = "Validità";
            dgvEditori.ClearSelection();

            // Carico la COMBO
            seleziona = false;
            cmbEditori.DataSource = lista;
            cmbEditori.DisplayMember = "NomeEditore";
            cmbEditori.ValueMember = "IdEditore";
            cmbEditori.SelectedIndex = -1;
            seleziona = true;
        }

        private void chkAnnullati_CheckedChanged(object sender, EventArgs e)
        {
            visElencoEditori();
        }
        private void visElencoEditori()
        {
            clsEditoriController listaEditore = new clsEditoriController();

            dgvEditori.DataSource = null;
            cmbEditori.DataSource = null;

            if (chkAnnullati.Checked)
                caricaEditori(listaEditore.elencoEditoriAnnullati());
            else
                caricaEditori(listaEditore.elencoEditori());
        }

        private void cmbEditori_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        private void gestioneVideo(bool abilita)
        {
            grbElenco.Enabled = abilita;
            cmbEditori.Enabled = abilita;
            txtId.ReadOnly = abilita;
            grbEditore.Enabled = !abilita;
        }

        private void btnAggiungi_Click(object sender, EventArgs e)
        {
            gestioneVideo(false);

            txtId.ReadOnly = true;

            txtNome.Focus();
        }

        private void btnConferma_Click(object sender, EventArgs e)
        {
            bool errore = false;

            if (chkDatiEditore())
            {
                clsEditoriController insEditore = new clsEditoriController();
                if (btnConferma.Text == "M O D I F I C A")
                {
                    insEditore.Editore.IdEditore = Convert.ToInt32(txtId.Text);
                }
                insEditore.Editore.NomeEditore = txtNome.Text;

                if (chkAnnullato.Checked)                
                    insEditore.Editore.ValEditore = 'A';
                
                if (btnConferma.Text == "C O N F E R M A")                
                    errore = insEditore.aggiungi();
                                    
                else
                    errore = insEditore.modifica();

                if (!errore)
                {
                    pulisciVideo();
                    visElencoEditori();
                }

                MessageBox.Show(insEditore.msgErrore);
            }
        }
        private bool chkDatiEditore()
        {
            bool esito = true;

            if (txtId.Text == string.Empty && btnConferma.Text == "M O D I F I C A")
            {
                MessageBox.Show("L'id non è stato inserito");
                txtId.Focus();
                esito = false;
            }
            else if (txtNome.Text == string.Empty)
            {
                MessageBox.Show("Il Nome non è stata inserita");
                txtNome.Focus();
                esito = false;
            }

            return esito;
        }
        private void pulisciVideo()
        {
            txtId.Text = string.Empty;
            txtNome.Text = string.Empty;
            chkAnnullato.Checked = false;
            btnConferma.Text = "C O N F E R M A";
            gestioneVideo(true);
        }

        private void btnAnnulla_Click(object sender, EventArgs e)
        {
            pulisciVideo();
        }

        private void dgvEditori_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
