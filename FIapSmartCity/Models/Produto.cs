﻿namespace FIapSmartCity.Models
{
    public class Produto
    {
        public int IdProduto { get; set; }
        public String NomeProduto { get; set; }
        public String Caracteristicas { get; set; }
        public String Logotipo { get; set; }
        public double PrecoMedio { get; set; }
        public bool Ativo { get; set; }

        public TipoProduto Tipo { get; set; }
    }
}
