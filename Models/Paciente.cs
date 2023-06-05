using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Proyecto.Models
{
    public class Paciente
    {
        [Key]
        [MaxLength(10)]
        public Guid idpaciente{ get; set; }

        [Required]
        [MaxLength(100)]
        public string nombre{ get; set; }


        public int edad{ get; set; }

        public bool sexo{ get; set; }

        public string sexotex => sexo ? "Masculino" : "Femenino";

        public int telefono{ get; set; }

        public string correo{ get; set; }

        public string user{ get; set; }

        public string password{ get; set; }
        public virtual ICollection<Cita> Citas { get; set; }
    }
}