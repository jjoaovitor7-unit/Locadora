using System;

namespace poo.src {
    public abstract class Item {
        public string titulo;
        public int anoLancamento;
        public string comentario;

        public Item() {
            
        }

        public Item(string _titulo, int _anoLancamento, string _comentario) {
            setTitulo(_titulo);
            setAnoLancamento(_anoLancamento);
            setComentario(_comentario);
        }

        public Item(string _titulo, int _anoLancamento) {
            setTitulo(_titulo);
            setAnoLancamento(_anoLancamento);
        }

        public void setTitulo(string _titulo) {
            this.titulo = _titulo;
        }

        public void setAnoLancamento(int _anoLancamento) {
            this.anoLancamento = _anoLancamento;
        }

        public void setComentario(string _comentario) {
            this.comentario = _comentario;
        }

        public string getTitulo() {
            return this.titulo;
        }

        public int getAnoLancamento() {
            return this.anoLancamento;
        }

        public string getComentario() {
            return this.comentario;
        }

        public abstract void ListaInformacoes();
    }
}