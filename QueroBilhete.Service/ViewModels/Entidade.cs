using System.Collections.Generic;
using System.Linq;

namespace QueroBilhete.Service.ViewModels
{
    public abstract class Entidade
    {
        private List<string> _mensagens;
        public List<string> Mensagens
        {
            get { return _mensagens ?? (_mensagens = new List<string>()); }
        }

        protected void AdicionaAlerta(string mensagem)
        {
            Mensagens.Add(mensagem);
        }

        protected void LimpaAlerta()
        {
            Mensagens.Clear();
        }

        public abstract void Validate();
        public bool Valido
        {
            get { return (!Mensagens.Any()); }
        }
    }
}
