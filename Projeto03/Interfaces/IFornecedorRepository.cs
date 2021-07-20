using Projeto03.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto03.Interfaces
{
    public interface IFornecedorRepository
    {
        void Exportar(Fornecedor fornecedor);
        void Importar(Guid idFornecedor);
    }
}
