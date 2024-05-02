public class GrupoGrande {

    public string Destino {get;set;}
    public bool Disponivel {get;set;}
    public bool Reservada;


    public GrupoGrande(string Destino, bool Disponivel){
        this.Destino = Destino;
        this.Disponivel = Disponivel;
    }

    public bool ReservarVoo(){
        if(Verificar()){
            Console.WriteLine($"Sua viagem para {Destino} esta disponível para reserva em grandes grupos!");
            Console.WriteLine($"Viagem com destino a {Destino} efetuada!");
            return Reservada = true;
        }else {
            Console.WriteLine($"Sua viagem para {Destino} nao esta disponível para reserva em grandes grupos!");
            Console.WriteLine("Reserva Pendente.");
            return Reservada = false;
        }
    }

    public void CancelarVoo(){
        if(Reservada){
            Console.WriteLine("Reserva cancelada.");
            Reservada = false;
        }else{
            Console.WriteLine("Não existe um reserva para cancelar.");
        }
    }

    public void StatusReserva(){
        if(Reservada){
            Console.WriteLine("Reserva em grandes grupos efetuada!");
        }else {
            Console.WriteLine("Reserva pendente!");
        }
    }

    public bool Verificar(){
        if(Disponivel == true){
            return true;
        }else{
            return false;
        }
    }
}