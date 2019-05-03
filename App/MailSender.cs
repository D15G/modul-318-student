using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;
using System.Text;

namespace App
{
    /// <summary>
    /// Class that sends emails
    /// </summary>
    class MailSender
    {
        /// <summary>
        /// Sends a mail with the connection data
        /// </summary>
        /// <param name="from"></param>
        /// <param name="to"></param>
        /// <param name="password"></param>
        /// <param name="smtpServer"></param>
        /// <param name="smtpPort"></param>
        /// <param name="dgtContent"></param>
        public void SendMail(string from, 
            string to, 
            string password, 
            string smtpServer, 
            int smtpPort,
            List<string> dgtContent)
        {
            MailMessage message = new MailMessage(from, to);
            message.Subject = "Sieh dir diese Verbindungen an";
            message.Body = FormatTable(dgtContent);
            SmtpClient client = new SmtpClient(smtpServer, smtpPort);
            client.EnableSsl = true;
            client.UseDefaultCredentials = false;
            client.Credentials = new NetworkCredential(from, password);

            try
            {
                client.Send(message);
            } catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
            }
        }

        private string FormatTable(List<string> dgtContent)
        {
            StringBuilder bodyContent = new StringBuilder();

            foreach (string row in dgtContent)
            {
                bodyContent.Append(row + "\n");
            }

            return bodyContent.ToString();
        }
    }
}
