public class Espanhol : Curso {

    public override void ConsultarPresenca(){
        if(Presenca < 70){
            Console.WriteLine("Limite de faltas excedido.");
        }else {
            Console.WriteLine("Limite de faltas não excedido.");
        }
    }
}