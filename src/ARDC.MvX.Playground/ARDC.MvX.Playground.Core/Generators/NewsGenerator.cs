using ARDC.MvX.Playground.Core.Models;
using Bogus;
using System.Collections.Generic;

namespace ARDC.MvX.Playground.Core.Generators
{
    /// <summary>
    /// Gerador de notícias falsas.
    /// </summary>
    public static class NewsGenerator
    {
        private static int newsId = 1;

        /// <summary>
        /// Gera uma notícia aleatóriamente.
        /// </summary>
        /// <returns>A notícia gerada</returns>
        public static NewsPost GenerateNewsPost()
        {
            return new Faker<NewsPost>(locale: "pt_BR")
                .RuleFor(n => n.Id, f => newsId++)
                .RuleFor(n => n.Titulo, f => f.Lorem.Sentence())
                .RuleFor(n => n.NomeAutor, f => f.Person.FullName)
                .RuleFor(n => n.DataPublicacao, f => f.Date.Past())
                .RuleFor(n => n.Conteudo, f => f.Rant.Review("mussum"))
                .Generate();
        }

        /// <summary>
        /// Gera várias notícias aleatóriamente.
        /// </summary>
        /// <param name="qtde">Quantidade de notícias a serem geradas, por padrão 10</param>
        /// <returns>Uma lista de notícias</returns>
        public static IList<NewsPost> GenerateNewsPost(int qtde = 10)
        {
            return new Faker<NewsPost>(locale: "pt_BR")
                .RuleFor(n => n.Id, f => newsId++)
                .RuleFor(n => n.Titulo, f => f.Lorem.Sentence())
                .RuleFor(n => n.NomeAutor, f => f.Person.FullName)
                .RuleFor(n => n.DataPublicacao, f => f.Date.Past())
                .RuleFor(n => n.Conteudo, f => f.Rant.Review("mussum"))
                .Generate(qtde);
        }
    }
}
