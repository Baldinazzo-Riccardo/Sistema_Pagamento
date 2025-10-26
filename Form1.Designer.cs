namespace Sistemapagamento
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
            this.rdb_cripto = new System.Windows.Forms.RadioButton();
            this.rdb_carta = new System.Windows.Forms.RadioButton();
            this.rdb_paypal = new System.Windows.Forms.RadioButton();
            this.btn_paga = new System.Windows.Forms.Button();
            this.pnl_paypal = new System.Windows.Forms.Panel();
            this.num_paypal = new System.Windows.Forms.NumericUpDown();
            this.txt_emailPayPal = new System.Windows.Forms.TextBox();
            this.txt_pswPayPal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.num_saldoCarta = new System.Windows.Forms.NumericUpDown();
            this.pnl_carta = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.date_carta = new System.Windows.Forms.DateTimePicker();
            this.txt_idCarta = new System.Windows.Forms.TextBox();
            this.txt_pinCarta = new System.Windows.Forms.TextBox();
            this.txt_emailCarta = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pnl_cripto = new System.Windows.Forms.Panel();
            this.txt_idCripto = new System.Windows.Forms.TextBox();
            this.num_saldoCripto = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btn_insDati = new System.Windows.Forms.Button();
            this.btn_disconessione = new System.Windows.Forms.Button();
            this.btn_accesso = new System.Windows.Forms.Button();
            this.rdb_applePay = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.pnl_paypal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_paypal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_saldoCarta)).BeginInit();
            this.pnl_carta.SuspendLayout();
            this.pnl_cripto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_saldoCripto)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdb_applePay);
            this.groupBox1.Controls.Add(this.rdb_cripto);
            this.groupBox1.Controls.Add(this.rdb_carta);
            this.groupBox1.Controls.Add(this.rdb_paypal);
            this.groupBox1.Location = new System.Drawing.Point(38, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(310, 301);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleziona tecnica di pagamento";
            // 
            // rdb_cripto
            // 
            this.rdb_cripto.AutoSize = true;
            this.rdb_cripto.Location = new System.Drawing.Point(48, 175);
            this.rdb_cripto.Name = "rdb_cripto";
            this.rdb_cripto.Size = new System.Drawing.Size(118, 24);
            this.rdb_cripto.TabIndex = 6;
            this.rdb_cripto.TabStop = true;
            this.rdb_cripto.Text = "Criptovalute";
            this.rdb_cripto.UseVisualStyleBackColor = true;
            this.rdb_cripto.CheckedChanged += new System.EventHandler(this.rdb_cripto_CheckedChanged);
            // 
            // rdb_carta
            // 
            this.rdb_carta.AutoSize = true;
            this.rdb_carta.Location = new System.Drawing.Point(48, 116);
            this.rdb_carta.Name = "rdb_carta";
            this.rdb_carta.Size = new System.Drawing.Size(73, 24);
            this.rdb_carta.TabIndex = 5;
            this.rdb_carta.TabStop = true;
            this.rdb_carta.Text = "Carta";
            this.rdb_carta.UseVisualStyleBackColor = true;
            this.rdb_carta.CheckedChanged += new System.EventHandler(this.rdb_carta_CheckedChanged);
            // 
            // rdb_paypal
            // 
            this.rdb_paypal.AutoSize = true;
            this.rdb_paypal.Location = new System.Drawing.Point(48, 58);
            this.rdb_paypal.Name = "rdb_paypal";
            this.rdb_paypal.Size = new System.Drawing.Size(82, 24);
            this.rdb_paypal.TabIndex = 4;
            this.rdb_paypal.TabStop = true;
            this.rdb_paypal.Text = "PayPal";
            this.rdb_paypal.UseVisualStyleBackColor = true;
            this.rdb_paypal.CheckedChanged += new System.EventHandler(this.rdb_paypal_CheckedChanged);
            // 
            // btn_paga
            // 
            this.btn_paga.Location = new System.Drawing.Point(38, 319);
            this.btn_paga.Name = "btn_paga";
            this.btn_paga.Size = new System.Drawing.Size(143, 111);
            this.btn_paga.TabIndex = 1;
            this.btn_paga.Text = "PAGA";
            this.btn_paga.UseVisualStyleBackColor = true;
            this.btn_paga.Click += new System.EventHandler(this.btn_paga_Click);
            // 
            // pnl_paypal
            // 
            this.pnl_paypal.Controls.Add(this.num_paypal);
            this.pnl_paypal.Controls.Add(this.txt_emailPayPal);
            this.pnl_paypal.Controls.Add(this.txt_pswPayPal);
            this.pnl_paypal.Controls.Add(this.label3);
            this.pnl_paypal.Controls.Add(this.label2);
            this.pnl_paypal.Controls.Add(this.label1);
            this.pnl_paypal.Location = new System.Drawing.Point(433, 39);
            this.pnl_paypal.Name = "pnl_paypal";
            this.pnl_paypal.Size = new System.Drawing.Size(335, 302);
            this.pnl_paypal.TabIndex = 3;
            // 
            // num_paypal
            // 
            this.num_paypal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.num_paypal.DecimalPlaces = 2;
            this.num_paypal.Location = new System.Drawing.Point(31, 114);
            this.num_paypal.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
            this.num_paypal.Name = "num_paypal";
            this.num_paypal.Size = new System.Drawing.Size(269, 26);
            this.num_paypal.TabIndex = 12;
            // 
            // txt_emailPayPal
            // 
            this.txt_emailPayPal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_emailPayPal.Location = new System.Drawing.Point(32, 48);
            this.txt_emailPayPal.Name = "txt_emailPayPal";
            this.txt_emailPayPal.Size = new System.Drawing.Size(270, 26);
            this.txt_emailPayPal.TabIndex = 10;
            // 
            // txt_pswPayPal
            // 
            this.txt_pswPayPal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_pswPayPal.Location = new System.Drawing.Point(31, 186);
            this.txt_pswPayPal.Name = "txt_pswPayPal";
            this.txt_pswPayPal.PasswordChar = '*';
            this.txt_pswPayPal.Size = new System.Drawing.Size(270, 26);
            this.txt_pswPayPal.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Saldo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Email account";
            // 
            // num_saldoCarta
            // 
            this.num_saldoCarta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.num_saldoCarta.DecimalPlaces = 2;
            this.num_saldoCarta.Location = new System.Drawing.Point(32, 102);
            this.num_saldoCarta.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
            this.num_saldoCarta.Name = "num_saldoCarta";
            this.num_saldoCarta.Size = new System.Drawing.Size(269, 26);
            this.num_saldoCarta.TabIndex = 8;
            // 
            // pnl_carta
            // 
            this.pnl_carta.Controls.Add(this.label4);
            this.pnl_carta.Controls.Add(this.date_carta);
            this.pnl_carta.Controls.Add(this.txt_idCarta);
            this.pnl_carta.Controls.Add(this.txt_pinCarta);
            this.pnl_carta.Controls.Add(this.txt_emailCarta);
            this.pnl_carta.Controls.Add(this.num_saldoCarta);
            this.pnl_carta.Controls.Add(this.label5);
            this.pnl_carta.Controls.Add(this.label6);
            this.pnl_carta.Controls.Add(this.label7);
            this.pnl_carta.Controls.Add(this.label8);
            this.pnl_carta.Location = new System.Drawing.Point(801, 39);
            this.pnl_carta.Name = "pnl_carta";
            this.pnl_carta.Size = new System.Drawing.Size(335, 313);
            this.pnl_carta.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Saldo";
            // 
            // date_carta
            // 
            this.date_carta.Location = new System.Drawing.Point(32, 169);
            this.date_carta.Name = "date_carta";
            this.date_carta.Size = new System.Drawing.Size(270, 26);
            this.date_carta.TabIndex = 11;
            // 
            // txt_idCarta
            // 
            this.txt_idCarta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_idCarta.Location = new System.Drawing.Point(32, 48);
            this.txt_idCarta.Name = "txt_idCarta";
            this.txt_idCarta.Size = new System.Drawing.Size(270, 26);
            this.txt_idCarta.TabIndex = 10;
            this.txt_idCarta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_idCarta_KeyPress);
            // 
            // txt_pinCarta
            // 
            this.txt_pinCarta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_pinCarta.Location = new System.Drawing.Point(32, 273);
            this.txt_pinCarta.Name = "txt_pinCarta";
            this.txt_pinCarta.PasswordChar = '*';
            this.txt_pinCarta.Size = new System.Drawing.Size(270, 26);
            this.txt_pinCarta.TabIndex = 9;
            // 
            // txt_emailCarta
            // 
            this.txt_emailCarta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_emailCarta.Location = new System.Drawing.Point(32, 221);
            this.txt_emailCarta.Name = "txt_emailCarta";
            this.txt_emailCarta.Size = new System.Drawing.Size(270, 26);
            this.txt_emailCarta.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 250);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "PIN";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 198);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "E-mail";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 146);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "Data di scadenza";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Numero carta";
            // 
            // pnl_cripto
            // 
            this.pnl_cripto.Controls.Add(this.txt_idCripto);
            this.pnl_cripto.Controls.Add(this.num_saldoCripto);
            this.pnl_cripto.Controls.Add(this.label11);
            this.pnl_cripto.Controls.Add(this.label12);
            this.pnl_cripto.Location = new System.Drawing.Point(1165, 39);
            this.pnl_cripto.Name = "pnl_cripto";
            this.pnl_cripto.Size = new System.Drawing.Size(335, 302);
            this.pnl_cripto.TabIndex = 11;
            // 
            // txt_idCripto
            // 
            this.txt_idCripto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_idCripto.Location = new System.Drawing.Point(32, 48);
            this.txt_idCripto.Name = "txt_idCripto";
            this.txt_idCripto.Size = new System.Drawing.Size(270, 26);
            this.txt_idCripto.TabIndex = 10;
            this.txt_idCripto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_idCripto_KeyPress);
            // 
            // num_saldoCripto
            // 
            this.num_saldoCripto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.num_saldoCripto.DecimalPlaces = 2;
            this.num_saldoCripto.Location = new System.Drawing.Point(32, 114);
            this.num_saldoCripto.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
            this.num_saldoCripto.Name = "num_saldoCripto";
            this.num_saldoCripto.Size = new System.Drawing.Size(269, 26);
            this.num_saldoCripto.TabIndex = 8;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(28, 91);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 20);
            this.label11.TabIndex = 1;
            this.label11.Text = "Saldo";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(28, 25);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 20);
            this.label12.TabIndex = 0;
            this.label12.Text = "ID wallet";
            // 
            // btn_insDati
            // 
            this.btn_insDati.Location = new System.Drawing.Point(433, 349);
            this.btn_insDati.Name = "btn_insDati";
            this.btn_insDati.Size = new System.Drawing.Size(335, 75);
            this.btn_insDati.TabIndex = 12;
            this.btn_insDati.Text = "INSERISCI INFORMAZIONI";
            this.btn_insDati.UseVisualStyleBackColor = true;
            this.btn_insDati.Click += new System.EventHandler(this.btn_insDati_Click);
            // 
            // btn_disconessione
            // 
            this.btn_disconessione.Location = new System.Drawing.Point(187, 376);
            this.btn_disconessione.Name = "btn_disconessione";
            this.btn_disconessione.Size = new System.Drawing.Size(161, 54);
            this.btn_disconessione.TabIndex = 14;
            this.btn_disconessione.Text = "DISCONNETTI";
            this.btn_disconessione.UseVisualStyleBackColor = true;
            this.btn_disconessione.Click += new System.EventHandler(this.btn_disconessione_Click);
            // 
            // btn_accesso
            // 
            this.btn_accesso.Location = new System.Drawing.Point(187, 319);
            this.btn_accesso.Name = "btn_accesso";
            this.btn_accesso.Size = new System.Drawing.Size(161, 51);
            this.btn_accesso.TabIndex = 15;
            this.btn_accesso.Text = "ACCEDI";
            this.btn_accesso.UseVisualStyleBackColor = true;
            this.btn_accesso.Click += new System.EventHandler(this.btn_accesso_Click);
            // 
            // rdb_applePay
            // 
            this.rdb_applePay.AutoSize = true;
            this.rdb_applePay.Location = new System.Drawing.Point(48, 235);
            this.rdb_applePay.Name = "rdb_applePay";
            this.rdb_applePay.Size = new System.Drawing.Size(105, 24);
            this.rdb_applePay.TabIndex = 7;
            this.rdb_applePay.TabStop = true;
            this.rdb_applePay.Text = "Apple Pay";
            this.rdb_applePay.UseVisualStyleBackColor = true;
            this.rdb_applePay.CheckedChanged += new System.EventHandler(this.rdb_applePay_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1492, 450);
            this.Controls.Add(this.btn_accesso);
            this.Controls.Add(this.btn_disconessione);
            this.Controls.Add(this.btn_insDati);
            this.Controls.Add(this.pnl_cripto);
            this.Controls.Add(this.pnl_carta);
            this.Controls.Add(this.pnl_paypal);
            this.Controls.Add(this.btn_paga);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Sistema di pagamento";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pnl_paypal.ResumeLayout(false);
            this.pnl_paypal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_paypal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_saldoCarta)).EndInit();
            this.pnl_carta.ResumeLayout(false);
            this.pnl_carta.PerformLayout();
            this.pnl_cripto.ResumeLayout(false);
            this.pnl_cripto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_saldoCripto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdb_cripto;
        private System.Windows.Forms.RadioButton rdb_carta;
        private System.Windows.Forms.RadioButton rdb_paypal;
        private System.Windows.Forms.Button btn_paga;
        private System.Windows.Forms.Panel pnl_paypal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_emailPayPal;
        private System.Windows.Forms.TextBox txt_pswPayPal;
        private System.Windows.Forms.NumericUpDown num_saldoCarta;
        private System.Windows.Forms.Panel pnl_carta;
        private System.Windows.Forms.TextBox txt_idCarta;
        private System.Windows.Forms.TextBox txt_pinCarta;
        private System.Windows.Forms.TextBox txt_emailCarta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel pnl_cripto;
        private System.Windows.Forms.TextBox txt_idCripto;
        private System.Windows.Forms.NumericUpDown num_saldoCripto;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btn_insDati;
        private System.Windows.Forms.DateTimePicker date_carta;
        private System.Windows.Forms.NumericUpDown num_paypal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_disconessione;
        private System.Windows.Forms.Button btn_accesso;
        private System.Windows.Forms.RadioButton rdb_applePay;
    }
}

