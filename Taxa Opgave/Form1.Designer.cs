namespace Taxa_Opgave
{
    partial class Form1
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
            this.menuHeader = new System.Windows.Forms.Label();
            this.pricesLabel = new System.Windows.Forms.Label();
            this.orderLabel = new System.Windows.Forms.Label();
            this.pricesButton = new System.Windows.Forms.Button();
            this.orderButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // menuHeader
            // 
            this.menuHeader.Font = new System.Drawing.Font("Cambria", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuHeader.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.menuHeader.Location = new System.Drawing.Point(305, 39);
            this.menuHeader.Name = "menuHeader";
            this.menuHeader.Size = new System.Drawing.Size(429, 72);
            this.menuHeader.TabIndex = 0;
            this.menuHeader.Text = "Kom sikkert frem – kør gult";
            // 
            // pricesLabel
            // 
            this.pricesLabel.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pricesLabel.Location = new System.Drawing.Point(438, 274);
            this.pricesLabel.Name = "pricesLabel";
            this.pricesLabel.Size = new System.Drawing.Size(76, 23);
            this.pricesLabel.TabIndex = 1;
            this.pricesLabel.Text = "Se Priser  -";
            // 
            // orderLabel
            // 
            this.orderLabel.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderLabel.Location = new System.Drawing.Point(411, 199);
            this.orderLabel.Name = "orderLabel";
            this.orderLabel.Size = new System.Drawing.Size(110, 23);
            this.orderLabel.TabIndex = 2;
            this.orderLabel.Text = "Bestil en taxa  -";
            this.orderLabel.Click += new System.EventHandler(this.orderLabel_Click);
            // 
            // pricesButton
            // 
            this.pricesButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pricesButton.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pricesButton.ForeColor = System.Drawing.Color.Yellow;
            this.pricesButton.Location = new System.Drawing.Point(560, 265);
            this.pricesButton.Name = "pricesButton";
            this.pricesButton.Size = new System.Drawing.Size(87, 32);
            this.pricesButton.TabIndex = 3;
            this.pricesButton.Text = "Priser";
            this.pricesButton.UseVisualStyleBackColor = false;
            this.pricesButton.Click += new System.EventHandler(this.pricesButton_Click);
            // 
            // orderButton
            // 
            this.orderButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.orderButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.orderButton.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderButton.ForeColor = System.Drawing.Color.Yellow;
            this.orderButton.Location = new System.Drawing.Point(560, 190);
            this.orderButton.Name = "orderButton";
            this.orderButton.Size = new System.Drawing.Size(87, 32);
            this.orderButton.TabIndex = 4;
            this.orderButton.Text = "Bestil";
            this.orderButton.UseVisualStyleBackColor = false;
            this.orderButton.Click += new System.EventHandler(this.orderButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 563);
            this.Controls.Add(this.orderButton);
            this.Controls.Add(this.pricesButton);
            this.Controls.Add(this.orderLabel);
            this.Controls.Add(this.pricesLabel);
            this.Controls.Add(this.menuHeader);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label menuHeader;
        private System.Windows.Forms.Label pricesLabel;
        private System.Windows.Forms.Label orderLabel;
        private System.Windows.Forms.Button pricesButton;
        private System.Windows.Forms.Button orderButton;
    }
}

