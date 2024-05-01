//---------> Exemplo Prático

Produto produto1 = new Produto("Raquete de Tênis", 500.0, 60);
produto1.ExibirInformacoes();
produto1.ValorTotalProduto(produto1.Preco);
Console.WriteLine();

Console.WriteLine("Teste método AdicionarUnidade: ");
produto1.AdicionarUnidade(50);
produto1.ExibirInformacoes();
produto1.ValorTotalProduto(produto1.Preco);
Console.WriteLine();

Console.WriteLine("Teste método RemoverUnidade: ");
produto1.RemoverUnidade(10);
produto1.ExibirInformacoes();
produto1.ValorTotalProduto(produto1.Preco);
Console.WriteLine();

//------------------------------------------------------

Console.WriteLine("Teste outro produto: ");
Produto produto2 = new Produto("Bola de Basquete", 259.0, 100);
produto2.ExibirInformacoes();
produto2.ValorTotalProduto(produto2.Preco);
Console.WriteLine();

Console.WriteLine("Teste método AdicionarUnidade: ");
produto2.AdicionarUnidade(20);
produto2.ExibirInformacoes();
produto2.ValorTotalProduto(produto2.Preco);
Console.WriteLine();

Console.WriteLine("Teste método RemoverUnidade: ");
produto2.RemoverUnidade(40);
produto2.ExibirInformacoes();
produto2.ValorTotalProduto(produto2.Preco);
Console.WriteLine();

