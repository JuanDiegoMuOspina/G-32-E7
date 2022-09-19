using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MascotaFeliz.App.Dominio;
using MascotaFeliz.App.Persistencia;

namespace MascotaFeliz.App.Frontend.Pages
{
    public class ListaMascotaModel : PageModel
    {
        //private static IRepositorioMascota _repoMascotas = new RepositorioMascota(new Persistencia.AppContext());
        private readonly IRepositorioMascota _repoMascotas;

        public  IEnumerable<Mascota> listaMascota { get;  set; }
        
        public  ListaMascotaModel()
        {
            this._repoMascotas = new RepositorioMascota(new Persistencia.AppContext());
        }  
        public void OnGet()
        {
             listaMascota = _repoMascotas.GetAllMascotas();
        }
    }
}
