
using System.Text.Json.Serialization;

namespace SistemaDeVendas.Models;

public class DadosVendas
{
    [JsonPropertyName("vendas")]
    public List<Venda> Vendas { get; set; }


}
