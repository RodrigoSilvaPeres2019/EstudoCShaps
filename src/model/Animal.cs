using System;

namespace EstudoCS.model
{
    public abstract class Animal
    {
        public string Nome { get; set; }
        public string Raca { get; set; }
        public double Peso { get; set; }

        public Animal(string nome, string raca, double peso)
        {
            Nome = nome;
            Raca = raca;
            Peso = peso;
        }
        public virtual void  ChamarDono(){
            Console.WriteLine("Alguma coisa deu errada na subescrita do metodo Pai!");
        }

    }
}