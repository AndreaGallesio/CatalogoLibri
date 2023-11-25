namespace Esercizio01
{
    partial class frmNuovoLibro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNuovoLibro));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.chiudiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.grbEditore = new System.Windows.Forms.GroupBox();
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTitolo = new System.Windows.Forms.TextBox();
            this.btnAnnulla = new System.Windows.Forms.Button();
            this.btnConferma = new System.Windows.Forms.Button();
            this.chkAnnullato = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAggiungi = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.grbEditore.SuspendLayout();
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
            this.menuStrip1.TabIndex = 4;
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
            // grbEditore
            // 
            this.grbEditore.BackColor = System.Drawing.Color.Transparent;
            this.grbEditore.Controls.Add(this.DataLibro);
            this.grbEditore.Controls.Add(this.cmbIdEdLibro);
            this.grbEditore.Controls.Add(this.cmbIdOffLibro);
            this.grbEditore.Controls.Add(this.cmbCodRepLibro);
            this.grbEditore.Controls.Add(this.label10);
            this.grbEditore.Controls.Add(this.label9);
            this.grbEditore.Controls.Add(this.label8);
            this.grbEditore.Controls.Add(this.nudPagine);
            this.grbEditore.Controls.Add(this.label7);
            this.grbEditore.Controls.Add(this.label6);
            this.grbEditore.Controls.Add(this.nudPrezzo);
            this.grbEditore.Controls.Add(this.label5);
            this.grbEditore.Controls.Add(this.txtImmagine);
            this.grbEditore.Controls.Add(this.label1);
            this.grbEditore.Controls.Add(this.txtId);
            this.grbEditore.Controls.Add(this.label2);
            this.grbEditore.Controls.Add(this.txtTitolo);
            this.grbEditore.Controls.Add(this.btnAnnulla);
            this.grbEditore.Controls.Add(this.btnConferma);
            this.grbEditore.Controls.Add(this.chkAnnullato);
            this.grbEditore.Controls.Add(this.label3);
            this.grbEditore.Enabled = false;
            this.grbEditore.ForeColor = System.Drawing.Color.White;
            this.grbEditore.Location = new System.Drawing.Point(142, 59);
            this.grbEditore.Margin = new System.Windows.Forms.Padding(4);
            this.grbEditore.Name = "grbEditore";
            this.grbEditore.Padding = new System.Windows.Forms.Padding(4);
            this.grbEditore.Size = new System.Drawing.Size(541, 430);
            this.grbEditore.TabIndex = 9;
            this.grbEditore.TabStop = false;
            this.grbEditore.Text = "Gestione Dati Offerte";
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
            this.cmbIdEdLibro.SelectedIndexChanged += new System.EventHandler(this.cmbIdEdLibro_SelectedIndexChanged);
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
            this.cmbCodRepLibro.SelectedIndexChanged += new System.EventHandler(this.cmbCodRepLibro_SelectedIndexChanged);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 94);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Immagine";
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 30);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Id";
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
            this.btnConferma.Text = "C O N F E R M A";
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 61);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Titolo";
            // 
            // btnAggiungi
            // 
            this.btnAggiungi.BackColor = System.Drawing.Color.Blue;
            this.btnAggiungi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAggiungi.Location = new System.Drawing.Point(0, 59);
            this.btnAggiungi.Margin = new System.Windows.Forms.Padding(4);
            this.btnAggiungi.Name = "btnAggiungi";
            this.btnAggiungi.Size = new System.Drawing.Size(100, 50);
            this.btnAggiungi.TabIndex = 10;
            this.btnAggiungi.Text = "Aggiungi";
            this.btnAggiungi.UseVisualStyleBackColor = false;
            this.btnAggiungi.Click += new System.EventHandler(this.btnAggiungi_Click);
            // 
            // frmNuovoLibro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 496);
            this.Controls.Add(this.btnAggiungi);
            this.Controls.Add(this.grbEditore);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmNuovoLibro";
            this.Text = "Anagrafica Nuovo Libro";
            this.Load += new System.EventHandler(this.frmNuovoLibro_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grbEditore.ResumeLayout(false);
            this.grbEditore.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPagine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrezzo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem chiudiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.GroupBox grbEditore;
        private System.Windows.Forms.TextBox txtImmagine;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTitolo;
        private System.Windows.Forms.Button btnAnnulla;
        private System.Windows.Forms.Button btnConferma;
        private System.Windows.Forms.CheckBox chkAnnullato;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudPrezzo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown nudPagine;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnAggiungi;
        private System.Windows.Forms.ComboBox cmbIdEdLibro;
        private System.Windows.Forms.ComboBox cmbIdOffLibro;
        private System.Windows.Forms.ComboBox cmbCodRepLibro;
        private System.Windows.Forms.DateTimePicker DataLibro;
    }
}