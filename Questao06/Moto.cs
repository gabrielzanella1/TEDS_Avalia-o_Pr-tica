public class Moto : Veiculo {
    public int Cilindrada {get;set;}

    public Moto (string Marca, string Modelo, int Cilindrada){
        this.Marca = Marca;
        this.Modelo = Modelo;
        this.Cilindrada = Cilindrada;
    }

     public void ExibirInformacoes(){
        Console.WriteLine($"Marca: {Marca}, Modelo: {Modelo}, Cilindrada: {Cilindrada}.");
    }
}