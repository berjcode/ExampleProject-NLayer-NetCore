using ExampleProject.Core.Entities.Abstract;

namespace ExampleProject.Entities.Concrete;

public sealed  class Product:EntityBase,IEntity
{
    public string  Name { get; set; }
}
