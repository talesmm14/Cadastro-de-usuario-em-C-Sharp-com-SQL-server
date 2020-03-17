using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    class Usuario : Pessoa, IDaoUsuario<Usuario>
    {
        public Login login = new Login();

        public Login Login
        {
            get => this.login;
            set => this.login = value;
        }

        public void create()
        {
            throw new NotImplementedException();
        }

        public void delete()
        {
            throw new NotImplementedException();
        }

        public Usuario findById()
        {
            throw new NotImplementedException();
        }

        public void update()
        {
            throw new NotImplementedException();
        }

        public String ValidarSenha(Usuario usuario, String confSenha)
        {
            if (usuario.login.senha == confSenha)
                return "Tudo certo!";
            return "As senhas não são iguais!";
        }
    }
}
