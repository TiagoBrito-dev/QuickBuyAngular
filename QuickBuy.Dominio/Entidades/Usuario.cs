using System;
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
        public string SobreNome { get; set; }

        public ICollection<Pedido> Pedidos { get; set; }

        public override void Validade()
        {
            if (string.IsNullOrEmpty(Email))
                AdicionarCritica("Critica - Email não foi informado");

            if (string.IsNullOrEmpty(Senha))
                AdicionarCritica("Senha nao foi informado");
        }
    }
}
