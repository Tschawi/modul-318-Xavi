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
            this.lblAktuellest = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnVerbindungen = new System.Windows.Forms.Button();
            this.cbxStart = new System.Windows.Forms.ComboBox();
            this.cbxEnd = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblAktuellest
            // 
            this.lblAktuellest.AutoSize = true;
            this.lblAktuellest.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAktuellest.Location = new System.Drawing.Point(30, 24);
            this.lblAktuellest.Name = "lblAktuellest";
            this.lblAktuellest.Size = new System.Drawing.Size(68, 25);
            this.lblAktuellest.TabIndex = 0;
            this.lblAktuellest.Text = "Sursee";
            this.lblAktuellest.Click += new System.EventHandler(this.lblAktuellest_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(526, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Startstation";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(729, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Endstation";
            // 
            // btnVerbindungen
            // 
            this.btnVerbindungen.Location = new System.Drawing.Point(619, 74);
            this.btnVerbindungen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVerbindungen.Name = "btnVerbindungen";
            this.btnVerbindungen.Size = new System.Drawing.Size(153, 35);
            this.btnVerbindungen.TabIndex = 8;
            this.btnVerbindungen.Text = "Verbindungen suchen";
            this.btnVerbindungen.UseVisualStyleBackColor = true;
            this.btnVerbindungen.Click += new System.EventHandler(this.btnVerbindungen_Click);
            // 
            // cbxStart
            // 
            this.cbxStart.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbxStart.FormattingEnabled = true;
            this.cbxStart.Location = new System.Drawing.Point(526, 40);
            this.cbxStart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxStart.Name = "cbxStart";
            this.cbxStart.Size = new System.Drawing.Size(158, 27);
            this.cbxStart.TabIndex = 14;
            this.cbxStart.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cbxStart_KeyUp);
            // 
            // cbxEnd
            // 
            this.cbxEnd.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbxEnd.FormattingEnabled = true;
            this.cbxEnd.Location = new System.Drawing.Point(726, 40);
            this.cbxEnd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxEnd.Name = "cbxEnd";
            this.cbxEnd.Size = new System.Drawing.Size(158, 27);
            this.cbxEnd.TabIndex = 15;
            this.cbxEnd.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cbxEnd_KeyUp);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 448);
            this.Controls.Add(this.cbxEnd);
            this.Controls.Add(this.cbxStart);
            this.Controls.Add(this.btnVerbindungen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblAktuellest);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Main";
            this.Text = "So ein geiles Produkt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblAktuellest;
        private Label label2;
        private Label label3;
        private Button btnVerbindungen;
        private ComboBox cbxStart;
        private ComboBox cbxEnd;
    }
}