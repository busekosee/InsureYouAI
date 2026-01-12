using Microsoft.AspNetCore.Mvc;

namespace InsureYouAI.ViewComponents.AdminLayoutViewComponents
{
    public class AdminLayoutNavbarComponentPartial:ViewComponent
    {
      public IViewComponentResult Invoke()
        {
            return View();

        }
    }
}
