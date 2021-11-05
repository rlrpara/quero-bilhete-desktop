using Caliburn.Micro;
using QueroBilhete.Data.Repositories;
using QueroBilhete.Service.Service;
using QueroBilhete.Service.ViewModels;
using System.Collections.Generic;

namespace QueroBolhete.Wpf.ViewModels.Cadastros
{
    public class CadastrosViewModel : Screen
    {
        #region [Propriedades Privadas]
        private List<UsuarioViewModel> _usuarioViewModel;
        private readonly BaseRepository _baseRepository;
        private UsuarioService usuarioService;
        #endregion

        #region [Propriedades Públicas]
        public List<UsuarioViewModel> ListaUsuarios
        {
            get { return _usuarioViewModel; }
            set
            {
                _usuarioViewModel = value;
                NotifyOfPropertyChange(() => ListaUsuarios);
            }
        }
        #endregion


        #region [Construtor]
        public CadastrosViewModel()
        {
            _baseRepository = new BaseRepository();
            usuarioService = new UsuarioService(_baseRepository);
            _usuarioViewModel = usuarioService.ObterTodos("");
        }
        #endregion
    }
}
