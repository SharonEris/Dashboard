using Microsoft.AspNetCore.Mvc;

public class AccountController : Controller
{
    // Other action methods...

    public ActionResult Register()
    {
        // Your register logic here
        return View();
    }

    public ActionResult MyProfile()
    {
        // Your register logic here
        return View();
    }

    public IActionResult Settings()
    {
        return View();
    }

}

