using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_Estacionamento.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string?> veiculos = new List<string?>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para estacionar: ");
            string placa = Console.ReadLine();
            veiculos.Add(placa);
             
        }

        public void RemoverVeiculo()
        {

        }

        public void ListarVeiculo()
        {
            Console.WriteLine("Veiculos estacionados: ");

            foreach(string placa in veiculos)
            {
                Console.WriteLine($"↸ō͡≡o˞̶  - {placa}");
            }
        }
    }
}