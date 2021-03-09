using System.Web;
using System.Web.Mvc;

namespace PTBC_CRUD_Test
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
