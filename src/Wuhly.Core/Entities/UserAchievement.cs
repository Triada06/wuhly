namespace Wuhly.Core.Entities;

public class UserAchievement
{
    public string UserId { get; set; }
    public User User { get; set; }
    
    public string AchievementId { get; set; }
    public Achievement Achievement { get; set; }
    
    public DateTime UnlockedAt { get; set; } = DateTime.UtcNow;
    
}