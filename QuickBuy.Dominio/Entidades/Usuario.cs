﻿using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Dominio.Entidades
{
    public class Usuario : Entidade
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }

        /*Um usuário pode ter muitos ou nenhum pedido*/
        public virtual ICollection<Pedido> Pedidos { get; set; }

        public override void Validate()
        {
            if (string.IsNullOrEmpty(Email))
                AdicionarCritica("Crítica - Email deve ser informado.");
            if (string.IsNullOrEmpty(Senha))
                AdicionarCritica("Crítica - Senha deve ser informada.");
        }
    }
}
