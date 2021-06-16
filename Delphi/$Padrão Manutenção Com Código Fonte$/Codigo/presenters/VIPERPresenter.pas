{
  __MODULENAME__Presenter.pas
  __APPNAME__

  Created by __USERNAME__ on __DATETIME__.
  Copyright © __YEAR__ __ORGANIZATIONNAME__. All rights reserved.
}

unit VIPERPresenter;

interface

uses
  Data.DB, VIPERInterfaces;

type
  TVIPERPresenter = class(TInterfacedObject, IViewToPresenterVIPER, IInteractorToPresenterVIPER)
    View: IPresenterToViewVIPER;
    Interactor: IPresenterToInteractorVIPER;
    Router: IPresenterToRouterVIPER;

    class function NewView: IViewToPresenterVIPER;
    class function NewInteractor: IInteractorToPresenterVIPER;
    procedure Filtrar(Condicao: String; DataSet: TDataSet);
    procedure Gravar(DataSet: TDataSet);
    procedure Excluir(DataSet: TDataSet);
    procedure FiltrarSuccess(DataSet: TDataSet);
    procedure FiltrarFailed(Mensagem: String);
    procedure GravarSucesso;
    procedure GravarFalha(Mensagem: String);
    procedure ExcluirSucesso;
    procedure ExcluirFalha(Mensagem: String);
  end;

implementation

{ TVIPERPresenter }

procedure TVIPERPresenter.Excluir(DataSet: TDataSet);
begin
  Interactor.Excluir(DataSet);
end;

procedure TVIPERPresenter.ExcluirFalha(Mensagem: String);
begin
  view.ExcluirFalha(Mensagem);
end;

procedure TVIPERPresenter.ExcluirSucesso;
begin
  view.ExcluirSucesso;
end;

procedure TVIPERPresenter.Filtrar(Condicao: String; DataSet: TDataSet);
begin
  Interactor.Filtrar(Condicao, DataSet);
end;

procedure TVIPERPresenter.FiltrarFailed(Mensagem: String);
begin
  view.FiltrarFailed(Mensagem);
end;

procedure TVIPERPresenter.FiltrarSuccess(DataSet: TDataSet);
begin
  view.FiltrarSuccess(DataSet);
end;

procedure TVIPERPresenter.Gravar(DataSet: TDataSet);
begin
  Interactor.Gravar(DataSet);
end;

procedure TVIPERPresenter.GravarFalha(Mensagem: String);
begin
  view.GravarFalha(Mensagem);
end;

procedure TVIPERPresenter.GravarSucesso;
begin
  View.GravarSucesso;
end;

class function TVIPERPresenter.NewInteractor: IInteractorToPresenterVIPER;
begin
  Result := TVIPERPresenter.Create;
end;

class function TVIPERPresenter.NewView: IViewToPresenterVIPER;
begin
  Result := TVIPERPresenter.Create;
end;

end.
