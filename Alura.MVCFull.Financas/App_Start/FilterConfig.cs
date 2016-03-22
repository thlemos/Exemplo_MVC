using System.Web;
using System.Web.Mvc;

namespace Alura.MVCFull.Financas
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}