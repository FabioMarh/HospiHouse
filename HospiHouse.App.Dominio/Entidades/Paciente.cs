using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;

namespace HospiHouse.App.Dominio
{
    public class Paciente
    {
 
       //LLave de la clase 
        public int id {get;set;}
        
///En este nuevo intento vamos a retirar a la clase Persona del todo y vamos a dejar sus atributos en cada uno de las clases que heredan. 
    //En este caso serian los mismos datos para las clases:
        // Paciente, Familiar, Enfermera, Medico y Auxiliar 
    // y los atributos serian:
        // Nombre, Apellido , Identificacion, Telefono y las sub clases Genero y TipoIdentificacion  
            //Requerimiento para mensajes en el front
        [Required(ErrorMessage="El campo -Nombre- es obligatorio")]
        public string nombre {get;set;} 
        [Required(ErrorMessage="El campo -Apellido- es obligatorio")]
        public string apellido {get;set;}
        [Required(ErrorMessage="El campo -Identificacion- es obligatorio")]
        public string identificacion {get;set;}
        [Required(ErrorMessage="El campo -Telefono- es obligatorio")]   
        public string telefono {get;set;}
        [Required(ErrorMessage="El campo -Genero- es obligatorio")]
        public Genero Genero {get;set;}
        [Required(ErrorMessage="El campo -Tipo Identificacion- es obligatorio")]
        public TipoIdentificacion TipoIdentificacion {get;set;}



        //!!! Agregado
        //public bool activoInactivo {get;set;}
        [Required(ErrorMessage="El campo -Contraseña- es obligatorio")]
        public string contraseña {get;set;}




        //Atributos propios de la clase 
        [Required(ErrorMessage="El campo -direccion- es obligatorio")]
        public string direccion {get;set;}
        [Required(ErrorMessage="El campo -Ciudad- es obligatorio")]
        public string ciudad {get;set;}
        
        [Required(ErrorMessage="El campo -fecha de nacimiento- es obligatorio")]
        public DateTime fechaNacimiento {get;set;}

        


    //Relaciones
        // 1 Paciente a muchos Familiar
            //Recibe lista de muchos +n Familiar
        public List <Familiar> ListaFamiliares {get;set;}

        //Relacion 1 paciente muchas +n historias medicas 
            //Recibe una lista de muchas +n historias medicas 
        public List <HistoriaMedica> ListaHistoriasMedicas {get;set;}

    }
}



