using System;

namespace HospiHouse.App.Dominio
{
    public class SignosVitales
    {
        //llave de la clase 
        public int id {get;set;}

        //Atributos de la clase 
        public string estadoGeneral {get;set;}
        public DateTime fechaYHora {get;set;}
        public string oximetria {get;set;}
        public string frecuenciaRespiratoria {get;set;}
        public string frecuenciaCardiaca {get;set;}
        public string temperatura {get;set;}
        public string precionArterial {get;set;}
        
    //Relacion 1 Enfermera a muchos SignosVitales
        //Llave foranea de clase relacionada 1 Enfermera
        public int idEnfermera {get;set;}
        //Referencia clase relacionada 1 Enfermera
        public Enfermera enfermera {get;set;}
    //Relacion 1 Historia medica a muchas +n Signos Vitales
        //Llave foranea clase 1 Historia medica 
        public int idHistoriaMedica {get;set;}
        //Referencia de clase 1 Historia Medica
        public HistoriaMedica historiaMedica {get;set;}



    }
}