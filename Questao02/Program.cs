//---------> Exemplo Prático

interface IPresa {
    //A classe que utilizará a interface IPresa, deve conter o método Fugir().
    void Fugir():
}

interface IPredador {
    //A classe que utilizará a interface IPredador, deve conter o método Cacar().
    void Cacar();
}

public class Rato : IPresa {
    //A classe Rato definiu como irá utilizar o método Fugir() herdado.
    public void Fugir(){
        Console.WriteLine("Preciso correr da águia!");
    }
}

public class Aguia : IPredador {
    //A classe Aguia definiu como irá utilizar o método Cacar() herdado.
    public void Cacar(){
        Console.WriteLine("Preciso caçar os roedores!");
    }
}

public class Piranha : IPresa, IPredador {
    //É possível também herdar características de duas ou mais interfaces.
    public void Fugir(){
        Console.WriteLine("Preciso correr da Traíra!");
    }

    public void Cacar(){
        Console.WriteLine("Prciso caçar os Lambaris");
    }
}