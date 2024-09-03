namespace Taxa_Opgave
{
    partial class orderTaxaForm
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
            this.carTypeDropdown = new System.Windows.Forms.ComboBox();
            this.timeDropdown = new System.Windows.Forms.ComboBox();
            this.startpointTextbox = new System.Windows.Forms.TextBox();
            this.endpointTextbox = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.priceLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.slutpointLabel = new System.Windows.Forms.Label();
            this.MainmenuButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).BeginInit();
            this.SuspendLayout();
            // 
            // carTypeDropdown
            // 
            this.carTypeDropdown.FormattingEnabled = true;
            this.carTypeDropdown.Location = new System.Drawing.Point(11, 23);
            this.carTypeDropdown.Name = "carTypeDropdown";
            this.carTypeDropdown.Size = new System.Drawing.Size(144, 21);
            this.carTypeDropdown.TabIndex = 4;
            this.carTypeDropdown.Text = "Vælg Vogn";
            this.carTypeDropdown.SelectedIndexChanged += new System.EventHandler(this.carTypeDropdown_SelectedIndexChanged_1);
            // 
            // timeDropdown
            // 
            this.timeDropdown.FormattingEnabled = true;
            this.timeDropdown.Location = new System.Drawing.Point(161, 22);
            this.timeDropdown.Name = "timeDropdown";
            this.timeDropdown.Size = new System.Drawing.Size(149, 21);
            this.timeDropdown.TabIndex = 11;
            this.timeDropdown.Text = "Dag / Nat";
            this.timeDropdown.SelectedIndexChanged += new System.EventHandler(this.timeDropdown_SelectedIndexChanged);
            // 
            // startpointTextbox
            // 
            this.startpointTextbox.Location = new System.Drawing.Point(316, 23);
            this.startpointTextbox.Name = "startpointTextbox";
            this.startpointTextbox.Size = new System.Drawing.Size(203, 20);
            this.startpointTextbox.TabIndex = 12;
            this.startpointTextbox.TextChanged += new System.EventHandler(this.startpointTextbox_TextChanged);
            // 
            // endpointTextbox
            // 
            this.endpointTextbox.Location = new System.Drawing.Point(525, 23);
            this.endpointTextbox.Name = "endpointTextbox";
            this.endpointTextbox.Size = new System.Drawing.Size(202, 20);
            this.endpointTextbox.TabIndex = 13;
            this.endpointTextbox.TextChanged += new System.EventHandler(this.endpointTextbox_TextChanged);
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(733, 15);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(90, 33);
            this.calculateButton.TabIndex = 14;
            this.calculateButton.Text = "Beregn Pris";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click_1);
            // 
            // priceLabel
            // 
            this.priceLabel.Location = new System.Drawing.Point(829, 22);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(169, 21);
            this.priceLabel.TabIndex = 15;
            this.priceLabel.Text = "PrisLabel";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(316, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 33);
            this.label3.TabIndex = 16;
            this.label3.Text = "Indtast startpoint";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // webView21
            // 
            this.webView21.AllowExternalDrop = true;
            this.webView21.CreationProperties = null;
            this.webView21.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView21.Location = new System.Drawing.Point(12, 63);
            this.webView21.Name = "webView21";
            this.webView21.Size = new System.Drawing.Size(1156, 658);
            this.webView21.TabIndex = 18;
            this.webView21.ZoomFactor = 1D;
            // 
            // slutpointLabel
            // 
            this.slutpointLabel.Location = new System.Drawing.Point(522, 11);
            this.slutpointLabel.Name = "slutpointLabel";
            this.slutpointLabel.Size = new System.Drawing.Size(98, 33);
            this.slutpointLabel.TabIndex = 19;
            this.slutpointLabel.Text = "Indtast Destination";
            // 
            // MainmenuButton
            // 
            this.MainmenuButton.Location = new System.Drawing.Point(1091, 12);
            this.MainmenuButton.Name = "MainmenuButton";
            this.MainmenuButton.Size = new System.Drawing.Size(77, 40);
            this.MainmenuButton.TabIndex = 20;
            this.MainmenuButton.Text = "Hoved Menu";
            this.MainmenuButton.UseVisualStyleBackColor = true;
            this.MainmenuButton.Click += new System.EventHandler(this.MainmenuButton_Click);
            // 
            // orderTaxaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 733);
            this.Controls.Add(this.MainmenuButton);
            this.Controls.Add(this.webView21);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.endpointTextbox);
            this.Controls.Add(this.startpointTextbox);
            this.Controls.Add(this.timeDropdown);
            this.Controls.Add(this.carTypeDropdown);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.slutpointLabel);
            this.Name = "orderTaxaForm";
            this.Text = "orderTaxaForm";
            this.Load += new System.EventHandler(this.orderTaxaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox carTypeDropdown;
        private System.Windows.Forms.ComboBox timeDropdown;
        private System.Windows.Forms.TextBox startpointTextbox;
        private System.Windows.Forms.TextBox endpointTextbox;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label label3;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
        private System.Windows.Forms.Label slutpointLabel;
        private System.Windows.Forms.Button MainmenuButton;
    }
}