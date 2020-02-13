using System;
using System.Collections.Generic;
using System.Linq;
using EstudoCS.model;

namespace EstudoCS.src.bd
{
    public class BDArray : CollectionsBD
    {
        private static Animal[] listaAnimais = new Animal[10];

        public Animal GetAnimalByName(string nome) => listaAnimais.AsQueryable().FirstOrDefault(a => String.Compare(a.Nome, nome) == 0);

        public void RemoveAnimalByName(string nome) => listaAnimais[Array.FindIndex(listaAnimais, a => a.Nome == nome)] = null;

        public void AddAnimal(Animal animal) => listaAnimais[Array.FindIndex(listaAnimais, a => a == null)] = animal;
        

        public List<Animal> getAllAnimals() => listaAnimais.OfType<Animal>().ToList();
      
    }
}