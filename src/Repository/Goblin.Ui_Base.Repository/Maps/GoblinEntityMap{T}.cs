﻿using Elect.Data.EF.Services.Map;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Goblin.Ui_Base.Contract.Repository.Models;

namespace Goblin.Ui_Base.Repository.Maps
{
    public class GoblinEntityMap<T> : TypeConfiguration<T> where T : GoblinEntity
    {
        public override void Map(EntityTypeBuilder<T> builder)
        {
            // Key
            builder.HasKey(x => x.Id);

            // Index
            builder.HasIndex(x => x.Id);
            builder.HasIndex(x => x.CreatedTime);
            builder.HasIndex(x => x.LastUpdatedTime);
            builder.HasIndex(x => x.DeletedTime);
        }
    }
}