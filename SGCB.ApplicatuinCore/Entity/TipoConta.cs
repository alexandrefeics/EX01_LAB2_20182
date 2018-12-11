using System;
using System.Collections.Generic;
using System.Text;

namespace SGCB.ApplicationCore.Entity
{
    public class TipoConta
    {
        public int TipoContaId { get; set; }
        public string Descricao { get; set; }
        public int ContaId { get; set; }
        public List<Conta> Contas { get; set; }
    }
}
