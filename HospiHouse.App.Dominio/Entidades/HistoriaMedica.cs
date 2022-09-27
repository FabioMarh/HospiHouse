using System;

namespace HospiHouse.App.Dominio
{
    public class HistoriaMedica
    {
    ///Llave extra para ver si funciona la migracion 
        public int id {get;set;}
        //LLave de la clase 
        public int idHistoriaMedica {get;set;}

        //Atributos adicionales 
        public string diagnostico {get;set;}
        public string entornoHospitalizacion {get;set;}

    //RELACIONES
        //Relacion 1 paciente +n Muchs Historias Medicas
            //Llave foranea de clase 1 Paciente
        public int idPaciente {get;set;}
            //Referencia de la clase
        public Paciente paciente {get;set;}
        
        //Relacion un 1 medico a muchas +n historias medicas 
        //Llave foranea de Medico 1
        public int idMedico {get;set;}
        //Referencia a 1 medico
        public Medico medico {get;set;}

        //relaciones con Signo vital y sugerencia de cuidado 
        //Recibe una lista de muchos Signos vitales 
        public List <SignosVitales> ListaSignosVitales {get;set;}

        //Relacion Sugerencia de cuidado
        public List <SugerenciaCuidado> ListaSugerenciasCuidado {get;set;}









    }
}