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
}
