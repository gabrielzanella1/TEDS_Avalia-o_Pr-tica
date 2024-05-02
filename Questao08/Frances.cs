public class Frances : Curso {
    public override void ConsultarPresenca(){
        if(Presenca < 75){
            Console.WriteLine("Limite de faltas excedido.");
        }else {
            Console.WriteLine("Limite de faltas não excedido.");
        }
    }
}