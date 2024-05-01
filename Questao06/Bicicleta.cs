public class Bicicleta : Veiculo {
    public int NumeroMarcha {get;set;}

    public Bicicleta (string Marca, string Modelo, int NumeroMarcha){
        this.Marca = Marca;
        this.Modelo = Modelo;
        this.NumeroMarcha = NumeroMarcha;
    }
    
     public void ExibirInformacoes(){
        Console.WriteLine($"Marca: {Marca}, Modelo: {Modelo}, Número de Marchas: {NumeroMarcha}.");
    }
}