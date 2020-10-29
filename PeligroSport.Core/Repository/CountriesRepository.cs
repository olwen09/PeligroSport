using PeligroSport.Core.Context;
using PeligroSport.Core.Entities;
using PeligroSport.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PeligroSport.Core.Repository
{
   public class CountriesRepository : ICountries
    {

        private readonly PeligroSportDBContext _context;
        public CountriesRepository(PeligroSportDBContext context)
        {
            _context = context;
        }

        public IQueryable<Countries> Countries => _context.Countries;
    }
}
