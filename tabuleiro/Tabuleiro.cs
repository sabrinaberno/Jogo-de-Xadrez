namespace tabuleiro {
    class Tabuleiro {
        public int linhas {get; set;}
        public int colunas {get; set;}
        // rever vídeo de matrizes
        private Peca[,]pecas;

        public Tabuleiro(int linhas, int colunas){
            this.linhas = linhas;
            this.colunas = colunas;
            pecas = new Peca[linhas,colunas];
        }
    }
}