using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookReading.Event.Observer_pattern
{
    public interface ISubject
    {
        public void Post(Notify Comment) { }
        public void NotifyUser(int i) { }
    }
}
