public class Filho : Mae {

    // Como a classe base não tem um método virtual TipoSanguineo, removi o override aqui
    public override void TipoSanguineo() {
        Console.WriteLine("O tipo sanguíneo é A.");
    }

    public void GostoMusical() {
        Console.WriteLine("Gosto preferido é Hard Rock.");
    }
}