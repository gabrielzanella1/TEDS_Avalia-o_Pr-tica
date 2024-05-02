public class Ingles : Curso {

    public List<double> Notas { get; set; } //Como passar lista como arguimento

    public Ingles (string Nome, int Duracao, List<double> notas) {
        Notas = notas;
    }

    public void EmitirCertificado(){
        if(Status == "Concluido"){
            Console.WriteLine("O seu certificado de conclusão foi enviado no e-mail informado.");
        }else{
            return;
        }
    }

    public override void ConsultarPresenca(){
        if(Presenca < 80){
            Console.WriteLine("Limite de faltas excedido.");
        }else {
            Console.WriteLine("Limite de faltas não excedido.");
        }
    }

    public void CalcularMediaNota(){
        if(Nivel == "Avançado"){
            double total = 0;
            foreach (var nota in Notas){
                total += nota;
            }

            return total / Notas.Count;
        }
    }
}