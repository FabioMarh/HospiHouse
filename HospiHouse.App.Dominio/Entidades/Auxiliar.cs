using System;

namespace HospiHouse.App.Dominio
{
    public class Auxiliar
    {
        public int id {get;set;}
    //Atributos propio de la clase, En este caso es el mismo id de la clase 
        public int idAuxiliar {get;set;}
        public string contraseña {get;set;}
       
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
        
         //Estado del usuario para poder borrarlo de listas 
        //public bool activoInactivo {get;set;}



    }
}