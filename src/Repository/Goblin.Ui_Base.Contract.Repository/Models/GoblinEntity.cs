using Goblin.Core.DateTimeUtils;

namespace Goblin.Ui_Base.Contract.Repository.Models
{
    public abstract class GoblinEntity : Elect.Data.EF.Models.Entity
    {
        protected GoblinEntity()
        {
            CreatedTime = LastUpdatedTime = GoblinDateTimeHelper.SystemTimeNow;
        }
    }
}