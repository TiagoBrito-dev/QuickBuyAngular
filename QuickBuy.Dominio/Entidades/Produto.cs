using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Dominio.Entidades
{
    public class Produto : Entidade
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public double Preco { get; set; }

        public override void Validade()
        {
            if (string.IsNullOrEmpty(Nome))
                AdicionarCritica("Critica - Deve ser informado o nome do produto");

            if (Preco <= 0.00)
                AdicionarCritica("Preco nao pode ser igual ou inferior a R$ 0.00");
        }
    }
}
