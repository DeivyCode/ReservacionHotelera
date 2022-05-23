using Hotel.Comunes;
using Hotel.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Data.Interfaces
{
    public interface IHotelRepository
    {
        bool CrearEditarHabitacion(Habitacion model, Acciones acciones);

        bool CrearEditarHotel(Models.Hotel model, Acciones acciones);

        bool CrearEditarTipoHabitacion(TipoHabitacion model, Acciones acciones);

        bool CrearReservacion(Reserva model);

        public string MessageError { get; }

        ICollection<Models.Hotel> ObtenerHoteles();

    }
}
