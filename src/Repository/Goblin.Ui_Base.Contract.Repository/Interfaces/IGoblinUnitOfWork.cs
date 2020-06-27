using Goblin.Ui_Base.Contract.Repository.Models;

namespace Goblin.Ui_Base.Contract.Repository.Interfaces
{
    public interface IGoblinUnitOfWork : Elect.Data.EF.Interfaces.UnitOfWork.IUnitOfWork
    {
        IGoblinRepository<T> GetRepository<T>() where T : GoblinEntity, new();
    }
}