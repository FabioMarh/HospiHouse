using System;

namespace HospiHouse.App.Dominio
{
    public class SugerenciaCuidado
    {
        //llave de la clase
        public int id {get;set;}
        //atributo de la clase 
        public string sugerencia {get;set;}

    
    //Relacion Con HistoriaMedica 1 a Muchos +n SugerenciaCuidado
        //Llave foranea clase 1 Historia medica 
        public int idHistoriaMedica {get;set;}
        //Referencia de clase 1 Historia Medica
        public HistoriaMedica historiaMedica {get;set;}

    }
}