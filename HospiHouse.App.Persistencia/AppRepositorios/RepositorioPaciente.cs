using System;
using HospiHouse.App.Dominio;

namespace HospiHouse.App.Persistencia
{
    public class RepositorioPaciente : IRepositorioPaciente
    {
        private readonly AppContext _appContext;

        public RepositorioPaciente()
        {

        }

        public RepositorioPaciente (AppContext appContext)
        {
            this._appContext = appContext;
        }
      
       
        //Metodo para adicionar paciente 
        public Paciente AddPaciente (Paciente paciente)
        {
            var PacienteAdicionado = _appContext.pacientes.Add(paciente);
            _appContext.SaveChanges();
            return PacienteAdicionado.Entity;
        }

        //Metodo para borrar un paciente 
        public void DeletePaciente (int idPaciente)
        {   
            //Primero debe buscar al paciente para borrar
            var PacienteEliminar= _appContext.pacientes.FirstOrDefault (p => p.id == idPaciente);
            //Condicional necesario para identificar el paciente 
            if (PacienteEliminar != null)
            {

                //Elimminar el paciente
                this._appContext.pacientes.Remove (PacienteEliminar);
                //Guardar cambios
                this._appContext.SaveChanges();

            }
        }

        //obtener un paciente 
        public Paciente GetPaciente (int idPaciente)
        {
            //// !!!!!!
            return this._appContext.pacientes.Where(p => p.id == idPaciente) //todo and p.estado == "1")
            .SingleOrDefault <Paciente> ();
        }


        //Obteber todos los pacientes
        public IEnumerable <Paciente> GetAllPacientes()
        {
            return this._appContext.pacientes;
        }

        //Actualizar un paciente 
        public Paciente UpdatePaciente (Paciente paciente)
        {
            //Debe buscar un paciente primero 
            var PacienteEncontrado = this._appContext.pacientes.FirstOrDefault (p => p.id == paciente.id);
            if (PacienteEncontrado != null)
            {

                PacienteEncontrado.id = paciente.id;
                PacienteEncontrado.nombre = paciente.nombre;
                PacienteEncontrado.apellido = paciente.apellido;
                PacienteEncontrado.identificacion = paciente.identificacion;
                //Contraseña 
                PacienteEncontrado.contraseña = paciente.contraseña;

                PacienteEncontrado.telefono = paciente.telefono;
                PacienteEncontrado.Genero = paciente.Genero;
                PacienteEncontrado.TipoIdentificacion = paciente.TipoIdentificacion;
                PacienteEncontrado.direccion = paciente.direccion;
                PacienteEncontrado.ciudad = paciente.ciudad;
                PacienteEncontrado.fechaNacimiento = paciente.fechaNacimiento;
                //Estado activoInactivo
                //PacienteEncontrado.activoInactivo = paciente.activoInactivo;



                //guardar cambios 
                this._appContext.SaveChanges();

            }
            return PacienteEncontrado;
        }

    }
}
