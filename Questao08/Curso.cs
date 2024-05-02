using System.Xml.Serialization;

public class Curso {
    public string Nome {get;set;}
    public string Status {get;set;}
    public string Nivel {get;set;}
    public int Presenca {get;set;}
    

    public virtual void ConsultarPresenca(){

    }
}