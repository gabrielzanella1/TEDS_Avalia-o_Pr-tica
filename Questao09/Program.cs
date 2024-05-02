//----------> Exemplo Prático

CartaoCredito compra1 = new CartaoCredito();
compra1.Bandeira = "Visa";
compra1.RealizarPagamento();
compra1.VerificarStatus();
Console.WriteLine();

//-------------------------------------------

BoletoBancario compra2 = new BoletoBancario();
compra2.NumeroBoleto = "8762901241";
compra2.RealizarPagamento();
compra2.VerificarStatus();
Console.WriteLine();

//-------------------------------------------

Transferencia compra3 = new Transferencia();
compra3.Conta = "12345-7";
compra3.RealizarPagamento();
compra3.VerificarStatus();

