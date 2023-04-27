using tabuleiro;

namespace xadrez {
    // herança
    class Torre : Peca {
        //passando as instrução da torre para a peça
        public Torre(Tabuleiro tab, Cor cor) : base(tab,cor){

        }

        public override string ToString() {
            return "T";
        }
    }
}