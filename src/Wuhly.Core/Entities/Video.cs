namespace Wuhly.Core.Entities;

public class Video
{
    public string Id { get; set; } = Guid.NewGuid().ToString();
    public required string YouTubeId { get; set; }
    public required string Title { get; set; }
    public string? Description { get; set; }
    public required string ThumbnailUrl { get; set; }
    public int DurationSeconds { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.Now;
}