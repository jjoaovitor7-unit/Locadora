using System;

namespace poo.src {
    public class Disco : poo.src.Item {
        public string ArtistaDisco { set; get; }
        public int QtdeFaixas { set; get; }
        public string Midia { set; get; }

        public Disco() { }

        public Disco(string _titulo, int _anoLancamento, string _comentario, string _artistaDisco, int _qtdeFaixas, string _midia) {
            base.Titulo = _titulo;
            base.AnoLancamento = _anoLancamento;
            base.Comentario = _comentario;
            this.ArtistaDisco = _artistaDisco;
            this.QtdeFaixas = _qtdeFaixas;
            this.Midia = _midia;
        }

        public override void ListaInformacoes() {
            Console.WriteLine($"Título: { base.Titulo }\nAno de Lançamento: { base.AnoLancamento }\nComentário: { base.Comentario }\nArtista do Disco: { this.ArtistaDisco }\nQuantidade de Faixas: { this.QtdeFaixas }\nMídia: { this.Midia }");
        }
    }
}