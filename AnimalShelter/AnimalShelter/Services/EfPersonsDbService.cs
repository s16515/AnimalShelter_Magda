using AnimalShelter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnimalShelter.Services
{
    public class EfPersonsDbService : IPersonsDbService
    {
        private readonly ShelterDbContext _context;
        public EfPersonsDbService(ShelterDbContext context)
        {
            _context = context;
        }


        public IEnumerable<Person> GetPersons()
        {
            return _context.Person.ToList();
        }

        public IPersonsDbService GetPerson(int id)
        {
            //code to be added
            throw new NotImplementedException();
        }
    }
}
