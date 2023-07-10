using BookReading.Event.Models;
using BookReading.Event.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using BookReading.Event.Data;

namespace BookReading.Event.Controllers
{
    public class EventController : Controller
    {
        private readonly ICommentRepository _iCommentRepository = null;
        private readonly IEventRepository _iEventRepository = null;
        public EventController(ICommentRepository iCommentRepository, IEventRepository iEventRepository)
        {
            _iCommentRepository = iCommentRepository;
            _iEventRepository = iEventRepository;
        }
        public IActionResult Index()
        {
            return View();
        }

        [Route("Events")]
        [Authorize(Roles = Role.Admin)]
        public async Task<IActionResult> GetEvents()
        {
            var eventList = await _iEventRepository.GetEvents();
            return View(eventList);
        }

        [Route("Events/{id}")]
        [Authorize(Roles = Role.Admin)]
        public async Task<IActionResult> ViewDetails(int? id)
        {
            var details = await _iEventRepository.ViewDetails(id.Value);
            var ans = await _iEventRepository.GetAllCommentByEventId(id.Value);
            details.Comments = ans;
            if (details == null)
            {
                return RedirectToAction("GetEvents");
            }
            return View(details);
        }

        [Authorize]
        [Route("CreateEvent")]
        public IActionResult CreateEvent()
        {
            return View();
        }
        
        [Authorize]
        [HttpPost]
        [Route("CreateEvent")]
        public async Task<IActionResult> CreateEvent(EventViewModel eventViewModel)
        {
            var result = await _iEventRepository.CreateEvent(eventViewModel);
            if (result > 0)
            {
                return RedirectToAction(nameof(CreateEvent));
            }
            return View();
        }

        [Authorize]
        [Route("UpadteEvent/{id}")]                                     //Update Event get Method
        [Authorize(Roles = Role.Admin)]
        public async Task<IActionResult> UpdateEvent(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("GetEvents");
            }
            var ans = await _iEventRepository.ViewDetails(id.Value); ;

            if (ans == null)
            {
                return RedirectToAction("GetEvents");
            }

            return View(ans);
        }

        [Authorize]
        [HttpPost]
        [Route("UpadteEvent/{id}")]                                     //Update Event Post Method
        [Authorize(Roles = Role.Admin)]
        public IActionResult UpdateEvent(EventViewModel eventViewModel)
        {
            var _id = _iEventRepository.UpdateEvent(eventViewModel);

            if (_id > 0)
            {
                return RedirectToAction("ViewDetails", new { id = _id });
            }
            return View();
        }

        [Authorize]
        [Route("MyEvents")]
        public async Task<IActionResult> MyEvents()
        {
            var organiser = User.Identity.Name;
            var eventList = await _iEventRepository.MyEvents(organiser);
            return View(eventList);
        }

        [Authorize]
        [Route("EventsInvitedTo")]
        public async Task<IActionResult> EventsInvitedTo()
        {
            var eventList = await _iEventRepository.GetEvents();
            return View(eventList);
        }

        [Route("FetchComments/{_id}")]
        [Authorize(Roles = Role.Admin)]
        public async Task<IActionResult> GetAllCommentByEventId(int _id)
        {
            var ans = await _iEventRepository.GetAllCommentByEventId(_id);
            if (ans == null)
            {
                return RedirectToAction("ViewDetails", new { id = _id });
            }
            return View(ans);
        }
    }
}
