// See https://aka.ms/new-console-template for more information
using System;
using HospiHouse.App.Dominio;
using HospiHouse.App.Persistencia;

public class Program
{
    private static IRepositorioPaciente _repositorioPaciente = new RepositorioPaciente (new HospiHouse.App.Persistencia.AppContext());

    private static void Main (string [] args)
    {
        Console.WriteLine("Hello, World!");
    //Van los metodos de Paciente 
        //AdicionarPaciente();
        //BuscarPaciente();
        VerListadoPacientes();
    // Metodos TO DO    
        //BorrarPaciente();
        //ActualizarPaciente();
    

    }

    static void AdicionarPaciente()
    {
    
        Console.WriteLine ("Adicionando un paciente...");
        Paciente paciente = new Paciente ();
    //Atributos agregados necesarios de la clase
    
    ///Este espacio id no va por que el sql lo establece de manera automatica y es autoincremental
        //paciente.id = 001;
        paciente.nombre = "Gerardo";
        paciente.apellido = "Ramirez Vejarano";
        paciente.identificacion = "1.111.999.444";
        paciente.telefono = "322 232 5820";
        paciente.Genero = Genero.masculino;
        paciente.TipoIdentificacion = TipoIdentificacion.cedula;
        paciente.ciudad = "Bogota";
        paciente.direccion = "cll 14 N 66-87 /Los Alamos";
        paciente.fechaNacimiento = new DateTime(2092,09,23);
        paciente.contraseña = "123";
       
        _repositorioPaciente.AddPaciente(paciente);
        Console.WriteLine("El paciente " + paciente.nombre + " " + paciente.apellido +  " a sido adicionado Correctamente.");
    }

    static void BuscarPaciente()
    {
        Console.WriteLine("*************");
        Console.WriteLine("Buscando paciente...");
        var paciente = _repositorioPaciente.GetPaciente(3);
        Console.WriteLine("Paciente encontrado...");
        Console.WriteLine("ID: " + paciente.id);
        Console.WriteLine("Nombre: " + paciente.nombre + " " + paciente.apellido);
        Console.WriteLine("Documento: "  + paciente.TipoIdentificacion +" "+ paciente.identificacion  );
        
   
    }

    static void VerListadoPacientes()
    {
        Console.WriteLine("***************");
        Console.WriteLine("Listado de pacientes...");
        var listadoPacientes = _repositorioPaciente.GetAllPacientes();
        foreach(var paciente in listadoPacientes)
        {
            Console.WriteLine("ID: " + paciente.id);
            Console.WriteLine("Nombre: " + paciente.nombre + " " + paciente.apellido);
            Console.WriteLine("Documento: "  + paciente.TipoIdentificacion +" "+ paciente.identificacion  );
        }
    }
    
   // Borrar paciente 
    static void BorrarPaciente()
    {
        Console.WriteLine("*******************");
        Console.WriteLine("Borrando paciente.....");
        var paciente =_repositorioPaciente.GetPaciente(5);
        Console.WriteLine("Paciente: " + paciente.nombre + " " + paciente.apellido);
        Console.WriteLine("Identificacion: "+ paciente.identificacion);
        _repositorioPaciente.DeletePaciente(5);
        Console.WriteLine("Ha sido eliminado");
    }

    
    //Modificar paciente 
    static void ActualizarPaciente()
    {
        Console.WriteLine("****************");
        Console.WriteLine("Actualizando datos de paciente...");
        var paciente = _repositorioPaciente.GetPaciente(3);
        Console.WriteLine("Se va a modificar el paciente" + paciente.nombre);


        paciente.nombre = "Agregar nuevo nombre";
//los demas datos 
        paciente.apellido = "agregar nombre";
        paciente.identificacion = "1.110.995.2042";
        paciente.telefono = "320 852 2800";
        paciente.Genero = Genero.femenino;
        paciente.TipoIdentificacion = TipoIdentificacion.registroCivil;
        paciente.ciudad = "Bogota";
        paciente.direccion = "cll 39 N 05-70 /Los comuneros";
        paciente.fechaNacimiento = new DateTime(2022,08,25);
        paciente.contraseña = "123";
       
        _repositorioPaciente.UpdatePaciente(paciente);
        Console.WriteLine("Ha sido actualizado");
    
    }

}


