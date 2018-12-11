using Microsoft.EntityFrameworkCore;
using SGCB.ApplicationCore.Entity;
using SGCB.Infrastructure.EntityConfig;
using System;
using System.Collections.Generic;
using System.Text;

namespace SGCB.Infrastructure.Dados
{
    public class ContextSGCB : DbContext
    {
        public DbSet<Pessoa> Pessoas { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<Conta> Contas { get; set; }
        public DbSet<Movimentacao> Movimentacaos { get; set; }
        public DbSet<TipoConta> TipoContas { get; set; }
        public DbSet<Transacao> Transacaos { get; set; }




        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=BdSGCB;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


            modelBuilder.ApplyConfiguration(new PessoaConfig());

            modelBuilder.ApplyConfiguration(new TipoContaConfig());

            modelBuilder.ApplyConfiguration(new EnderecoConfig());

       
        }
    }





}
    

