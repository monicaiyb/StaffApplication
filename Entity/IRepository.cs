using StaffApplication.Data;
using StaffApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace StaffApplication.Entity
{
    public interface IRepository<T> where T : class
    {

        Task CreateAsync(T entity);
    }
}
