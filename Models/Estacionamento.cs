using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoEstacionamento.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public decimal PrecoInicial
        {
            get { return precoInicial; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("O preço inicial não pode ser negativo");
                }
                precoInicial = value;
            }
        }

        public decimal PrecoPorHora
        {
            get { return precoPorHora; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("O preço por hora não pode ser negativo");
                }
                precoPorHora = value;
            }
        }

        private decimal CalcularValorCobrado(int horasEstacionado)
        {
            return precoInicial + (precoPorHora * horasEstacionado);
        }

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo de no máximo 7 digitos para estacionar : ");
            string placa = Console.ReadLine();

            if (!string.IsNullOrEmpty(placa) && placa.Length == 7)
            {
                veiculos.Add(placa.ToUpper());
                Console.WriteLine($"Veículo com a placa {placa} estacionado com sucesso!");
            }
            else if (placa.Length > 7)
            {
                Console.WriteLine("Placa inválida. A placa não pode ter mais de 7 caracteres.");
            }
            else
            {
                Console.WriteLine("Placa inválida. Não foi possível estacionar o veículo.");
            }

        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover o carro do estacionamento: ");
            string placa = Console.ReadLine();


            if (veiculos.Contains(placa, StringComparer.OrdinalIgnoreCase))
            {
                Console.WriteLine("Digite o número de horas que o veículo ficou estacionado: ");
                if (int.TryParse(Console.ReadLine(), out int horasEstacionado) && horasEstacionado >= 0)
                {
                    decimal valorCobrado = CalcularValorCobrado(horasEstacionado);
                    veiculos.Remove(placa);
                    Console.WriteLine($"Veículo com a placa {placa} foi removido. \n" + $"Valor cobrado: {valorCobrado.ToString("C")}");
                }
                else
                {
                    Console.WriteLine("Número de horas inválido.");
                }
            }
            else
            {
                Console.WriteLine($"Veículo com a placa {placa} não encontrado no estacionamento.");
            }
        }


        public void ListarVeiculo()
        {
            Console.WriteLine("Veiculos estacionados: ");

            foreach (string placa in veiculos)
            {
                string placaFormatada = FormatarPlaca(placa);
                Console.WriteLine($"↸ō͡≡o˞̶ - {placaFormatada}");
            }
        }

        private string FormatarPlaca(string placa)
        {
            if (placa.Length == 7)
            {
                return $"{placa.Substring(0, 3)}-{placa.Substring(3)}";
            }
            return placa;
        }

    }
}