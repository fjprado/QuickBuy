﻿using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Dominio.Entidades
{
    public class Produto : Entidade
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }

        public override void Validate()
        {
            if (string.IsNullOrEmpty(Nome))
                AdicionarCritica("Crítica - Nome do produto deve ser informado.");
            if (string.IsNullOrEmpty(Descricao))
                AdicionarCritica("Crítica - Descrição do produto deve ser informado.");
            if (Preco == 0)
                AdicionarCritica("Crítica - Preço do produto deve ser informado.");
        }
    }
}
