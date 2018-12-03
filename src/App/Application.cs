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
            
            // lstForm
            lstFrom.DisplayMember = "Name";
            lstFrom.ValueMember = "Id";

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
            if (toStations.Count != 0)
            {
                cboTo.DataSource = toStations;
                //cboTo.SelectedIndex = 0;
                cboTo.DroppedDown = true;

                lstFrom.DataSource = fromStations;
            }

        }

        private void ShowFromStations()
        {
            if ((fromStations.Count != 0) && (cboFrom.SelectedValue == null))
            {
                cboFrom.DataSource = fromStations;
                //cboFrom.SelectedIndex = 0;
                cboFrom.DroppedDown = true;
                //var autoComplete = new AutoCompleteStringCollection();
                //var array = fromStations.Select(o => o.Name).ToArray();
                //autoComplete.AddRange(array);

                //cboFrom.AutoCompleteCustomSource = autoComplete;
            }          
        }

        private void ShowConnections()
        {
            ToUserFriendly toUserFriendly = new ToUserFriendly();

            if (connections.Count != 0)
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
            if ((lstFrom.Visible == true))
            {
                if (lstFrom.Text != txtFrom.Text)
                {
                    lstFrom.Visible = false;
                    txtFrom.Text = lstFrom.Text;
                }
                //if (lstFrom.Items.Count > 0)
                //{
                //    lstFrom.SelectedIndex = 0;
                //    lstFrom.Visible = false;
                //    txtFrom.Text = lstFrom.Text;
                //}
            }
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
            //SetFirstAsToStation();

        }

        private void lstFrom_Leave(object sender, EventArgs e)
        {
            SetToStation();
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
            SetToStation();
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
            if (cboFrom.SelectedValue != null)
            {
                ShowStationBoard(cboFrom.Text, cboFrom.SelectedValue.ToString());
            }
            else
            {
                MessageBox.Show("Die Abfahrtsstation ist ungültig.", "Ungültige Station", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void btnToStationBoard_Click(object sender, EventArgs e)
        {
            if (cboTo.SelectedValue != null)
            {
                ShowStationBoard(cboTo.Text, cboTo.SelectedValue.ToString());
            }
            else
            {
                MessageBox.Show("Die Zielstation ist ungültig.", "Ungültige Station", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void cboFrom_TextChanged(object sender, EventArgs e)
        {
            fromStations = GetStations(cboFrom.Text);
            ShowFromStations();

            //cboFrom.DataSource = fromStations;

            //if (toStations.Count != 0 && toStations != null)
            //{
            //    cboFrom.DroppedDown = true;
            //}
            //else
            //{
            //    cboFrom.DroppedDown = false;
            //}
        }

        private void cboTo_TextChanged(object sender, EventArgs e)
        {
            toStations = GetStations(cboTo.Text);
            ShowToStations();
        }
    }
}
