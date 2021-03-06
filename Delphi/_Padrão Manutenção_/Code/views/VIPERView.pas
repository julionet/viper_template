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
  Vcl.Graphics, Vcl.Controls, Vcl.Forms, Vcl.Dialogs, ManutencaoView, cxGraphics,
  cxLookAndFeels, cxLookAndFeelPainters, dxBarBuiltInMenu, Vcl.Menus, cxStyles,
  cxCustomData, cxFilter, cxData, cxDataStorage, cxEdit, cxNavigator,
  cxDataControllerConditionalFormattingRulesManagerDialog, Data.DB, cxDBData,
  cxContainer, cxTextEdit, cxLabel, cxGridLevel, cxClasses, cxGridCustomView,
  cxControls, cxGridCustomTableView, cxGridTableView, cxGridDBTableView, cxGrid,
  Vcl.StdCtrls, cxButtons, Vcl.ExtCtrls, cxPC, FireDAC.Comp.Client,
  VIPERInterfaces, cxMemo, cxDBEdit, FireDAC.Stan.Intf, FireDAC.Stan.Option,
  FireDAC.Stan.Param, FireDAC.Stan.Error, FireDAC.DatS, FireDAC.Phys.Intf,
  FireDAC.DApt.Intf, FireDAC.Stan.Async, FireDAC.DApt, FireDAC.Comp.DataSet,
  VIPERPresenter;

type
  TFrmVIPERView = class(TFrmManutencaoView, IViewVIPER)
    procedure FormCreate(Sender: TObject);
  private
    { Private declarations }
	FDataSet: TFDMemTable;
    FPresenter: IPresenterVIPER;
  public
    { Public declarations }
	constructor Create(AOwner: TComponent); override;
	destructor Destroy; override;
  protected
    { Protected declarations }
	function CancelarRegistro: Boolean; override;
	procedure ExcluirRegistro; override;
	procedure FiltrarRegistros; override;
	procedure GravarRegistro; override;
	function InserirRegistro: Boolean; override;
  end;

var
  FrmVIPERView: TFrmVIPERView;

implementation

{$R *.dfm}

uses Utils, uMensagens, VIPER;

{ TFrmVIPERView }

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

function TFrmVIPERView.CancelarRegistro: Boolean;
begin
  DataSourcePrincipal.DataSet.Cancel;
  Result := inherited;
end;

procedure TFrmVIPERView.ExcluirRegistro;
begin
  
end;

procedure TFrmVIPERView.FiltrarRegistros;
begin
  inherited;
end;

procedure TFrmVIPERView.FormCreate(Sender: TObject);
begin
  FDataSet := TFDMemTable.Create(Self);
  DataSourcePrincipal.DataSet := TUtils.ObjectToDataSet<TVIPER>(FDataSet);

  FirstControl := nil;
  FieldIndex := 0;
  
  inherited;
end;

procedure TFrmVIPERView.GravarRegistro;
begin
  
end;

function TFrmVIPERView.InserirRegistro: Boolean;
begin
  Result := inherited;
end;

end.
