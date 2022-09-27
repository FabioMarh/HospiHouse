using System;

namespace HospiHouse.App.Dominio
{
    public class Familiar
    {

//llave identificacion de la clase para llaves principales y foraneas.
        public int id {get;set;}

///En este nuevo intento vamos a retirar a la clase Persona del todo y vamos a dejar sus atributos en cada uno de las clases que heredan. 
    //En este caso serian los mismos datos para las clases:
        // Paciente, Familiar, Enfermera, Medico y Auxiliar 
    // y los atributos serian:
        // Nombre, Apellido , Identificacion, Telefono y las sub clases Genero y TipoIdentificacion  
        public string nombre {get;set;} 
        public string apellido {get;set;}
        public string identificacion {get;set;}
        public string telefono {get;set;}
        public Genero Genero {get;set;}
        public TipoIdentificacion TipoIdentificacion {get;set;}
    
    //Atributos de la clase 
        public string correoElectronico {get;set;}
        public string parentescoPaciente {get;set;}
        

      //Relacion 1 Paciente a muchos Familiar
        //Llave foranea de clase relacionada 1 Paciente
        public int idPaciente {get;set;}
        //Referencia clase relacionada 1 paciente 
        public Paciente paciente {get;set;}

    }
}