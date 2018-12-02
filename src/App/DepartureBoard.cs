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
    public partial class DepartureBoard : Form
    {
        Transport transport = new Transport();

        public DepartureBoard(string stationName, string stationId)
        {
            InitializeComponent();
            InitializeDataGridView();
            lblStation.Text = stationName;

            ShowStationBoardEntries(stationName, stationId);

        }

        private void InitializeDataGridView()
        {
            // code
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

        private void datStationBoard_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
