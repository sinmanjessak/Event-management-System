using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookReading.Event.Observer_pattern
{
    public class Subject : ISubject
    {
        List<INotify> observer = new List<INotify>();
        private int flag;
        public int Flag
        {
            get
            {
                return flag;
            }
            set
            {
                flag = value;
            }
        }
        public void Post(INotify comment)
        {
            observer.Add(comment);
        }
        public void NotifyUsers(int i)
        {
            foreach(var comment in observer)
            {
                comment.update(i);
            }
        }
    }
}