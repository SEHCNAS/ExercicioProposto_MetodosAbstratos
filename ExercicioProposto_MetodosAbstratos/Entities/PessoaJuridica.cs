using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioProposto_MetodosAbstratos.Entities {
    class PessoaJuridica : Pessoa {
        public int NFuncionario { get; set; }

        public PessoaJuridica() {
        }

        public PessoaJuridica(string nome, double renda, int nFuncionario) : base(nome, renda) {
            NFuncionario = nFuncionario;
        }

        public override double ImpostoPago() {
            if (NFuncionario <= 10) {
                return Renda * 0.16;

            } else {
                return Renda * 0.14;
            }

        }
    }
}
