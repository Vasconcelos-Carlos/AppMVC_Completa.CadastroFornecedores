using System;
using System.Collections.Generic;
using System.Text;

namespace Dev.Business.Models
{
    public class Fornecedor : Entity
    {
        public string Nome { get; set; }
        public string Documento { get; set; }
        public TipoFornecedorEnum TipoFornecedor { get; set; }
        public Endereco Endereco { get; set; }
        public bool Ativo { get; set; }
        public IEnumerable<Produto> Produtos { get; set; }
    }
}
