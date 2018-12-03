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
using System.Runtime.InteropServices;

namespace App
{
    public partial class frmApplication : Form
    {
        ITransport transport = new Transport();
        List<Station> fromStations = new List<Station>();
        List<Station> toStations = new List<Station>();
        List<Connection> connections = new List<Connection>();
        bool isArrivalTime = false;

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void MoveForm(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        public frmApplication()
        {
            InitializeComponent();
            InitializeControls();
            InitializeDataGrid();
        }



        private void InitializeControls()
        {
            // Form
            this.Height = 180;

            // cboFrom

            // lblTitle
            lblTitle.Text = this.Text;
            
            // lstFromStations
            lstFromStations.DisplayMember = "Name";
            lstFromStations.ValueMember = "Id";
            lstFromStations.BringToFront();
            lstFromStations.Visible = false;


            // lstToStations
            lstToStations.DisplayMember = "Name";
            lstToStations.ValueMember = "Id";
            lstToStations.BringToFront();
            lstToStations.Visible = false;

            // dtpTime
            dtpTime.Value = DateTime.Now;


            // dtpDate
            dtpDate.Value = DateTime.Now;
        }

        private void InitializeDataGrid()
        {
            datConnections.Visible = false;
            datConnections.BorderStyle = BorderStyle.None;
        }

        private void ShowToStations()
        {
            if (toStations.Count > 0 && txtToStation.Focused == true)
            {
                lstToStations.BringToFront();
                lstToStations.DataSource = toStations;
                lstToStations.Visible = true;
            }
            else
            {
                lstToStations.Visible = false;
            }

        }

        private void ShowFromStations()
        {
            if (fromStations.Count > 0 && txtFromStation.Focused == true)
            {
                lstFromStations.BringToFront();
                lstFromStations.DataSource = fromStations;
                lstFromStations.Visible = true;
            }
            else
            {
                lstFromStations.Visible = false;
            }
        }

        private void ShowConnections()
        {
            ToUserFriendly toUserFriendly = new ToUserFriendly();

            if (connections.Count > 0)
            {
                var connectionList = from connection in connections
                                     select new
                                     {
                                         Dauer = toUserFriendly.ConvertDuration(connection.Duration), // ConvertDurationToTimeSpan(connection.Duration)., 
                                         Von = connection.From.Station.Name,
                                         Abfahrtszeit = Convert.ToDateTime(connection.From.Departure).ToString("hh:MM"),
                                         Nach = connection.To.Station.Name,
                                         Ankunftszeit = Convert.ToDateTime(connection.To.Arrival).ToString("hh:MM")
                                     };
                datConnections.DataSource = connectionList.ToList();
                datConnections.Refresh();
                datConnections.Visible = true;
                this.Height = 450;
            }
            else
            {
                datConnections.Visible = false;
                this.Height = 180;
            }
        }
        private void ShowStationBoard(string station, string id)
        {
            try
            {
                frmDepartureBoard departureBoard = new frmDepartureBoard(station, id);
                departureBoard.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Station ist ungültig.\n\n" +
                                "Details:\n" + ex,
                                "Ungültig",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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
                string time = dtpTime.Value.ToString("hh:MM");
                string date = dtpDate.Value.ToString("dd-MM-yyyy");
                
                connections = transport.GetConnections(fromStation, toStation, time, date, Convert.ToInt32(isArrivalTime)).ConnectionList;
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

        private void SetToStation()
        {
            if ((lstToStations.Visible == true))
            {
                if (lstToStations.Text != txtToStation.Text)
                {
                    lstToStations.Visible = false;
                    txtToStation.Text = lstToStations.Text;
                }
            }
        }

        private void SetFromStation()
        {
            if ((lstFromStations.Visible == true))
            {
                if (lstFromStations.Text != txtFromStation.Text)
                {
                    lstFromStations.Visible = false;
                    txtFromStation.Text = lstFromStations.Text;
                }
            }
        }

        // 
        // GUI-Events
        //
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnSearchConnections_Click(object sender, EventArgs e)
        {
            lstToStations.Visible = false;
            lstFromStations.Visible = false;
            btnSearchConnections.Focus();

            //if (lstFromStations.SelectedValue == null)
            //{
            //    fromStations = GetStations(txtFromStation.Text);
            //}
            //if (lstToStations.SelectedValue == null)
            //{
            //    toStations = GetStations(txtToStation.Text);
            //}

            connections = GetConnections(txtFromStation.Text, txtToStation.Text);
            ShowConnections();
        }

        private void txtFromStation_TextChanged(object sender, EventArgs e)
        {
            tmrFromStation.Stop();
            tmrFromStation.Start();
            fromStations.Clear();
            
        }

        private void txtToStation_TextChanged(object sender, EventArgs e)
        {
            toStations = GetStations(txtToStation.Text);
            ShowToStations();
        }

        private void txtFromStation_Leave(object sender, EventArgs e)
        {
            //ShowFromStations();
            tmrFromStation.Stop();
            if (lstFromStations.Items.Count > 0)
            {
                if (txtFromStation.Text != lstFromStations.Text && lstFromStations.Focused == false)
                {
                    txtFromStation.Text = lstFromStations.Text;
                    lstFromStations.Visible = false;
                }
            }
        }

        private void txtToStation_Leave(object sender, EventArgs e)
        {
            //ShowToStations();
            tmrToStation.Stop();
            if (lstToStations.Items.Count > 0)
            {
                if (txtToStation.Text != lstToStations.Text && lstToStations.Focused == false)
                {
                    txtToStation.Text = lstToStations.Text;
                    lstToStations.Visible = false;
                }
            }
        }

        private void txtFrom_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtFromStation.Focused)
            {
                if (lstFromStations.Items.Count != 0)
                {
                    if ((lstFromStations.SelectedIndex != (lstFromStations.Items.Count - 1))
                        && (e.KeyCode == Keys.Down))
                    {
                        lstFromStations.SelectedIndex++;
                    }
                    if ((lstFromStations.SelectedIndex != 0)
                        && (e.KeyCode == Keys.Up))
                    {
                        lstFromStations.SelectedIndex--;
                    }
                }

                if (e.KeyCode == Keys.Enter)
                {
                    txtFromStation.Text = lstFromStations.Text;
                }
            }
        }

        private void txtFromStation_Click(object sender, EventArgs e)
        {
            txtFromStation.SelectAll();
            ShowFromStations();
        }

        private void lstFromStations_Click(object sender, EventArgs e)
        {
            lstFromStations.Visible = false;
            txtFromStation.Text = lstFromStations.Text;
        }

        private void lstFromStations_Leave(object sender, EventArgs e)
        {
            SetFromStation();
        }

        private void Application_Load(object sender, EventArgs e)
        {
            //this.ControlBox = false;
            //this.Text = String.Empty;
            //this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void btnIsArrivalTime_Click(object sender, EventArgs e)
        {
            if (isArrivalTime)
            {
                isArrivalTime = false;
                btnIsArrivalTime.Text = "Abfahrtszeit";
            }
            else
            {
                isArrivalTime = true;
                btnIsArrivalTime.Text = "Ankunftszeit";
            }
        }

        private void btnFromStationBoard_Click(object sender, EventArgs e)
        {
            if (lstFromStations.SelectedValue != null)
            {
                ShowStationBoard(lstFromStations.Text, lstFromStations.SelectedValue.ToString());
            }
            else
            {
                MessageBox.Show("Die Abfahrtsstation ist ungültig.", "Ungültige Station", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void btnToStationBoard_Click(object sender, EventArgs e)
        {
            if (lstToStations.SelectedValue != null)
            {
                ShowStationBoard(lstToStations.Text, lstToStations.SelectedValue.ToString());
            }
            else
            {
                MessageBox.Show("Die Zielstation ist ungültig.", "Ungültige Station", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtToStation_Enter(object sender, EventArgs e)
        {
            txtToStation.SelectAll();
            ShowToStations();
        }

        private void txtToStation_Click(object sender, EventArgs e)
        {
            txtToStation.SelectAll();
            ShowToStations();
        }

        private void txtFromStation_Enter(object sender, EventArgs e)
        {
            txtFromStation.SelectAll();
            ShowFromStations();
        }

        private void tmrFromStation_Tick(object sender, EventArgs e)
        {
            tmrFromStation.Stop();
            fromStations = GetStations(txtFromStation.Text);
            ShowFromStations();
        }

        private void tmrToStation_Tick(object sender, EventArgs e)
        {
            tmrFromStation.Stop();
            toStations = GetStations(txtToStation.Text);
            ShowToStations();
        }

        private void btnChangeStations_Click(object sender, EventArgs e)
        {
            var tempStations = fromStations;
            var tempStation = txtFromStation.Text;

            fromStations = toStations;
            txtFromStation.Text = txtToStation.Text;

            toStations = tempStations;
            txtToStation.Text = tempStation;

            ShowToStations();
            ShowFromStations();
        }

        private void lstToStations_Leave(object sender, EventArgs e)
        {
            SetToStation();
        }

        private void lstToStations_Click(object sender, EventArgs e)
        {
            lstToStations.Visible = false;
            txtToStation.Text = lstToStations.Text;
        }
    }
}
