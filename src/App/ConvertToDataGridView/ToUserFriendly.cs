﻿using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.ConvertToDataGridView
{
    public class ToUserFriendly
    {        
        /// <summary>
        /// Wandelt den string Duration Wert in einen "benutzerfreundlichen" string
        /// </summary>
        /// <param name="duration"></param>
        /// <returns></returns>
        public string ConvertDuration(string duration)
        {
            string durationConverted = null;

            try
            {
                if (duration.Length == 11)
                {
                    int days = Convert.ToInt32(duration.Substring(0, 2));
                    int hours = Convert.ToInt32(duration.Substring(3, 2));
                    int minutes = Convert.ToInt32(duration.Substring(6, 2));

                    // Convert Days
                    if (days != 0)
                    {
                        durationConverted += (days + " d"); // Beispiel: 1 d
                    }

                    if (hours != 0)
                    {
                        if (durationConverted != null)
                            durationConverted += " ";

                        durationConverted += (hours + " h"); // Beispiel: 3 h

                    }

                    if (minutes != 0)
                    {
                        if (durationConverted != null)
                            durationConverted += " ";

                        durationConverted += (minutes + " min");  // Beispiel: 35 min
                    }
                }
            }
            catch (Exception ex)
            {
                ShowException(ex);
            }

            return durationConverted;
        }

        /// <summary>
        /// Formatiert den departureTime Wert in einen user-friendly Darstellung
        /// </summary>
        /// <param name="departureTime"></param>
        /// <returns></returns>
        public string ConvertDepartureTime(string departureTime)
        {
            string departureTimeConverted = null;
            DateTime date = new DateTime();

            try
            {
                date = DateTime.Parse(departureTime);

                departureTimeConverted = date.ToShortTimeString();
            }
            catch (Exception ex)
            {
                ShowException(ex);
            }

            return departureTimeConverted;
        }

        private void ShowException(Exception ex)
        {
            MessageBox.Show(ex.ToString());
        }
    }
}