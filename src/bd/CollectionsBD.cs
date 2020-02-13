using System.Collections.Generic;
using EstudoCS.model;

namespace EstudoCS.src.bd
{
    public interface CollectionsBD
    {
         public abstract void AddAnimal(Animal animal);
         public abstract void RemoveAnimalByName(string nome);
         public abstract List<Animal> getAllAnimals();
         public abstract Animal GetAnimalByName(string nome);
        
    }
}