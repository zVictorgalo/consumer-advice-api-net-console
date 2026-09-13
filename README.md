# Consumer Advice API — .NET Console

Aplicação de console desenvolvida em C# para consumir um conselho aleatório da API [Advice Slip](https://api.adviceslip.com/advice).

Atividade da disciplina **Usabilidade, Desenvolvimento Web, Mobile e Jogos**, ministrada pelo professor Daniel Henrique Matos de Paiva.

## Funcionamento

A aplicação:

1. Faz uma requisição HTTP para o endpoint `https://api.adviceslip.com/advice`.
2. Converte a resposta JSON para objetos C#.
3. Mostra o conselho recebido no console.
4. Trata erros de comunicação ou respostas inválidas.

Exemplo de resposta da API:

```json
{
  "slip": {
    "id": 214,
    "advice": "Things are just things. Don't get too attached to them."
  }
}
```

Exemplo de saída:

```text
Iniciando requisição para obter dados de um conselho:

https://api.adviceslip.com/advice

Conselho de Hoje:
Things are just things. Don't get too attached to them.
```

Como o endpoint retorna dados aleatórios, o conselho exibido pode ser diferente a cada execução.

## Requisitos

- .NET SDK 8.0 ou superior.

## Como executar

No terminal, entre na pasta do projeto:

```bash
cd ConsumerAdviceApi
dotnet run
```

## Estrutura do projeto

```text
consumer-advice-api-net-console/
├── ConsumerAdviceApi/
│   ├── Models/
│   │   ├── AdviceResponse.cs
│   │   └── AdviceSlip.cs
│   ├── ConsumerAdviceApi.csproj
│   └── Program.cs
├── .gitignore
├── LICENSE
└── README.md
```

## Tecnologias

- C#
- .NET 8
- HttpClient
- System.Net.Http.Json

## Autor

Victor Rodrigues
