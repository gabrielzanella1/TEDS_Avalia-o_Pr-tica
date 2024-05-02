using System;
using System.Text.RegularExpressions;

public class Transferencia : IMetodoPagamento {
    public string Conta {get;set;}

    public void RealizarPagamento(){
        if(VerificarConta()){
            Console.WriteLine("Número de conta válido.");
        }else{
            Console.WriteLine("Conta inválida.");
        }
    }

    public void VerificarStatus(){
        if(VerificarConta()){
            Console.WriteLine("Pagamento efetuado via Transferência Bancária.");
            Console.WriteLine("Status do pagamento: Pago.");
        }else{
            Console.WriteLine("Status do pagamento: Pendente.");
        }
    }   

    public bool VerificarConta(){
        if(Regex.IsMatch(Conta, @"^\d{5}-\d$")){
            return true;
        }else{
            return false;
        }
    }
}