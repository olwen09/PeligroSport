using PeligroSport.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PeligroSport.Core.Interfaces
{
    public interface ICountries
    {
        IQueryable<Countries> Countries { get; }


    }
}
