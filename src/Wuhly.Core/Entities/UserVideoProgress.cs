namespace Wuhly.Core.Entities;

public class UserVideoProgress
{
    public string Id { get; set; } = Guid.NewGuid().ToString();

    public int ProgressSec { get; set; }
    public bool IsCompleted { get; set; }
    public string UserId { get; set; }
    public User User { get; set; }
    public string VideoId { get; set; }
    public Video Video { get; set; }

    public required DateTime DateTime { get; set; }
}