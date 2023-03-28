using StaffApplication.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StaffApplication.Entity
{
   
    public class Repository<T> : IRepository<T> where T : class
    {
        private StaffContext context;

        public Repository(StaffContext context)
        {
            this.context = context;
        }

        public async Task CreateAsync(T entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));

            context.Add(entity);
            await context.SaveChangesAsync();
        }
    }
}
