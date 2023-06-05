using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Proyecto.Models;

public class Cita
{
    public Cita(Guid idcita, string fecha, string horainicio, string horafinal, bool disponible, especialidad especialidad, Guid idpaciente, Guid idodoctor){
    this.idcita = idcita;
    this.fecha = fecha;
    this.horainicio = horainicio;
    this.horafinal = horafinal;
    this.disponible = disponible;
    this.Especialidad = especialidad;
    this.idpaciente = idpaciente;
    this.idodoctor = idodoctor;
    }
    public Guid idcita { get; set; }

    [Required]
    public string fecha { get; set; }

    public string horainicio { get; set; }

    public string horafinal { get; set; }

    public bool disponible { get; set; }

    public string disponibletex => disponible ? "SI" : "NO";

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

    [ForeignKey("idpaciente")]
    public Guid idpaciente { get; set; }

    [ForeignKey("iddoctor")]
    public Guid idodoctor { get; set; }
    public virtual ICollection<Paciente> Pacientes { get; set; }
    public virtual ICollection<Doctor> Doctors { get; set; }
}