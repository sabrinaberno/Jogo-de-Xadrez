using tabuleiro;

namespace xadrez {
    // herança
    class Rei : Peca {
        //passando as instrução do rei para a peça
        public Rei(Tabuleiro tab, Cor cor) : base(tab,cor){

        }

        public override string ToString() {
            return "R";
        }
    }
}