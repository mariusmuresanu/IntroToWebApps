using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntroToWebApps.Models
{
    public class RemindersContext : DbContext
    {
        public RemindersContext(DbContextOptions<RemindersContext> options)
            : base(options)
        {
        }

        public DbSet<ReminderItem> ReminderItems { get; set; } = null!;
    }
}
