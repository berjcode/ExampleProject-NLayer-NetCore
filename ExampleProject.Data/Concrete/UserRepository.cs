using ExampleProject.Core.Data.Concrete.EntityFrameWork;
using ExampleProject.Data.Abstract;
using ExampleProject.Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace ExampleProject.Data.Concrete;

public sealed class UserRepository : EFEntityRepositoryBase<User>, IUserRepository
{
    public UserRepository(DbContext context) : base(context)
    {
    }
}
