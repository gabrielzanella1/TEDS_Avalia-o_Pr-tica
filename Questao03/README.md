--- QUESTÃO 3
R: A sobrecarga é usada quando em uma classe possuem dois métodos com o mesmo nome, algo que não seria possível sem a sobrecarga, mas quando os diferenciam através de parâmetros ou assinatura, se torna possível. 
A sobreposição ocorre quando uma subclasse herda um método da classe base, mas precisa de uma implementação específica para o mesmo, substituindo então o método herdado da classe base para a funcionalidade desejada. 
O conceito de sobrecarga ocorre dentro de uma mesma classe, já o de sobreposição dentro de uma ou mais subclasses.

Prompt Gpt ->
Exemplo de Sobrecarga e Sobreposição em C#

Resposta GPT ->
Claro, aqui estão os exemplos:

Exemplo de Sobrecarga (Overload):
class Calculadora
{
    public int Somar(int a, int b)
    {
        return a + b;
    }

    public double Somar(double a, double b)
    {
        return a + b;
    }
}

class Program
{
    static void Main()
    {
        Calculadora calculadora = new Calculadora();
        Console.WriteLine(calculadora.Somar(5, 3)); // Saída: 8
        Console.WriteLine(calculadora.Somar(4.5, 2.5)); // Saída: 7.0
    }
}

Neste exemplo, a classe Calculadora possui dois métodos Somar com a mesma nome, mas com diferentes tipos de parâmetros. Dependendo dos parâmetros passados, o compilador irá decidir qual versão do método chamar.


Exemplo de Sobreposição (Override):
class Animal
{
    public virtual void Falar()
    {
        Console.WriteLine("Animal faz algum som.");
    }
}

class Cachorro : Animal
{
    public override void Falar()
    {
        Console.WriteLine("O cachorro faz: Au Au!");
    }
}

class Program
{
    static void Main()
    {
        Animal animal = new Animal();
        animal.Falar(); // Saída: Animal faz algum som.

        Cachorro cachorro = new Cachorro();
        cachorro.Falar(); // Saída: O cachorro faz: Au Au!

        Animal cachorro2 = new Cachorro();
        cachorro2.Falar(); // Saída: O cachorro faz: Au Au!
    }
}

Neste exemplo, a classe Cachorro herda da classe Animal e sobrescreve o método Falar. Quando um objeto Cachorro é criado e chamamos o método Falar, a versão do método da classe Cachorro é executada, mesmo se a referência for do tipo Animal. Isso ocorre devido ao polimorfismo em C#.