using System.Web;
using System.Web.Mvc;

namespace SistemaFerreteria_Victor_Lozano_Vargas_SAC
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
