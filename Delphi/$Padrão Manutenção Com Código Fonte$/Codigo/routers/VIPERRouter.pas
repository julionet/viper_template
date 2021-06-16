{
  __MODULENAME__Router.pas
  __APPNAME__

  Created by __USERNAME__ on __DATETIME__.
  Copyright © __YEAR__ __ORGANIZATIONNAME__. All rights reserved.
}

unit VIPERRouter;

interface

uses
  VIPERInterfaces, VIPERView, Forms;

type
  TVIPERRouter = class(TInterfacedObject, IPresenterToRouterVIPER)
    class function New: IPresenterToRouterVIPER;
    procedure LoadModule(View: TForm);
  end;

implementation

{ TVIPERRouter }

uses VIPERPresenter, VIPERInteractor;

procedure TVIPERRouter.LoadModule(View: TForm);
begin
  var Presenter := TVIPERPresenter.Create;
  var Interactor := TVIPERInteractor.Create;
  var Router := TVIPERRouter.Create;

  TFrmVIPERView(View).Presenter := Presenter;
  Presenter.View := TFrmVIPERView(View);
  Presenter.Router := Router;
  Presenter.Interactor := Interactor;
  Interactor.Presenter := Presenter;
end;

class function TVIPERRouter.New: IPresenterToRouterVIPER;
begin
  Result := TVIPERRouter.Create;
end;

end.
