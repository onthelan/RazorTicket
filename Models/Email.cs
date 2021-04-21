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
            message.From.Add (new MailboxAddress ("Wake ROD", ""));
            message.To.Add (new MailboxAddress (ToName, ToEmail));

            message.Subject = subject;
            message.Body = new TextPart("plain")
            {
                Text = body
            };

            using (var client = new SmtpClient ())
            {
                client.ServerCertificateValidationCallback = (s, c, h, e) => true;
                client.Connect ("", 465, false);
                
				// Note: only needed if the SMTP server requires authentication
				client.Authenticate ("", "");

				client.Send (message);
				client.Disconnect (true);
			}
        }
    }
}