using Hotel.Comunes;
using Hotel.Data.Interfaces;
using Hotel.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Data.Repositorio
{
    public class HotelRepositoryImp : IHotelRepository
    {

        private readonly HotelDbContext context;
        private string messageError;

        public string MessageError
        {
            get
            {
                return messageError;
            }
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
                    context.Entry(model).State = EntityState.Detached;
                    context.Update(model);
                    if (context.SaveChanges() > 0) return true;


                    return false;
                }

                context.Habitaciones.Add(model);

                if (context.SaveChanges() > 0) return true;

                return false;
            }
            catch (Exception ex)
            {
                messageError = $"{ex.Message} - INNER  {ex.InnerException?.Message}";
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
                    context.Entry(model).State = EntityState.Modified;

                    if (context.SaveChanges() > 0) return true;

                    return false;
                }

                context.Hotel.Add(model);

                if (context.SaveChanges() > 0) return true;

                return false;

            }
            catch (Exception ex)
            {
                messageError = $"{ex.Message} - INNER  {ex.InnerException?.Message}";
                return false;
            }
        }

        public bool CrearEditarTipoHabitacion(TipoHabitacion model, Acciones acciones)
        {
            try
            {
                if (model == null) return false;

                if (acciones == Acciones.Editar)
                {
                    context.Entry(model).State = EntityState.Modified;
                    if (context.SaveChanges() > 0) return true;

                    return false;
                }

                context.TipoHabitacion.Add(model);

                if (context.SaveChanges() > 0) return true;

                return false;
            }
            catch (Exception ex)
            {
                messageError = $"{ex.Message} - INNER  {ex.InnerException?.Message}";
                return false;
            }
        }

        public bool CrearReservacion(Reserva model)
        {
            throw new NotImplementedException();
        }
    }
}
