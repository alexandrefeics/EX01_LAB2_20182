using System;
using System.Collections.Generic;
using System.Text;

namespace SGCB.ApplicationCore.Entity
{
   public class Pessoa
    {
        public int PessoaId { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Email { get; set; }
        public Endereco Endereco { get; set; }
        public List<Transacao> Transacaos { get; set; }
    }
}
