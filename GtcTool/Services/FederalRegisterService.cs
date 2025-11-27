using GtcTool.Models;

namespace GtcTool.Services;
public class FederalRegisterService
{
    public Response GetFederalRegisterResponse()
    {
        return new Response
        {
            Count = 0,
            Description = "Sample Federal Register Response",
            TotalPages = 0,
            NextPageUrl = string.Empty,
            Results = new List<Document>()
        };
    }

    public async Task<string> GetResponseJsonAsync()
    {
        // https://www.federalregister.gov/api/v1/documents.json
        using (HttpClient client = new HttpClient())
        {
            var response = await client.GetStringAsync("https://www.federalregister.gov/api/v1/documents.json");
            Response result = System.Text.Json.JsonSerializer.Deserialize<Response>(response, new System.Text.Json.JsonSerializerOptions
            {
                PropertyNamingPolicy = new Utils.SnakeCaseNamingPolicy(),
                WriteIndented = true
            }) ?? new Response();
            return System.Text.Json.JsonSerializer.Serialize(result, new System.Text.Json.JsonSerializerOptions
            {
                PropertyNamingPolicy = new Utils.SnakeCaseNamingPolicy(),
                WriteIndented = true
            });
        }
    }
}
