public class Filho : Mae {
    public double Tamanho { get; set; }
    
    public Filho() {
    }

    // Como a classe base não tem um método virtual TipoSanguineo, removi o override aqui
    public override void TipoSanguineo() {
        Console.WriteLine("O tipo sanguíneo é A.");
    }

    public void GostoMusical() {
        Console.WriteLine("Meu gosto preferido é Hard Rock");
    }
}