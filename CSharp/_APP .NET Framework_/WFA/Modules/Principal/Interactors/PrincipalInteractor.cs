using VIPER.Modules.Principal.Interfaces;
using VIPER.Service;
using DevExpress.XtraBars.Navigation;
using System.Linq;

namespace VIPER.Modules.Principal.Interactors
{
    public class PrincipalInteractor : IPresenterToInteractorPrincipal
    {
        public IInteractorToPresenterPrincipal presenter;

        public void SelecionarAcessoPorUsuarioModulo(int usuario, int modulo, int sistema, TileBar tilebarmodulo, TileBarItem tilebaritem, TileBarDropDownContainer container)
        {
            var dados = Servicos.usuarioFuncaoService.SelecionarAcessoPorUsuarioModulo(usuario, modulo, sistema).OrderBy(p => p.FuncaoGrupo).ThenBy(p => p.FuncaoDescricao).ToList();
            if (dados.Count != 0)
                presenter.SelecionarAcessoPorUsuarioModuloSucesso(dados, tilebarmodulo, tilebaritem, container);
            else
                presenter.SelecionarAcessoPorUsuarioModuloFalha();
        }

        public void SelecionarAcessoPorUsuarioSistema(int usuario, int sistema)
        {
            var dados = Servicos.usuarioFuncaoService.SelecionarAcessoPorUsuarioModulo(usuario, 0, sistema).ToList();
            if (dados.Count != 0)
                presenter.SelecionarAcessoPorUsuarioSistemaSucesso(dados);
            else
                presenter.SelecionarAcessoPorUsuarioModuloFalha();
        }

        public void SelecionarFuncaoPorModulo(int modulo, TileBar tilebarmodulo, TileBarItem tilebaritem, TileBarDropDownContainer container)
        {
            var funcaos = Servicos.funcaoService.SelecionarPorModulo(modulo).OrderBy(p => p.Descricao).ToList();
            if (funcaos.Count != 0)
                presenter.SelecionarFuncaoPorModuloSucesso(funcaos, tilebarmodulo, tilebaritem, container);
            else
                presenter.SelecionarFuncaoPorModuloFalha();
        }

        public void SelecionarModulosPorSistema(int sistema)
        {
            var modulos = Servicos.moduloService.SelecionarPorSistema(sistema).OrderBy(p => p.Codigo).ToList();
            if (modulos.Count() != 0)
                presenter.SelecionarModulosSucesso(modulos);
            else
                presenter.SelecionarModulosFalha();
        }

        public void SelecionarModulosPorSistemaUsuario(int sistema, int usuario)
        {
            var modulos = Servicos.moduloService.SelecionarPorSistemaUsuario(sistema, usuario).OrderBy(p => p.Codigo).ToList();
            if (modulos.Count() != 0)
                presenter.SelecionarModulosSucesso(modulos);
            else
                presenter.SelecionarModulosFalha();
        }
    }
}
