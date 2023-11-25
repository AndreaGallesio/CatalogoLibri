namespace Esercizio01
{
    partial class frmEditori
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditori));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.chiudiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.grbElenco = new System.Windows.Forms.GroupBox();
            this.dgvEditori = new System.Windows.Forms.DataGridView();
            this.chkAnnullati = new System.Windows.Forms.CheckBox();
            this.btnAggiungi = new System.Windows.Forms.Button();
            this.grbEditore = new System.Windows.Forms.GroupBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btnAnnulla = new System.Windows.Forms.Button();
            this.btnConferma = new System.Windows.Forms.Button();
            this.chkAnnullato = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbEditori = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.grbElenco.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEditori)).BeginInit();
            this.grbEditore.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chiudiToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(183, 43);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // chiudiToolStripMenuItem
            // 
            this.chiudiToolStripMenuItem.BackColor = System.Drawing.Color.SandyBrown;
            this.chiudiToolStripMenuItem.Font = new System.Drawing.Font("Showcard Gothic", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chiudiToolStripMenuItem.Name = "chiudiToolStripMenuItem";
            this.chiudiToolStripMenuItem.Size = new System.Drawing.Size(131, 39);
            this.chiudiToolStripMenuItem.Text = "Chiudi";
            this.chiudiToolStripMenuItem.Click += new System.EventHandler(this.chiudiToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.BackColor = System.Drawing.Color.SandyBrown;
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Showcard Gothic", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(44, 39);
            this.toolStripMenuItem1.Text = "?";
            // 
            // grbElenco
            // 
            this.grbElenco.BackColor = System.Drawing.Color.Transparent;
            this.grbElenco.Controls.Add(this.dgvEditori);
            this.grbElenco.Controls.Add(this.chkAnnullati);
            this.grbElenco.Controls.Add(this.btnAggiungi);
            this.grbElenco.ForeColor = System.Drawing.Color.White;
            this.grbElenco.Location = new System.Drawing.Point(10, 47);
            this.grbElenco.Margin = new System.Windows.Forms.Padding(4);
            this.grbElenco.Name = "grbElenco";
            this.grbElenco.Padding = new System.Windows.Forms.Padding(4);
            this.grbElenco.Size = new System.Drawing.Size(587, 430);
            this.grbElenco.TabIndex = 3;
            this.grbElenco.TabStop = false;
            this.grbElenco.Text = "Elenco Editori";
            // 
            // dgvEditori
            // 
            this.dgvEditori.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEditori.Location = new System.Drawing.Point(40, 71);
            this.dgvEditori.Margin = new System.Windows.Forms.Padding(4);
            this.dgvEditori.Name = "dgvEditori";
            this.dgvEditori.RowHeadersWidth = 51;
            this.dgvEditori.Size = new System.Drawing.Size(539, 332);
            this.dgvEditori.TabIndex = 2;
            this.dgvEditori.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEditori_CellContentClick);
            // 
            // chkAnnullati
            // 
            this.chkAnnullati.AutoSize = true;
            this.chkAnnullati.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkAnnullati.Location = new System.Drawing.Point(472, 43);
            this.chkAnnullati.Margin = new System.Windows.Forms.Padding(4);
            this.chkAnnullati.Name = "chkAnnullati";
            this.chkAnnullati.Size = new System.Drawing.Size(79, 20);
            this.chkAnnullati.TabIndex = 1;
            this.chkAnnullati.Text = "Annullati";
            this.chkAnnullati.UseVisualStyleBackColor = true;
            this.chkAnnullati.CheckedChanged += new System.EventHandler(this.chkAnnullati_CheckedChanged);
            // 
            // btnAggiungi
            // 
            this.btnAggiungi.BackColor = System.Drawing.Color.Blue;
            this.btnAggiungi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAggiungi.Location = new System.Drawing.Point(21, 38);
            this.btnAggiungi.Margin = new System.Windows.Forms.Padding(4);
            this.btnAggiungi.Name = "btnAggiungi";
            this.btnAggiungi.Size = new System.Drawing.Size(100, 28);
            this.btnAggiungi.TabIndex = 0;
            this.btnAggiungi.Text = "Aggiungi";
            this.btnAggiungi.UseVisualStyleBackColor = false;
            this.btnAggiungi.Click += new System.EventHandler(this.btnAggiungi_Click);
            // 
            // grbEditore
            // 
            this.grbEditore.BackColor = System.Drawing.Color.Transparent;
            this.grbEditore.Controls.Add(this.txtId);
            this.grbEditore.Controls.Add(this.label2);
            this.grbEditore.Controls.Add(this.txtNome);
            this.grbEditore.Controls.Add(this.btnAnnulla);
            this.grbEditore.Controls.Add(this.btnConferma);
            this.grbEditore.Controls.Add(this.chkAnnullato);
            this.grbEditore.Controls.Add(this.label3);
            this.grbEditore.ForeColor = System.Drawing.Color.White;
            this.grbEditore.Location = new System.Drawing.Point(605, 47);
            this.grbEditore.Margin = new System.Windows.Forms.Padding(4);
            this.grbEditore.Name = "grbEditore";
            this.grbEditore.Padding = new System.Windows.Forms.Padding(4);
            this.grbEditore.Size = new System.Drawing.Size(541, 430);
            this.grbEditore.TabIndex = 8;
            this.grbEditore.TabStop = false;
            this.grbEditore.Text = "Gestione Dati Offerte";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(125, 68);
            this.txtId.Margin = new System.Windows.Forms.Padding(4);
            this.txtId.MaxLength = 50;
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(407, 22);
            this.txtId.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 71);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Id";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(125, 159);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4);
            this.txtNome.MaxLength = 50;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(407, 22);
            this.txtNome.TabIndex = 6;
            // 
            // btnAnnulla
            // 
            this.btnAnnulla.BackColor = System.Drawing.Color.LightCoral;
            this.btnAnnulla.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnulla.Location = new System.Drawing.Point(341, 330);
            this.btnAnnulla.Margin = new System.Windows.Forms.Padding(4);
            this.btnAnnulla.Name = "btnAnnulla";
            this.btnAnnulla.Size = new System.Drawing.Size(192, 46);
            this.btnAnnulla.TabIndex = 4;
            this.btnAnnulla.Text = "A N N U L L A";
            this.btnAnnulla.UseVisualStyleBackColor = false;
            this.btnAnnulla.Click += new System.EventHandler(this.btnAnnulla_Click);
            // 
            // btnConferma
            // 
            this.btnConferma.BackColor = System.Drawing.Color.LightGreen;
            this.btnConferma.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConferma.Location = new System.Drawing.Point(125, 330);
            this.btnConferma.Margin = new System.Windows.Forms.Padding(4);
            this.btnConferma.Name = "btnConferma";
            this.btnConferma.Size = new System.Drawing.Size(192, 46);
            this.btnConferma.TabIndex = 3;
            this.btnConferma.Text = "C O N F E R M A";
            this.btnConferma.UseVisualStyleBackColor = false;
            this.btnConferma.Click += new System.EventHandler(this.btnConferma_Click);
            // 
            // chkAnnullato
            // 
            this.chkAnnullato.AutoSize = true;
            this.chkAnnullato.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkAnnullato.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.chkAnnullato.Location = new System.Drawing.Point(28, 246);
            this.chkAnnullato.Margin = new System.Windows.Forms.Padding(4);
            this.chkAnnullato.Name = "chkAnnullato";
            this.chkAnnullato.Size = new System.Drawing.Size(84, 20);
            this.chkAnnullato.TabIndex = 2;
            this.chkAnnullato.Text = "Annullato";
            this.chkAnnullato.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 162);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nome";
            // 
            // cmbEditori
            // 
            this.cmbEditori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEditori.FormattingEnabled = true;
            this.cmbEditori.Location = new System.Drawing.Point(97, 481);
            this.cmbEditori.Margin = new System.Windows.Forms.Padding(4);
            this.cmbEditori.Name = "cmbEditori";
            this.cmbEditori.Size = new System.Drawing.Size(500, 24);
            this.cmbEditori.TabIndex = 10;
            this.cmbEditori.SelectedIndexChanged += new System.EventHandler(this.cmbEditori_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(10, 489);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Editori";
            // 
            // frmEditori
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1217, 559);
            this.Controls.Add(this.cmbEditori);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grbEditore);
            this.Controls.Add(this.grbElenco);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmEditori";
            this.Text = "Anagrafica Editori";
            this.Load += new System.EventHandler(this.frmEditori_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grbElenco.ResumeLayout(false);
            this.grbElenco.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEditori)).EndInit();
            this.grbEditore.ResumeLayout(false);
            this.grbEditore.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem chiudiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.GroupBox grbElenco;
        private System.Windows.Forms.DataGridView dgvEditori;
        private System.Windows.Forms.CheckBox chkAnnullati;
        private System.Windows.Forms.Button btnAggiungi;
        private System.Windows.Forms.GroupBox grbEditore;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button btnAnnulla;
        private System.Windows.Forms.Button btnConferma;
        private System.Windows.Forms.CheckBox chkAnnullato;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbEditori;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label2;
    }
}