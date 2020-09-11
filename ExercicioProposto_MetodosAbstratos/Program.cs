using System;
using System.Collections.Generic;
using ExercicioProposto_MetodosAbstratos.Entities;
using System.Globalization;

namespace ExercicioProposto_MetodosAbstratos {
    class Program {
        static void Main(string[] args) {
            double total = 0;

            Console.Write("Digite o numero de contribuintes: ");
            int n = int.Parse(Console.ReadLine());

            List<Pessoa> list = new List<Pessoa>();

            for (int i = 1; i <= n; i++) {
                Console.WriteLine("Contribuinte #{0} informações: ", i);
                Console.Write("Pessoa fisica ou juridica (F / J):");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Renda: ");
                double renda = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (ch == 'f' || ch == 'F') {
                    Console.Write("Gastos com saude: ");
                    double saude = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new PessoaFisica(nome, renda, saude));

                } else if (ch == 'j' || ch == 'J') {
                    Console.Write("Numeros de funcionarios: ");
                    int nfunc = int.Parse(Console.ReadLine());
                    list.Add(new PessoaJuridica(nome, renda, nfunc));

                } else {
                    Console.WriteLine("Opção invalida!!");
                }

            }

            Console.WriteLine();
            Console.WriteLine("Juros pagos: ");

            foreach (Pessoa p in list) {
                Console.WriteLine(p.Nome + ": $ " + p.ImpostoPago().ToString("f2", CultureInfo.InvariantCulture));
                total += p.ImpostoPago();
            }

            Console.WriteLine();
            Console.WriteLine("Total de juros pagos: $" + total);

        }
    }
}
