using SwissTransport;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Forms;

namespace App
{
    public partial class App : Form
    {

        public App()
        {
            InitializeComponent();
            InitSettings();
        }

        private void InitSettings()
        {
            dgtConnections.Visible = true;
            dgtBoard.Visible = false;

            dtpTime.Format = DateTimePickerFormat.Custom;
            dtpTime.CustomFormat = "HH:mm";
        }

        private void FillStationBoxes(object sender, EventArgs e)
        {
            Transport transport = new Transport();
            Stations stations = new Stations();
            ComboBox myInput = (ComboBox)sender;

            if (myInput.Text.Length >= 2)
            {

                stations = transport.GetStations(myInput.Text);

                List<Station> stationList = stations.StationList;

                if (stationList.Count > 1)
                {
                    foreach (Station station in stationList)
                    {
                        try
                        {
                            myInput.Items.Add(station.Name);
                        } catch (ArgumentNullException exc)
                        {
                            Console.WriteLine(exc.StackTrace);
                        }
                    }
                }
            }
        }
        
        private void BtnSearch_Click(object sender, EventArgs e)
        {
            if (!cmbFrom.Text.Equals("") && !cmbTo.Text.Equals(""))
            {
                if (!cmbFrom.Text.Equals(cmbTo.Text))
                {
                    GetNextConnections();
                }
                else
                {
                    MessageBox.Show("Sie haben die Station: " + cmbFrom.Text + " zweimal eingegeben!",
                        "Beide Stationen sind gleich", MessageBoxButtons.OK, 
                        MessageBoxIcon.Warning);
                }

            } else if (!cmbFrom.Text.Equals("") && cmbTo.Text.Equals(""))
            {
                GetDepartementTable();
            } else
            {
                MessageBox.Show("Sie müssen die von Station eintragen", "Von Station leer",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void GetDepartementTable()
        {
            dgtBoard.Rows.Clear();

            dgtConnections.Visible = false;
            dgtBoard.Visible = true;

            Transport transport = new Transport();
            StationBoardRoot stationBoardRoot = new StationBoardRoot();

            stationBoardRoot = transport.GetStationBoard(cmbFrom.Text);

            foreach (StationBoard stationBoard in stationBoardRoot.Entries)
            {

                dgtBoard.Rows.Add(Convert.ToDateTime(stationBoard.Stop.Departure).ToString("HH:mm"),
                    stationBoard.Stop.Platform,
                    stationBoard.To
                    );

            }

        }

        private void GetNextConnections()
        {
            dgtConnections.Rows.Clear();

            dgtConnections.Visible = true;
            dgtBoard.Visible = false;

            Connections connections = new Connections();
            Transport transport = new Transport();
            

            connections = transport.GetConnections(cmbFrom.Text, cmbTo.Text, Convert.ToDateTime(dtpTime.Value).ToString("HH:mm"), Convert.ToDateTime(dtpDate.Value).ToString("yyyy-MM-dd"));
            List<Connection> connectionList = connections.ConnectionList;
            
            if (connectionList.Count != 0)
            {

                foreach (Connection connection in connectionList)
                {

                    dgtConnections.Rows.Add(Convert.ToDateTime(connection.From.Departure).ToString("HH:mm"),
                        connection.From.Platform,
                        connection.To.Station.Name,
                        Convert.ToDateTime(connection.To.Arrival).ToString("HH:mm"),
                        connection.Duration.Remove(0, 3).Remove(5, 3) + " h");

                }

            } else
            {
                MessageBox.Show("Zwischen den Stationen: " + cmbFrom.Text + " und "
                    + cmbTo.Text + " wurden keine Verbindungen gefunden.",
                    "Keine Verbindung gefunden", MessageBoxButtons.OK, 
                    MessageBoxIcon.Information);
            }
        }

        private void Exchange_Click(object sender, EventArgs e)
        {
            string from = cmbFrom.Text;
            string to = cmbTo.Text;

            cmbFrom.Text = to;
            cmbTo.Text = from;
        }

    }
}
