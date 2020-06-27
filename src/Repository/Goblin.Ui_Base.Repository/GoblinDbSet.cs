using Goblin.Ui_Base.Contract.Repository.Models;
using Microsoft.EntityFrameworkCore;

namespace Goblin.Ui_Base.Repository
{
    public sealed partial class GoblinDbContext
    {
        public DbSet<SampleEntity> Samples { get; set; }
    }
}