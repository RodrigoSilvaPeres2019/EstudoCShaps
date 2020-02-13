using System;

namespace EstudoCS.model
{
    public class Gato : Animal
    {
        
        public Gato(string nome, string raca, double peso) : base(nome, raca, peso)
        {
        }

        public override void ChamarDono()
        {
            Console.WriteLine("Miau!");
        }

    }
}