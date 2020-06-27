using System.Threading;
using System.Threading.Tasks;
using Elect.Web.Swagger.Attributes;
using Goblin.Ui_Base.Contract.Service;
using Goblin.Ui_Base.Core.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace Goblin.Ui_Base.Controllers
{
    public class SampleController : BaseController
    {
        private readonly ISampleService _sampleService;

        public SampleController(ISampleService sampleService)
        {
            _sampleService = sampleService;
        }

        /// <summary>
        ///     Create Sample
        /// </summary>
        /// <remarks>
        ///     <b>SampleData</b>: Cannot be null or empty <br />
        /// </remarks>
        /// <param name="model"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        [ApiDocGroup("Sample")]
        [HttpPost]
        [Route("/samples")]
        [SwaggerResponse(StatusCodes.Status201Created, "Sample Saved", typeof(SampleModel))]
        public async Task<IActionResult> Upload([FromBody] CreateSampleModel model, CancellationToken cancellationToken = default)
        {
            var sampleModel = await _sampleService.CreateAsync(model, cancellationToken);
            
            return Created(Url.Action("Get", new {sampleModel.Id}), sampleModel);
        }
        
        /// <summary>
        ///     Get Sample
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        [ApiDocGroup("Resource")]
        [HttpGet]
        [Route("/samples")]
        [SwaggerResponse(StatusCodes.Status200OK, "Sample Information", typeof(SampleModel))]
        public async Task<IActionResult> Get([FromRoute] long id, CancellationToken cancellationToken = default)
        {
            var sampleModel = await _sampleService.GetAsync(id, cancellationToken);

            return Ok(sampleModel);
        }
        
        /// <summary>
        ///     Delete Sample
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        [ApiDocGroup("Resource")]
        [HttpDelete]
        [Route("/samples")]
        [SwaggerResponse(StatusCodes.Status204NoContent, "Sample Deleted")]
        public async Task<IActionResult> Delete([FromRoute] long id, CancellationToken cancellationToken = default)
        {
            await _sampleService.DeleteAsync(id, cancellationToken);
            
            return NoContent();
        }
    }
}