using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HospiHouse.App.Dominio;
using HospiHouse.App.Persistencia;

namespace HospiHouse.App.Frontend.Pages
{
    public class CrearPacienteModel : PageModel
    {
        //Conectar con la base de datos 
        private static IRepositorioPaciente _repositorioPaciente = new RepositorioPaciente (new HospiHouse.App.Persistencia.AppContext());


        [BindProperty]
        //referencia formulario 
        public Paciente paciente{get;set;}
        
        //Constructor
        public CrearPacienteModel()
        {
        }

        public ActionResult OnGet()
        {
            return Page(); 
        }

        public ActionResult OnPost()
        {
            //Conecta con el repositorio
            try{ 
            Paciente PacienteAdicionado =_repositorioPaciente.AddPaciente(paciente);
            return RedirectToPage("./ListadoPacientes");
            }catch(System.Exception e)
            {
                ViewData["Error"] = "Error: " + e.Message;
                return Page();
            }

        }   
    }
}




