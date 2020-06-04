using Goblin.Ui_Base.Contract.Repository.Interfaces;

namespace Goblin.Ui_Base.Service.Base
{
    public abstract class Service
    {
        protected readonly IUnitOfWork UnitOfWork;

        protected Service(IUnitOfWork unitOfWork)
        {
            UnitOfWork = unitOfWork;
        }
    }
}