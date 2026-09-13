using System.Net.Http.Json;
using System.Text;
using ConsumerAdviceApi.Models;

Console.OutputEncoding = Encoding.UTF8;

const string endpoint = "https://api.adviceslip.com/advice";

Console.WriteLine("Iniciando requisição para obter dados de um conselho:");
Console.WriteLine();
Console.WriteLine(endpoint);
Console.WriteLine();

try
{
    using HttpClient httpClient = new();

    AdviceResponse? response = await httpClient.GetFromJsonAsync<AdviceResponse>(endpoint);

    if (response?.Slip?.Advice is null)
    {
        Console.WriteLine("Não foi possível encontrar um conselho na resposta da API.");
        return;
    }

    Console.WriteLine("Conselho de Hoje:");
    Console.WriteLine(response.Slip.Advice);
}
catch (HttpRequestException exception)
{
    Console.WriteLine($"Erro ao acessar a API: {exception.Message}");
}
catch (Exception exception)
{
    Console.WriteLine($"Ocorreu um erro inesperado: {exception.Message}");
}
