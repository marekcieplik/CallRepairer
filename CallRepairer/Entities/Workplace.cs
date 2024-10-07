namespace CallRepairer.Entities;

public class Workplace : EntityBase
{
    public string? Address { get; set; }

    public Workplace() { }

    public Workplace(string? address, string repairerProfession)
    {
        Address = address;

        base.RepairerProfession = repairerProfession;
    }

    public override string ToString() => $"Id: {Id}, Workplace address: {Address}, Who is needed: {RepairerProfession}";
}
