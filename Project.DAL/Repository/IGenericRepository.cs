using Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DAL.Repository
{
    public interface IGenericRepository<T> where T: class
    {
        Task<bool> Insert(T model);
        Task<bool> Update(T model);
        Task<T> Get(int id);
        Task<bool> Delete(int id);

        Task<IQueryable<T>> GetAll();
    }
}
