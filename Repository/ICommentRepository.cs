using BookReading.Event.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BookReading.Event.Repository
{
    public interface ICommentRepository
    {
        Task<int> PostComment(CommentViewModel response);

        Task<IList<CommentViewModel>> GetComments();

        Task<CommentViewModel> ViewComment(int commentId);

        int EditComment(CommentViewModel response);
    }
}