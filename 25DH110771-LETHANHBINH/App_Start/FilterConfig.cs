using System.Web;
using System.Web.Mvc;

namespace _25DH110771_LETHANHBINH
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
