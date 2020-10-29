using Microsoft.EntityFrameworkCore;
using PeligroSport.Core.Context;
using PeligroSport.Core.Entities;
using PeligroSport.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PeligroSport.Core.Repository
{
    public class UsersRepository : IUsuarios
    {

        private readonly PeligroSportDBContext _context;

        public UsersRepository(PeligroSportDBContext context)
        {
            _context = context;
        }

        public IQueryable<Usuarios> GetAll => _context.Users
            .Include(x => x.Address)
            .Include(x => x.Address.Country)
            .Include(x => x.BillingAddress)
            .Include(x => x.BillingAddress.Country)
            .Include(x => x.ShippingAddress)
            .Include(x => x.ShippingAddress.Country);

            

        public Usuarios GetById(string userId)
        {
            return _context.Users.Find(userId);
        }

        public Usuarios GetByUserName(string userName)
        {
            return GetAll.FirstOrDefault(x => x.UserName == userName);
        }

        public void Save(Usuarios model)
        {
            throw new NotImplementedException();
        }
    }
}
