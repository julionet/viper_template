{
  __MODULENAME__Presenter.pas
  __APPNAME__

  Created by __USERNAME__ on __DATETIME__.
  Copyright © __YEAR__ __ORGANIZATIONNAME__. All rights reserved.
}

unit VIPERPresenter;

interface

uses SysUtils, VIPERInterfaces, VIPERInteractor, VIPERRouter;

type
  TVIPERPresenter = class(TInterfacedObject, IPresenterVIPER, IInteractorOutputVIPER)
  private
    FView: IViewVIPER;
    FInteractor: IInteractorVIPER;
    FRouter: IRouterVIPER;
  public
    constructor Create(AView: IViewVIPER);
    procedure Unload();
  end;

implementation

{ TVIPERPresenter }

constructor TVIPERPresenter.Create(AView: IViewVIPER);
begin
  FView := AView;
  FInteractor := TVIPERInteractor.Create(Self);
  FRouter := TVIPERRouter.Create;
end;

procedure TVIPERPresenter.Unload;
begin
  FInteractor := nil;
  FRouter := nil;
end;

end.
