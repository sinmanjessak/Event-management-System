using BookReading.Event.Models;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace BookReading.Event.Repository
{
    public interface IEventRepository
    {
        Task<IList<EventViewModel>> GetEvents();
        Task<EventViewModel> ViewDetails(int eventId);
        Task<int> CreateEvent(EventViewModel _event);

        int UpdateEvent(EventViewModel _event);
        Task<IList<EventViewModel>> MyEvents(string organiser);

        Task<IList<CommentViewModel>> GetAllCommentByEventId(int eventId);
    }
}
