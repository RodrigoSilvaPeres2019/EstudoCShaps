using System;
using System.Collections.Generic;
using System.Linq;
using EstudoCS.model;

namespace EstudoCS.src.bd
{
    public class BDList : CollectionsBD
    {
        private static List<Animal> listaAnimais = new List<Animal>{};

        public void AddAnimal(Animal animal) => listaAnimais.Add(animal);

        public Animal GetAnimalByName(string nome) => listaAnimais.AsQueryable().FirstOrDefault(a => String.Compare(a.Nome,nome) == 0 );
        
        public void RemoveAnimalByName(string nome) => listaAnimais.Remove(GetAnimalByName(nome));
        
         public List<Animal> getAllAnimals() => listaAnimais;
    }
}