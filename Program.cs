﻿using ProjetoEstacionamento.Models;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        decimal precoInicial = 0;
        decimal precoPorHora = 0;

        Console.WriteLine("Olá! Bem vindo ao sistema de estacionamento do Alexsander!\n" +
                          "Por gentileza, digite o preço de entrada: ");
        precoInicial = Convert.ToDecimal(Console.ReadLine());

        Console.WriteLine("Agora digite o preço cobrado por hora: ");
        precoPorHora = Convert.ToDecimal(Console.ReadLine());

        Estacionamento estacionamentoDoAle = new Estacionamento(precoInicial, precoPorHora);

        string opcao = string.Empty;
        bool exibirMenu = true;

        while (exibirMenu)
        {
            Console.Clear();
            Console.WriteLine("Digite a sua opção: ");
            Console.WriteLine("--------------------");
            Console.WriteLine("1 - Estacionar veículo");
            Console.WriteLine("2 - Remover veículo");
            Console.WriteLine("3 - Listar veículos");
            Console.WriteLine("4 - Encerrar");
            Console.WriteLine("--------------------");

            switch (Console.ReadLine())
            {
                case "1":
                    estacionamentoDoAle.AdicionarVeiculo();
                    break;

                case "2":
                    estacionamentoDoAle.RemoverVeiculo();
                    break;

                case "3":
                    estacionamentoDoAle.ListarVeiculo();
                    break;

                case "4":
                    exibirMenu = false;
                    break;

                default:
                    Console.WriteLine("Opção inválida");
                    break;
            }
        }

        Console.WriteLine("O estacionamento está encerrando suas atividades por hoje");
    }
}
