public class Mae {
    public string Nome { get; set; }
    public string NomeFilho { get; set; }
    
    public Mae() {
        Nome = "";
        NomeFilho = "";
    }

    public virtual void TipoSanguineo() {
        Console.WriteLine("O tipo sanguíneo é A.");
    }
}
