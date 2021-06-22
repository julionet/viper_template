using VIPER.DTO;
using DevExpress.XtraBars.Navigation;
using System.Collections.Generic;

namespace VIPER.Modules.Principal.Interfaces
{
    public interface IViewToPresenterPrincipal
    {
        void SelecionarAcessoPorUsuarioModulo(int usuario, int modulo, int sistema, TileBar tilebarmodulo, TileBarItem tilebaritem, TileBarDropDownContainer container);
        void SelecionarAcessoPorUsuarioSistema(int usuario, int sistema);
        void SelecionarModulosPorSistema(int sistema);
        void SelecionarModulosPorSistemaUsuario(int sistema, int usuario);
        void SelecionarFuncaoPorModulo(int modulo, TileBar tilebarmodulo, TileBarItem tilebaritem, TileBarDropDownContainer container);
        void CarregarLogin(out bool confirmado);
        void CarregarAlteraSenha();
        void CarregarTrocaSistema(out bool confirmado);
    }

    public interface IPresenterToViewPrincipal
    {
        void SelecionarAcessoPorUsuarioModuloSucesso(List<UsuarioFuncaoDTO> acesso, TileBar tilebarmodulo, TileBarItem tilebaritem, TileBarDropDownContainer container);
        void SelecionarAcessoPorUsuarioModuloFalha();
        void SelecionarAcessoPorUsuarioSistemaSucesso(List<UsuarioFuncaoDTO> acesso);
        void SelecionarAcessoPorUsuarioSistemaFalha();
        void SelecionarModulosSucesso(List<Entity.Modulo> modulos);
        void SelecionarModulosFalha();
        void SelecionarFuncaoPorModuloSucesso(List<Entity.Funcao> funcaos, TileBar tilebarmodulo, TileBarItem tilebaritem, TileBarDropDownContainer container);
        void SelecionarFuncaoPorModuloFalha();
    }

    public interface IPresenterToInteractorPrincipal
    {
        void SelecionarAcessoPorUsuarioModulo(int usuario, int modulo, int sistema, TileBar tilebarmodulo, TileBarItem tilebaritem, TileBarDropDownContainer container);
        void SelecionarAcessoPorUsuarioSistema(int usuario, int sistema);
        void SelecionarModulosPorSistema(int sistema);
        void SelecionarModulosPorSistemaUsuario(int sistema, int usuario);
        void SelecionarFuncaoPorModulo(int modulo, TileBar tilebarmodulo, TileBarItem tilebaritem, TileBarDropDownContainer container);
    }

    public interface IInteractorToPresenterPrincipal
    {
        void SelecionarAcessoPorUsuarioModuloSucesso(List<UsuarioFuncaoDTO> acesso, TileBar tilebarmodulo, TileBarItem tilebaritem, TileBarDropDownContainer container);
        void SelecionarAcessoPorUsuarioModuloFalha();
        void SelecionarAcessoPorUsuarioSistemaSucesso(List<UsuarioFuncaoDTO> acesso);
        void SelecionarAcessoPorUsuarioSistemaFalha();
        void SelecionarModulosSucesso(List<Entity.Modulo> modulos);
        void SelecionarModulosFalha();
        void SelecionarFuncaoPorModuloSucesso(List<Entity.Funcao> funcaos, TileBar tilebarmodulo, TileBarItem tilebaritem, TileBarDropDownContainer container);
        void SelecionarFuncaoPorModuloFalha();
    }

    public interface IPresenterToRouterPrincipal
    {
        void CarregarLogin(out bool confirmado);
        void CarregarAlteraSenha();
        void CarregarTrocaSistema(out bool confirmado);
    }
}
