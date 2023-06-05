using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Proyecto.Models;

public class Cita
{

    [Key]
    public Guid idcita { get; set; }

    [Required]
    public string fecha { get; set; }

    public string horainicio { get; set; }

    public string horafinal { get; set; }

    public bool disponible { get; set; }

    public string disponibletex => disponible ? "SI" : "NO";

    [ForeignKey("especialidad")]
    public especialidad especialidad { get; set; }

    [ForeignKey("idpaciente")]
    public Guid idpaciente { get; set; }

    [ForeignKey("iddoctor")]
    public Guid idodoctor { get; set; }
    
}