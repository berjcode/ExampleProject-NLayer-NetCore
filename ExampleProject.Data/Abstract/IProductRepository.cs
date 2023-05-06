using ExampleProject.Core.Data.Abstract;
using ExampleProject.Entities.Concrete;

namespace ExampleProject.Data.Abstract;

public interface IProductRepository :IEntityRepository<Product>
{
}
