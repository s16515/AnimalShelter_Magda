using AnimalShelter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnimalShelter.Services
{
    public interface IAnimalsDbService
    {
        public Animal GetAnimal(int shelterNumber);
        //--- to be added

        public IEnumerable<Animal> GetAnimals();
    }
}
