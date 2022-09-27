using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HospiHouse.App.Dominio;
using HospiHouse.App.Persistencia;

namespace HospiHouse.App.Frontend.Pages
{
    public class BorrarPacienteModel : PageModel
    {
        //Conectar con la base de datos 
        private static IRepositorioPaciente _repositorioPaciente = new RepositorioPaciente (new HospiHouse.App.Persistencia.AppContext());


        [BindProperty]//vincula la clase con el modelo 
        //referencia formulario 
        public Paciente paciente{get;set;}
        
        //Constructor
        public BorrarPacienteModel()
        {
        }


        public ActionResult OnGet(int id)
        {
            this.paciente = _repositorioPaciente.GetPaciente(id);

            return Page();
        }
        
        /*
        //Intentos raros
        public ActionResult OnPost()
        {
            var PacienteBorrado = _repositorioPaciente.GetPaciente(id);
            if (paciente == null)
            {
                return NotFound();
            } 

            _repositorioPaciente.DeletePaciente(paciente);
             this._repositorioPaciente.SaveChanges();
             return redirectToPage("/ListadoPacientes");
            


            //Conecta con el repositorio
            try{ 
            this.paciente = _repositorioPaciente.DeletePaciente(paciente.id);
            //Paciente PacienteBorrado =_repositorioPaciente.DeletePaciente(paciente.id);
            //paciente.id.DeletePaciente(paciente); 
            return RedirectToPage("./ListadoPacientes");
            }catch(System.Exception e)
            {
                ViewData["Error"] = "Error: " + e.Message;
                return Page();
            } 

        }   */
        
    }
}
