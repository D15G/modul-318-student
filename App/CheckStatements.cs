using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    /*
     * Class that contains some checks
     */
    class CheckStatements
    {
        /// <summary>
        /// Checks if the from and to inputs are empty
        /// </summary>
        /// <param name="from"></param>
        /// <param name="to"></param>
        /// <returns>true or false</returns>
        public bool CheckIfFromAndToAreEmpty(string from, string to)
        {
            if (!from.Equals("") && !to.Equals(""))
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// Checks if the input is for searching the stationboard
        /// </summary>
        /// <param name="from"></param>
        /// <param name="to"></param>
        /// <returns></returns>
        public bool CheckIfSearchingStationBoard(string from, string to)
        {
            if (!from.Equals("") && to.Equals(""))
            {
                return true;
            }
            return false;
        }
    }
}
