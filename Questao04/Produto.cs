public class Produto {
    public string Nome {get;set;}
    public double Preco {get;set;}
    public int QuantidadeEmEstoque {get;set;}

    public Produto (string Nome, double Preco, int QuantidadeEmEstoque){
        this.Nome = Nome;
        this.Preco = Preco;
        this.QuantidadeEmEstoque = QuantidadeEmEstoque;
    }

    public void AdicionarUnidade(int QuantidadeAdicionada){
        QuantidadeEmEstoque += QuantidadeAdicionada;
        Console.WriteLine($"Quantidade de unidades do produto {Nome} após adição: {QuantidadeEmEstoque}.");
    }

    public void RemoverUnidade(int QuantidadeRemovida){
        QuantidadeEmEstoque -= QuantidadeRemovida;
        Console.WriteLine($"Quantidade de unidades do produto {Nome} após remoção: {QuantidadeEmEstoque}.");
    }

    public void ValorTotalProduto(double Preco){
        Preco *= QuantidadeEmEstoque;
        Console.WriteLine($"O valor em estoque do produto {Nome} é de R${Preco}.");
    }

    public void ExibirInformacoes(){
        Console.WriteLine($"Preco: {Preco}, Quantidade em estoque: {QuantidadeEmEstoque}.");
    }
}
