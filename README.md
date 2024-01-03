# Projeto-Estacionamento

  ![Status](https://img.shields.io/badge/Status-Completed-brightgreen.svg)

# DIO - Trilha .NET - Fundamentos

## Desafio de projeto
Neste desafio, foi proposto o desenvolvimento de um sistema para um estacionamento, com o objetivo de gerenciar os veículos estacionados e realizar operações como adição e remoção de veículos (com exibição do valor cobrado durante o período) e listagem dos veículos. da trilha .NET da DIO.


## Diagrama de Classe
- **Atributos:**
  - `- precoInicial: decimal`
  - `- precoPorHora: decimal`
  - `- veiculos: List<string>`

- **Métodos:**
  - `+ PrecoInicial: decimal`
  - `+ PrecoPorHora: decimal`
  - `+ Estacionamento(precoInicial, precoPorHora): void`
  - `+ AdicionarVeiculo(): void`
  - `+ RemoverVeiculo(): void`
  - `+ ListarVeiculo(): void`
  - `- CalcularValorCobrado(horasEstacionado): decimal`
  - `- FormatarPlaca(placa): string`

A classe contém três variáveis, sendo:

**precoInicial**: Tipo decimal. É o preço cobrado para deixar seu veículo estacionado.

**precoPorHora**: Tipo decimal. É o preço por hora que o veículo permanecer estacionado.

**veiculos**: É uma lista de string, representando uma coleção de veículos estacionados. Contém apenas a placa do veículo.

A classe contém três métodos, sendo:

**AdicionarVeiculo**: Método responsável por receber uma placa digitada pelo usuário e guardar na variável **veiculos**.

**RemoverVeiculo**: Método responsável por verificar se um determinado veículo está estacionado, e caso positivo, irá pedir a quantidade de horas que ele permaneceu no estacionamento. Após isso, realiza o seguinte cálculo: **precoInicial** * **precoPorHora**, exibindo para o usuário.

**ListarVeiculos**: Lista todos os veículos presentes atualmente no estacionamento. Caso não haja nenhum, exibir a mensagem "Não há veículos estacionados".

Por último, foi feito um menu interativo com as seguintes ações implementadas:
1. Cadastrar veículo
2. Remover veículo
3. Listar veículos
4. Encerrar

## Implementações Adicionais

- **Método `Main`:** Adicionado método principal para iniciar a execução do programa.
- **Exceções:** Adicionadas verificações para não aceitar valores nulos ou negativos nos preços e horas estacionadas, proporcionando maior robustez ao sistema.

