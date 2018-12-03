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
    public partial class frmDepartureBoard : Form
    {
        Transport transport = new Transport();

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void MoveForm(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        public frmDepartureBoard(string stationName, string stationId)
        {
            InitializeComponent();
            InitializeDataGridView();
            lblStation.Text = "Abfahrtstafel - " + stationName;

            ShowStationBoardEntries(stationName, stationId);

        }

        private void InitializeDataGridView()
        {
            datStationBoard.BorderStyle = BorderStyle.None;
        }

        private void ShowStationBoardEntries(string stationName, string stationId)
        {
            ToUserFriendly toUserFriendly = new ToUserFriendly();
            List<StationBoard> stationBoardEntries = GetStationBoardEntries(stationName, stationId);

            var stationBoardList = from stationBoardEntry in stationBoardEntries
                               select new
                               {
                                   Abfahrtszeit = stationBoardEntry.Stop.Departure.ToShortTimeString(),
                                   Zug          = stationBoardEntry.Name,
                                   Richtung     = stationBoardEntry.To
                               };

            datStationBoard.DataSource = stationBoardList.ToList();
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

        ////////////////////
        // GUI Events
        //

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
