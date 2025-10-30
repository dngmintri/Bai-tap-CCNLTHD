using Microsoft.AspNetCore.Mvc;

public class EventController : Controller
{

    [HttpPost]
    public IActionResult Register(EventRegistration eventRegistration)
    {
        if(!ModelState.IsValid)
        {
            TempData["Success"] = null;
            return View(eventRegistration);
        }

        TempData["Success"] = "SuccessMessage";
        return RedirectToAction("Register");

    }

    [HttpGet]
    public IActionResult Register()
    {
        return View();
    }
}