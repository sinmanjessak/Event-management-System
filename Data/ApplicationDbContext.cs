using BookReading.Event.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookReading.Event.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {
        }
        //public DbSet<LoginViewModel> Logins { get; set; }
        //public DbSet<SignUpViewModel> Register { get; set; }
        public DbSet<EventViewModel> Events { get; set; }           //Table 1
        public DbSet<CommentViewModel> Comments { get; set; }       //Table 2
    }
}
