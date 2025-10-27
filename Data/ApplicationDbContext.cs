using LMS.DataModel;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace LMS.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Member> Members { get; set; }
        public DbSet<BookIssue> BookIssues { get; set; }
        public DbSet<BookReturn> BookReturns { get; set; }
        public DbSet<Fine> Fines { get; set; }
        public DbSet<Staff> Staffs { get; set; }

    }
}
