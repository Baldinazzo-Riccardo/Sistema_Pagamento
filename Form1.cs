using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistemapagamento
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Point firstLocation = new Point(320, 12);


        int index = 0;
        List<GiveMeMyMoney> payments = new List<GiveMeMyMoney>();
        AllPayments allPayments = new AllPayments();
        decimal total = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            rdb_carta.Checked = false;
            rdb_cripto.Checked = false;
            rdb_paypal.Checked = false;


            pnl_paypal.Visible = false;
            pnl_cripto.Visible = false;
            pnl_carta.Visible = false;

            date_carta.Value = DateTime.Now;

            this.Size = new Size(600, 350);
        }

        private void btn_insDati_Click(object sender, EventArgs e)
        {
            if (pnl_carta.Visible == true)
            {
                //dati: numero carta, data di scadenza, PIN; richiede autenticazione.

                string numCarta = txt_idCarta.Text;

                DateTime dataScadenza = date_carta.Value;

                int totCarta = (int)num_saldoCarta.Value;

                string passwCarta = txt_pinCarta.Text;

                string emailCarta = txt_emailCarta.Text;

                if (numCarta == "")
                {
                    MessageBox.Show("Inserire un numero di carta valido");
                    return;
                }

                if (passwCarta == "")
                {
                    MessageBox.Show("Inserire una password valida");
                    return;
                }

                if (emailCarta == "")
                {
                    MessageBox.Show("Inserire una email valida");
                    return;
                }

                if (dataScadenza < DateTime.Now)
                {
                    MessageBox.Show("Data non inseribile");
                    return;
                }

                if (!IsEmail(emailCarta))
                {
                    MessageBox.Show("Email non valida");
                }


                Card card = new Card(numCarta, totCarta, 'B', emailCarta, passwCarta, dataScadenza);
                payments.Add(card);
                index++;

                txt_idCarta.Clear();
                txt_pinCarta.Clear();
                txt_emailCarta.Clear();
                num_saldoCarta.Value = 0;
                date_carta.Value = DateTime.Today;
            }
            else if (pnl_paypal.Visible == true)
            {
                //dati: email account, saldo disponibile; richiede autenticazione.
                string emailPayPal = txt_emailPayPal.Text;
                int totPayPal = (int)num_paypal.Value;

                string passwPayPal = txt_pswPayPal.Text;

                if (emailPayPal == "")
                {
                    throw new ArgumentException("Inserire una email valida");
                }

                if (passwPayPal == "")
                {
                    throw new ArgumentException("Inserire una password valida");
                }

                if (!IsEmail(emailPayPal))
                {
                    throw new ArgumentException("Email non valida");
                }

                PayPal payPal = new PayPal(emailPayPal, totPayPal, 'P', emailPayPal, passwPayPal);
                payments.Add(payPal);
                index++;

                txt_emailPayPal.Clear();
                txt_pswPayPal.Clear();
                num_paypal.Value = 0;
            }
            else if (pnl_cripto.Visible == true)
            {
                //dati: identificativo wallet, saldo cripto; non richiede autenticazione.
                string idWallet = txt_idCripto.Text;

                int totCripto = (int)num_saldoCripto.Value;

                if(idWallet == "")
                {
                    throw new ArgumentException("Inserire un ID wallet valido");
                }
                    

                GiveMeMyMoney element;

                if (rdb_cripto.Checked == true)
                {
                    element = new Cripto(idWallet, totCripto, 'C');
                }
                else
                {
                    element = new ApplePay(idWallet, totCripto, 'A');
                }
                payments.Add(element);
                index++;

                txt_idCripto.Clear();
                num_saldoCripto.Value = 0;
            }
        }



        //per controllare se sia email con Regez
        private bool IsEmail(string input)
        {
            string elements = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(input, elements, RegexOptions.IgnoreCase);
        }

        #region controlli_radiobutton
        private void rdb_paypal_CheckedChanged(object sender, EventArgs e)
        {
            pnl_cripto.Visible = false;
            pnl_carta.Visible = false;

            pnl_paypal.Location = firstLocation;
            pnl_paypal.Visible = true;
        }

        private void rdb_carta_CheckedChanged(object sender, EventArgs e)
        {
            pnl_cripto.Visible = false;
            pnl_paypal.Visible = false;

            pnl_carta.Location = firstLocation;
            pnl_carta.Visible = true;
        }

        private void rdb_cripto_CheckedChanged(object sender, EventArgs e)
        {
            pnl_carta.Visible = false;
            pnl_paypal.Visible = false;

            pnl_cripto.Location = firstLocation;
            pnl_cripto.Visible = true;
        }

        private void rdb_applePay_CheckedChanged(object sender, EventArgs e)
        {
            pnl_carta.Visible = false;
            pnl_paypal.Visible = false;

            pnl_cripto.Location = firstLocation;
            pnl_cripto.Visible = true;
        }
        #endregion

        private void txt_idCarta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btn_accesso_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (FAuthentication fa = new FAuthentication())
            {
                if (fa.ShowDialog() == DialogResult.OK)
                {
                    string email = fa.Email;
                    string passw = fa.Password;
                    GiveMeMyMoney payment = payments[index - 1];
                    if (payment is IProtected)
                    {
                        IProtected protectedPayment = (IProtected)payment;
                        protectedPayment.Access(email, passw);
                        if(protectedPayment.isAuthenticated)
                        {
                            allPayments.GetPayments();
                        }
                    }
                }
            }
            
            this.Show();
        }



        private void btn_disconessione_Click(object sender, EventArgs e)
        {
            GiveMeMyMoney payment = payments[index - 1];

            if (payment is IProtected)
            {
                IProtected protectedPayment = (IProtected)payment;
                if (protectedPayment.isAuthenticated)
                {
                    protectedPayment.Exit();
                    allPayments.GetDisconnect();
                }
                else
                {
                    MessageBox.Show("Utente non autenticato. Impossibile disconnessione");
                }
            }
        }

        private void btn_paga_Click(object sender, EventArgs e)
        {
            if (payments.Count > 0)
            {
                GiveMeMyMoney payment = payments[index - 1];

                if (payment is IProtected)
                {
                    IProtected protectedPayment = (IProtected)payment;
                    if (protectedPayment.isAuthenticated)
                    {
                        LetsPay((GiveMeMyMoney)protectedPayment);
                    }
                    else
                    {
                        MessageBox.Show("Utente non autenticato. Accedi");
                    }
                }
            }
            else
            {
                MessageBox.Show("Nessun pagamento");
            }
        }

        private void LetsPay(GiveMeMyMoney payment)
        {
            this.Hide();
            using (FPayment fp = new FPayment())
            {
                if (fp.ShowDialog() == DialogResult.OK)
                {
                    total = fp.Tot;
                    allPayments.GetPayments();
                    allPayments.AddMoney(total);
                }
            }
            this.Show();

            payment.Pay(total);
            
            MessageBox.Show(payment.ToString());
        }

        private void txt_idCripto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        
    }
}
