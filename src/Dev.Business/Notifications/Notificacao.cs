using System;
using System.Linq;
using System.Text;

namespace Dev.Business.Notifications
{
    public class Notificacao
    {
        public Notificacao(string mensagem)
        {
            Mensagem = mensagem;       
        }

        public string Mensagem { get; }
    }

}
