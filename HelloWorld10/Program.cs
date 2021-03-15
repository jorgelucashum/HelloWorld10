using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld10
{
    class Program
    {
        // Construtor: É uma operação especial da classe, que executa no momento da instanciação do objeto, servindo como um "molde". Uso comuns:
        // - Iniciar valores dos atributos
        // - Permitir ou obrigar que o objeto receba dados/dependências no momento de sua instanciação (injeção de dependência)
        // - Se um construtor não for especificado dentro do parametro, a classe disponibiliza um contrutor padrão que recebe null e 0.0: Produto p = new Produto();
        // - É possível especificar mais de um construtor na mesma classe (sobrecarga)

        static void Main(string[] args)
        {

            Console.WriteLine("Digite o nome do produto: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite o preço: ");
            double preco = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a quantidade: ");
            int quantidade = int.Parse(Console.ReadLine());

            Produto p1 = new Produto(nome, preco, quantidade); // Produto instanciado com os parametros obrigatorios do construtor

            // Produto p2 = new Produto(nome, preco); // Também pode ser instanciado dessa forma com 2 parâmetros (construtor usando sobrecarga) 

            // Produto p3 = new Produto(); // Construtor padrão também usando sobrecarga

            // Produto p4 = new Produto() {Nome = nome, Preco = preco, Quantidade = quantidade}; // Sintaxe alternativa para iniciar valores igual ao construtor

            Console.WriteLine();
            Console.WriteLine("Dados do pruduto: " + p1);
            Console.WriteLine();

            Console.WriteLine("Digite a quantidade de produtos a serem adicionadas");
            int quant = int.Parse(Console.ReadLine());
            p1.AdicionarProdutos(quant);
            Console.WriteLine("Dados atualizados: " + p1);
            Console.WriteLine();

            Console.WriteLine("Digite a quantidade de produtos a serem removidas");
            quant = int.Parse(Console.ReadLine());
            p1.RemoverProdutos(quant);
            Console.WriteLine("Dados atualizados: " + p1);
            Console.WriteLine();


            Console.ReadLine();
        }
    }
}
