using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taxa_Opgave
{
    public partial class pricesForm : Form
    {
        public pricesForm()
        {
            InitializeComponent();
        }

        private void pricesForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }
        //Går vi tilbage til hovedmenuen, når brugeren klikker på knappen.
        private void MainmenuButton_Click(object sender, EventArgs e)
        {
            // Opret en ny instans af Form1
            Form1 mainMenuForm = new Form1();

            // Brug FormManager til at skifte tilbage til hovedmenuen
            FormManager formManager = new FormManager(this);
            formManager.SwitchForm(mainMenuForm);
        }
    }
}
