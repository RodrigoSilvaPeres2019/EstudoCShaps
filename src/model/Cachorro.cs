using System;

namespace EstudoCS.model
{
    public class Cachorro : Animal
    {
        public Cachorro(string nome, string raca, double peso) : base(nome, raca, peso)
        {
        }

        public override void ChamarDono()
        {
            Console.WriteLine("Au Au!");
        }

       
    }
}