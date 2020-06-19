using System;

namespace Aula21Exercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente gustavo = new Cliente("Gustavo");
            gustavo.Endereco = "Av.Paulista, 111";
            Console.WriteLine (gustavo.MostrarDados() );

            Restaurante outback = new Restaurante("Outback");
            outback.Endereco = "Rua da Idependência, 23";
            System.Console.WriteLine(outback.MostrarDados() );

            Pedido pedido1= new Pedido();
            pedido1.Cliente = gustavo.NomeCliente;
            pedido1.Restaurante = outback.NomeRestaurante;
            Console.WriteLine(pedido1.EntregarPedido() );
        }
    }
}
