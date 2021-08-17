using System.ComponentModel.DataAnnotations;

namespace REYSAL.Models
{
    public class CorreoModel
    {
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string Correo { get; set; }
        [Required]
        public string Telefono { get; set; }
        [Required]
        public string Asunto { get; set; }

        //public HttpPostedFileBase Adjunto { get; set; }
    }
}
