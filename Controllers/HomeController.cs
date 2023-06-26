using Microsoft.AspNetCore.Mvc;
using PostDataUsingAjaxMike.Models;

namespace PostDataUsingAjaxMike.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult WithValidation()
        {
            return View();
        }

        [HttpPost]
        public JsonResult SaveStudentWithSerialize(Student student1)
        {
            return Json("student saved successfully");
        }
    }
}
