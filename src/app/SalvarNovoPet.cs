using System;
using EstudoCS.model;
using EstudoCS.src.bd;

namespace EstudoCS.src.app
{
    public class SalvarNovoPet : InterTelas
    {
        public int executar(CollectionsBD bd)
        {
            string nome;
            string raca;
            double peso;
            int escolha = 0; 
            int sair = 0;

            while (sair == 0)
            {
                switch (escolha)
                {   
                    case -1:
                        Console.WriteLine("0-Adicionar outro pet.\n" +
                                "1-Retornar a tela principal.\n" +
                                "2-Sair do programa.\n");
                                escolha = Convert.ToInt16(Console.ReadLine());
                                sair = ( escolha != 0 ? 1 : 0 );
                                break;

                    case 0:
                        Console.WriteLine("Adicionar novo:\n" +
                                "1-Cachorro.:\n" +
                                "2-Gato:\n");
                                escolha = Convert.ToInt16(Console.ReadLine());
                                break;

                    case 1:
                        Console.WriteLine("Escolha o nome: ");
                        nome = Console.ReadLine();
                        Console.WriteLine("Escolha raca: ");
                        raca = Console.ReadLine();
                        Console.WriteLine("Escolha peso: ");
                        peso = Convert.ToDouble(Console.ReadLine());
                        bd.AddAnimal(new Cachorro(nome, raca, peso));
                        escolha = -1;
                        break;

                    case 2:
                        Console.WriteLine("Escolha o nome: ");
                        nome = Console.ReadLine();
                        Console.WriteLine("Escolha raca: ");
                        raca = Console.ReadLine();
                        Console.WriteLine("Escolha peso: ");
                        peso = Convert.ToDouble(Console.ReadLine());
                        bd.AddAnimal(new Gato(nome, raca, peso));
                        escolha = -1;
                        break;

                    default:
                        sair = 1;
                        escolha = 0;
                        break;
                }
            }
            return escolha;
        }
    }
}