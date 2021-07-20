using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto03.Entities
{
    public class Fornecedor
    {
        #region Properties
        public Guid IdFornecedor { get; set; }
        public string Nome { get; set; }
        public string Cnpj { get; set; }
        #endregion

        #region Associação
        public List<Produto> Produto { get; set; }
        #endregion

        #region Construtores
        public Fornecedor()
        {

        }

        public Fornecedor(Guid idFornecedor, string nome, string cnpj)
        {
            IdFornecedor = idFornecedor;
            Nome = nome;
            Cnpj = cnpj;
        }
        #endregion
    }
}
