using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto03.Entities
{
    public class Produto
    {
        #region Properties
        public Guid IdProduto { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public int Quantidade { get; set; }
        public DateTime DataCompra { get; set; }
        #endregion

        #region Construtores
        public Produto()
        {

        }

        public Produto(Guid idProduto, string nome, decimal preco, int quantidade, DateTime dataCompra)
        {
            IdProduto = idProduto;
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
            DataCompra = dataCompra;
        }
        #endregion
    }
}
