public class BoletoBancario : IMetodoPagamento {
    public string NumeroBoleto {get;set;}

    public bool RealizarPagamento(){
        if(VerificarBoleto()){
            Console.WriteLine("Boleto válido!");
            return true;
        }else{
            Console.WriteLine("Boleto inválido!");
            return false;
        }
    }

    public void VerificarStatus(){
        if(VerificarBoleto()){
            Console.WriteLine($"Compra via Boleto aprovada.");
            Console.WriteLine("Status do pagamento: Pago.");
        }else{
            Console.WriteLine("Compra via Boleto reprovada.");
            Console.WriteLine("Status do pagamento: Pendente.");
        }
    }

    public bool VerificarBoleto(){
        if(NumeroBoleto.Length == 10){
            return true;
        }else {
            return false;
        }
    }
}