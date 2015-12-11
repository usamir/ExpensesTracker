using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToptalExpensesTrackerAPI.Models
{
    public interface IStoreAppContext : IDisposable
    {
        DbSet<ApplicationUser> Users { get; set; }
        int SaveChanges();
        void MarkAsModified(ApplicationUser item);
    } 
}
