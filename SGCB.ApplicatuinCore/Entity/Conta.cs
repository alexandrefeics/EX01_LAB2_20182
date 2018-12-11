using System;
using System.Collections.Generic;
using System.Text;

namespace SGCB.ApplicationCore.Entity
{
    public class Conta
    {
        public int ContaId { get; set; }
        public int Numero { get; set; }
        public DateTime DataAbertura { get; set; }
        public bool Situacao { get; set; }
        public int MovimentacaoId { get; set; }
        public Movimentacao Movimentacao { get; set; }
        public int TipoContaId { get; set; }
        public TipoConta TipoConta { get; set; }
        public List<Transacao> Transacaos { get; set; }

    }
}
