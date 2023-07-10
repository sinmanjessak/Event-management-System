using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookReading.Event.Repository
{
    interface IUnitOfWork
    {
        ICommentRepository CommentRepository { get; }
    }
}
