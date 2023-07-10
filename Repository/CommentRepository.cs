using BookReading.Event.Data;
using BookReading.Event.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookReading.Event.Repository
{
    public class CommentRepository : ICommentRepository              //Methods related to Comments
    {
        private readonly ApplicationDbContext _commentContext;

        public CommentRepository(ApplicationDbContext commentContext)
        {
           _commentContext = commentContext;
        }
        public async Task<int> PostComment(CommentViewModel response)
        {
            var newComment = new CommentViewModel()
            {
                Comment = response.Comment,
                EventId = response.EventId
            };
            await _commentContext.Comments.AddAsync(newComment);
            _commentContext.SaveChanges();
            return newComment.CommentId;
        }

        public async Task<IList<CommentViewModel>> GetComments()
        {
            return await _commentContext.Comments.OrderBy(x => x.TimeStamp).ToListAsync();
        }
        public async Task<CommentViewModel> ViewComment(int commentId)
        {
            return await _commentContext.Comments.FindAsync(commentId);
        }
        public int EditComment(CommentViewModel response)
        {
            _commentContext.Comments.Update(response);
            _commentContext.SaveChanges();
            return response.CommentId;
        }
    }
}
