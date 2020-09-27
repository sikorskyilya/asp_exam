using System.Web;
using System.Web.Mvc;

namespace _16_MODEL_REPOS
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
