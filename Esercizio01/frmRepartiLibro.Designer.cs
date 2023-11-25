namespace Esercizio01
{
    partial class frmRepartiLibro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRepartiLibro));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.chiudiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.grbElenco = new System.Windows.Forms.GroupBox();
            this.btnModifica = new System.Windows.Forms.Button();
            this.cmbReparti = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvLibri = new System.Windows.Forms.DataGridView();
            this.grbModifica = new System.Windows.Forms.GroupBox();
            this.DataLibro = new System.Windows.Forms.DateTimePicker();
            this.cmbIdEdLibro = new System.Windows.Forms.ComboBox();
            this.cmbIdOffLibro = new System.Windows.Forms.ComboBox();
            this.cmbCodRepLibro = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.nudPagine = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nudPrezzo = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.txtImmagine = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTitolo = new System.Windows.Forms.TextBox();
            this.btnAnnulla = new System.Windows.Forms.Button();
            this.btnConferma = new System.Windows.Forms.Button();
            this.chkAnnullato = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.grbElenco.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibri)).BeginInit();
            this.grbModifica.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPagine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrezzo)).BeginInit();
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
            this.menuStrip1.Size = new System.Drawing.Size(189, 43);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // chiudiToolStripMenuItem
            // 
            this.chiudiToolStripMenuItem.BackColor = System.Drawing.Color.SandyBrown;
            this.chiudiToolStripMenuItem.Font = new System.Drawing.Font("Showcard Gothic", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chiudiToolStripMenuItem.Name = "chiudiToolStripMenuItem";
            this.chiudiToolStripMenuItem.Size = new System.Drawing.Size(137, 39);
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
            this.grbElenco.Controls.Add(this.btnModifica);
            this.grbElenco.Controls.Add(this.cmbReparti);
            this.grbElenco.Controls.Add(this.label1);
            this.grbElenco.Controls.Add(this.dgvLibri);
            this.grbElenco.ForeColor = System.Drawing.Color.SandyBrown;
            this.grbElenco.Location = new System.Drawing.Point(13, 47);
            this.grbElenco.Margin = new System.Windows.Forms.Padding(4);
            this.grbElenco.Name = "grbElenco";
            this.grbElenco.Padding = new System.Windows.Forms.Padding(4);
            this.grbElenco.Size = new System.Drawing.Size(587, 464);
            this.grbElenco.TabIndex = 4;
            this.grbElenco.TabStop = false;
            this.grbElenco.Text = "Elenco Libri";
            // 
            // btnModifica
            // 
            this.btnModifica.BackColor = System.Drawing.Color.Blue;
            this.btnModifica.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifica.Location = new System.Drawing.Point(206, 411);
            this.btnModifica.Margin = new System.Windows.Forms.Padding(4);
            this.btnModifica.Name = "btnModifica";
            this.btnModifica.Size = new System.Drawing.Size(153, 45);
            this.btnModifica.TabIndex = 28;
            this.btnModifica.Text = "Modifica";
            this.btnModifica.UseVisualStyleBackColor = false;
            this.btnModifica.Click += new System.EventHandler(this.btnModifica_Click);
            // 
            // cmbReparti
            // 
            this.cmbReparti.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbReparti.FormattingEnabled = true;
            this.cmbReparti.Location = new System.Drawing.Point(87, 33);
            this.cmbReparti.Margin = new System.Windows.Forms.Padding(4);
            this.cmbReparti.Name = "cmbReparti";
            this.cmbReparti.Size = new System.Drawing.Size(492, 24);
            this.cmbReparti.TabIndex = 12;
            this.cmbReparti.SelectedIndexChanged += new System.EventHandler(this.cmbReparti_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Reparti";
            // 
            // dgvLibri
            // 
            this.dgvLibri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLibri.Location = new System.Drawing.Point(11, 71);
            this.dgvLibri.Margin = new System.Windows.Forms.Padding(4);
            this.dgvLibri.Name = "dgvLibri";
            this.dgvLibri.RowHeadersWidth = 51;
            this.dgvLibri.Size = new System.Drawing.Size(568, 332);
            this.dgvLibri.TabIndex = 2;
            this.dgvLibri.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLibri_CellContentClick);
            // 
            // grbModifica
            // 
            this.grbModifica.BackColor = System.Drawing.Color.Transparent;
            this.grbModifica.Controls.Add(this.DataLibro);
            this.grbModifica.Controls.Add(this.cmbIdEdLibro);
            this.grbModifica.Controls.Add(this.cmbIdOffLibro);
            this.grbModifica.Controls.Add(this.cmbCodRepLibro);
            this.grbModifica.Controls.Add(this.label10);
            this.grbModifica.Controls.Add(this.label9);
            this.grbModifica.Controls.Add(this.label8);
            this.grbModifica.Controls.Add(this.nudPagine);
            this.grbModifica.Controls.Add(this.label7);
            this.grbModifica.Controls.Add(this.label6);
            this.grbModifica.Controls.Add(this.nudPrezzo);
            this.grbModifica.Controls.Add(this.label5);
            this.grbModifica.Controls.Add(this.txtImmagine);
            this.grbModifica.Controls.Add(this.label2);
            this.grbModifica.Controls.Add(this.txtId);
            this.grbModifica.Controls.Add(this.label3);
            this.grbModifica.Controls.Add(this.txtTitolo);
            this.grbModifica.Controls.Add(this.btnAnnulla);
            this.grbModifica.Controls.Add(this.btnConferma);
            this.grbModifica.Controls.Add(this.chkAnnullato);
            this.grbModifica.Controls.Add(this.label4);
            this.grbModifica.Enabled = false;
            this.grbModifica.ForeColor = System.Drawing.Color.White;
            this.grbModifica.Location = new System.Drawing.Point(608, 47);
            this.grbModifica.Margin = new System.Windows.Forms.Padding(4);
            this.grbModifica.Name = "grbModifica";
            this.grbModifica.Padding = new System.Windows.Forms.Padding(4);
            this.grbModifica.Size = new System.Drawing.Size(541, 430);
            this.grbModifica.TabIndex = 10;
            this.grbModifica.TabStop = false;
            this.grbModifica.Text = "Gestione Dati Offerte";
            // 
            // DataLibro
            // 
            this.DataLibro.Location = new System.Drawing.Point(108, 185);
            this.DataLibro.Name = "DataLibro";
            this.DataLibro.Size = new System.Drawing.Size(224, 22);
            this.DataLibro.TabIndex = 27;
            // 
            // cmbIdEdLibro
            // 
            this.cmbIdEdLibro.FormattingEnabled = true;
            this.cmbIdEdLibro.Location = new System.Drawing.Point(108, 300);
            this.cmbIdEdLibro.Name = "cmbIdEdLibro";
            this.cmbIdEdLibro.Size = new System.Drawing.Size(407, 24);
            this.cmbIdEdLibro.TabIndex = 26;
            // 
            // cmbIdOffLibro
            // 
            this.cmbIdOffLibro.FormattingEnabled = true;
            this.cmbIdOffLibro.Location = new System.Drawing.Point(108, 268);
            this.cmbIdOffLibro.Name = "cmbIdOffLibro";
            this.cmbIdOffLibro.Size = new System.Drawing.Size(407, 24);
            this.cmbIdOffLibro.TabIndex = 25;
            // 
            // cmbCodRepLibro
            // 
            this.cmbCodRepLibro.FormattingEnabled = true;
            this.cmbCodRepLibro.Location = new System.Drawing.Point(109, 239);
            this.cmbCodRepLibro.Name = "cmbCodRepLibro";
            this.cmbCodRepLibro.Size = new System.Drawing.Size(407, 24);
            this.cmbCodRepLibro.TabIndex = 24;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 247);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 16);
            this.label10.TabIndex = 23;
            this.label10.Text = "Cod Rep Libro";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 308);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 16);
            this.label9.TabIndex = 21;
            this.label9.Text = "Id Editore Libro";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 276);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 16);
            this.label8.TabIndex = 19;
            this.label8.Text = "Id Offerta Libro";
            // 
            // nudPagine
            // 
            this.nudPagine.Location = new System.Drawing.Point(108, 216);
            this.nudPagine.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudPagine.Name = "nudPagine";
            this.nudPagine.Size = new System.Drawing.Size(407, 22);
            this.nudPagine.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 222);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 16);
            this.label7.TabIndex = 17;
            this.label7.Text = "N Pagine";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "Data";
            // 
            // nudPrezzo
            // 
            this.nudPrezzo.Location = new System.Drawing.Point(109, 151);
            this.nudPrezzo.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudPrezzo.Name = "nudPrezzo";
            this.nudPrezzo.Size = new System.Drawing.Size(407, 22);
            this.nudPrezzo.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 157);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Prezzo";
            // 
            // txtImmagine
            // 
            this.txtImmagine.Location = new System.Drawing.Point(110, 91);
            this.txtImmagine.Margin = new System.Windows.Forms.Padding(4);
            this.txtImmagine.MaxLength = 50;
            this.txtImmagine.Name = "txtImmagine";
            this.txtImmagine.Size = new System.Drawing.Size(407, 22);
            this.txtImmagine.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 94);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Immagine";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(109, 27);
            this.txtId.Margin = new System.Windows.Forms.Padding(4);
            this.txtId.MaxLength = 50;
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(407, 22);
            this.txtId.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 30);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Id";
            // 
            // txtTitolo
            // 
            this.txtTitolo.Location = new System.Drawing.Point(109, 58);
            this.txtTitolo.Margin = new System.Windows.Forms.Padding(4);
            this.txtTitolo.MaxLength = 50;
            this.txtTitolo.Name = "txtTitolo";
            this.txtTitolo.Size = new System.Drawing.Size(407, 22);
            this.txtTitolo.TabIndex = 6;
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
            this.btnConferma.Text = "M O D I F I C A";
            this.btnConferma.UseVisualStyleBackColor = false;
            this.btnConferma.Click += new System.EventHandler(this.btnConferma_Click);
            // 
            // chkAnnullato
            // 
            this.chkAnnullato.AutoSize = true;
            this.chkAnnullato.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkAnnullato.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.chkAnnullato.Location = new System.Drawing.Point(7, 330);
            this.chkAnnullato.Margin = new System.Windows.Forms.Padding(4);
            this.chkAnnullato.Name = "chkAnnullato";
            this.chkAnnullato.Size = new System.Drawing.Size(84, 20);
            this.chkAnnullato.TabIndex = 2;
            this.chkAnnullato.Text = "Annullato";
            this.chkAnnullato.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 61);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Titolo";
            // 
            // frmRepartiLibro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1195, 537);
            this.Controls.Add(this.grbModifica);
            this.Controls.Add(this.grbElenco);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRepartiLibro";
            this.Text = "frmRepartiLibro";
            this.Load += new System.EventHandler(this.frmRepartiLibro_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grbElenco.ResumeLayout(false);
            this.grbElenco.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibri)).EndInit();
            this.grbModifica.ResumeLayout(false);
            this.grbModifica.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPagine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrezzo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem chiudiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.GroupBox grbElenco;
        private System.Windows.Forms.DataGridView dgvLibri;
        private System.Windows.Forms.ComboBox cmbReparti;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grbModifica;
        private System.Windows.Forms.DateTimePicker DataLibro;
        private System.Windows.Forms.ComboBox cmbIdEdLibro;
        private System.Windows.Forms.ComboBox cmbIdOffLibro;
        private System.Windows.Forms.ComboBox cmbCodRepLibro;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown nudPagine;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nudPrezzo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtImmagine;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTitolo;
        private System.Windows.Forms.Button btnAnnulla;
        private System.Windows.Forms.Button btnConferma;
        private System.Windows.Forms.CheckBox chkAnnullato;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnModifica;
    }
}