namespace EsFarmacia
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnInserisciFarmacia = new System.Windows.Forms.Button();
            this.txtTitolareFarmacia = new System.Windows.Forms.TextBox();
            this.txtCodiceFarmacia = new System.Windows.Forms.TextBox();
            this.txtIndirizzoFarmacia = new System.Windows.Forms.TextBox();
            this.txtNomeFarmacia = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cbFarmacie = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnInserisciFarmaco = new System.Windows.Forms.Button();
            this.txtScadenza = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPrezzo = new System.Windows.Forms.TextBox();
            this.txtCodiceFarmaco = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCasaFarmaceutica = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNomeFarmaco = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvFarmacie = new System.Windows.Forms.DataGridView();
            this.clNomeFarmacia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clIndirizzoFarmacia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clCodiceFarmacia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTitolareFarmacia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clCostoTotFarmaci = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dgvFarmaci = new System.Windows.Forms.DataGridView();
            this.clNomeFarmaco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clCasa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clCodiceFarmaco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clPrezzo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clScadenza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFarmacie)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFarmaci)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupBox1.Controls.Add(this.btnInserisciFarmacia);
            this.groupBox1.Controls.Add(this.txtTitolareFarmacia);
            this.groupBox1.Controls.Add(this.txtCodiceFarmacia);
            this.groupBox1.Controls.Add(this.txtIndirizzoFarmacia);
            this.groupBox1.Controls.Add(this.txtNomeFarmacia);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(509, 221);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "INSERIMENTO FARMACIA";
            // 
            // btnInserisciFarmacia
            // 
            this.btnInserisciFarmacia.Location = new System.Drawing.Point(315, 64);
            this.btnInserisciFarmacia.Name = "btnInserisciFarmacia";
            this.btnInserisciFarmacia.Size = new System.Drawing.Size(90, 47);
            this.btnInserisciFarmacia.TabIndex = 8;
            this.btnInserisciFarmacia.Text = "Inserisci farmacia";
            this.btnInserisciFarmacia.UseVisualStyleBackColor = true;
            this.btnInserisciFarmacia.Click += new System.EventHandler(this.btnInserisciFarmacia_Click);
            // 
            // txtTitolareFarmacia
            // 
            this.txtTitolareFarmacia.Location = new System.Drawing.Point(136, 115);
            this.txtTitolareFarmacia.Name = "txtTitolareFarmacia";
            this.txtTitolareFarmacia.Size = new System.Drawing.Size(129, 24);
            this.txtTitolareFarmacia.TabIndex = 7;
            // 
            // txtCodiceFarmacia
            // 
            this.txtCodiceFarmacia.Location = new System.Drawing.Point(136, 89);
            this.txtCodiceFarmacia.Name = "txtCodiceFarmacia";
            this.txtCodiceFarmacia.Size = new System.Drawing.Size(129, 24);
            this.txtCodiceFarmacia.TabIndex = 6;
            // 
            // txtIndirizzoFarmacia
            // 
            this.txtIndirizzoFarmacia.Location = new System.Drawing.Point(136, 63);
            this.txtIndirizzoFarmacia.Name = "txtIndirizzoFarmacia";
            this.txtIndirizzoFarmacia.Size = new System.Drawing.Size(129, 24);
            this.txtIndirizzoFarmacia.TabIndex = 5;
            // 
            // txtNomeFarmacia
            // 
            this.txtNomeFarmacia.Location = new System.Drawing.Point(136, 37);
            this.txtNomeFarmacia.Name = "txtNomeFarmacia";
            this.txtNomeFarmacia.Size = new System.Drawing.Size(129, 24);
            this.txtNomeFarmacia.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nome del titolare:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Codice farmacia:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Indirizzo farmacia:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome farmacia:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.cbFarmacie);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.btnInserisciFarmaco);
            this.groupBox2.Controls.Add(this.txtScadenza);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtPrezzo);
            this.groupBox2.Controls.Add(this.txtCodiceFarmaco);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtCasaFarmaceutica);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtNomeFarmaco);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(527, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(498, 221);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "INSERIMENTO FARMACO";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(6, 149);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(375, 18);
            this.label14.TabIndex = 9;
            this.label14.Text = "Per i medicinali senza scadenza lasciare il campo vuoto";
            // 
            // cbFarmacie
            // 
            this.cbFarmacie.FormattingEnabled = true;
            this.cbFarmacie.Location = new System.Drawing.Point(146, 185);
            this.cbFarmacie.Name = "cbFarmacie";
            this.cbFarmacie.Size = new System.Drawing.Size(129, 26);
            this.cbFarmacie.TabIndex = 20;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(8, 188);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(138, 18);
            this.label13.TabIndex = 19;
            this.label13.Text = "Seleziona farmacia:";
            // 
            // btnInserisciFarmaco
            // 
            this.btnInserisciFarmaco.Location = new System.Drawing.Point(311, 55);
            this.btnInserisciFarmaco.Name = "btnInserisciFarmaco";
            this.btnInserisciFarmaco.Size = new System.Drawing.Size(90, 47);
            this.btnInserisciFarmaco.TabIndex = 9;
            this.btnInserisciFarmaco.Text = "Inserisci farmaco";
            this.btnInserisciFarmaco.UseVisualStyleBackColor = true;
            this.btnInserisciFarmaco.Click += new System.EventHandler(this.btnInserisciFarmaco_Click);
            // 
            // txtScadenza
            // 
            this.txtScadenza.Location = new System.Drawing.Point(146, 124);
            this.txtScadenza.Name = "txtScadenza";
            this.txtScadenza.Size = new System.Drawing.Size(129, 24);
            this.txtScadenza.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(49, 127);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 18);
            this.label9.TabIndex = 17;
            this.label9.Text = "Scadenza:";
            // 
            // txtPrezzo
            // 
            this.txtPrezzo.Location = new System.Drawing.Point(146, 98);
            this.txtPrezzo.Name = "txtPrezzo";
            this.txtPrezzo.Size = new System.Drawing.Size(129, 24);
            this.txtPrezzo.TabIndex = 16;
            // 
            // txtCodiceFarmaco
            // 
            this.txtCodiceFarmaco.Location = new System.Drawing.Point(146, 72);
            this.txtCodiceFarmaco.Name = "txtCodiceFarmaco";
            this.txtCodiceFarmaco.Size = new System.Drawing.Size(129, 24);
            this.txtCodiceFarmaco.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(28, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 18);
            this.label8.TabIndex = 9;
            this.label8.Text = "Nome farmaco:";
            // 
            // txtCasaFarmaceutica
            // 
            this.txtCasaFarmaceutica.Location = new System.Drawing.Point(146, 46);
            this.txtCasaFarmaceutica.Name = "txtCasaFarmaceutica";
            this.txtCasaFarmaceutica.Size = new System.Drawing.Size(129, 24);
            this.txtCasaFarmaceutica.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(9, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 18);
            this.label7.TabIndex = 10;
            this.label7.Text = "Casa farmaceutica:";
            // 
            // txtNomeFarmaco
            // 
            this.txtNomeFarmaco.Location = new System.Drawing.Point(146, 20);
            this.txtNomeFarmaco.Name = "txtNomeFarmaco";
            this.txtNomeFarmaco.Size = new System.Drawing.Size(129, 24);
            this.txtNomeFarmaco.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(23, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 18);
            this.label6.TabIndex = 11;
            this.label6.Text = "Codice farmaco:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(65, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 18);
            this.label5.TabIndex = 12;
            this.label5.Text = "Prezzo:";
            // 
            // dgvFarmacie
            // 
            this.dgvFarmacie.AllowUserToAddRows = false;
            this.dgvFarmacie.AllowUserToDeleteRows = false;
            this.dgvFarmacie.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFarmacie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFarmacie.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clNomeFarmacia,
            this.clIndirizzoFarmacia,
            this.clCodiceFarmacia,
            this.clTitolareFarmacia,
            this.clCostoTotFarmaci});
            this.dgvFarmacie.Location = new System.Drawing.Point(9, 78);
            this.dgvFarmacie.Name = "dgvFarmacie";
            this.dgvFarmacie.RowHeadersVisible = false;
            this.dgvFarmacie.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFarmacie.Size = new System.Drawing.Size(448, 242);
            this.dgvFarmacie.TabIndex = 2;
            this.dgvFarmacie.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFarmacie_CellClick);
            // 
            // clNomeFarmacia
            // 
            this.clNomeFarmacia.HeaderText = "Nome";
            this.clNomeFarmacia.Name = "clNomeFarmacia";
            // 
            // clIndirizzoFarmacia
            // 
            this.clIndirizzoFarmacia.HeaderText = "Indirizzo";
            this.clIndirizzoFarmacia.Name = "clIndirizzoFarmacia";
            // 
            // clCodiceFarmacia
            // 
            this.clCodiceFarmacia.HeaderText = "Codice";
            this.clCodiceFarmacia.Name = "clCodiceFarmacia";
            // 
            // clTitolareFarmacia
            // 
            this.clTitolareFarmacia.HeaderText = "Nome del titolare";
            this.clTitolareFarmacia.Name = "clTitolareFarmacia";
            // 
            // clCostoTotFarmaci
            // 
            this.clCostoTotFarmaci.HeaderText = "Costo totale farmaci";
            this.clCostoTotFarmaci.Name = "clCostoTotFarmaci";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.dgvFarmaci);
            this.groupBox3.Controls.Add(this.dgvFarmacie);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 239);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1013, 331);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "INFORMAZIONI";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(494, 59);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(281, 18);
            this.label12.TabIndex = 6;
            this.label12.Text = "Elenco farmaci della farmacia selezionata";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(9, 59);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(115, 18);
            this.label11.TabIndex = 5;
            this.label11.Text = "Elenco farmacie";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 32);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(308, 18);
            this.label10.TabIndex = 4;
            this.label10.Text = "Selezionare una farmacia per vedere i farmaci";
            // 
            // dgvFarmaci
            // 
            this.dgvFarmaci.AllowUserToAddRows = false;
            this.dgvFarmaci.AllowUserToDeleteRows = false;
            this.dgvFarmaci.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFarmaci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFarmaci.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clNomeFarmaco,
            this.clCasa,
            this.clCodiceFarmaco,
            this.clPrezzo,
            this.clScadenza});
            this.dgvFarmaci.Location = new System.Drawing.Point(497, 78);
            this.dgvFarmaci.Name = "dgvFarmaci";
            this.dgvFarmaci.RowHeadersVisible = false;
            this.dgvFarmaci.Size = new System.Drawing.Size(481, 242);
            this.dgvFarmaci.TabIndex = 3;
            // 
            // clNomeFarmaco
            // 
            this.clNomeFarmaco.HeaderText = "Nome";
            this.clNomeFarmaco.Name = "clNomeFarmaco";
            // 
            // clCasa
            // 
            this.clCasa.HeaderText = "Casa farmaceutica";
            this.clCasa.Name = "clCasa";
            // 
            // clCodiceFarmaco
            // 
            this.clCodiceFarmaco.HeaderText = "Codice";
            this.clCodiceFarmaco.Name = "clCodiceFarmaco";
            // 
            // clPrezzo
            // 
            this.clPrezzo.HeaderText = "Prezzo";
            this.clPrezzo.Name = "clPrezzo";
            // 
            // clScadenza
            // 
            this.clScadenza.HeaderText = "Scadenza";
            this.clScadenza.Name = "clScadenza";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1037, 581);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFarmacie)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFarmaci)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvFarmacie;
        private System.Windows.Forms.Button btnInserisciFarmacia;
        private System.Windows.Forms.TextBox txtTitolareFarmacia;
        private System.Windows.Forms.TextBox txtCodiceFarmacia;
        private System.Windows.Forms.TextBox txtIndirizzoFarmacia;
        private System.Windows.Forms.TextBox txtNomeFarmacia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPrezzo;
        private System.Windows.Forms.TextBox txtCodiceFarmaco;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCasaFarmaceutica;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNomeFarmaco;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtScadenza;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnInserisciFarmaco;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvFarmaci;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNomeFarmacia;
        private System.Windows.Forms.DataGridViewTextBoxColumn clIndirizzoFarmacia;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCodiceFarmacia;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTitolareFarmacia;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNomeFarmaco;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCasa;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCodiceFarmaco;
        private System.Windows.Forms.DataGridViewTextBoxColumn clPrezzo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clScadenza;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCostoTotFarmaci;
        private System.Windows.Forms.ComboBox cbFarmacie;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
    }
}

