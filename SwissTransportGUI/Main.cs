using System;
using SwissTransport.Core;
using SwissTransport.Models;



namespace SwissTransportGUI
{
    public partial class Main : Form
    {
        private readonly ITransport Database;
        public Main()
        {
            InitializeComponent();
            this.Database = new Transport();
            //HIer wird ein Transportobjekt erstellt
            
        }

        private void btnVerbindungen_Click(object sender, EventArgs e)
        {
            
            string Startstation = cbxStart.Text;
            string Endstation = cbxEnd.Text;
            DateTime Date = dTPDatum.Value;
            DateTime Time = dTPZeit.Value;
            //Hier wird überprüft ob das Feld Leer ist
            if(Startstation != "" && Endstation != "")
            {
                //Man holt die Verbindungen
                var Verbindungen = Database.GetConnections(Startstation, Endstation, Date, Time);
                int xCord = 777; 
                int yCord = 200;
                int lblname = 1;
                //Falls exitierend werden die Labels gelöscht
                for (int zähler = 0; zähler < 19; zähler++)
                {
                    var label = this.Controls.OfType<Label>().FirstOrDefault(l => l.Name == zähler.ToString());
                    if (label != null)
                        this.Controls.Remove(label);
                }


                foreach (var Verbindung in Verbindungen.ConnectionList)
                {
                    //Die Variabeln für das Labelerstellen werden Initialisiert
                    string Text1 = String.Format("{0:HH:mm}", Verbindung.From.Departure);
                    string Text2 = Verbindung.To.Station.Name;
                    string Text3 = String.Format("{0:HH:mm}", Verbindung.To.Arrival);
                    lblname = createlbl(lblname, xCord, yCord, Text1, Text2, Text3);
                    yCord += 75;
                }
                
            }
            else {
                //Ausgabe falls eines der Felder Leer ist
                MessageBox.Show("Bitte Start und Endhaltestelle eingeben", "Fehler");
            }
           
        }
        private int createlbl(int lblname, int xCord, int yCord, string Text1, string Text2, string Text3)
        {
            for (int zähler = 0; zähler < 3; zähler++)
            {
                //Properties für ein Label werden erstellt
                Label mylab = new Label();
                mylab.AutoSize = true;
                mylab.Font = new Font("Segoe UI", 13);
                mylab.Name = lblname.ToString();
                //je nach Label bekommt es einen anderen Text
                if (zähler == 0)
                {
                    mylab.Location = new Point(xCord, yCord);
                    mylab.Text = String.Format("{0:HH:mm}", Text1);

                }
                else if (zähler == 1)
                {
                    mylab.Location = new Point(xCord + 70, yCord);
                    mylab.Text = Text2;
                }
                else
                {
                    mylab.Location = new Point(xCord + 360, yCord);
                    mylab.Text = String.Format("{0:HH:mm}", Text3);
                }
                //Das Label wird dem Forms hinzugefügt
                this.Controls.Add(mylab);
                lblname++;
            }
            yCord += 40;
            return lblname;
        }
  

        private void cbxStart_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                //Bestehende Items werden aus der combobox gelöscht
                cbxStart.Items.Clear();
                string Startstation = cbxStart.Text;
                //Man holt die Stationsnamen
                var Stationlist = Database.GetStations(Startstation);
                List<string> list = new List<string>();
                //Die Namen werden in eine LIste geschrieben
                foreach (var Station in Stationlist.StationList)
                {
                    list.Add(Station.Name);
                }
                //Die liste wird in die Combobox gefüllt
                foreach (var item in list)
                {
                    cbxStart.Items.Add(item);
                }
                cbxStart.DroppedDown = true;
            }
        }

        private void cbxEnd_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                //Bestehende Items werden aus der combobox gelöscht
                cbxEnd.Items.Clear();
                string Startstation = cbxEnd.Text;
                //Man holt die Stationsnamen
                var Stationlist = Database.GetStations(Startstation);
                List<string> list = new List<string>();
                //Die Namen werden in eine LIste geschrieben
                foreach (var Station in Stationlist.StationList)
                {
                    list.Add(Station.Name);
                }
                //Die liste wird in die Combobox gefüllt
                foreach (var item in list)
                {
                    cbxEnd.Items.Add(item);
                }
                cbxEnd.DroppedDown = true;
            }
        }

        private void lblKarte_Click(object sender, EventArgs e)
        {
            //Falls exitierend werden die Labels gelöscht
            for (int zähler = 19; zähler < 46; zähler++)
            {
                var label = this.Controls.OfType<Label>().FirstOrDefault(l => l.Name == zähler.ToString());
                if (label != null)
                    this.Controls.Remove(label);
            }
            //ein Webbroswser für Google Maps wird erstellt und hinzugefügt
            WebBrowser wb = new WebBrowser();
            wb.Location = new Point(48, 151);
            wb.Navigate("https://www.google.ch/maps/");
            wb.Size = new Size(634, 609);
            wb.Name = "Map";
            this.Controls.Add(wb);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            if (cbxStart.Text != "")
            {
                //die Informationen für die Anzeigetafel werden geholt
                var Abfahrtstafel = Database.GetStationBoard(cbxStart.Text, "0");
                int xCord = 48;
                int yCord = 151;
                int lblname = 19;
                //Die Karte wird entfernt
                this.Controls.Remove(this.Controls.OfType<WebBrowser>().FirstOrDefault(l => l.Name == "Map"));
                //Bestehende Labels werden Gelöscht
                for (int zähler = 19; zähler < 46; zähler++)
                {
                    var label = this.Controls.OfType<Label>().FirstOrDefault(l => l.Name == zähler.ToString());
                    if (label != null)
                        this.Controls.Remove(label);
                }
                //Die verbindungen werden per Labels ausgegeben
                foreach (var Verbindung in Abfahrtstafel.Entries)
                {
                    //der Text für die Labeles wird generiert
                    string Text4 = String.Format("{0:HH:mm}", Verbindung.Stop.Departure);
                    string Text5 = Verbindung.To;
                    string Text6 = Verbindung.Category + " " + Verbindung.Number;
                    lblname = createlbl(lblname, xCord, yCord, Text4, Text5, Text6);
                    lblname++;
                    yCord += 75;
                    if (45 < lblname)
                        break;
                }
            }
            
        }
    }
}