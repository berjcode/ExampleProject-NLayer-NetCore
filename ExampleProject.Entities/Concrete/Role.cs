using ExampleProject.Core.Entities.Abstract;

namespace ExampleProject.Entities.Concrete;

public sealed class Role : EntityBase, IEntity
{
    public string Name { get; set; }
    public string Description { get; set; }
    public ICollection<User> Users { get; set; }
}
