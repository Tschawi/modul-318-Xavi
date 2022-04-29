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
            
        }

        private void btnVerbindungen_Click(object sender, EventArgs e)
        {
            
            string Startstation = cbxStart.Text;
            string Endstation = cbxEnd.Text;
            DateTime Date = dTPDatum.Value;
            DateTime Time = dTPZeit.Value;
            if(Startstation != "" && Endstation != "")
            {
                var Verbindungen = Database.GetConnections(Startstation, Endstation, Date, Time);
                int xCord = 777; 
                int yCord = 200;
                int lblname = 1;
                for (int z�hler = 0; z�hler < 19; z�hler++)
                {
                    var label = this.Controls.OfType<Label>().FirstOrDefault(l => l.Name == z�hler.ToString());
                    if (label != null)
                        this.Controls.Remove(label);
                }


                foreach (var Verbindung in Verbindungen.ConnectionList)
                {
                        string Text1 = String.Format("{0:HH:mm}", Verbindung.From.Departure);
                        string Text2 = Verbindung.To.Station.Name;
                        string Text3 = String.Format("{0:HH:mm}", Verbindung.To.Arrival);
                        lblname = createlbl(lblname, xCord, yCord, Text1, Text2, Text3);
                    yCord += 75;
                }
                
            }
            else {
                MessageBox.Show("Bitte Start und Endhaltestelle eingeben", "Fehler");
            }
           
        }
        private int createlbl(int lblname, int xCord, int yCord, string Text1, string Text2, string Text3)
        {
            for (int z�hler = 0; z�hler < 3; z�hler++)
            {
                Label mylab = new Label();
                mylab.AutoSize = true;
                mylab.Font = new Font("Segoe UI", 13);
                mylab.Name = lblname.ToString();
                if (z�hler == 0)
                {
                    mylab.Location = new Point(xCord, yCord);
                    mylab.Text = String.Format("{0:HH:mm}", Text1);

                }
                else if (z�hler == 1)
                {
                    mylab.Location = new Point(xCord + 70, yCord);
                    mylab.Text = Text2;
                }
                else
                {
                    mylab.Location = new Point(xCord + 360, yCord);
                    mylab.Text = String.Format("{0:HH:mm}", Text3);
                }
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
                cbxStart.Items.Clear();
                string Startstation = cbxStart.Text;

                var Stationlist = Database.GetStations(Startstation);
                List<string> list = new List<string>();

                foreach (var Station in Stationlist.StationList)
                {
                    list.Add(Station.Name);
                }
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
                    cbxEnd.Items.Clear();
                    string Startstation = cbxEnd.Text;

                    var Stationlist = Database.GetStations(Startstation);
                    List<string> list = new List<string>();

                    foreach (var Station in Stationlist.StationList)
                    {
                        list.Add(Station.Name);
                    }
                    foreach (var item in list)
                    {
                        cbxEnd.Items.Add(item);
                    }
                cbxEnd.DroppedDown = true;
            }
        }

        private void lblKarte_Click(object sender, EventArgs e)
        {
            for (int z�hler = 19; z�hler < 46; z�hler++)
            {
                var label = this.Controls.OfType<Label>().FirstOrDefault(l => l.Name == z�hler.ToString());
                if (label != null)
                    this.Controls.Remove(label);
            }
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
                var Abfahrtstafel = Database.GetStationBoard(cbxStart.Text, "0");
                int xCord = 48;
                int yCord = 151;
                int lblname = 19;
                this.Controls.Remove(this.Controls.OfType<WebBrowser>().FirstOrDefault(l => l.Name == "Map"));
                for (int z�hler = 19; z�hler < 46; z�hler++)
                {
                    var label = this.Controls.OfType<Label>().FirstOrDefault(l => l.Name == z�hler.ToString());
                    if (label != null)
                        this.Controls.Remove(label);
                }
                foreach (var Verbindung in Abfahrtstafel.Entries)
                {
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