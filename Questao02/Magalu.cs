public class Magalu : ITipoPagamento {
    public void PagarComBoleto(){
        Console.WriteLine("Aqui na Magalu, seu pedido chega em até dez dias com pagamento via Boleto.");
    }

    public void PagarComPix(){
        Console.WriteLine("Aqui na Magalu, seu pedido chega em até cinco dias com o pagamento via Pix.");
    }

    public void CancelarCompra(){
        Console.WriteLine("Não é possível cancelar a compra.");
    }   
}