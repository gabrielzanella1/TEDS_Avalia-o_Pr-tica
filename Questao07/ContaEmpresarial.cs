public class ContaEmpresarial : Banco{
    public double Valor {get;set;}
    public double Saldo {get;set;}

    public ContaEmpresarial (string NumeroConta){
        this.NumeroConta = NumeroConta;
    }

    public override void Depositar(double Valor){
        Saldo += Valor;
        Console.WriteLine("Deposito no valor de " + Valor + " reais efetuado na conta " + NumeroConta);
        Console.WriteLine("Deposito feito na Conta Empresarial.");
        Console.WriteLine("O saldo resultante é: " + Saldo);
    }

    public override void Sacar(double Valor){
        
        if(VerificaSaldoMinimo() == true){
            if (Valor <= Saldo){
                Saldo -= Valor;
                Console.WriteLine("Saque no valor de " + Valor + " reais efetuado na conta " + NumeroConta);
                Console.WriteLine("Saque feito na Conta Empresarial.");
                Console.WriteLine("O saldo resultante é: " + Saldo);
            }else{
                Console.WriteLine("Negado, seu Saldo é: " + Saldo);
            }
        }
    }
        

    public bool VerificaSaldoMinimo(){
        if(Saldo <= 1000){
            Console.WriteLine("Não é possível efetuar a operação de saque pois o saldo mínimo será ultrapassado.");
            return false;
        }else {
            return true;
        }
    }
}