using MoralesA_LigaPro.Models;

namespace MoralesA_LigaPro.Interfaces
{
    public interface IEquipoRepository
    {
        List<Equipo> DevuelveListadoEquipo();
        Equipo DevuelveInfoEquipos(int Id);
        bool CrearEquipo();
        bool ActualizarEquipo();
        bool EliminarEquipo();
    }
}
