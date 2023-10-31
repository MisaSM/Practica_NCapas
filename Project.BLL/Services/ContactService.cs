using Project.DAL.Repository;
using Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.Services
{
    public class ContactService
    {
        private readonly IGenericRepository<Contacto> _contactRepo;
        public ContactService(IGenericRepository<Contacto> contacto)
        {
            _contactRepo = contacto;
        }
        public async Task<bool> Update(Contacto model)
        {
            return await _contactRepo.Update(model);
        }
        public async Task<bool> Delete(int id)
        {
            return await _contactRepo.Delete(id);
        }
        public async Task<bool> Insert(Contacto model)
        {
            return await _contactRepo.Insert(model);
        }
        public async Task<Contacto> Get(int id)
        {
            return await _contactRepo.Get(id);
        }
        public async Task<IQueryable<Contacto>> GetAll()
        {
            return await _contactRepo.GetAll();
        }

        public async Task<Contacto> GetbyName(string name)
        {
            IQueryable<Contacto> queryContact = await _contactRepo.GetAll();
            Contacto contact = queryContact.Where(c => c.Nombre == name).FirstOrDefault();
            return contact;
        }
    }
}
