using AnimalShelter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnimalShelter.Services
{
    public class AnimalsDbService : IAnimalsDbService
    {
        private readonly ShelterDbContext _context;
        public AnimalsDbService(ShelterDbContext context)
        {
            _context = context;
        }


        public Animal GetAnimal(int shelterNumber)
        {
            return _context.Animal.Where(a => a.ShelterNumber == shelterNumber).FirstOrDefault();
        }

        public IEnumerable<Animal> GetAnimals()
        {
            return _context.Animal.ToList();
        }
    }
}
