using Elect.DI.Attributes;
using Goblin.Ui_Base.Contract.Repository.Interfaces;
using Goblin.Ui_Base.Contract.Service;
using System.Threading;
using System.Threading.Tasks;
using Elect.Mapper.AutoMapper.IQueryableUtils;
using Elect.Mapper.AutoMapper.ObjUtils;
using Goblin.Ui_Base.Contract.Repository.Models;
using Goblin.Ui_Base.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace Goblin.Ui_Base.Service
{
    [ScopedDependency(ServiceType = typeof(ISampleService))]
    public class SampleService : Base.Service, ISampleService
    {
        private readonly IGoblinRepository<SampleEntity> _sampleRepo;

        public SampleService(IGoblinUnitOfWork goblinUnitOfWork, IGoblinRepository<SampleEntity> sampleRepo) : base(
            goblinUnitOfWork)
        {
            _sampleRepo = sampleRepo;
        }

        public async Task<SampleModel> CreateAsync(CreateSampleModel model,
            CancellationToken cancellationToken = default)
        {
            var sampleEntity = model.MapTo<SampleEntity>();

            _sampleRepo.Add(sampleEntity);

            await GoblinUnitOfWork.SaveChangesAsync(cancellationToken).ConfigureAwait(true);

            var fileModel = sampleEntity.MapTo<SampleModel>();

            return fileModel;
        }

        public async Task<SampleModel> GetAsync(long id, CancellationToken cancellationToken = default)
        {
            var sampleModel =
                await _sampleRepo
                    .Get(x => x.Id == id)
                    .QueryTo<SampleModel>()
                    .FirstOrDefaultAsync(cancellationToken: cancellationToken)
                    .ConfigureAwait(true);

            return sampleModel;
        }

        public async Task DeleteAsync(long id, CancellationToken cancellationToken = default)
        {
            var sampleEntity =
                await _sampleRepo
                    .Get(x => x.Id == id)
                    .FirstOrDefaultAsync(cancellationToken: cancellationToken)
                    .ConfigureAwait(true);
            
            _sampleRepo.Delete(sampleEntity);

            await GoblinUnitOfWork.SaveChangesAsync(cancellationToken).ConfigureAwait(true);
        }
    }
}