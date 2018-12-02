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
using App.ConvertToDataGridView;

namespace App
{
    public partial class Application : Form
    {
        ITransport transport = new Transport();
        List<Station> fromStations = new List<Station>();
        List<Station> toStations = new List<Station>();
        List<Connection> connections = new List<Connection>();

        public Application()
        {
            InitializeComponent();
            InitializeControls();
            InitializeDataGrid();
        }

        private void InitializeControls()
        {
            // lstForm
            lstFrom.DisplayMember = "Name";
            lstFrom.ValueMember = "Id";
        }

        private void InitializeDataGrid()
        {
            datConnections.Visible = false;
        }

        private void ShowToStations()
        {
            if (toStations.Count != 0)
            {
                cboTo.DataSource = toStations;
                cboTo.SelectedIndex = 0;
                cboTo.DroppedDown = true;

                lstFrom.DataSource = fromStations;
            }

        }

        private void ShowFromStations()
        {
            if (fromStations.Count != 0)
            {
                cboFrom.DataSource = fromStations;
                cboFrom.SelectedIndex = 0;
                cboFrom.DroppedDown = true;
            }          
        }

        private void ShowConnections()
        {
            ToUserFriendly toUserFriendly = new ToUserFriendly();

            var connectionList = from connection in connections
                          select new
                          {
                              Dauer         = toUserFriendly.ConvertDuration(connection.Duration), // ConvertDurationToTimeSpan(connection.Duration)., 
                              Von           = connection.From.Station.Name,
                              Abfahrtszeit  = Convert.ToDateTime(connection.From.Departure), 
                              Nach          = connection.To.Station.Name,
                              Ankunftszeit  = Convert.ToDateTime(connection.To.Arrival)
                          };
            datConnections.DataSource = connectionList.ToList();
            datConnections.Refresh();
            datConnections.Visible = true;
        }

        private List<Station> GetStations(string query)
        {
            List<Station> stations = new List<Station>();

            try
            {
                stations = transport.GetStations(query).StationList;
            }
            catch (Exception)
            {
                MessageBox.Show("Die Station " + query + " wurde nicht gefunden.");
            }
            //bool queryNotNullOrWhiteSpaces = !(String.IsNullOrWhiteSpace(query));

            //if (queryNotNullOrWhiteSpaces)
            //{
            //    stations =  transport.GetStations(query).StationList;
            //}

            return stations;
        }

        private List<Connection> GetConnections(string fromStation, string toStation)
        {
            List<Connection> connections = new List<Connection>();

            bool stationsNotNullOrWhiteSpaces = 
                (NotNullOrWhiteSpace(fromStation) && NotNullOrWhiteSpace(toStation));

            if (stationsNotNullOrWhiteSpaces)
            {
                connections = transport.GetConnections(fromStation, toStation).ConnectionList;
            }

            return connections;
        }

        private List<StationBoard> GetStationBoardEntries(string station, string id)
        {
            List<StationBoard> stationBoardEntries = new List<StationBoard>();

            bool stationAndIdNotNullOrWhiteSpaces =
                (NotNullOrWhiteSpace(station) && NotNullOrWhiteSpace(id));

            if (stationAndIdNotNullOrWhiteSpaces)
            {
                stationBoardEntries = transport.GetStationBoard(station, id).Entries;
            }

            return stationBoardEntries;
        }

        private bool NotNullOrWhiteSpace(string toCheck)
        {
            if (String.IsNullOrWhiteSpace(toCheck) != true)
            {
                return true;
            }
            return false;
        }

        // 
        // GUI-Events
        //
        private void btnSearchConnections_Click(object sender, EventArgs e)
        {
            fromStations = GetStations(cboFrom.Text);
            toStations = GetStations(cboTo.Text);
            ShowFromStations();
            ShowToStations();

            connections = GetConnections(cboFrom.Text, cboTo.Text);
            ShowConnections();
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

        private void lstFrom_SelectedIndexChanged(object sender, EventArgs e)
        {
            ////if (lstFrom.Focused == true)
            ////{
            //    txtFrom.Text = lstFrom.Text;
            ////}
        }

        private void txtFrom_TextChanged(object sender, EventArgs e)
        {
            toStations = GetStations(txtFrom.Text);

            lstFrom.DataSource = toStations;

            if (toStations.Count != 0 && toStations != null)
            {
                lstFrom.Visible = true;
            }
            else
            {
                lstFrom.Visible = false;
            }
        }

        private void lstFrom_Enter(object sender, EventArgs e)
        {
            txtFrom.Text = lstFrom.Text;
        }

        private void lstFrom_Leave(object sender, EventArgs e)
        {
            txtFrom.Text = lstFrom.Text;
            lstFrom.Visible = false;
        }

        private void btnFromStationBoard_Click(object sender, EventArgs e)
        {
            DepartureBoard departureBoard = new DepartureBoard(cboFrom.Text, cboFrom.SelectedValue.ToString());
            departureBoard.Show();
        }

        private void txtFrom_Leave(object sender, EventArgs e)
        {
            if (lstFrom.Items.Count != 0)
            {
                if (txtFrom.Text != lstFrom.Text && lstFrom.Focused == false)
                {
                    txtFrom.Text = lstFrom.Text;
                    lstFrom.Visible = false;
                }
            }
        }

        private void txtFrom_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtFrom.Focused)
            {
                if (lstFrom.Items.Count != 0)
                {
                    //if ((lstFrom.SelectedIndex != (lstFrom.Items.Count-1)) 
                    //    && (e.KeyCode == Keys.Down))
                    //{
                    //        lstFrom.SelectedIndex++;
                    //}
                    //if ((lstFrom.SelectedIndex != 0) 
                    //    && (e.KeyCode == Keys.Up))
                    //{
                    //        lstFrom.SelectedIndex--;
                    //}

                    if (e.KeyCode == Keys.Down)
                    {
                        lstFrom.Focus();
                    }
                }

                if (e.KeyCode == Keys.Enter)
                {
                    txtFrom.Text = lstFrom.Text;
                }
            }
        }

        private void txtFrom_Click(object sender, EventArgs e)
        {
            txtFrom.SelectAll();
        }

        private void lstFrom_Click(object sender, EventArgs e)
        {
            
            
        }
    }
}
