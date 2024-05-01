public class Shopee : ITipoPagamento, ITipoEntrega{
    public void PagarComBoleto(){
        Console.WriteLine("Aqui na Shopee, seu pedido chega em até dois dias com pagamento via Boleto.");
    }

    public void PagarComPix(){
        Console.WriteLine("Aqui na Shopee, seu pedido chega no mesmo dia com o pagamento via Pix.");
    }

    public void CancelarCompra(){
        Console.WriteLine("Só é possível efetuar o cancelamento caso o produto possua defeito.");
    }   
}