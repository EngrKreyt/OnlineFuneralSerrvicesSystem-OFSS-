using System.Web;
using System.Web.Mvc;

namespace OnlineFuneralSerrvicesSystem_OFSS_
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
