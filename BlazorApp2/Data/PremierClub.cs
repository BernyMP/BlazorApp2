namespace BlazorApp2.Data;

public class PremierClub
{
    public int Position { get; set; }
    public string? Club { get; set; }
    public int Played { get; set; }
    public int Won { get; set; }
    public int Drawn { get; set; }
    public int Lost { get; set; }
    public int GF { get; set; }
    public int GA { get; set; }
    public int GoalDifference
    {
        get
        {
            return Math.Abs(GF-GA);
        }
    }
    public int Points { get; set; }
}