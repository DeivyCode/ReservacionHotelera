using Hotel.Comunes;
using Hotel.Data.Interfaces;
using Hotel.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;

namespace Hotel.Data.Repositorio
{
    public class HotelRepositoryImp : IHotelRepository
    {

        private readonly HotelDbContext context;

        public string MessageError { get; private set; }

        public ICollection<Models.Hotel> ObtenerHoteles()
        {
            return context.Hotel
                .Include(c => c.Categoria)
                .Include(a => a.Administrador)
                .ToList();
        }

        public ICollection<Habitacion> ObtenerHabitaciones()
        {
            return context.Habitaciones.ToList();
        }

        public HotelRepositoryImp(HotelDbContext context)
        {
            this.context = context;
        }

        public bool CrearEditarHabitacion(Habitacion model, Acciones acciones)
        {
            try
            {
                if (model == null) return false;

                if (acciones == Acciones.Editar)
                {
                    //Verificar Id
                    if (model.IdHabitacion == 0)
                    {
                        throw new Exception($"Habitacion con Id {model?.IdHabitacion}, no se puede actualizar");
                    }

                    var entry = context.ChangeTracker.Entries<Habitacion>()
                                                     .FirstOrDefault(x => x.Entity.IdHabitacion == model.IdHabitacion);

                    if (entry == null)
                    {
                        context.Update(model);
                    }
                    else
                    {
                        entry.CurrentValues.SetValues(model);
                    }

                    if (context.SaveChanges() > 0) return true;

                    return false;
                }

                context.Habitaciones.Add(model);

                if (context.SaveChanges() > 0) return true;

                return false;
            }
            catch (Exception ex)
            {
                MessageError = $"{ex.Message} - INNER  {ex.InnerException?.Message}";
                return false;
            }
        }

        public bool CrearEditarHotel(Models.Hotel model, Acciones acciones)
        {
            try
            {
                if (model == null) return false;

                if (acciones == Acciones.Editar)
                {
                    if (model.IdHotel == 0)
                        throw new Exception($"Hotel con id {model.IdHotel} no se puede actualizar.");

                    var entry = context.ChangeTracker.Entries<Models.Hotel>()
                                    .FirstOrDefault(x => x.Entity.IdHotel == model.IdHotel);

                    if (entry == null)
                    {
                        context.Update(model);
                    }
                    else
                    {
                        entry.CurrentValues.SetValues(model);
                    }

                    if (context.SaveChanges() > 0) return true;

                    return false;
                }
                context.ChangeTracker.Clear();
                context.Hotel.Add(model);

                if (context.SaveChanges() > 0) return true;

                return false;

            }
            catch (Exception ex)
            {
                MessageError = $"{ex.Message} - INNER  {ex.InnerException?.Message}";
                return false;
            }
        }

        public bool CrearEditarTipoHabitacion(TipoHabitacion model, Acciones acciones)
        {
            try
            {
                if (model == null) return false;

                var entry = context.ChangeTracker.Entries<TipoHabitacion>()
                    .FirstOrDefault(x => x.Entity.IdHotel == model.IdHotel && x.Entity.IdHabitacion == model.IdHabitacion);

                if (acciones == Acciones.Editar)
                {
                    if (model.IdHotel == 0 || model.IdHabitacion == 0)
                        throw new Exception($"Tipo de habitacion el Id Hotel {model.IdHotel} y Id Habitacion {model.IdHabitacion} no se puede actualizar");

                    if (entry == null)
                    {
                        context.Update(model);
                    }
                    else
                    {
                        entry.CurrentValues.SetValues(model);
                    }

                    return context.SaveChanges() > 0;
                }

                // Verificar si ya existe un tipo de reservacion para esta habitacion y hotel
                var tipoHabitacion = context.TipoHabitacion.FirstOrDefault(x =>
                    x.IdHotel == model.IdHotel && x.IdHabitacion == model.IdHabitacion);

                if (tipoHabitacion != null)
                {
                    MessageError = $@"Ya existe un tipo de habitacion para el hotel{model?.Hotel?.Nombre} y la habitacion con ID {model.IdHabitacion}";
                    return false;
                }

                context.ChangeTracker.Clear();

                context.TipoHabitacion.Add(model);

                return context.SaveChanges() > 0;
            }
            catch (Exception ex)
            {
                MessageError = $"{ex.Message} - INNER  {ex.InnerException?.Message}";
                return false;
            }
        }

        public bool CrearReservacion(Reserva model)
        {
            using var transaction = context.Database.BeginTransaction();

            try
            {
                if (model == null) return false;

                context.ChangeTracker.Clear();
                context.Reservaciones.Add(model);

                if (context.SaveChanges() > 0)
                {
                    transaction.Commit();
                    return true;
                }

                transaction.Rollback();
                return false;
            }
            catch (Exception e)
            {
                MessageError = $"{e?.Message} {e?.InnerException}";
                transaction.Rollback();
                return false;
            }
        }
    }
}
