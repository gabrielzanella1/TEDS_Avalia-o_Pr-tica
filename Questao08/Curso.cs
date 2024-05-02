public class Curso {
    public string Nome {get;set;}
    public string Status {get;set;}
    public string Nivel {get;set;}
    public int Presenca {get;set;}

    public Curso(string nome, string status, string nivel, int presenca) {
        Nome = nome;
        Status = status;
        Nivel = nivel;
        Presenca = presenca;
    }
    
    public virtual void ConsultarPresenca(){

    }
}