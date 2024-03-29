﻿using Caliburn.Micro;
using QueroBilhete.Data.Repositories;
using QueroBilhete.Service.Service;
using System.Collections.Generic;

namespace QueroBolhete.Wpf.ViewModels.Usuario
{
    public class UsuarioViewModel : Screen
    {

        #region [Propriedades Privadas]
        private List<QueroBilhete.Service.ViewModels.UsuarioViewModel> _usuarioViewModel;
        private readonly BaseRepository _baseRepository;
        private UsuarioService usuarioService;
        #endregion

        #region [Propriedades Públicas]
        public List<QueroBilhete.Service.ViewModels.UsuarioViewModel> ListaUsuarios
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
        public UsuarioViewModel()
        {
            _baseRepository = new BaseRepository();
            usuarioService = new UsuarioService(_baseRepository);
            _usuarioViewModel = usuarioService.ObterTodos("");
        }
        #endregion

    }
}
