using Project.DAL.Repository;
using Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.Services
{
    public interface IContactoService
    {
        Task<Contacto> GetByName(string name);
    }
}
