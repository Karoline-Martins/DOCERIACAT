using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DOCERIACAT
{
    public partial class Tela_cardapio : Form
    {
        public Tela_cardapio()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            // Exibindo o cardápio
            Console.WriteLine("Bem-vindo à DoceriaCat!\n");
            Console.WriteLine("Cardápio:");
            Console.WriteLine("1. Bombom de Gato - R$5.00");
            Console.WriteLine("2. Cappuccino de Gato - R$12.00");
            Console.WriteLine("3. Bolo de Gato - R$20.00");
            Console.WriteLine("4. Bolacha de Gato - R$7.00");
            Console.WriteLine("5. Donuts de Gato - R$15.00");
            Console.WriteLine("6. Picolé de Gato - R$11.00");
            Console.WriteLine("7. Cupcake de Gato - R$14.00");

            // Solicitando o item que o cliente quer pedir
            Console.Write("\nDigite o número do item que deseja pedir: ");
            int escolha = int.Parse(Console.ReadLine());

            // Solicitando a quantidade do item
            Console.Write("Digite a quantidade desejada: ");
            int quantidade = int.Parse(Console.ReadLine());

            // Preços dos itens
            decimal preco = 0;
            string itemEscolhido = "";

            switch (escolha)
            {
                case 1:
                    itemEscolhido = "Bombom de Gato";
                    preco = 5.00m;
                    break;
                case 2:
                    itemEscolhido = "Cappuccino de Gato";
                    preco = 12.00m;
                    break;
                case 3:
                    itemEscolhido = "Bolo de Gato";
                    preco = 20.00m;
                    break;
                case 4:
                    itemEscolhido = "Bolacha de Gato";
                    preco = 7.00m;
                    break;
                case 5:
                    itemEscolhido = "Donuts de Gato";
                    preco = 15.00m;
                    break;
                case 6:
                    itemEscolhido = "Picolé de Gato";
                    preco = 11.00m;
                    break;
                case 7:
                    itemEscolhido = "Cupcake de Gato";
                    preco = 14.00m;
                    break;
                default:
                    Console.WriteLine("Opção inválida!");
                    return;
            }

            // Calculando o valor total
            decimal valorTotal = quantidade * preco;

            // Exibindo o resumo do pedido
            Console.WriteLine($"\nResumo do pedido:");
            Console.WriteLine($"{quantidade}x {itemEscolhido} - Preço unitário: R${preco:F2}");
            Console.WriteLine($"Valor total: R${valorTotal:F2}");

            // Aguardando para fechar o programa
            Console.WriteLine("\nObrigado por comprar na DoceriaCat! Pressione qualquer tecla para sair.");
            Console.ReadKey();
        }
    }
}


