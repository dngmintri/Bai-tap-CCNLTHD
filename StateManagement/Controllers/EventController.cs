using Microsoft.AspNetCore.Mvc;

public class EventController : Controller
{

    [HttpPost]
    public IActionResult Index(EventRegistration eventRegistration)
    {
        if(!ModelState.IsValid)
        {
            TempData["Success"] = null;
            return View(eventRegistration);
        }

        TempData["Success"] = "Sản phẩm đã được tạo thành công!";
        return RedirectToAction("Index");

    }

    [HttpGet]
    public IActionResult Index()
    {
        return View();
    }
}