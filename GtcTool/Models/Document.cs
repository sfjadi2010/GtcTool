namespace GtcTool.Models;

public class Document
{
    public string Title { get; set; } = default!;
    public string Type { get; set; } = default!;
    public string Abstract { get; set; } = default!;
    public string HtmlUrl { get; set; } = default!;
    public string PdfUrl { get; set; } = default!;
    public string PublicInspectionUrl { get; set; } = default!;
    public string PublicationDate { get; set; } = default!;
    public IList<Agency> Agencies { get; set; } = new List<Agency>();
    public string Excepts { get; set; } = default!;

    public override string ToString()
    {
        return Title;
    }
}
