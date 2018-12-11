using System;
using System.Collections.Generic;
using System.Text;

namespace SGCB.ApplicationCore.Entity
{
    public class Transacao
    {
        public int TransacaoId { get; set; }
        public int ContaId { get; set; }
        public int PessoaId { get; set; }
    }
}
