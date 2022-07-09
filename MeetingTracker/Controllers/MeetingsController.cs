using Microsoft.AspNetCore.Mvc;
using MeetingTracker.Models;
using Microsoft.AspNetCore.Authorization;

namespace MeetingTracker.Controllers
{
  
    public class MeetingsController : Controller
    {
        IMeetingRepoistory _repo;
        public IActionResult Index()
        {
            ViewBag.PageTitle = "Meetings List";
            _repo = new MeetingRepoistory();

            List<Meeting> meetings = _repo.GetMeetings();

            return View(meetings);
        }
    }
}
