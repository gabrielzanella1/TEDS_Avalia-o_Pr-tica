public class CartaoCredito : IMetodoPagamento{
    public string Bandeira {get;set;}

    public bool RealizarPagamento(){
        if(VerificarBandeira()){
            Console.WriteLine("Bandeira aceita!");
            return true;
        }else{
            Console.WriteLine("Bandeira recusada!");
            return false;
        }
    }

    public void VerificarStatus(){
        if(VerificarBandeira()){
            Console.WriteLine($"Compra aprovada no cartão {Bandeira}.");
            Console.WriteLine("Status do pagamento: Pago.");
        }else{
            Console.WriteLine("Esta bandeira não é aceita.");
            Console.WriteLine("Status do pagamento: Pendente.");
        }
    }

    public bool VerificarBandeira(){
        if(Bandeira == "Visa"){
            return true;
        }else{
            return false;
        }
    }   
}