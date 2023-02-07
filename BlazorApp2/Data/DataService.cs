namespace BlazorApp2.Data;
using System.Text.Json;

public class DataService
{
    public async Task<string> GetJsonResponseAsync(string url)
    {
        HttpClient httpClient = new HttpClient();
        var httpResponseMessage = await httpClient.GetAsync(url);
        return await httpResponseMessage.Content.ReadAsStringAsync();
    }
}