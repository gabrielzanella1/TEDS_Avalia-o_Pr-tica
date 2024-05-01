//---------> Exemplo Prático

// --  Sobrecarga  -->
Calc calculadora = new Calc();

Console.WriteLine(calculadora.Somar(1, 2));           //Chama o método Somar com os parâmetros(int, int)
Console.WriteLine(calculadora.Somar(1.5, 2.5));       //Chama o método Somar com os parâmetros(double, double)
Console.WriteLine(calculadora.Somar(1, 2, 3));        //Chama o método Somar com os parâmetros(int, int, int)

// -- Sobreposição -->
Carro carro = new Carro();
carro.Ligar();

Bmw m3 = new Bmw();
m3.Ligar();

