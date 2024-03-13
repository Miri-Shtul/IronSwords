using IronSwords.Repositories.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IronSwords.Repositories.Interfaces
{
    public interface IContext
    {
        DbSet<User> Users { get; set; }
        DbSet<Accommodation> Accommodations { get; set; }
        int SaveChanges();
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default(CancellationToken));
    }
}
