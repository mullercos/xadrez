using Tabuleiro;

namespace xadrez
{
    internal class Torre : Peca
    {
        public Torre(Tab tab, Cor cor) : base(tab, cor)
        {
        }

        public override string ToString()
        {
            return "T";
        }
    }
}
