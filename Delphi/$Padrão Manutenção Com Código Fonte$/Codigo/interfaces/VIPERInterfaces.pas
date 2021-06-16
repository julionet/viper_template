{
  __MODULENAME__Interfaces.pas
  __APPNAME__

  Created by __USERNAME__ on __DATETIME__.
  Copyright © __YEAR__ __ORGANIZATIONNAME__. All rights reserved.
}

unit VIPERInterfaces;

interface

uses
  System.Generics.Collections, Data.DB, Forms;

type
  IViewToPresenterVIPER = interface
  end;

  IPresenterToViewVIPER = interface
  end;

  IPresenterToInteractorVIPER = interface
  end;

  IInteractorToPresenterVIPER = interface
  end;

  IPresenterToRouterVIPER = interface
    procedure LoadModule(View: TForm);
  end;

implementation

end.
