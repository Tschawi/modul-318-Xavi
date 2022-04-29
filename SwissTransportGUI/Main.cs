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
                int x = 777; 
                int y = 200;
                int lblname = 1;
                for (int i = 0; i < 19; i++)
                {
                    var label = this.Controls.OfType<Label>().FirstOrDefault(l => l.Name == i.ToString());
                    if (label != null)
                        this.Controls.Remove(label);
                }


                foreach (var Verbindung in Verbindungen.ConnectionList)
                {
                        string Text1 = String.Format("{0:HH:mm}", Verbindung.From.Departure);
                        string Text2 = Verbindung.To.Station.Name;
                        string Text3 = String.Format("{0:HH:mm}", Verbindung.To.Arrival);
                        lblname = createlbl(lblname, x, y, Text1, Text2, Text3);
                    y += 75;
                }
                
            }
            else {
                MessageBox.Show("Bitte Start und Endhaltestelle eingeben", "Fehler");
            }
           
        }
        private int createlbl(int lblname, int x, int y, string Text1, string Text2, string Text3)
        {
            for (int i = 0; i < 3; i++)
            {
                Label mylab = new Label();
                mylab.AutoSize = true;
                mylab.Font = new Font("Segoe UI", 13);
                mylab.Name = lblname.ToString();
                if (i == 0)
                {
                    mylab.Location = new Point(x, y);
                    mylab.Text = String.Format("{0:HH:mm}", Text1);

                }
                else if (i == 1)
                {
                    mylab.Location = new Point(x + 70, y);
                    mylab.Text = Text2;
                }
                else
                {
                    mylab.Location = new Point(x + 360, y);
                    mylab.Text = String.Format("{0:HH:mm}", Text3);
                }
                this.Controls.Add(mylab);
                lblname++;
            }
            y += 40;
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
            for (int i = 19; i < 46; i++)
            {
                var label = this.Controls.OfType<Label>().FirstOrDefault(l => l.Name == i.ToString());
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
            var Abfahrtstafel = Database.GetStationBoard(cbxStart.Text, "0");
            int x = 48;
            int y = 151;
            int lblname = 19;
            this.Controls.Remove(this.Controls.OfType<WebBrowser>().FirstOrDefault(l => l.Name == "Map"));
            for (int i = 19; i < 46; i++)
            {
                var label = this.Controls.OfType<Label>().FirstOrDefault(l => l.Name == i.ToString());
                if (label != null)
                    this.Controls.Remove(label);
            }
            foreach (var Verbindung in Abfahrtstafel.Entries)
            {
                string Text4 = String.Format("{0:HH:mm}", Verbindung.Stop.Departure);
                string Text5 = Verbindung.To;
                string Text6 = Verbindung.Category + " " + Verbindung.Number;
                lblname = createlbl(lblname, x, y, Text4, Text5, Text6);
                lblname++;
                y += 75;
                if (45 < lblname)
                    break;
            }
        }
    }
}