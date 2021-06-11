using VIPER.DTO;
using VIPER.Modules.Principal.Interfaces;
using DevExpress.XtraBars.Navigation;
using System.Collections.Generic;

namespace VIPER.Modules.Principal.Presenters
{
    public class PrincipalPresenter : IViewToPresenterPrincipal, IInteractorToPresenterPrincipal
    {
        public IPresenterToInteractorPrincipal interactor;
        public IPresenterToRouterPrincipal router;
        public IPresenterToViewPrincipal view;

        public void CarregarAlteraSenha()
        {
            router.CarregarAlteraSenha();
        }

        public void CarregarLogin(out bool confirmado)
        {
            router.CarregarLogin(out confirmado);
        }

        public void CarregarTrocaSistema(out bool confirmado)
        {
            router.CarregarTrocaSistema(out confirmado);
        }

        public void SelecionarAcessoPorUsuarioModulo(int usuario, int modulo, int sistema, TileBar tilebarmodulo, TileBarItem tilebaritem, TileBarDropDownContainer container)
        {
            interactor.SelecionarAcessoPorUsuarioModulo(usuario, modulo, sistema, tilebarmodulo, tilebaritem, container);
        }

        public void SelecionarAcessoPorUsuarioModuloFalha()
        {
            view.SelecionarAcessoPorUsuarioModuloFalha();
        }

        public void SelecionarAcessoPorUsuarioModuloSucesso(List<UsuarioFuncaoDTO> acesso, TileBar tilebarmodulo, TileBarItem tilebaritem, TileBarDropDownContainer container)
        {
            view.SelecionarAcessoPorUsuarioModuloSucesso(acesso, tilebarmodulo, tilebaritem, container);
        }

        public void SelecionarAcessoPorUsuarioSistema(int usuario, int sistema)
        {
            interactor.SelecionarAcessoPorUsuarioSistema(usuario, sistema);
        }

        public void SelecionarAcessoPorUsuarioSistemaFalha()
        {
            view.SelecionarAcessoPorUsuarioSistemaFalha();
        }

        public void SelecionarAcessoPorUsuarioSistemaSucesso(List<UsuarioFuncaoDTO> acesso)
        {
            view.SelecionarAcessoPorUsuarioSistemaSucesso(acesso);
        }

        public void SelecionarFuncaoPorModulo(int modulo, TileBar tilebarmodulo, TileBarItem tilebaritem, TileBarDropDownContainer container)
        {
            interactor.SelecionarFuncaoPorModulo(modulo, tilebarmodulo, tilebaritem, container);
        }

        public void SelecionarFuncaoPorModuloFalha()
        {
            view.SelecionarFuncaoPorModuloFalha();
        }

        public void SelecionarFuncaoPorModuloSucesso(List<Entity.Funcao> funcaos, TileBar tilebarmodulo, TileBarItem tilebaritem, TileBarDropDownContainer container)
        {
            view.SelecionarFuncaoPorModuloSucesso(funcaos, tilebarmodulo, tilebaritem, container);
        }

        public void SelecionarModulosFalha()
        {
            view.SelecionarModulosFalha();
        }

        public void SelecionarModulosPorSistema(int sistema)
        {
            interactor.SelecionarModulosPorSistema(sistema);
        }

        public void SelecionarModulosPorSistemaUsuario(int sistema, int usuario)
        {
            interactor.SelecionarModulosPorSistemaUsuario(sistema, usuario);
        }

        public void SelecionarModulosSucesso(List<Entity.Modulo> modulos)
        {
            view.SelecionarModulosSucesso(modulos);
        }
    }
}
