using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioProposto_MetodosAbstratos.Entities {
    abstract class Pessoa {
        public string Nome { get; set; }
        public double Renda { get; set; }

        public Pessoa() {

        }

        protected Pessoa(string nome, double renda) {
            Nome = nome;
            Renda = renda;
        }

        public abstract double ImpostoPago();

    }
}
