using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioProposto_MetodosAbstratos.Entities {
    class PessoaFisica : Pessoa {
        public double GastoSaude { get; set; }

        public PessoaFisica() {
        }

        public PessoaFisica(string nome, double renda, double gastoSaude)
            : base(nome, renda) {
            GastoSaude = gastoSaude;
        }

        public override double ImpostoPago() {
            if (Renda < 20000.00) {
                return (Renda * 0.15) - (GastoSaude * 0.5);
            } else {
                return (Renda * 0.25) - (GastoSaude * 0.5);
            }
        }
    }
}
