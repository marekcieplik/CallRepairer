namespace CallRepairer.Entities;

public abstract class EntityBase : IEntity
{
    public int Id { get; set; }
    public string RepairerProfession { get; set; }
}
