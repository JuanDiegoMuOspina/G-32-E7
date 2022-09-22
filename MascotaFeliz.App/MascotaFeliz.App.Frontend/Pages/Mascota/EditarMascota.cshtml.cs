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
    public class EditarMascotaModel : PageModel
    {
        private readonly IRepositorioMascota _repoMascotas;
        [BindProperty]
        public  Mascota mascota { get;  set; }


        public  EditarMascotaModel()
        {
            this._repoMascotas = new RepositorioMascota(new Persistencia.AppContext());
        } 

         public IActionResult OnGet (int? mascotaId)
        {
            if(mascotaId.HasValue){
                mascota= _repoMascotas.GetMascota(mascotaId.Value);
            }
            else{
                 mascota= new Mascota();
            }
            if(mascota== null){
                return RedirectToPage("./NotFound");
            }
            else{
                return Page();
            }
            
        }

         public IActionResult OnPost ()
        {
            if (!ModelState.IsValid){
                return Page();
            }
            if(mascota.Id>0){
                mascota= _repoMascotas.UpdateMascota(mascota);
            }
            else{
                _repoMascotas.AddMascota(mascota);
            }
            return Page();
        }

       
    }
}
