{
  __MODULENAME__Interactor.pas
  __APPNAME__

  Created by __USERNAME__ on __DATETIME__.
  Copyright © __YEAR__ __ORGANIZATIONNAME__. All rights reserved.
}

unit VIPERInteractor;

interface

uses VIPERInterfaces;

type
  TVIPERInteractor = class(TInterfacedObject, IInteractorVIPER)
  private
    FOutput: IInteractorOutputVIPER;
  public
    constructor Create(AOutput: IInteractorOutputVIPER);
  end;

implementation

{ TModeloInteractor }

constructor TVIPERInteractor.Create(AOutput: IInteractorOutputVIPER);
begin
  FOutput := AOutput;
end;

end.
