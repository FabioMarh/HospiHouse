using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HospiHouse.App.Dominio;
using HospiHouse.App.Persistencia;

namespace HospiHouse.App.Frontend.Pages
{
    public class EditarPacienteModel : PageModel
    {
         //Conectar con la base de datos 
        private static IRepositorioPaciente _repositorioPaciente = new RepositorioPaciente (new HospiHouse.App.Persistencia.AppContext());

        [BindProperty]
        //referencia formulario 
        public Paciente paciente{get;set;}
       
        public ActionResult OnGet(int id)
        {
            this.paciente = _repositorioPaciente.GetPaciente(id);
            return Page();
        }

        
        public ActionResult OnPost(string nombre)
        {
            //Conecta con el repositorio
            try{ 
            Paciente pacienteEditado =_repositorioPaciente.UpdatePaciente (paciente);
            return RedirectToPage("./ListadoPacientes");
            }catch(System.Exception e)
            {
                ViewData["Error"] = "Error: " + e.Message;
                return Page();
            }

        }   
    }
}
