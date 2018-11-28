using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SwissTransport;

namespace App
{
    public partial class Application : Form
    {
        Transport transport = new Transport();
        Stations fromStations = new Stations();
        Stations toStations = new Stations();
        Connections connections = new Connections();

        public Application()
        {
            InitializeComponent();
            InitializeControls();
            InitializeDataGrid();
        }

        private void InitializeControls()
        {
            cboFrom.DisplayMember = "Name";
            cboFrom.ValueMember = "Name";

            cboTo.DisplayMember = "Name";
            cboTo.ValueMember = "Name";
        }

        private void InitializeDataGrid()
        {
            datConnections.DataSource = connections;
            datConnections.Columns.Add("from", "Von");
            datConnections.Columns.Add("fromTime", "Abfahrtszeit");
            datConnections.Columns.Add("to", "Nach");
            datConnections.Columns.Add("toTime", "Von");

            foreach (Connection connection in connections.ConnectionList)
            {
                datConnections.Rows.Add(connection)
            }

        }


        private void UI_Load(object sender, EventArgs e)
        {

        }

        private void btnSearchConnections_Click(object sender, EventArgs e)
        {
            fromStations = GetStations(cboFrom.Text);
            toStations = GetStations(cboTo.Text);
            ShowFromStations();
            ShowToStations();

            connections = GetConnections(cboFrom.ValueMember, cboTo.ValueMember);
            datConnections.DataSource = connections;
            datConnections.AutoGenerateColumns = true;


            //foreach (Connection connection in connections.ConnectionList)
            //{

            //}
            
            datConnections.Refresh();
        }

        private void ShowToStations()
        {
            cboTo.DataSource = toStations.StationList;
            cboTo.SelectedIndex = 0;
            cboTo.DroppedDown = true;
        }

        private void ShowFromStations()
        {
            cboFrom.DataSource = fromStations.StationList;
            cboFrom.SelectedIndex = 0;
            cboFrom.DroppedDown = true;
        }

        private Stations GetStations(string query)
        {
            bool queryNotNullOrWhiteSpaces = !(String.IsNullOrWhiteSpace(query));

            if (queryNotNullOrWhiteSpaces)
            {
                return transport.GetStations(query);
            }

            return null;
        }

        private Connections GetConnections(string fromStation, string toStation)
        {
            bool stationsNotNullOrWhiteSpaces = 
                (!(String.IsNullOrWhiteSpace(fromStation)) && !(String.IsNullOrWhiteSpace(toStation)));

            if (stationsNotNullOrWhiteSpaces)
            {
                return transport.GetConnections(fromStation, toStation);
            }

            return null;
        }

        private void btnBinh_Click(object sender, EventArgs e)
        {
            MessageBox.Show(datConnections.Columns[0].HeaderText);
        }

        private void cboFrom_Click(object sender, EventArgs e)
        {
            cboFrom.SelectAll();
        }

        private void cboTo_Click(object sender, EventArgs e)
        {
            cboFrom.SelectAll();
        }
    }
}
