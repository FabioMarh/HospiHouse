using System;
using HospiHouse.App.Dominio;

namespace HospiHouse.App.Persistencia
{
    public interface IRepositorioPaciente
    {
        public Paciente AddPaciente (Paciente paciente);
        public void DeletePaciente (int idPaciente);
        public Paciente GetPaciente (int idPaciente);
        public IEnumerable <Paciente> GetAllPacientes();
        public Paciente UpdatePaciente (Paciente paciente);
    }
}
