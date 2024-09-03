using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taxa_Opgave
{
    public partial class Form1 : Form
    {
        private FormManager FormManager;
        
        // Constructor for Form1, initialiserer komponenter og FormManager.
        public Form1()
        {
            InitializeComponent();
            FormManager = new FormManager(this);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void orderLabel_Click(object sender, EventArgs e)
        {

        }

        // Når brugeren klikker på pris-knappen, åbner vi pris-formen.
        private void pricesButton_Click(object sender, EventArgs e)
        {
            pricesForm pricesForm = new pricesForm();
            
            FormManager.SwitchForm(pricesForm);
        }

        // Når brugeren klikker på bestil-knappen, åbner vi formen til at bestille en taxa.
        private void orderButton_Click(object sender, EventArgs e)
        {
            orderTaxaForm orderTaxaForm = new orderTaxaForm();

            FormManager.SwitchForm(orderTaxaForm);
        }
    }
}
