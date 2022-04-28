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
            if(Startstation != "" && Endstation != "")
            {
                var Verbindungen = Database.GetConnections(Startstation, Endstation);
                int x = 600;
                int y = 200;
                int lblname = 1;
                for (int i = 0; i < 12; i++)
                {
                    var label = this.Controls.OfType<Label>().FirstOrDefault(l => l.Name == i.ToString());
                    if (label != null)
                        this.Controls.Remove(label);
                }


                foreach (var Verbindung in Verbindungen.ConnectionList)
                {
                    for (int i = 0; i < 3; i++)
                    {
                        Label mylab = new Label();
                        mylab.AutoSize = true;
                        mylab.Font = new Font("Segoe UI", 11);
                        mylab.Name = lblname.ToString();
                        if (i == 0)
                        {
                            mylab.Location = new Point(x, y);
                            mylab.Text = String.Format("{0:HH:mm}", Verbindung.From.Departure);

                        }
                        else if (i == 1)
                        {
                            mylab.Location = new Point(x + 70, y);
                            mylab.Text = Verbindung.To.Station.Name;
                        }
                        else
                        {
                            mylab.Location = new Point(x + 360, y);
                            mylab.Text = String.Format("{0:HH:mm}", Verbindung.To.Arrival);
                        }
                        this.Controls.Add(mylab);
                        lblname++;
                    }
                    y += 40;
                }
            }else {
                MessageBox.Show("Bitte Start und Endhaltestelle eingeben", "Fehler");
            }
           
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

        private void lblAktuellest_Click(object sender, EventArgs e)
        {
            string aktuellest = lblAktuellest.Text;
            var Abfahrtstafel = Database.GetStationBoard(aktuellest, "0");
            int x = 30;
            int y = 90;
            int lblname = 13;
            for (int i = 13; i < 25; i++)
            {
                var label = this.Controls.OfType<Label>().FirstOrDefault(l => l.Name == i.ToString());
                if (label != null)
                    this.Controls.Remove(label);
            }


            foreach (var Verbindung in Abfahrtstafel.Entries)
            {
                for (int i = 0; i < 3; i++)
                {
                    Label mylab = new Label();
                    mylab.AutoSize = true;
                    mylab.Font = new Font("Segoe UI", 11);
                    mylab.Name = lblname.ToString();
                    if (i == 0)
                    {
                        mylab.Location = new Point(x, y);
                        mylab.Text = String.Format("{0:HH:mm}", Verbindung.Stop.Departure);

                    }
                    else if (i == 1)
                    {
                        mylab.Location = new Point(x + 70, y);
                        mylab.Text = Verbindung.To;
                    }
                    else
                    {
                        mylab.Location = new Point(x + 360, y);
                        mylab.Text = Verbindung.Number;
                    }
                    this.Controls.Add(mylab);
                    lblname++;
                }
                y += 40;
                if (31 < lblname)
                    break;
            }
        }
    }
}