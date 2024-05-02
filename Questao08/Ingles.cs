public class Ingles : Curso {

    public List<double> Notas { get; set; }

    public Ingles(string nome, string status, string nivel, int presenca) : base(nome, status, nivel, presenca) {
        Notas = new List<double>();
    }
    
    public void AdicionaNota(double nota) {
        Notas.Add(nota);
    }

    public void RemoveNota(double nota) {
        Notas.Remove(nota);
    }

    public void EmitirCertificado() {
        if (Status == "Concluido") {
            Console.WriteLine("O seu certificado de conclusão foi enviado no e-mail informado.");
        } else {
            Console.WriteLine("O seu certificado de conclusão não pode ser emitido.");
        }
    }

    public override void ConsultarPresenca() {
        if (Presenca < 80 && Presenca >= 80) {
            Console.WriteLine("Limite de faltas excedido.");
        } else {
            Console.WriteLine("Limite de faltas não excedido.");
        }
    }

    public double CalcularMediaNota() {
        if (Nivel == "Avançado" && Notas.Any()) {
            double total = 0;
            foreach (var nota in Notas) {
                total += nota;
            }

            return total / Notas.Count;
        }

        return 0;
    }
}