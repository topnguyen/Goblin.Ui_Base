using Elect.Core.ConfigUtils;
using Goblin.Core.Web.Setup;
using Goblin.Ui_Base.Core.Validators;
using Goblin.Ui_Base.Core;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;

namespace Goblin.Ui_Base
{
    public class Startup : BaseUiStartup
    {
        public Startup(IWebHostEnvironment env, IConfiguration configuration) : base(env, configuration)
        {
            RegisterValidators.Add(typeof(IValidator));

            BeforeConfigureServices = services =>
            {
                // Setting

                SystemSetting.Current = Configuration.GetSection<SystemSetting>("Setting");
            };
        }
    }
}