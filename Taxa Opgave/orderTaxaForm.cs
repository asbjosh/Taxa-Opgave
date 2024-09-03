using Microsoft.Web.WebView2.WinForms;
using Microsoft.Web.WebView2.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Net.Http;

namespace Taxa_Opgave
{
    public partial class orderTaxaForm : Form
    {
        public orderTaxaForm()
        {
            InitializeComponent();
        }

        // Når formen loader, tilføjer vi vogntyper og tidspunkter og loader Google Maps
        private async void orderTaxaForm_Load(object sender, EventArgs e)
        {
            // Tilføjer valgmuligheder for vogntyper
            carTypeDropdown.Items.Add("Almindelig Vogn");
            carTypeDropdown.Items.Add("Stor Vogn - Minibus");

            // Tilføjer valgmuligheder for tidspunkter
            timeDropdown.Items.Add("Dag: 06 - 18");
            timeDropdown.Items.Add("Nat: 18 - 06");

            // Skjuler priceLabel indtil vi har en beregning
            priceLabel.Visible = false;

            await webView21.EnsureCoreWebView2Async(null);

            // Loader Google Maps i WebView2
            webView21.CoreWebView2.Navigate("https://www.google.com/maps"); // Dette indlæser Google Maps startsiden
        }

        private void carTypeDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private async void calculateButton_Click_1(object sender, EventArgs e)
        {
            // Henter start- og slutpunkter fra tekstbokse
            string startpoint = startpointTextbox.Text;
            string endpoint = endpointTextbox.Text;

            // Henter afstanden mellem punkterne i kilometer
            double distance = await GetDistanceAsync(startpoint, endpoint);

            // Henter valgte vogntype og tidspunkt
            string selectedCarType = carTypeDropdown.SelectedItem.ToString();
            string selectedTimeOfDay = timeDropdown.SelectedItem.ToString();

            // Opretter en ny TaxaCalculator for at udregne prisen
            TaxaCalculator calculator = new TaxaCalculator(selectedCarType, selectedTimeOfDay, distance);

            // Viser den beregnede pris
            priceLabel.Text = $"Prisen for turen er: {calculator.TotalPrice} kr";
            priceLabel.Visible = true;

            // Naviger til Google Maps URL med rutevejledning
            string googleMapsUrl = $"https://www.google.com/maps/dir/{Uri.EscapeDataString(startpoint)}/{Uri.EscapeDataString(endpoint)}/";
            webView21.CoreWebView2.Navigate(googleMapsUrl);
        }

        // TaxaCalculator-klassen håndterer beregning af prisen baseret på afstand, vogntype og tidspunkt
        public class TaxaCalculator
        {
            public string CarType { get; set; }
            public string TimeOfDay { get; set; }
            public decimal StartPrice { get; private set; }
            public decimal PricePerKm { get; private set; }
            public decimal TotalPrice { get; private set; }

            // Constructor – sætter op startpris og udregner den totale pris
            public TaxaCalculator(string carType, string timeOfDay, double distance)
            {
                CarType = carType;
                TimeOfDay = timeOfDay;
                CalculateStartPrice();
                CalculateTotalPrice(distance);
            }

            // Udregner startpris og pris pr. km afhængigt af vogntype og tidspunkt
            private void CalculateStartPrice()
            {
                if (CarType == "Almindelig Vogn")
                {
                    StartPrice = TimeOfDay == "Dag: 06 - 18" ? 37 : 47;
                    PricePerKm = TimeOfDay == "Dag: 06 - 18" ? 12.75m : 16m;
                }
                else if (CarType == "Stor Vogn - Minibus")
                {
                    StartPrice = TimeOfDay == "Dag: 06 - 18" ? 77 : 87;
                    PricePerKm = TimeOfDay == "Dag: 06 - 18" ? 17m : 19m;
                }
            }

            // Udregner den totale pris baseret på afstand og pr. km-pris
            private void CalculateTotalPrice(double distance)
            {
                TotalPrice = StartPrice + (PricePerKm * (decimal)distance);
            }
        }

        private void startpointTextbox_TextChanged(object sender, EventArgs e)
        {
            UpdateMap();
        }

        private void endpointTextbox_TextChanged(object sender, EventArgs e)
        {
            UpdateMap();
        }

        // Opdaterer kortet med ruten fra start- til slutpunkt
        private void UpdateMap()
        {
            string startpoint = startpointTextbox.Text;
            string endpoint = endpointTextbox.Text;

            if (!string.IsNullOrEmpty(startpoint) && !string.IsNullOrEmpty(endpoint))
            {
                // Generer Google Maps URL med rutevejledning
                string googleMapsUrl = $"https://www.google.com/maps/dir/{Uri.EscapeDataString(startpoint)}/{Uri.EscapeDataString(endpoint)}/";

                // Navigerer til URL'en i WebView2-kontrollen
                webView21.CoreWebView2.Navigate(googleMapsUrl);
            }
        }
        
        // Får afstanden mellem to punkter ved hjælp af Google Maps API
        private async Task<double> GetDistanceAsync(string startpoint, string endpoint)
        {
            string apiKey = "AIzaSyDAo5Cokd4acdyTCMgtY1DXBUTPToyE--I";
            string url = $"https://maps.googleapis.com/maps/api/distancematrix/json?origins={Uri.EscapeDataString(startpoint)}&destinations={Uri.EscapeDataString(endpoint)}&key={apiKey}";

            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    string jsonResponse = await response.Content.ReadAsStringAsync();
                    dynamic json = JsonConvert.DeserializeObject(jsonResponse);

                    // Henter afstanden i meter og konverterer til kilometer
                    double distanceInMeters = json.rows[0].elements[0].distance.value;
                    double distanceInKilometers = distanceInMeters / 1000;

                    return distanceInKilometers;
                }
                else
                {
                    throw new Exception("Fejl ved hentning af afstand fra Google Maps API.");
                }
            }
        }
        private void MainmenuButton_Click(object sender, EventArgs e)
        {
            // Opret en ny instans af Form1
            Form1 mainMenuForm = new Form1();

            // Brug FormManager til at skifte tilbage til hovedmenuen
            FormManager formManager = new FormManager(this);
            formManager.SwitchForm(mainMenuForm);
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void carTypeDropdown_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void timeDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
