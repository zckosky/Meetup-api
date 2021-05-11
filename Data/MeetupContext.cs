using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Meetup.Models;

namespace Meetup.Data
{
    public class MeetupContext : DbContext
    {
        public MeetupContext (DbContextOptions<MeetupContext> options)
            : base(options)
        {
        }

        public DbSet<Meetup.Models.Person> Person { get; set; }
    }
}
