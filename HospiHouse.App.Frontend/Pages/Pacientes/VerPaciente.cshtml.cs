using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HospiHouse.App.Dominio;
using HospiHouse.App.Persistencia;

namespace HospiHouse.App.Frontend.Pages
{
    
    public class VerPacienteModel : PageModel
    {
        
        //Conectar con la base de datos 
        private static IRepositorioPaciente _repositorioPaciente = new RepositorioPaciente (new HospiHouse.App.Persistencia.AppContext());

        //Generamos una Variable para mapear que llega del usuario desde DBs
        [BindProperty]
        public Paciente paciente {get;set;} 

        //Constructor 
        public VerPacienteModel()
        {
        }

        public ActionResult OnGet(int id)
        {
            this.paciente = _repositorioPaciente.GetPaciente(id);
            return Page();
        }
    }
}
