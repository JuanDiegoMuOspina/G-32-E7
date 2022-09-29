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
    public class DeleteMascotaModel : PageModel
    {
        private readonly IRepositorioMascota _repoMascotas;
        public string mensaje { get; set; }
        public string Boton { get; set; }

        public  DeleteMascotaModel()
        {
           this._repoMascotas = new RepositorioMascota(new Persistencia.AppContext());
                        
        } 
        public IActionResult OnGet(int mascotaId)
        {
            try
            {
                mensaje="Si es posible eliminar Dueño";
                Boton="Borrar";
                _repoMascotas.DeleteMascota(mascotaId);
            }
            catch (Exception e)
            {
                mensaje="NO es posible eliminar Dueño revise relaciones";
                Boton="Volver";
                Console.WriteLine("{0} Exception caught.",e);
            }
            
            
            if (mascotaId==0)
            {
                return RedirectToPage("./NotFound");
            }else{
                return Page();
            }
                
           
            
        }

    }
}
