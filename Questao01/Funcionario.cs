public class Funcionario {

    public string Nome {get;set;}
    public string Turno {get;set;}

    public Funcionario(string Nome, string Turno) {
        this.Nome = Nome;
        this.Turno = Turno;
    }
    public virtual void Trabalhar() {
        Console.WriteLine($"Meu nome é {Nome} e trabalho no {Turno}.");
    }
}
