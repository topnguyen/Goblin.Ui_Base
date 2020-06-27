using Microsoft.AspNetCore.Mvc;
using Goblin.Ui_Base.Filters;

namespace Goblin.Ui_Base.Controllers
{
    [ServiceFilter(typeof(GoblinUiAuthFilter))]
    public class BaseController : Controller
    {
    }
}