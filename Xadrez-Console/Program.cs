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
            PosicaoXadrez pos = new PosicaoXadrez('c', 7);


            Console.WriteLine(pos);
            Console.WriteLine(pos.toPosicao());

            Console.ReadLine();

        }
    }
}