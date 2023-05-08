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

        public override bool[,] movimentosPossiveis() {
            bool[,] mat = new bool[tab.linhas, tab.colunas];
            posicao pos = new Posicao(0,0);

            //acima 
            pos.definirValores(posicao.linha - 1, posicao.coluna);
            while (tab.posicaoValida(pos) && podeMover(pos)) {
                mat[pos.linha, pos.coluna] = true;
                if(tab.peca(pos) != null && tab.peca(pos).cor != cor){
                    break;
                }
                pos.linha = pos.linha - 1;
            }

            //abaixo 
            pos.definirValores(posicao.linha + 1, posicao.coluna);
            while (tab.posicaoValida(pos) && podeMover(pos)) {
                mat[pos.linha, pos.coluna] = true;
                if(tab.peca(pos) != null && tab.peca(pos).cor != cor){
                    break;
                }
                pos.linha = pos.linha + 1;
            }

            //direita
            pos.definirValores(posicao.linha, posicao.coluna + 1);
            while (tab.posicaoValida(pos) && podeMover(pos)) {
                mat[pos.linha, pos.coluna] = true;
                if(tab.peca(pos) != null && tab.peca(pos).cor != cor){
                    break;
                }
                pos.linha = pos.coluna + 1;
            }

            //esuerda 
            pos.definirValores(posicao.linha, posicao.coluna - 1);
            while (tab.posicaoValida(pos) && podeMover(pos)) {
                mat[pos.linha, pos.coluna] = true;
                if(tab.peca(pos) != null && tab.peca(pos).cor != cor){
                    break;
                }
                pos.linha = pos.coluna - 1;
            }

            return mat;
        }
    }
}