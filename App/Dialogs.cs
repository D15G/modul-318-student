using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App
{
    /*
     * Class that contains all of the dialogs
     */
    class Dialogs
    {
        /// <summary>
        /// Shows info dialog if there are no connections found
        /// </summary>
        /// <param name="from"></param>
        /// <param name="to"></param>
        public void ShowNoConnectionFoundDialog(string from, string to)
        {
            MessageBox.Show("Zwischen den Stationen: " + from + " und "
                    + to + " wurden keine Verbindungen gefunden.",
                    "Keine Verbindung gefunden", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
        }

        /// <summary>
        /// Shows warning dialog if a station is put in twice
        /// </summary>
        /// <param name="station"></param>
        public void ShowStationsTheSameDialog(string station)
        {
            MessageBox.Show("Sie haben die Station: " + station + " zweimal eingegeben!",
                        "Beide Stationen sind gleich", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
        }

        /// <summary>
        /// Shows warning dialog if from station is empty
        /// </summary>
        public void ShowMissingFromStationDialog()
        {
            MessageBox.Show("Sie müssen die von Station eintragen", "Von Station leer",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        /// <summary>
        /// Shows information dialog if no stationboard found
        /// </summary>
        /// <param name="station"></param>
        public void ShowNoStationBoardFoundDialog(string station)
        {
            MessageBox.Show("Keine Abfahrtstafel für: " + station + " gefunden", "Keine Abfahrtstafel gefunden",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
