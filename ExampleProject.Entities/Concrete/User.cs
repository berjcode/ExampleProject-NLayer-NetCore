
using ExampleProject.Core.Entities.Abstract;

namespace ExampleProject.Entities.Concrete;

public sealed class User:EntityBase,IEntity
{
    public string Name  { get; set; }
    public string LastName { get; set; }
    public string UserName { get; set; }
    public byte[]  PasswordHash { get; set; }
    public int RoleId { get; set; }
    public Role  Role{ get; set; }

}
