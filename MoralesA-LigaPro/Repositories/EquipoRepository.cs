using MoralesA_LigaPro.Interfaces;
using MoralesA_LigaPro.Models;

namespace MoralesA_LigaPro.Repositories
{
    public class EquipoRepository : IEquipoRepository
    {
        public bool ActualizarEquipo()
        {
            throw new NotImplementedException();
        }

        public bool CrearEquipo()
        {
            throw new NotImplementedException();
        }

        public List<Equipo> DevuelveListadoEquipo()
        {
            List<Equipo> equipos = new List<Equipo>();
            Equipo ldu = new Equipo
            {

                Id = 1,
                Nombre = "LDU",
                PartidosJugados = 10,
                PartidosGanados = 10,
                PartidosEmpatados = 0,
                PartidosPerdidos = 0,
            };
            equipos.Add(ldu);

            Equipo barcelona = new Equipo
            {
                Id = 2,
                Nombre = "Barcelona",
                PartidosJugados = 10,
                PartidosGanados = 8,
                PartidosEmpatados = 1,
                PartidosPerdidos = 1,
            };
            equipos.Add(barcelona);

            Equipo emelec = new Equipo
            {
                Id = 3,
                Nombre = "Emelec",
                PartidosJugados = 10,
                PartidosGanados = 7,
                PartidosEmpatados = 2,
                PartidosPerdidos = 1,
            };
            equipos.Add(emelec);

            Equipo cuenca = new Equipo
            {
                Id = 4,
                Nombre = "Cuenca",
                PartidosJugados = 10,
                PartidosGanados = 5,
                PartidosEmpatados = 2,
                PartidosPerdidos = 3,
            };
            equipos.Add(cuenca);

            return equipos;
        }

        public bool EliminarEquipo()
        {
            throw new NotImplementedException();
        }

        public Equipo DevuelveInfoEquipos(int Id)
        {
            var equipos = DevuelveListadoEquipo();
            var equipo = equipos.Where( item => item.Id == Id).First();
            return equipo;

        }
    }
}
