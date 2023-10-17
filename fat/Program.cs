using System;

class Program
{
    static void Main(string[] args)
    {
        //Apresentação do sistema de locação de carro.
        Console.WriteLine("Bem-vindo ao sistema de Chat Bot de locação de carro: ");
        Console.WriteLine("Digite: \n 1 - Locação de carro;\n 2 - Finalizar Programa");
        int opcao = Convert.ToInt32(Console.ReadLine());

        while (opcao != 2)
        {
            //Primeiro caso de condição para a seleção de modelo de carros
            if (opcao == 1)
            {
                Console.WriteLine("1 - SUV (HRV - tracker)");
                Console.WriteLine("2 - HATCH (ford ka - gol)");
                Console.WriteLine("3 - SEDAN (voyage - cruze)");
                int modelo = Convert.ToInt32(Console.ReadLine()); //Criação da variavel modelo para o segundo caso de condição.

                switch (modelo)
                {
                    case 1: //Usei um switch para fazer a seleção dos modelos.
                        Console.WriteLine("Escolha o SUV: ");
                        Console.WriteLine("1 - HRV");
                        Console.WriteLine("2 - tracker");
                        int carSuv = Convert.ToInt32(Console.ReadLine());

                        if (carSuv == 1)
                        {
                            Console.WriteLine("Diaria do HRV é $70,00");
                        }
                        else if (carSuv == 2)
                        {
                            Console.WriteLine("Diaria do tracker é $60,00");
                        }
                        else
                        {
                            Console.WriteLine("Opção invalida.");
                        }
                        break;

                    case 2: //Segundo caso de escolha Hatch
                        Console.WriteLine("Escolha o HATCH: ");
                        Console.WriteLine("1 - ford ka");
                        Console.WriteLine("2 - gol");
                        int carHatch = Convert.ToInt32(Console.ReadLine());

                        if (carHatch == 1)
                        {
                            Console.WriteLine("Diaria do ford ka é $60,00");
                        }
                        else if (carHatch == 2)
                        {
                            Console.WriteLine("Diaria do gol é $55,00");
                        }
                        else
                        {
                            Console.WriteLine("Opção invalida.");
                        }
                        break;
                    case 3:
                        Console.WriteLine("Escolha o SEDAN: ");
                        Console.WriteLine("1 - voyage");
                        Console.WriteLine("2 - cruze");
                        int carSedan = Convert.ToInt32(Console.ReadLine());

                        if (carSedan == 1)
                        {
                            Console.WriteLine("Diaria do voyage é $60,00");
                        }
                        else if (carSedan == 2)
                        {
                            Console.WriteLine("Diaria do cruze é $80,00");
                        }
                        else
                        {
                            Console.WriteLine("Opção invalida.");
                        }
                        break;
                    default:
                        Console.WriteLine("Nenhuma opção encontrada");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Opção inválida, por favor, escolha uma opção valida");
            }

            Console.WriteLine("Digite: \n1 - Locação de carro \n2 - Finalizar programa");
            opcao = Convert.ToInt32(Console.ReadLine());
        }
    }
}
