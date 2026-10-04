using SistemaDeVendas.Models;
using System.Text.Json;


namespace SistemaDeVendas
{
    public class Program
    {
         static void Main(string[] args)
        {
            string json = File.ReadAllText("vendas.json");

            DadosVendas dados = JsonSerializer.Deserialize<DadosVendas>(json);

            foreach (Venda venda in dados.Vendas)
            {
                decimal comissao = venda.CalcularComissao();

                Console.WriteLine(
                    $"Vendedor: {venda.Vendedor} | " +
                    $"Venda: R$ {venda.Valor:F2} | " +
                    $"Comissão: R$ {comissao:F2}"
                );
            }
        }
    }
}