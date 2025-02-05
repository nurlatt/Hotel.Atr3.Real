using Hotel.Atr3.Real.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Hotel.Atr3.Real.Controllers
{
    public class EventController : Controller
    {
        public IActionResult Index()
        {
            #region GET data from DataBase
            List<EventViewModel> events = new List<EventViewModel>();

            EventViewModel even = new EventViewModel();
            even.ImageSize = 2;
            even.PathImage = "~/img/event/1.jpg";
            even.EventTitle = "management conferences";
            even.AuthorName = "By : Jhtyg Hyuir";
            even.Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt";

            events.Add(even);
            #endregion



            return View(events);
        }
    }
}
