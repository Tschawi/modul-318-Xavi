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
            this.lblAktuellest = new System.Windows.Forms.Label();
            this.libxAnzeigetafel = new System.Windows.Forms.ListBox();
            this.txtStartst = new System.Windows.Forms.TextBox();
            this.libxVerbindungen = new System.Windows.Forms.ListBox();
            this.txtEndst = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnVerbindungen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAktuellest
            // 
            this.lblAktuellest.AutoSize = true;
            this.lblAktuellest.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAktuellest.Location = new System.Drawing.Point(31, 27);
            this.lblAktuellest.Name = "lblAktuellest";
            this.lblAktuellest.Size = new System.Drawing.Size(174, 31);
            this.lblAktuellest.TabIndex = 0;
            this.lblAktuellest.Text = "Aktuelle Station";
            // 
            // libxAnzeigetafel
            // 
            this.libxAnzeigetafel.FormattingEnabled = true;
            this.libxAnzeigetafel.ItemHeight = 20;
            this.libxAnzeigetafel.Location = new System.Drawing.Point(31, 71);
            this.libxAnzeigetafel.Name = "libxAnzeigetafel";
            this.libxAnzeigetafel.Size = new System.Drawing.Size(387, 504);
            this.libxAnzeigetafel.TabIndex = 1;
            // 
            // txtStartst
            // 
            this.txtStartst.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtStartst.Location = new System.Drawing.Point(601, 55);
            this.txtStartst.Name = "txtStartst";
            this.txtStartst.Size = new System.Drawing.Size(160, 39);
            this.txtStartst.TabIndex = 2;
            // 
            // libxVerbindungen
            // 
            this.libxVerbindungen.FormattingEnabled = true;
            this.libxVerbindungen.ItemHeight = 20;
            this.libxVerbindungen.Location = new System.Drawing.Point(601, 153);
            this.libxVerbindungen.Name = "libxVerbindungen";
            this.libxVerbindungen.Size = new System.Drawing.Size(392, 424);
            this.libxVerbindungen.TabIndex = 4;
            // 
            // txtEndst
            // 
            this.txtEndst.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEndst.Location = new System.Drawing.Point(833, 55);
            this.txtEndst.Name = "txtEndst";
            this.txtEndst.Size = new System.Drawing.Size(160, 39);
            this.txtEndst.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(601, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Startstation";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(833, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Endstation";
            // 
            // btnVerbindungen
            // 
            this.btnVerbindungen.Location = new System.Drawing.Point(709, 100);
            this.btnVerbindungen.Name = "btnVerbindungen";
            this.btnVerbindungen.Size = new System.Drawing.Size(175, 47);
            this.btnVerbindungen.TabIndex = 8;
            this.btnVerbindungen.Text = "Verbindungen suchen";
            this.btnVerbindungen.UseVisualStyleBackColor = true;
            this.btnVerbindungen.Click += new System.EventHandler(this.btnVerbindungen_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 602);
            this.Controls.Add(this.btnVerbindungen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEndst);
            this.Controls.Add(this.libxVerbindungen);
            this.Controls.Add(this.txtStartst);
            this.Controls.Add(this.libxAnzeigetafel);
            this.Controls.Add(this.lblAktuellest);
            this.Name = "Main";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblAktuellest;
        private ListBox libxAnzeigetafel;
        private TextBox txtStartst;
        private ListBox libxVerbindungen;
        private TextBox txtEndst;
        private Label label2;
        private Label label3;
        private Button btnVerbindungen;
    }
}