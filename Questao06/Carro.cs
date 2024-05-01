public class Carro : Veiculo {
    public int NumeroPortas {get;set;}
    
    public Carro (string Marca, string Modelo, int NumeroPortas){
        this.Marca = Marca;
        this.Modelo = Modelo;
        this.NumeroPortas = NumeroPortas;
    }

    public void ExibirInformacoes(){
        Console.WriteLine($"Marca: {Marca}, Modelo: {Modelo}, Número de Portas: {NumeroPortas}.");
    }
}