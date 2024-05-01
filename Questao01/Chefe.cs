public class Chefe : Funcionario {

    //Adicionado atributo específico.
    public int Bonus {get;set;}

    public Chefe(string Nome, string Turno, int Bonus) : base (Nome, Turno){
        this.Bonus = Bonus;
    }

    //Herdado método da Classe Base Funcionário.
    public override void Trabalhar() {
        Console.WriteLine($"Meu nome é {Nome} e trabalho no {Turno}.");
    }

    //Adicionado método específico.
    public void CriarProduto() {
        Console.WriteLine("Preciso criar um produto novo mensalmente.");
    }
}