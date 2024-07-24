namespace CallRepairer.Entities;

public class Plumber : RepairerBase
{
    public string? PlumberName { get; set; }

    public Plumber() {}

    public Plumber(string? plumberName)
    {
        PlumberName = plumberName;
    }

    public override string ToString() => $"Id:{Id}, Name: {PlumberName}, Plumber";
}
