using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using REYSAL.Models;
using System.Net.Mail;
using System.Net;

namespace REYSAL.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Contactanos()
        {
            return View();
        }

        public IActionResult Galeria()
        {
            return View();
        }

        public IActionResult Eventos()
        {
            return View();
        }

        public IActionResult Testimonios()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Contactanos(CorreoModel model)
        {
            if (ModelState.IsValid)
            {
                using (MailMessage mm = new MailMessage(model.Correo, "vania@reysalcapacitaciones.com"))
                {
                    mm.Subject = model.Asunto;
                    mm.Body = "Nombre: " + model.Nombre + " Telefono" + model.Telefono + " Correo:" + model.Correo;
                    //if (model.Adjunto.ContentLength > 0 && model.Adjunto != null)
                    //{
                    //    string fileName = Path.GetFileName(model.Adjunto.FileName);
                    //    mm.Attachments.Add(new Attachment(model.Adjunto.InputStream, fileName));
                    //}

                    mm.IsBodyHtml = false;
                    using (SmtpClient smtp = new SmtpClient())
                    {
                        smtp.Host = "smtp.reysalcapacitaciones.com";
                        //smtp.Host = "smtp.outlook.com";
                        //smtp.Host = "192.XXX.X.XXX";  // IP empresa/institucional
                        //smtp.Host = "smtp.gmail.com";
                        //Para usar estas funciones, descomenta la opcion del correo de origen que estes utilizando, en caso de usar gmail configura previamente tu cuenta https://www.youtube.com/watch?v=i5O6rtkeozY
                        smtp.EnableSsl = true;
                        NetworkCredential NetworkCred = new NetworkCredential("vania@reysalcapacitaciones.com", "Vania123@");
                        smtp.UseDefaultCredentials = true;
                        smtp.Credentials = NetworkCred;
                        smtp.Port = 587;
                        smtp.Send(mm);
                        mm.Dispose();
                        smtp.Dispose();
                        return RedirectToAction("Sent");
                    }
                }
            }
            return View();
        }

    }
}
