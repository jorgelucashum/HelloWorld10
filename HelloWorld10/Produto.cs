using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization; // usado para converter 'CultureInfo.InvariantCulture' 

namespace HelloWorld10
{
    //Sobrecarga: É um recurso que uma classe possui de oferecer mais de uma operação com o mesmo nome, porém com diferentes listas de parâmetros.
    class Produto
    {
        public string Nome; //atributo com primeira letra maiusculo em classe fora da main
        public int Quantidade;
        public double Preco;

        //Criando e definindo paramêtros no construtor:
        public Produto(string nome, double preco, int quantidade) // Construtor tem o mesmo nome da classe
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public Produto(string nome, double preco) // Sobrecarga de um construtor só com dois parâmetros de entrada, sendo possível coexistir o construtor de 3 e o de 2 parametros.
        {
            Nome = nome;
            Preco = preco;
            // Quantidade = 10; Pode ser definida a quantidade caso necessário, mas sem valor atribuido, por padrão é 0

        }

        public Produto() // Sobrecarga para funcionar o construtor padrão e sintaxe alternativa (Só é necessário quando se declara algum construtor)
        {

        }

        public double ValorTotalEmEsqtoque()
        {
            return Quantidade * Preco;
        }

        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade; // Quantidade = Quantidade + quantidade;
        }

        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade; // Quantidade = Quantidade - quantidade;
        }

        public override string ToString() // método usado para retornar a váriavel 'p1' nas informações em String
        {
            return Nome + ", R$:" + Preco.ToString("F2", CultureInfo.InvariantCulture) + ", " + Quantidade + " " +
                "Unidades, total R$:" + ValorTotalEmEsqtoque().ToString("F2", CultureInfo.InvariantCulture); // converter as ',' para '.' (padrão internacional)
        }

    }
}