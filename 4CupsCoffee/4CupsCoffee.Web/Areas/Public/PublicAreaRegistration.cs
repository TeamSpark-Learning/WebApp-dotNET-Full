using System.Web.Mvc;

namespace _4CupsCoffee.Web.Areas.Public
{
    public class PublicAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Public";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Public_HomePage",
                "",
                new { controller = "Home", action = "Index" }
            );

            context.MapRoute(
                "Public_Default",
                "Public/{controller}/{action}/{id}",
                new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}