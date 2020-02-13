using System;
using EstudoCS.src.bd;

namespace EstudoCS.src.app
{
    public class ExcluirPet : InterTelas
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
                        Console.WriteLine("0-Excluir outro pet.\n" +
                                "1-Retornar a tela principal.\n" +
                                "2-Sair do programa.\n");
                        escolha = Convert.ToInt16(Console.ReadLine());
                        sair = (escolha != 0 ? 1 : 0);
                        break;

                    case 0:
                        try
                        {
                            Console.WriteLine("Digite o nome do pet a ser excluido: ");
                            bd.RemoveAnimalByName(Console.ReadLine());
                            Console.WriteLine("Pet escluido com sucesso!! \nAperte enter para continuar.");
                            Console.ReadLine();
                        }
                        catch (System.Exception)
                        {
                            Console.WriteLine("Nome de pet não encontrado!");
                            throw;
                        }
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