using Microsoft.AspNetCore.Mvc.Filters;

namespace Goblin.Ui_Base.Filters
{
    public static class GoblinUiAuthHelper
    {
        public static bool IsAuthenticate(AuthorizationFilterContext context)
        {
            return true;
        }
    }
}