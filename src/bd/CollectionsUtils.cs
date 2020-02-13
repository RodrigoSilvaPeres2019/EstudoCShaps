using System;
using System.Collections.Generic;
using EstudoCS.model;

namespace EstudoCS.src.bd
{
    class CollectionsUtils
    {
        public static Animal findAnimalByName(List<Animal> listaAnimais, string nome){
            foreach (var item in listaAnimais)
            {
                if((String.Compare(item.Nome, nome)==0)){
                    return item;
                }
            }
            return null;
        }
        public static Animal findAnimalByName(Animal[] listaAnimais, string nome){
            foreach (var item in listaAnimais)
            {
                if((String.Compare(item.Nome, nome)==0)){
                    return item;
                }
            }
            return null;
        }
    }
}