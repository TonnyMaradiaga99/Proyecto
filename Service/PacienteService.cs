using System;
using Proyecto.Models;

namespace Proyecto.Service
{
public class PacienteService : IPacienteService
{
    context context;

    public PacienteService(context _context)
    {
        context = _context;
    }

    //CRUD

    public async Task CreateAsync(Paciente newPaciente)
    {
        newPaciente.idpaciente = Guid.NewGuid();
        await context.AddAsync<Paciente>(newPaciente);
        await context.SaveChangesAsync();
    }

    public IEnumerable<Paciente> Get()
    {
        return context.Paciente;
    }

    public async Task Update(Guid id, Paciente updPaciente)
    {
        var Paciente = context.Paciente.Find(id);
        if (Paciente != null)
        {
            Paciente.idpaciente = updPaciente.idpaciente;
            Paciente.nombre = updPaciente.nombre;
            Paciente.edad = updPaciente.edad;
            Paciente.sexo = updPaciente.sexo;
            Paciente.telefono = updPaciente.telefono;
            Paciente.correo = updPaciente.correo;
            Paciente.user = updPaciente.user;
            Paciente.password = updPaciente.password;
        

            context.Update(Paciente);
            await context.SaveChangesAsync();
        }
    }
    
    public async Task Delete(Guid id)
    {
        var Doctor = context.Doctor.Find(id);
        if (Doctor != null)
        {
            context.Remove(Doctor);
            await context.SaveChangesAsync();
        }
    }


}
}


public interface IPacienteService
{
    Task CreateAsync(Paciente newPaciente);

    IEnumerable<Paciente> Get();

    Task Update(Guid id, Paciente updPaciente);

    Task Delete(Guid id);
    
}