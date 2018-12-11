using System;
using System.Collections.Generic;
using System.Text;

namespace SGCB.ApplicationCore.Entity
{
    public class Movimentacao
    {
        public int MovimentacaoId { get; set; }
        public DateTime DataMovimentacao { get; set; }
        public decimal Valor { get; set; }
        public int ContaId { get; set; }
        public List<Conta> Contas { get; set; }

    }
}
