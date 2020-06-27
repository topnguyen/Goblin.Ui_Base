using Elect.DI.Attributes;
using Goblin.Ui_Base.Contract.Repository.Interfaces;
using Goblin.Ui_Base.Contract.Repository.Models;

namespace Goblin.Ui_Base.Repository
{
    [ScopedDependency(ServiceType = typeof(IGoblinRepository<>))]
    public class GoblinRepository<T> : Elect.Data.EF.Services.Repository.BaseEntityRepository<T>, IGoblinRepository<T> where T : GoblinEntity, new()
    {
        public GoblinRepository(Elect.Data.EF.Interfaces.DbContext.IDbContext dbContext) : base(dbContext)
        {
        }
    }
}