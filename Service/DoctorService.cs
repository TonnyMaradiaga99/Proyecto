using System;
using Proyecto.Models;

namespace Proyecto.Service
{
public class DoctorService : IDoctorService
{
    context context;

    public DoctorService(context _context)
    {
        context = _context;
    }

    //CRUD

    public async Task CreateAsync(Doctor newDoctor)
    {
        newDoctor.iddoctor = Guid.NewGuid();
        await context.AddAsync<Doctor>(newDoctor);
        await context.SaveChangesAsync();
    }

    public IEnumerable<Doctor> Get()
    {
        return context.Doctor;
    }

    public async Task Update(Guid id, Doctor updDoctor)
    {
        var Doctor = context.Doctor.Find(id);
        if (Doctor != null)
        {
            Doctor.iddoctor = updDoctor.iddoctor;
            Doctor.nombre = updDoctor.nombre;
            Doctor.telefono = updDoctor.telefono;
            Doctor.correo = updDoctor.correo;
            Doctor.experiencia = updDoctor.experiencia;
            Doctor.user = updDoctor.user;
            Doctor.password = updDoctor.password;
            Doctor.Especialidad = updDoctor.Especialidad;
        

            context.Update(Doctor);
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


public interface IDoctorService
{
    Task CreateAsync(Doctor newDoctor);

    IEnumerable<Doctor> Get();

    Task Update(Guid id, Doctor updDoctor);

    Task Delete(Guid id);
    
}