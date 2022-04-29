namespace SwissTransportGUI
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnVerbindungen = new System.Windows.Forms.Button();
            this.cbxStart = new System.Windows.Forms.ComboBox();
            this.cbxEnd = new System.Windows.Forms.ComboBox();
            this.dTPDatum = new System.Windows.Forms.DateTimePicker();
            this.dTPZeit = new System.Windows.Forms.DateTimePicker();
            this.lblKarte = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(48, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 28);
            this.label2.TabIndex = 6;
            this.label2.Text = "Startstation";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(999, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 28);
            this.label3.TabIndex = 7;
            this.label3.Text = "Endstation";
            // 
            // btnVerbindungen
            // 
            this.btnVerbindungen.Location = new System.Drawing.Point(670, 49);
            this.btnVerbindungen.Name = "btnVerbindungen";
            this.btnVerbindungen.Size = new System.Drawing.Size(175, 47);
            this.btnVerbindungen.TabIndex = 8;
            this.btnVerbindungen.Text = "Verbindungen suchen";
            this.btnVerbindungen.UseVisualStyleBackColor = true;
            this.btnVerbindungen.Click += new System.EventHandler(this.btnVerbindungen_Click);
            // 
            // cbxStart
            // 
            this.cbxStart.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbxStart.FormattingEnabled = true;
            this.cbxStart.Location = new System.Drawing.Point(48, 52);
            this.cbxStart.Name = "cbxStart";
            this.cbxStart.Size = new System.Drawing.Size(250, 36);
            this.cbxStart.TabIndex = 14;
            this.cbxStart.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cbxStart_KeyUp);
            // 
            // cbxEnd
            // 
            this.cbxEnd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbxEnd.FormattingEnabled = true;
            this.cbxEnd.Location = new System.Drawing.Point(999, 52);
            this.cbxEnd.Name = "cbxEnd";
            this.cbxEnd.Size = new System.Drawing.Size(250, 36);
            this.cbxEnd.TabIndex = 15;
            this.cbxEnd.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cbxEnd_KeyUp);
            // 
            // dTPDatum
            // 
            this.dTPDatum.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dTPDatum.Location = new System.Drawing.Point(364, 57);
            this.dTPDatum.Name = "dTPDatum";
            this.dTPDatum.Size = new System.Drawing.Size(107, 27);
            this.dTPDatum.TabIndex = 16;
            // 
            // dTPZeit
            // 
            this.dTPZeit.CustomFormat = "HH:mm";
            this.dTPZeit.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dTPZeit.Location = new System.Drawing.Point(505, 57);
            this.dTPZeit.Name = "dTPZeit";
            this.dTPZeit.ShowUpDown = true;
            this.dTPZeit.Size = new System.Drawing.Size(90, 27);
            this.dTPZeit.TabIndex = 17;
            // 
            // lblKarte
            // 
            this.lblKarte.AutoSize = true;
            this.lblKarte.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblKarte.Location = new System.Drawing.Point(195, 106);
            this.lblKarte.Name = "lblKarte";
            this.lblKarte.Size = new System.Drawing.Size(67, 31);
            this.lblKarte.TabIndex = 18;
            this.lblKarte.Text = "Karte";
            this.lblKarte.Click += new System.EventHandler(this.lblKarte_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(48, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 31);
            this.label1.TabIndex = 19;
            this.label1.Text = "Anzeigetafel";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1322, 772);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblKarte);
            this.Controls.Add(this.dTPZeit);
            this.Controls.Add(this.dTPDatum);
            this.Controls.Add(this.cbxEnd);
            this.Controls.Add(this.cbxStart);
            this.Controls.Add(this.btnVerbindungen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "Swiss Tarnsport";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label2;
        private Label label3;
        private Button btnVerbindungen;
        private ComboBox cbxStart;
        private ComboBox cbxEnd;
        private DateTimePicker dTPDatum;
        private DateTimePicker dTPZeit;
        private Label lblKarte;
        private Label label1;
    }
}