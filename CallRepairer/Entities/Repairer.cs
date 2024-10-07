namespace CallRepairer.Entities;

public class Repairer : EntityBase
{
    public string? FirstName { get; set; }
    public Repairer() {}

    public Repairer(string firstName, string profession)
    {
        FirstName = firstName;
        base.RepairerProfession = profession;
    }

    public override string ToString() => $"Id:{Id}, Name: {FirstName},  Profession: {base.RepairerProfession}";
}
