{
  __MODULENAME__View.pas
  __APPNAME__

  Created by __USERNAME__ on __DATETIME__.
  Copyright © __YEAR__ __ORGANIZATIONNAME__. All rights reserved.
}

unit VIPERView;

interface

uses
  Winapi.Windows, Winapi.Messages, System.SysUtils, System.Variants, System.Classes, 
  Vcl.Graphics, Vcl.Controls, Vcl.Forms, Vcl.Dialogs, ModeloView, Vcl.ExtCtrls,
  cxGraphics, cxLookAndFeels, cxLookAndFeelPainters, Vcl.Menus, dxSkinsCore, 
  dxSkinOffice2016Colorful, dxSkinOffice2016Dark, Vcl.StdCtrls, cxButtons,
  VIPERPresenter, VIPERInterfaces;

type
  TFrmVIPERView = class(TFrmModeloView,IViewVIPER)
  private
    { Private declarations }
	FPresenter: IPresenterVIPER;
  public
    { Public declarations }
	constructor Create(AOwner: TComponent); override;
	destructor Destroy; override;
  end;

var
  FrmVIPERView: TFrmVIPERView;

implementation

{$R *.dfm}

constructor TFrmVIPERView.Create(AOwner: TComponent);
begin
  inherited Create(AOwner);
  FPresenter := TVIPERPresenter.Create(Self);
end;

destructor TFrmVIPERView.Destroy;
begin
  if Assigned(FPresenter) then
  begin
    FPresenter.Unload;
    FPresenter := nil;
  end;

  inherited;
end;

end.
