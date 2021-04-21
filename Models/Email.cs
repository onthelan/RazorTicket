using System;
using System.Collections.Generic;
using MimeKit;
using MailKit.Net.Smtp;

namespace RazorTicket.Models
{
    public class EmailAlert
    {
        //public string ToEmail { get; set; }
        //public string FromEmail { get; set; }

        public static void Send(string subject, string body, string ToName, string ToEmail)
        {
            var message = new MimeMessage();
            message.From.Add (new MailboxAddress ("Wake ROD", "christopher.peck@wakegov.com"));
            message.To.Add (new MailboxAddress (ToName, ToEmail));

            message.Subject = subject;
            message.Body = new TextPart("plain")
            {
                Text = body
            };

            using (var client = new SmtpClient ())
            {
                client.ServerCertificateValidationCallback = (s, c, h, e) => true;
                client.Connect ("smtprelay.wakegov.com", 465, false);
                
				// Note: only needed if the SMTP server requires authentication
				client.Authenticate ("christopher.peck@wakegov.com", "S1Ch!L3bV!");

				client.Send (message);
				client.Disconnect (true);
			}
        }
    }
}