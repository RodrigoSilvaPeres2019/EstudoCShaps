using System;
using EstudoCS.src.bd;


namespace EstudoCS.src.app
{
    class Program
    {


        static void Main(string[] args)
        {
            int escolha = 0;
            int frag = 0;

            CollectionsBD bd = new BDHash();
            while (frag == 0)
            {
                switch (escolha)
                {
                    case -1:
                        frag = 1;
                        break;
                    case 0:
                        Console.WriteLine("Oque deseja Faze?: \n" +
                                            "1-Salvar novo pet.\n" +
                                            "2-Recuperar dados de um pet.\n" +
                                            "3-Excluir pet.\n" +
                                            "4-Listar pets.\n");
                        escolha = Convert.ToInt16(Console.ReadLine());
                        break;
                    case 1:
                        escolha = new SalvarNovoPet().executar(bd);
                        escolha = (escolha == 1 ? 0 : -1);
                        break;

                    case 2:
                        escolha = new RecuperarDadosPet().executar(bd);
                        escolha = (escolha == 1 ? 0 : -1);
                        break;

                    case 3:
                        escolha = new ExcluirPet().executar(bd);
                        escolha = (escolha == 1 ? 0 : -1);
                        break;

                    case 4:
                        bd.getAllAnimals().ForEach(animal => Console.WriteLine(animal.Nome + "\n" +
                                                                                   animal.Raca + "\n" +
                                                                                   animal.Peso + "\n"));
                        Console.WriteLine("Listar novamente? \n1-Retornar a tela principal.\n" +
                                "2-Sair do programa.\n");
                        escolha = Convert.ToInt16(Console.ReadLine());
                        escolha = (escolha == 1 ? 4 : 0);
                        break;

                    default:
                        break;
                }
                // bd = new BDHash();
                // bd.AddAnimal(animal);
                // Console.WriteLine("Digite o nome do animal: ");
                // nome = Console.ReadLine();
                // animal = bd.GetAnimalByName(nome);
                // animal.ChamarDono();
                // bd.RemoveAnimalByName(nome);
                // animal = bd.GetAnimalByName(nome);
                // animal.ChamarDono();
            }
        }
    }
}
