using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeLigaNoBlog
{
    public class ServicoRecomendacao
    {
        public void Executar()
        {
            var usuario = new Usuario();

            usuario.Nome = "Denis";
            usuario.Email = "denisferrari@azys.com.br";

            IBlog blog = new BlogMartinFowler();

            var artigo = blog.ObterArtigo();

            var servicoEmail = new Gmail();

            servicoEmail.EnviarEmail(usuario, artigo);
        }
    }
}
