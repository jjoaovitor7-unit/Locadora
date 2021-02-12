using System;
using poo.src;

namespace poo {
    class Program {
        static void Main(string[] args) {
            Locadora loc = new Locadora();

            loc.novoDisco(new Disco("Samba Social Clube 5", 2014, "Vários Sambas", "Vários Artistas", 12, "CD"));
            loc.novoDisco(new Disco("Pode Entrar", 2009, "Ivete e Convidados", "Ivete Sangalo", 14, "DVD"));

            loc.novoFilme(new Filme("Smurfs 2", 2013, "Gargamel cria a versão malvada dos Smurfs", "Raja Gosnell", 140, "Animação"));
            loc.novoFilme(new Filme("Os mercenários 2", 2012, "De volta ao mundo", "Simon West", 210, "Animação"));

            loc.ListarDiscos();
            loc.ListarFilmes();
        }
    }
}