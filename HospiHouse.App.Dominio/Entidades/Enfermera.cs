using System;

namespace HospiHouse.App.Dominio
{
    public class Enfermera
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

    //Atributos propios de la clase 
       
        public string targetaProfecional {get;set;}
        public string horasLaboralesSemana {get;set;} 
        
    //Relacion 1 a muchos signos vitales
        //Resive lista de clase relacionada n+ muchos signos vitales  
        public List <SignosVitales> ListaSignosVitales {get;set;}

    }
}