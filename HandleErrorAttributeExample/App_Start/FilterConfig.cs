using System.Web;
using System.Web.Mvc;

namespace HandleErrorAttributeExample
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
//onException mvc how to handle that
//create ur  any filter model 

    //name   Gender
    //sandya  F
    //mohanty M

    //Miss Sandya
    //Mr Mohanty