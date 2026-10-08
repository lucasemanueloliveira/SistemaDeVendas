# SistemaDeVendas

Solução desenvolvida em **C#/.NET** como parte de um desafio técnico proposto durante um processo seletivo.

## Sobre o projeto

O desafio consiste em desenvolver um programa capaz de ler registros de vendas de um time comercial a partir de um arquivo JSON e calcular a comissão de cada vendedor de acordo com as regras de negócio definidas.

## Regras de comissão

A comissão é calculada individualmente para cada venda:

| Valor da venda | Comissão |
|---|---:|
| Abaixo de R$ 100,00 | 0% |
| Abaixo de R$ 500,00 | 1% |
| A partir de R$ 500,00 | 5% |

### Exemplo

Para uma venda de **R$ 1.200,50**, a comissão é calculada da seguinte forma:

```text
R$ 1.200,50 × 5% = R$ 60,03
```

## Funcionamento

A aplicação:

1. Lê os registros de vendas armazenados em um arquivo JSON.
2. Desserializa os dados para objetos C#.
3. Analisa o valor de cada venda.
4. Aplica a regra de comissão correspondente.
5. Calcula e apresenta a comissão de cada venda.

## Exemplo de estrutura dos dados

```json
{
  "vendas": [
    {
      "vendedor": "João Silva",
      "valor": 1200.50
    }
  ]
}
```

## Tecnologias utilizadas

- C#
- .NET
- System.Text.Json
- JSON
- Programação Orientada a Objetos
- Git
- GitHub

## Estrutura do projeto

```text
SistemaDeVendas/
│
├── Models/
│   ├── DadosVendas.cs
│   └── Venda.cs
│
├── Program.cs
├── vendas.json
└── README.md
```

## Como executar

1. Clone o repositório.
2. Abra o projeto no Visual Studio.
3. Compile a aplicação.
4. Execute o projeto.

## Objetivo

Este projeto foi desenvolvido para atender aos requisitos apresentados no desafio técnico, demonstrando a implementação de regras de negócio em **C#/.NET**, leitura e desserialização de dados em **JSON** e utilização de **Programação Orientada a Objetos**.
