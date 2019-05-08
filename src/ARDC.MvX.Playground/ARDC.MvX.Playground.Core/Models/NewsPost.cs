using System;

namespace ARDC.MvX.Playground.Core.Models
{
    /// <summary>
    /// Notícia a ser publicada pelo App.
    /// </summary>
    public class NewsPost
    {
        public int Id { get; set; }

        public string Titulo { get; set; }

        public DateTime DataPublicacao { get; set; }

        public string Conteudo { get; set; }

        public string NomeAutor { get; set; }

        public override string ToString() => $"{Titulo} @ {NomeAutor}";
    }
}
