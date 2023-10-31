using Microsoft.EntityFrameworkCore;
using Project.DAL.DataContext;
using Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DAL.Repository
{
    public class ContactRepository : IGenericRepository<Contacto>
    {
        private readonly DbcrudcoreContext _dbContext;

        public ContactRepository(DbcrudcoreContext context)
        {
            _dbContext = context;
        }

        public async Task<bool> Delete(int id)
        {
            Contacto model = _dbContext.Contactos.First(c => c.IdContacto == id);
            _dbContext.Remove(model);
            await _dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<Contacto> Get(int id)
        {
            return await _dbContext.Contactos.FirstAsync(c => c.IdContacto == id);

            //return await _dbContext.Contactos.FindAsync(id);
        }

        public async Task<IQueryable<Contacto>> GetAll()
        {
            IQueryable<Contacto> contactQuery = _dbContext.Contactos;
            return contactQuery;
        }

        public async Task<bool> Insert(Contacto model)
        {
            _dbContext.Contactos.Add(model);
            await _dbContext.SaveChangesAsync();
            return true;
        }


        public async Task<bool> Update(Contacto model)
        {
            _dbContext.Contactos.Update(model);
            await _dbContext.SaveChangesAsync();
            return true;
        }

    }
}
