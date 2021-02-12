using System;

namespace poo.src {
    public class Disco : poo.src.Item {
        private String artistaDisco;
        private int qtdeFaixas;
        private String midia;

        public Disco(string _titulo, int _anoLancamento, string _comentario, string _artistaDisco, int _qtdeFaixas, string _midia) {
            setTitulo(_titulo);
            setAnoLancamento(_anoLancamento);
            setComentario(_comentario);
            setArtistaDisco(_artistaDisco);
            setQtdeFaixas(_qtdeFaixas);
            setMidia(_midia);
        }

        public Disco() {
            
        }

        public void setArtistaDisco(string _artistaDisco) {
            this.artistaDisco = _artistaDisco;
        }

        public void setQtdeFaixas(int _qtdeFaixas) {
            this.qtdeFaixas = _qtdeFaixas;
        }

        public void setMidia(string _midia) {
            this.midia = _midia;
        }

        public String getArtistaDisco() {
            return this.artistaDisco;
        }

        public int getQtdeFaixas() {
            return this.qtdeFaixas;
        }

        public String getMidia() {
            return this.midia;
        }

        public override void ListaInformacoes() {
            Console.WriteLine($"Título: { getTitulo() }\nAno de Lançamento: { getAnoLancamento() }\nComentário: { getComentario() }\nArtista do Disco: { getArtistaDisco() }\nQuantidade de Faixas: { getQtdeFaixas() }\nMídia: {getMidia()}");
        }
    }
}