using PeligroSport.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PeligroSport.Core.Interfaces
{
   public interface IUsuarios
    {
        IQueryable<Usuarios> GetAll { get; }

        Usuarios GetById(string userId);
        Usuarios GetByUserName(string userName);

        void  Save(Usuarios model);
    }
}
