using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace BookReading.Event.Observer_pattern
{
    public class Notify : INotify
    {
        HttpContext httpContext => new HttpContextAccessor().HttpContext;
        string NameOfObserver;
        public Notify(string name)
        {
            this.NameOfObserver = name;
        }
        public void Update(int i)
        {
            httpContext.Response.WriteAsync(string.Format($"{NameOfObserver} has recieved an alert: SomeOne has post a comment: {i}"));
        }
    }
}