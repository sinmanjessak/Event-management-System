using BookReading.Event.Data;
using BookReading.Event.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookReading.Event.Repository
{
    public class EventRepository: IEventRepository
    {
        private readonly ApplicationDbContext _eventContext;

        public EventRepository(ApplicationDbContext eventContext)
        {
            _eventContext = eventContext;
        }

        public async Task<IList<EventViewModel>> GetEvents()
        {
            return (IList<EventViewModel>)await _eventContext.Events.OrderBy(x => x.Date).ToListAsync();
        }

        public async Task<EventViewModel> ViewDetails(int eventId)
        {
            return await _eventContext.Events.FindAsync(eventId);
        }

        public Task<int> CreateEvent(EventViewModel _event)
        {
            var newEvent = new EventViewModel()
            {
                Title = _event.Title,
                Description = _event.Description,
                Date = _event.Date,
                StartTime = _event.StartTime,
                Location = _event.Location,
                Duration = _event.Duration,
                Organiser = _event.Organiser,
                EventType = _event.EventType,
                Invitees = _event.Invitees
            };
            _eventContext.Events.Add(newEvent);
            _eventContext.SaveChanges();

            return Task.FromResult(newEvent.ID);

        }

        public int UpdateEvent(EventViewModel _event)
        {
            _eventContext.Events.Update(_event);
            _eventContext.SaveChanges();
            return _event.ID;
        }

        public async Task<IList<EventViewModel>> MyEvents(string organiser)
        {
            var result = from _event in _eventContext.Events
                         where _event.Organiser == organiser
                         orderby _event.Date
                         select _event;
            return (IList<EventViewModel>)await result.ToListAsync();

        }

        public async Task<IList<CommentViewModel>> GetAllCommentByEventId(int eventId)
        {
            var result = await (from e in _eventContext.Events
                                join c in _eventContext.Comments on e.ID equals c.EventId
                                where c.EventId == eventId
                                orderby c.TimeStamp
                                select new CommentViewModel()
                                {
                                    EventId = eventId,
                                    Comment = c.Comment,
                                    TimeStamp = c.TimeStamp

                                }).ToListAsync();
            return result;
        }


    }
}
