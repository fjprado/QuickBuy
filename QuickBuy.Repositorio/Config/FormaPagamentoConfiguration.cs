﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuickBuy.Dominio.ObjetoDeValor;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Repositorio.Config
{
    public class FormaPagamentoConfiguration : IEntityTypeConfiguration<FormaDePagamento>
    {
        public void Configure(EntityTypeBuilder<FormaDePagamento> builder)
        {
            throw new NotImplementedException();
        }
    }
}