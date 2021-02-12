using System;

namespace poo.src {
    public class Locadora {
        private Disco[] arrDisco;
        private Filme[] arrFilme;

        private int indiceD;
        private int indiceF;

        public Locadora() {
            this.indiceD = 0;
            this.indiceF = 0;
            this.arrDisco = new Disco[2];
            this.arrFilme = new Filme[2];
        }

        public void novoDisco(Disco d) {
            this.arrDisco[this.indiceD] = d;
            this.indiceD++;
        }

        public void novoFilme(Filme f) {
            this.arrFilme[this.indiceF] = f;
            this.indiceF++;
        }

        public void ListarDiscos() {
            for (int i=0; i < arrDisco.Length; i++) {
                Console.WriteLine($"Informações do Disco {i+1}");
                Console.WriteLine("-----------------------------------------");
                arrDisco[i].ListaInformacoes();
                Console.WriteLine("-----------------------------------------\n");
            }
        }

        public void ListarFilmes() {
            for (int i=0; i < arrFilme.Length; i++) {
                Console.WriteLine($"Informações do Filme {i+1}");
                Console.WriteLine("-----------------------------------------");
                arrFilme[i].ListaInformacoes();
                Console.WriteLine("-----------------------------------------\n");
            }
        }
    }
}
