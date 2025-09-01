namespace Wuhly.Core.Entities;

public class Achievement
{
    public string Id { get; set; } = Guid.NewGuid().ToString();
    public int ConditionValue { get; set; }
    public double ComplicationRate { get; set; }
    public required string Name { get; set; }
    public required string IconUrl { get; set; }
    public required string Description { get; set; }
}