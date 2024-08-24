using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WF_RepeatProject.Models;

namespace WF_RepeatProject.Data
{
    public class WF_RepeatProjectContext : DbContext
    {
        public WF_RepeatProjectContext (DbContextOptions<WF_RepeatProjectContext> options)
            : base(options)
        {
        }

        public DbSet<WF_RepeatProject.Models.Book> Book { get; set; } = default!;
    }
}
