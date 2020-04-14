using System.Web;
using System.Web.Mvc;

namespace Ejercicio_T8_2C_MVC
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
