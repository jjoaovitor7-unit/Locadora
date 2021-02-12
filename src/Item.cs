using System;

namespace poo.src {
    public abstract class Item {
        public string Titulo { set; get; }
        public int AnoLancamento { set; get; }
        public string Comentario { set; get; }

        public Item() { }

        public Item(string _titulo, int _anoLancamento, string _comentario) {
            this.Titulo = _titulo;
            this.AnoLancamento = _anoLancamento;
            this.Comentario = _comentario;
        }

        public Item(string _titulo, int _anoLancamento) {
            this.Titulo = _titulo;
            this.AnoLancamento = _anoLancamento;
        }

        public abstract void ListaInformacoes();
    }
}