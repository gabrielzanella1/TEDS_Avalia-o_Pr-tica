--- QUESTÃO 2
R: Uma interface é um contrato realizado com as subclasses, podendo conter: métodos, propriedades, eventos e indexadores. Estas classes então, tem o papel de definir como isso vai ser feito. 
Resumindo, a interface declara o que a classe deve fazer (contrato) e a subclasse define como vai fazer isso.

Prompt Gpt ->
Exemplo de Interface em C#

Resposta GPT ->
Claro, aqui está um exemplo simples de uma interface em C#:

namespace ExemploInterface
{
    // Definindo uma interface chamada IAnimal
    public interface IAnimal
    {
        // Método que deve ser implementado por todas as classes que implementam a interface
        void FazerBarulho();
    }

    // Implementação da interface IAnimal para a classe Cachorro
    public class Cachorro : IAnimal
    {
        public void FazerBarulho()
        {
            Console.WriteLine("Au Au!");
        }
    }

    // Implementação da interface IAnimal para a classe Gato
    public class Gato : IAnimal
    {
        public void FazerBarulho()
        {
            Console.WriteLine("Miau!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Criando uma instância de Cachorro
            IAnimal cachorro = new Cachorro();
            cachorro.FazerBarulho(); // Saída: Au Au!

            // Criando uma instância de Gato
            IAnimal gato = new Gato();
            gato.FazerBarulho(); // Saída: Miau!
        }
    }
}
Neste exemplo, temos a definição de uma interface IAnimal com um método FazerBarulho(). As classes Cachorro e Gato implementam essa interface e fornecem suas próprias implementações do método FazerBarulho(). Em seguida, no método Main, criamos instâncias de Cachorro e Gato através da interface IAnimal e chamamos o método FazerBarulho(), que imprime o som característico de cada animal.