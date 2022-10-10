using Tabuleiro;

namespace xadrez
{
    internal class Rei : Peca
    {
        public Rei(Tab tab, Cor cor) : base(tab, cor)
        {
        }

        public override string ToString()
        {
            return "R";
        }
    }
}
