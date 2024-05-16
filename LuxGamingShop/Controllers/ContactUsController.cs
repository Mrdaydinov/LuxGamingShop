using LuxGamingShop.Models;
using Microsoft.AspNetCore.Mvc;

namespace LuxGamingShop.Controllers
{
    public class ContactUsController : Controller
    {
        public IActionResult Index()
        {
            var contactUs = new ContactUs
            {
                Title = "Some title",
                Address = "Some address",
                Description = "Some description",
                Email = "Some email",
                Phone = "Some phone"
            };

            return View(contactUs);
        }
    }
}
