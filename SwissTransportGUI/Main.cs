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
            string Startstation = txtStartst.Text;
            string Endstation = txtEndst.Text;
            var Verbindungen = Database.GetConnections(Startstation, Endstation);
            
        }
    }
}