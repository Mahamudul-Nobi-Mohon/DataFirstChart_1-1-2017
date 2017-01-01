using System.Web;
using System.Web.Mvc;

namespace DatafirstChart_1_1_2017
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
