using ExampleProject.Core.Data.Concrete.EntityFrameWork;
using ExampleProject.Data.Abstract;
using ExampleProject.Entities.Concrete;

namespace ExampleProject.Data.Concrete.Repositories;

public sealed class RoleRepository : EFEntityRepositoryBase<Role>, IRoleRepository
{
}
