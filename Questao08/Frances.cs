public class Frances : Curso {
   
    public Frances(string nome, string status, string nivel, int presenca) : base(nome, status, nivel, presenca) {

    }

    public override void ConsultarPresenca(){
        if(Presenca < 75){
            Console.WriteLine("Limite de faltas excedido.");
        }else {
            Console.WriteLine("Limite de faltas não excedido.");
        }
    }

       public void EmitirCertificado() {
        if (Status == "Concluido" && Presenca >= 75) {
            Console.WriteLine("O seu certificado de conclusão foi enviado no e-mail informado.");
        } else {
            Console.WriteLine("O seu certificado de conclusão não pode ser emitido.");
        }
    }
}