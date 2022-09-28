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
    public class AgregarVisitaModel : PageModel
    {
        
        private readonly IRepositorioVisitaPyP _repoVisitaPyP;
        private readonly IRepositorioHistoria _repoHistoria;
        DateTime FechaInicial;
        [BindProperty]

        public VisitaPyP VisitaPyP { get; set;}
        public Historia Historia { get; set; }

        public  AgregarVisitaModel()
        {
            
            this._repoHistoria = new RepositorioHistoria(new Persistencia.AppContext());
            this._repoVisitaPyP= new RepositorioVisitaPyP(new Persistencia.AppContext());
            
        } 
        
         public IActionResult OnGet (int? visita)
        {
            //Historia=_repoHistoria.GetHistoria(historiaId);
            
            
            
            if(visita.HasValue){
                VisitaPyP = _repoVisitaPyP.GetVisitaPyP(visita.Value);
            }
            else{
                 VisitaPyP= new VisitaPyP();
            }
            if(VisitaPyP== null){
                return RedirectToPage("./NotFound");
            }
            else{
                return Page();
            }
            
        }

          public IActionResult OnPost(VisitaPyP VisitaPyP, int historiaId)
        {
            if (ModelState.IsValid)
            {
                Historia=_repoHistoria.GetHistoria(historiaId);
                Console.WriteLine(Historia.Id);

                if (VisitaPyP.Id > 0)
                {
                    FechaInicial = new DateTime(2020, 01, 01);
                    VisitaPyP.FechaVisita=FechaInicial;
                   
                    VisitaPyP = _repoVisitaPyP.UpdateVisitaPyP(VisitaPyP);
                }
                else
                {
                    VisitaPyP = _repoVisitaPyP.AddVisitaPyP(VisitaPyP);
                    Historia.VisitasPyP.Append(VisitaPyP);
                    
                    _repoHistoria.UpdateHistoria(Historia);
                    

                }
                return RedirectToPage("/Mascota/ListaMascota");

            }
            else
            {
                return Page();
            }
        }

    }
}
