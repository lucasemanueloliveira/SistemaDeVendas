
using System.Text.Json.Serialization;

namespace SistemaDeVendas.Models;

public class Venda
{
    [JsonPropertyName("vendedor")]
    public string Vendedor { get; set; }

    [JsonPropertyName("valor")]
    public decimal Valor { get; set; }

    public decimal CalcularComissao()
    {
        if (Valor < 100)
        {
            return 0;
        }

        if (Valor < 500)
        {
            return Valor * 0.01m;
        }

        return Valor * 0.05m;
    }
}
