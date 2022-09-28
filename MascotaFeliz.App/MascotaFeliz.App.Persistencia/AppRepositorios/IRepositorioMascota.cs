using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using MascotaFeliz.App.Dominio;

namespace MascotaFeliz.App.Persistencia
{
    public interface IRepositorioMascota
    {
        IEnumerable<Mascota> GetAllMascotas();
        Mascota AddMascota(Mascota mascota);
        Mascota UpdateMascota(Mascota mascota);
        Mascota AsignarNuevoVeterinario(int mascota, int veterinario);
        //void DeleteMascota(int idMascota);
        Mascota GetMascota(int idMascota);
        IEnumerable<Mascota> GetMascotasPorFiltro(string filtro);
        Dueno AsignarDueno(int idMascota, int idDueno);
        Historia AsignarHistoria(int idMascota, int idHistoria);
    }
}