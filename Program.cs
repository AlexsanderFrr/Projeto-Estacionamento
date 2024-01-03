using Projeto_Estacionamento.Models;

Console.OutputEncoding = System.Text.Encoding.UTF8;

decimal precoInicial = 0;
decimal precoPorHora = 0;

Console.WriteLine("Olá! Bem vindo ao sistema de estacionamento do Alexsander!\n" + 
                  "Por gentileza, digite o preço de entrada: ");

Estacionamento estacionamentoDoAle = new Estacionamento(precoInicial, precoPorHora);



estacionamentoDoAle.ListarVeiculo();
