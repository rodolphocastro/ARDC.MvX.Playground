using ARDC.MvX.Playground.Core.Models;
using Bogus;
using System;
using System.Collections.Generic;

namespace ARDC.MvX.Playground.Core.Generators
{
    public class ServiceItemGenerator
    {
        private static int _serviceId = 1;

        /// <summary>
        /// Gera um serviço.
        /// </summary>
        /// <returns>O serviço gerado aleatóriamente</returns>
        public static ServiceItem GenerateServiceItem()
        {
            return new Faker<ServiceItem>("pt_BR")
                .RuleFor(s => s.Id, f => _serviceId++)
                .RuleFor(s => s.Nome, f => f.Commerce.ProductName())
                .RuleFor(s => s.Descricao, f => f.Commerce.Product())
                .RuleFor(s => s.IsCobradoPorHora, f => f.Random.Bool())
                .RuleFor(s => s.Valor, f => f.Random.Decimal(1, 200))
                .RuleFor(s => s.DthPublicacao, f => f.Date.Past())
                .RuleFor(s => s.DthAtualizacao, (f, u) => f.Random.Bool() ? (DateTime?)f.Date.Future(1, u.DthPublicacao) : null)
                .RuleFor(s => s.NomeVendedor, f => f.Person.FullName)
                .RuleFor(s => s.IsDisponivel, f => f.Random.Bool())
                .Generate();
        }

        /// <summary>
        /// Gera vários serviços.
        /// </summary>
        /// <param name="qtde">Quantidade de serviços a serem gerados</param>
        /// <returns>Uma lsita de serviços gerados aleatóriamente</returns>
        public static IList<ServiceItem> GenerateServiceItem(int qtde = 10)
        {
            return new Faker<ServiceItem>("pt_BR")
                .RuleFor(s => s.Id, f => _serviceId++)
                .RuleFor(s => s.Nome, f => f.Commerce.ProductName())
                .RuleFor(s => s.Descricao, f => f.Commerce.Product())
                .RuleFor(s => s.IsCobradoPorHora, f => f.Random.Bool())
                .RuleFor(s => s.Valor, f => f.Random.Decimal(1, 200))
                .RuleFor(s => s.DthPublicacao, f => f.Date.Past())
                .RuleFor(s => s.DthAtualizacao, (f, u) => f.Random.Bool() ? (DateTime?)f.Date.Future(1, u.DthPublicacao) : null)
                .RuleFor(s => s.NomeVendedor, f => f.Person.FullName)
                .RuleFor(s => s.IsDisponivel, f => f.Random.Bool())
                .Generate(qtde);
        }
    }
}
