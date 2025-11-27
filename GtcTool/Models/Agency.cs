namespace GtcTool.Models;

public class Agency
{
    public int Id { get; set; }
    public string RawName { get; set; } = default!;
    public string Name { get; set; } = default!;
    public string JsonUrl { get; set; } = default!;
    public int? ParentId { get; set; }
    public string Slug { get; set; } = default!;

    public override string ToString()
    {
        return Name;
    }
}
