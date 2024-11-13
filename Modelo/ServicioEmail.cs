using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;
namespace BDS.Modelo
{
    public class ServicioEmail
    {
        public static void EnviarCorreo(string Email, string codigo)
        {
            try
            {
                MailMessage msg = new MailMessage();
                msg.From= new MailAddress("portilloheisel16@gmail.com");
                msg.To.Add(Email);
                msg.Subject = "Código de Verificación para Restablecer Contraseña";
                msg.Body = $"El codigo para restablecer tu contraseña es :{ codigo}. Valido por 15 minutos";

                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com");
                smtpClient.Port = 587;
                smtpClient.Credentials = new NetworkCredential("portilloheisel16@gmail.com", "heisel1590p*");
                smtpClient.EnableSsl = true;

                smtpClient.Send(msg);
            }
            catch(Exception ex) {
                Console.WriteLine("Error al enviar correo: " + ex.Message);
            }
        }
    }
}
