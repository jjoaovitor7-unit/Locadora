using System;

namespace poo.src {
    public class Filme : poo.src.Item {
        public string NomeDiretor { set; get; }
        public float Duracao { set; get; }
        public string GeneroFilme { set; get;}

        public Filme() { }

        public Filme(string _titulo, int _anoLancamento, string _comentario, string _nomeDiretor, float _duracao, string _generoFilme) {
            base.Titulo = _titulo;
            base.AnoLancamento = _anoLancamento;
            base.Comentario = _comentario;
            this.NomeDiretor = _nomeDiretor;
            this.Duracao = _duracao;
            this.GeneroFilme = _generoFilme;
        }

        public override void ListaInformacoes() {
            Console.WriteLine($"Título: { base.Titulo }\nAno de Lançamento: { base.AnoLancamento }\nComentário: { base.Comentario }\nNome do Diretor: { this.NomeDiretor }\nDuracao: { this.Duracao }\nGênero: { this.GeneroFilme }");
        }
    }
}