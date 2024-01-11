using System;
using tabuleiro;
using xadrez;
using Xadrez_Console;

namespace xadrezconsole
{
    class Program
    {
        static void Main(string[] args)
        {

           Tabuleiro tab = new Tabuleiro(8,8);

            tab.colocarPeca(new Torre(Cor.Preta, tab), new Posicao(0, 0));
            tab.colocarPeca(new Torre(Cor.Preta, tab), new Posicao(1, 3));
            tab.colocarPeca(new Rei(Cor.Preta, tab), new Posicao(2, 4));



            Tela.imprimirTabuleiro(tab);

           Console.ReadLine();

        }
    }
}