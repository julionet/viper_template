{
  __MODULENAME__Interactor.pas
  __APPNAME__

  Created by __USERNAME__ on __DATETIME__.
  Copyright © __YEAR__ __ORGANIZATIONNAME__. All rights reserved.
}

unit VIPERInteractor;

interface

uses
  SysUtils, Data.DB, VIPERInterfaces, VIPERService;

type
  TVIPERInteractor = class(TInterfacedObject, IPresenterToInteractorVIPER)
    Presenter: IInteractorToPresenterVIPER;
    class function New: IPresenterToInteractorVIPER;
    procedure Filtrar(Condicao: String; DataSet: TDataSet);
    procedure Gravar(DataSet: TDataSet);
    procedure Excluir(DataSet: TDataSet);
  end;

implementation

{ TVIPERInteractor }

procedure TVIPERInteractor.Excluir(DataSet: TDataSet);
begin
  var mensagem := TVIPERService.Excluir(DataSet);
  if mensagem = '' then
    Presenter.ExcluirSucesso
  else
    Presenter.ExcluirFalha(mensagem);
end;

procedure TVIPERInteractor.Filtrar(Condicao: String; DataSet: TDataSet);
begin
  try
    Presenter.FiltrarSuccess(TVIPERService.Filtrar(Condicao, DataSet));
  except
    on E: Exception do
    begin
      Presenter.FiltrarFailed(E.Message);
    end;
  end;
end;

procedure TVIPERInteractor.Gravar(DataSet: TDataSet);
begin
  var mensagem := TVIPERService.Gravar(DataSet);
  if mensagem = '' then
    Presenter.GravarSucesso
  else
    Presenter.GravarFalha(mensagem);
end;

class function TVIPERInteractor.New: IPresenterToInteractorVIPER;
begin
  Result := TVIPERInteractor.Create;
end;

end.
