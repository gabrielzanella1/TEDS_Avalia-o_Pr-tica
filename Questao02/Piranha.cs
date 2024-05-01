
public class Piranha : IPresa, IPredador {
    //É possível também herdar características de duas ou mais interfaces.
    public void Fugir(){
        Console.WriteLine("Preciso correr da Traíra!");
    }
       public void Cacar(){
        Console.WriteLine("Prciso caçar os Lambaris!");
    }
}