namespace Datashi.Api;

public class Query
{
    public Sushi GetSushi() =>
        new()
        {
            Name = "Sushi",
            Description = "Taste sushi"
        };
}
