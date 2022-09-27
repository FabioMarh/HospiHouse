using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HospiHouse.App.Dominio;
using HospiHouse.App.Persistencia;


namespace HospiHouse.App.Frontend.Pages
{
    
    public class ListadoPacientesModel : PageModel
    {

    //Conectar con la base de datos 
        private static IRepositorioPaciente _repositorioPaciente = new RepositorioPaciente (new HospiHouse.App.Persistencia.AppContext());
    
    //Variable para la lista de pacientes 
        public IEnumerable<Paciente> pacientes {get;set;}

    //Constructor 
        public ListadoPacientesModel()
        {
        }

        public void OnGet()
        {
            this.pacientes = _repositorioPaciente.GetAllPacientes();

        }
    }
}
