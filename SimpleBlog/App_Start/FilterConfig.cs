using System.Web.Mvc;
using SimpleBlog.Infastructure;

namespace SimpleBlog
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new TransactionFilter());
            filters.Add(new HandleErrorAttribute());
        }
    }
}