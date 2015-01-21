using System;

namespace SeLigaNoBlog.Playground
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Despacho!
             * 
             * Eu, enquanto usuário, quero receber, todo dia, pela manhã, 
             * um artigo técnico do Blog do Martin Fowler em meu e-mail.
             * 
             * Planejamento
             * 
             * Obter os posts do Blog
             *      TNX.RssReader
             * Separar os Artigos
             *      Onde o link conter a palavra articles
             * Pegar um artigo aleatório
             * Enviar o link para o e-mail do Usuário
             * 
             * Desafios
             * 
             * Como pegar os posts
             *      - RSS http://martinfowler.com/feed.atom
             * Como enviar o e-mail
             * 
             */

            var usuario = new Usuario();

            usuario.Nome = "Denis";
            usuario.Email = "denisferrari@azys.com.br";

            IBlog blog = new BlogMartinFowler();

            var artigo = blog.ObterArtigo();

            var servicoEmail = new Gmail();

            servicoEmail.EnviarEmail(usuario, artigo);

            Console.ReadLine();
        }
    }
}
