using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Proyecto.Models
{
    public class Doctor
    {
        [Key]
        [MaxLength(10)]
        public Guid iddoctor{ get; set;}

        [Required]
        [MaxLength(100)]
        public string nombre{ get; set;}

        public string telefono{ get; set;}

        public string correo{ get; set;}

        public string experiencia { get; set;}

        public string user { get; set;}

        public string password{ get; set;}

        public especialidad Especialidad { get; set;}
        public enum especialidad
        {
            Cardiología,
            Endocrinología,
            Hematología,
            Nefrología,
            Neumología,
            Neurología,
            Oncología,
            Pedriatría,
            Psquiatría,
            Rehabilitación,
            Reumatología,
            Obstetricia,
            Ginecología,
            Oftalmología,
            Otorrinolaringología,
            Urología,
            
        }
        public virtual ICollection<Cita> Citas { get; set; }
    }
}