using AutoMapper;
using Elect.Mapper.AutoMapper.IMappingExpressionUtils;
using Goblin.Ui_Base.Contract.Repository.Models;
using Goblin.Ui_Base.Core.Models;

namespace Goblin.Ui_Base.Mapper
{
    public class SampleProfile : Profile
    {
        public SampleProfile()
        {
            CreateMap<CreateSampleModel, SampleEntity>()
                .IgnoreAllNonExisting();
            
            CreateMap<SampleEntity, SampleModel>()
                .IgnoreAllNonExisting();
        }
    }
}