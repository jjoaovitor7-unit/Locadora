using System;

namespace poo.src {
    public class Filme : poo.src.Item {
        private string nomeDiretor;
        private float duracao;
        private string generoFilme;

        public Filme(string _titulo, int _anoLancamento, string _comentario, string _nomeDiretor, float _duracao, string _generoFilme) {
            setTitulo(_titulo);
            setAnoLancamento(_anoLancamento);
            setComentario(_comentario);
            setNomeDiretor(_nomeDiretor);
            setDuracao(_duracao);
            setGeneroFilme(_generoFilme);
        }

        public Filme() {
            
        }

        public void setNomeDiretor(string _nomeDiretor) {
            this.nomeDiretor = _nomeDiretor;
        }

        public void setDuracao(float _duracao) {
            this.duracao = _duracao;
        }

        public void setGeneroFilme(string _generoFilme) {
            this.generoFilme = _generoFilme;
        }

        public String getNomeDiretor() {
            return this.nomeDiretor;
        }

        public float getDuracao() {
            return this.duracao;
        }

        public String getGeneroFilme() {
            return this.generoFilme;
        }

        public override void ListaInformacoes() {
            Console.WriteLine($"Título: { getTitulo() }\nAno de Lançamento: { getAnoLancamento() }\nComentário: { getComentario() }\nNome do Diretor: { getNomeDiretor() }\nDuracao: { getDuracao() }\nGênero: { getGeneroFilme() }");
        }
    }
}