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
    public partial class FAuthentication : Form
    {
        public string Email { get; set; }
        public string Password { get; set; }

        public FAuthentication()
        {
            InitializeComponent();
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            Password = txt_passw.Text;
            Email = txt_email.Text;
            if (IsEmail(Email))
            {
                DialogResult = DialogResult.OK;
            }
            this.Close();
        }

        private bool IsEmail(string input)
        {
            string elements = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(input, elements, RegexOptions.IgnoreCase);
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
