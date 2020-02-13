using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using EstudoCS.model;

namespace EstudoCS.src.bd
{
    public class BDHash : CollectionsBD
    {
        private static Hashtable listaAnimais = new Hashtable();

        public void AddAnimal(Animal animal) => listaAnimais.Add(animal.Nome, animal);
        
        public Animal GetAnimalByName(string nome) => (Animal)listaAnimais[nome];
        
        public void RemoveAnimalByName(string nome) => listaAnimais.Remove(nome);

        public List<Animal> getAllAnimals() => new ArrayList(listaAnimais.Values).OfType<Animal>().ToList();

    }
}