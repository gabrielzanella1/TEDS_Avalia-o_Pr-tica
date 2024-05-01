public class Amazon : ITipoPagamento {
    public void PagarComBoleto(){
        Console.WriteLine("Aqui na Amazon, seu pedido chega em até cinco dias com pagamento via Boleto.");
    }

    public void PagarComPix(){
        Console.WriteLine("Aqui na Amazon, seu pedido chega em até três dias com o pagamento via Pix.");
    }

    public void CancelarCompra(){
        Console.WriteLine("Deseja cancelar a compra? Aceite os termos da Amazon.");
    }   
}