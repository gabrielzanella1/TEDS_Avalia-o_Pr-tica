//---------> Exemplo Prático

Funcionario funcionario = new Funcionario("Gabriel", "Primeiro Turno");
Chefe chefe = new Chefe("Thomas", "Primeiro Turno", 100000);

funcionario.Trabalhar();
chefe.Trabalhar();
chefe.CriarProduto();
Console.WriteLine(funcionario.Nome);
Console.WriteLine(chefe.Bonus);