public class Filme {
    public string Titulo {get;set;}
    public string Genero {get;set;}
    public double Duracao {get;set;}
    public bool Disponivel {get;set;}

    public Filme(string Titulo, string Genero, double Duracao, bool Disponivel){
        this.Titulo = Titulo;
        this.Genero = Genero;
        this.Duracao = Duracao;
        this.Disponivel = Disponivel;
    }

    public bool Locar(){
        Verificar();
        Console.WriteLine($"Você acaba de locar o filme {Titulo}! Devolva-o em até cinco dias.");
        return Disponivel = false;
    }   

    public void Devolver(){
        Console.WriteLine($"Você efetuou a devolução do filme {Titulo}. Obrigado pela preferência!");
        Disponivel = true;
    }

    public void Verificar(){
        if(Disponivel == true){
            Console.WriteLine($"{Titulo} está disponível para locação!");
        }else{
            Console.WriteLine($"{Titulo} não está disponível para locação!");
        }
    }
}   