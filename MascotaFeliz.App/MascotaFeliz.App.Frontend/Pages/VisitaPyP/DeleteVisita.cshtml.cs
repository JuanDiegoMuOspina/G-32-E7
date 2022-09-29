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
    public class DeleteVisitaModel : PageModel
    {

        private readonly IRepositorioVisitaPyP _repoVisitaPyP;
        private readonly IRepositorioHistoria _repoHistoria;
        
        [BindProperty]

        public VisitaPyP VisitaPyP { get; set;}
        public List<VisitaPyP> ListaVisitasPyP {get;set;}
        public  IEnumerable<Historia> listaHistoria { get;  set; }
        public Historia Historia { get; set; }

        public  DeleteVisitaModel()
        {
            
            this._repoHistoria = new RepositorioHistoria(new Persistencia.AppContext());
            this._repoVisitaPyP= new RepositorioVisitaPyP(new Persistencia.AppContext());
            
        } 


        public IActionResult OnGet (int visita)
        {
           _repoVisitaPyP.DeleteVisitaPyP(visita);
           if(visita== 0){
                return RedirectToPage("./NotFound");
            }
            else{
                return Page();
            }
            
        }
        
    }
}
