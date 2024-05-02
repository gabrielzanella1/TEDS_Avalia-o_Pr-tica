--- QUESTÃO 1
R: A herança na orientação a objeto, é um conceito que permite a simplificação do código por meio da reutilização de atributos e métodos de uma classe para outra, uma classe subclasse herda atributos de uma classe base ou superclasse. Podendo também, adicionar funcionalidades específicas, caso necessário, além das características base herdadas.
Ela é implementada da usando a palavra "Class" assim como na sintaxe padrão, mas as subclasse herdam as características através do caractere ":" (dois pontos), colocando o nome da subclasse : nome da classe base;

Prompt Gpt ->
Como usar public virtual e public override em C#

Resposta GPT ->
Virtual: É uma palavra-chave que permite que um método seja sobrescrito em classes derivadas. Isso significa que você pode substituir o comportamento padrão do método em uma classe base. Por exemplo:
public class MinhaClasseBase
{
    public virtual void MetodoVirtual()
    {
        Console.WriteLine("Classe base");
    }
}

public class MinhaClasseDerivada : MinhaClasseBase
{
    public override void MetodoVirtual()
    {
        Console.WriteLine("Classe derivada");
    }
}

Override: É uma palavra-chave usada para substituir um método virtual da classe base em uma classe derivada. O método substituído na classe derivada deve ter a mesma assinatura (nome, tipo e número de parâmetros) que o método virtual na classe base. Por exemplo, na classe MinhaClasseDerivada acima, MetodoVirtual está substituindo o método virtual da classe base MinhaClasseBase.