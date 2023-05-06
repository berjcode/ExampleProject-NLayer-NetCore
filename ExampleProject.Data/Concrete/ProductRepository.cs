using ExampleProject.Core.Data.Concrete.EntityFrameWork;
using ExampleProject.Data.Abstract;
using ExampleProject.Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace ExampleProject.Data.Concrete;

public sealed class ProductRepository : EFEntityRepositoryBase<Product>, IProductRepository
{
    public ProductRepository(DbContext context) : base(context)
    {
    }
}
