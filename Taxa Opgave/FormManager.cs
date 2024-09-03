using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taxa_Opgave
{
    public class FormManager
    {
        private Form currentForm;

        // Constructor – gemmer den form, der er aktiv lige nu
        public FormManager(Form initialForm) 
        {
            currentForm = initialForm;
        }

        // Skifter fra den nuværende form til en ny form
        public void SwitchForm(Form newForm)
        {
            currentForm.Hide();
            newForm.FormClosed += NewForm_FormClosed;
            newForm.Show();
            currentForm = newForm;
        }

        // Lukker hele appen, når en form lukkes
        private void NewForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }   
}
