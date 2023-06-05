using System;
using Proyecto.Models;

namespace Proyecto.Service
{
public class CitaService : ICitaService
{
    context context;

    public CitaService(context _context)
    {
        context = _context;
    }

    //CRUD

    public async Task CreateAsync(Cita newCita)
    {
        newCita.idcita = Guid.NewGuid();
        await context.AddAsync<Cita>(newCita);
        await context.SaveChangesAsync();
    }

    public IEnumerable<Cita> Get()
    {
        return context.Cita;
    }

    public async Task Update(Guid id, Cita updCita)
    {
        var Cita = context.Cita.Find(id);
        if (Cita != null)
        {
            Cita.idcita = updCita.idcita;
            Cita.fecha = updCita.fecha;
            Cita.horainicio = updCita.horainicio;
            Cita.horafinal = updCita.horafinal;
            Cita.disponible = updCita.disponible;

            context.Update(Cita);
            await context.SaveChangesAsync();
        }
    }
    
    public async Task Delete(Guid id)
    {
        var Cita = context.Cita.Find(id);
        if (Cita != null)
        {
            context.Remove(Cita);
            await context.SaveChangesAsync();
        }
    }


}
}


public interface ICitaService
{
    Task CreateAsync(Cita newCita);

    IEnumerable<Cita> Get();

    Task Update(Guid id, Cita updCita);

    Task Delete(Guid id);
    
}