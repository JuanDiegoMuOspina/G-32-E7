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
    public class DetalleMascotaModel : PageModel

    {
        private readonly IRepositorioMascota _repoMascotas;
        private readonly IRepositorioVisitaPyP _repoVisitaPyP;
        private readonly IRepositorioHistoria _repoHistoria;

        public  IEnumerable<VisitaPyP> listaVisitaPyP { get;  set; }
        public  Mascota mascota { get;  set; }
     
        


        public  DetalleMascotaModel()
        {
            this._repoMascotas = new RepositorioMascota(new Persistencia.AppContext());
            this._repoHistoria = new RepositorioHistoria(new Persistencia.AppContext());
            this._repoVisitaPyP= new RepositorioVisitaPyP(new Persistencia.AppContext());
            
        } 

        public IActionResult OnGet(int mascotaId)
        {
            mascota=_repoMascotas.GetMascota(mascotaId);
            listaVisitaPyP =mascota.Historia.VisitasPyP;
            
            

            if (mascota==null)
            {
                return RedirectToPage("./NotFound");
            }else{
                return Page();
            }
        }

      

    }
    
}
