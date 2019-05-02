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

        Dialogs dialogs = new Dialogs();
        CheckStatements checks = new CheckStatements();

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
        
        private void BtnSearch_Click(object sender, EventArgs e)
        {
            if (checks.CheckIfFromAndToAreEmpty(cmbFrom.Text, cmbTo.Text))
            {
                if (!cmbFrom.Text.Equals(cmbTo.Text))
                {
                    lblDateAndTimeFromSearch.Text = "Verbindungen vom: " + dtpDate.Text + " ab " + dtpTime.Text;
                    GetNextConnections();
                }
                else
                {
                    dialogs.ShowStationsTheSameDialog(cmbFrom.Text);
                }

            } else if (checks.CheckIfSearchingStationBoard(cmbFrom.Text, cmbTo.Text))
            {
                lblDateAndTimeFromSearch.Text = "Aktuelle Abfahrtstabelle von " + cmbFrom.Text;
                GetDepartementTable();
            } else
            {
                dialogs.ShowMissingFromStationDialog();
            }
        }

        private void GetDepartementTable()
        {
            dgtBoard.Rows.Clear();

            dgtConnections.Visible = false;
            dgtBoard.Visible = true;

            Transport transport = new Transport();
            StationBoardRoot stationBoardRoot = new StationBoardRoot();

            // Error gets thrown when no stationboard can be found
            try
            {
                stationBoardRoot = transport.GetStationBoard(cmbFrom.Text);

                foreach (StationBoard stationBoard in stationBoardRoot.Entries)
                {

                    dgtBoard.Rows.Add(Convert.ToDateTime(stationBoard.Stop.Departure).ToString("HH:mm"),
                        stationBoard.Stop.Platform,
                        stationBoard.To
                        );

                }
            } catch (Exception exc)
            {
                dialogs.ShowNoStationBoardFoundDialog(cmbFrom.Text);
            }

        }

        private void GetNextConnections()
        {
            dgtConnections.Rows.Clear();

            dgtConnections.Visible = true;
            dgtBoard.Visible = false;

            Connections connections = new Connections();
            Transport transport = new Transport();

            // Error gets thrown when from or to station is an address  |   
            // Bäckerei Café Bachmann Länderpark, Stans, Bitzistr. 2  <-|        
            try
            {
                connections = transport.GetConnections(cmbFrom.Text, cmbTo.Text, dtpTime.Value.ToString("HH:mm"),
                    dtpDate.Value.ToString("yyyy-MM-dd"));

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

                }
}
            catch (Exception exc)
            {
                dialogs.ShowNoConnectionFoundDialog(cmbFrom.Text, cmbTo.Text);
            }
        }

        private void Exchange_Click(object sender, EventArgs e)
        {
            string from = cmbFrom.Text;
            string to = cmbTo.Text;

            cmbFrom.Text = to;
            cmbTo.Text = from;
        }

        private void Autocomplete_KeyUp(object sender, KeyEventArgs e)
        {
            Transport transport = new Transport();
            Stations stations = new Stations();
            ComboBox myInput = (ComboBox)sender;

            myInput.DroppedDown = true;
            Cursor.Current = Cursors.Default;

            if (myInput.Text.Length >= 2)
            {
                stations = transport.GetStations(myInput.Text);

                List<Station> stationList = stations.StationList;
                List<string> stationNames = new List<string>();
                string inputText = myInput.Text;

                if (stationList.Count > 1)
                {
                    foreach (Station station in stationList)
                    {
                        try
                        {
                            stationNames.Add(station.Name);
                        }
                        catch (ArgumentNullException exc)
                        {
                            Console.WriteLine(exc.StackTrace);
                        }
                    }

                    // Clears combobox leaves input and puts cursor on string end
                    myInput.Items.Clear();
                    myInput.Text = inputText;
                    myInput.Select(inputText.Length, 0);

                    try
                    {
                        myInput.Items.AddRange(stationNames.ToArray());
                    } catch(ArgumentNullException ex)
                    {
                        Console.WriteLine(ex.StackTrace);
                    }

                    
                }
            }
        }
        /*
        private void Map_Click(object sender, EventArgs e)
        {
            StringBuilder location = new StringBuilder("http://maps.google.com/maps?q=&#8221");
            if (cmb) {
            location.Append

            System.Diagnostics.Process.Start(location.ToString());

        }
        */
    }
}
