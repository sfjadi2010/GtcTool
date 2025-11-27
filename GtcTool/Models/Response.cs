namespace GtcTool.Models;

public class Response
{
    public int Count { get; set; }
    public string Description { get; set; } = default!;
    public int TotalPages { get; set; }
    public string NextPageUrl { get; set; } = default!;
    public IList<Document> Results { get; set; } = new List<Document>();

    public override string ToString()
    {
        return $"{Count} results";
    }
}
