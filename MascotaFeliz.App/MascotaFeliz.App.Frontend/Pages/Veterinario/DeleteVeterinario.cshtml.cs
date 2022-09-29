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
    public class DeleteVeterinarioModel : PageModel
    {
        
        private readonly IRepositorioVeterinario _repoVeterinario;
        public Veterinario  veterinario { get; set; }
        public string mensaje { get; set; }
        public string Boton { get; set; }

        public DeleteVeterinarioModel()
        {
           this._repoVeterinario  = new RepositorioVeterinario(new Persistencia.AppContext());
        }

        public IActionResult OnGet(int veterinarioId)
        {
            try
            {
                mensaje="Si es posible eliminar Veterinario";
                Boton="Borrar";
                _repoVeterinario.DeleteVeterinario(veterinarioId);
            }
            catch (Exception e)
            {
                mensaje="NO es posible eliminar Veterinario revise relaciones";
                Boton="Volver";
                Console.WriteLine("{0} Exception caught.",e);
            }
            
            
            if (veterinarioId==0)
            {
                return RedirectToPage("./NotFound");
            }else{
                return Page();
            }
                
           
            
        }
    }
}
