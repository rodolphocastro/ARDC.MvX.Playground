using System;

namespace ARDC.MvX.Playground.Core.Models
{
    /// <summary>
    /// Serviço ofertado através do App.
    /// </summary>
    public class ServiceItem
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Descricao { get; set; }

        public bool IsCobradoPorHora { get; set; }

        public decimal Valor { get; set; }

        public DateTime DthPublicacao { get; set; }

        public DateTime? DthAtualizacao { get; set; }

        public string NomeVendedor { get; set; }

        public bool IsDisponivel { get; set; }
    }
}
