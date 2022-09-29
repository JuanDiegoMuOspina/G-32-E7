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
        private readonly  IRepositorioVeterinario _repoVeterinario;
        private readonly IRepositorioDueno _repoDueno;
        private readonly IRepositorioHistoria _repoHistoria;
        DateTime FechaInicial;
        [BindProperty]
        
        
   
        public Veterinario  veterinario { get; set; }
        public IEnumerable<Veterinario> listaVeterinario { get;  set; }
        public  Mascota mascota { get;  set; }
        public Dueno dueno { get; set; }
        public Historia historia { get; set; }
        public IEnumerable<Dueno> listaDuenos { get; set; }


        public  EditarMascotaModel()
        {
            this._repoMascotas = new RepositorioMascota(new Persistencia.AppContext());
            this._repoVeterinario = new RepositorioVeterinario(new Persistencia.AppContext());
            this._repoDueno = new RepositorioDueno(new Persistencia.AppContext());
            this._repoHistoria = new RepositorioHistoria(new Persistencia.AppContext());
        } 

         public IActionResult OnGet (int? mascotaId)
        {
            listaVeterinario=_repoVeterinario.GetAllVeterinarios();
            listaDuenos = _repoDueno.GetAllDuenos();
            
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

          public IActionResult OnPost(Mascota mascota, int veterinarioId, int duenoId)
        {
            if (ModelState.IsValid)
            {
                dueno = _repoDueno.GetDueno(duenoId);
                veterinario = _repoVeterinario.GetVeterinario(veterinarioId);
                historia = new Historia

                {
                    FechaInicial = new DateTime(2020, 01, 01)


                };
                List<VisitaPyP> listaVisitaPyP;
                listaVisitaPyP=new List<VisitaPyP>{};
                historia.VisitasPyP=listaVisitaPyP;
                historia = _repoHistoria.AddHistoria(historia);
                if (mascota.Id > 0)
                {
                    mascota.Veterinario = veterinario;
                    mascota.Dueno = dueno;
                    mascota.Historia=historia;
                    mascota = _repoMascotas.UpdateMascota(mascota);
                }
                else
                {
                    mascota = _repoMascotas.AddMascota(mascota);
                    _repoMascotas.AsignarDueno(mascota.Id, dueno.Id);
                    _repoMascotas.AsignarNuevoVeterinario(mascota.Id, veterinario.Id);
                    _repoMascotas.AsignarHistoria(mascota.Id,historia.Id);

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
