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
    public class DeleteDuenoModel : PageModel
    {
        private readonly IRepositorioDueno _repoDueno;
        // private static IRepositorioDueno _repoDueno = new RepositorioDueno(new Persistencia.AppContext());

        public Dueno dueno { get; set; }
        public string mensaje { get; set; }
        public string Boton { get; set; }

        public DeleteDuenoModel()
        {
           this._repoDueno = new RepositorioDueno(new Persistencia.AppContext()); 
           this.mensaje = "";
           this.Boton = "";
        }

        
        public IActionResult OnGet(int duenoId)
        {
            try
            {
                mensaje="Si es posible eliminar Dueño";
                Boton="Borrar";
                _repoDueno.DeleteDueno(duenoId);
            }
            catch (Exception e)
            {
                mensaje="NO es posible eliminar Dueño revise relaciones";
                Boton="Volver";
                Console.WriteLine("{0} Exception caught.",e);
            }
            
            
            if (duenoId==0)
            {
                return RedirectToPage("./NotFound");
            }else{
                return Page();
            }
                
           
            
        }
    }
}
