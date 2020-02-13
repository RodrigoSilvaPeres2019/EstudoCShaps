using System;
using EstudoCS.model;
using EstudoCS.src.bd;

namespace EstudoCS.src.app
{
    public class RecuperarDadosPet : InterTelas
    {
        public int executar(CollectionsBD bd)
        {
            int escolha = 0;
            int sair = 0;

            while (sair == 0)
            {
                switch (escolha)
                {
                    case -1:
                        Console.WriteLine("0-Viualizar outro pet.\n" +
                                "1-Retornar a tela principal.\n" +
                                "2-Sair do programa.\n");
                        escolha = Convert.ToInt16(Console.ReadLine());
                        sair = ( escolha != 0 ? 1 : 0 );
                        break;

                    case 0:
                        Console.WriteLine("Digite o nome do pet: ");
                        Animal animal = bd.GetAnimalByName(Console.ReadLine());
                        Console.WriteLine("Nome do pet: {0}", animal.Nome);
                        Console.WriteLine("Raça do pet: {0}", animal.Raca);
                        Console.WriteLine("Peso do pet: {0}", animal.Peso);
                        Console.WriteLine("Aperte enter para continuar");
                        Console.ReadLine();
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