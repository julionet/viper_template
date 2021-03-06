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
  Vcl.Graphics, Vcl.Controls, Vcl.Forms, Vcl.Dialogs, uManutencao, cxGraphics,
  cxLookAndFeels, cxLookAndFeelPainters, dxBarBuiltInMenu, Vcl.Menus, cxStyles,
  cxCustomData, cxFilter, cxData, cxDataStorage, cxEdit, cxNavigator,
  cxDataControllerConditionalFormattingRulesManagerDialog, Data.DB, cxDBData,
  cxContainer, cxTextEdit, cxLabel, cxGridLevel, cxClasses, cxGridCustomView,
  cxControls, cxGridCustomTableView, cxGridTableView, cxGridDBTableView, cxGrid,
  Vcl.StdCtrls, cxButtons, Vcl.ExtCtrls, cxPC, FireDAC.Comp.Client,
  VIPERInterfaces, cxMemo, cxDBEdit, FireDAC.Stan.Intf, FireDAC.Stan.Option,
  FireDAC.Stan.Param, FireDAC.Stan.Error, FireDAC.DatS, FireDAC.Phys.Intf,
  FireDAC.DApt.Intf, FireDAC.Stan.Async, FireDAC.DApt, FireDAC.Comp.DataSet;

type
  TFrmVIPERView = class(TFrmManutencao, IPresenterToViewVIPER)
    procedure FormCreate(Sender: TObject);
  private
    { Private declarations }
	  FDataSet: TFDMemTable;
    procedure FiltrarSuccess(DataSet: TDataSet);
    procedure FiltrarFailed(Mensagem: String);
    procedure GravarSucesso;
    procedure GravarFalha(Mensagem: String);
    procedure ExcluirSucesso;
    procedure ExcluirFalha(Mensagem: String);
  public
    { Public declarations }
    Presenter: IViewToPresenterVIPER;
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

{ TFrmBemSemoventeView }

function TFrmVIPERView.CancelarRegistro: Boolean;
begin
  DataSourcePrincipal.DataSet.Cancel;
  Result := inherited;
end;

procedure TFrmVIPERView.ExcluirFalha(Mensagem: String);
begin
  TMensagem.Atencao(Mensagem);
end;

procedure TFrmVIPERView.ExcluirRegistro;
begin
  Presenter.Excluir(DataSourcePrincipal.DataSet);
end;

procedure TFrmVIPERView.ExcluirSucesso;
begin
  TFDMemTable(DataSourcePrincipal.DataSet).EmptyDataSet;
  ExcluidoSucesso;
end;

procedure TFrmVIPERView.FiltrarFailed(Mensagem: String);
begin
  TMensagem.Atencao(Mensagem);
end;

procedure TFrmVIPERView.FiltrarRegistros;
begin
  inherited;
  if CondicaoFiltro <> '' then
    Presenter.Filtrar(CondicaoFiltro, FDataSet);
end;

procedure TFrmVIPERView.FiltrarSuccess(DataSet: TDataSet);
begin
  DataSourcePrincipal.DataSet := DataSet;
end;

procedure TFrmVIPERView.FormCreate(Sender: TObject);
begin
  FDataSet := TFDMemTable.Create(Self);
  DataSourcePrincipal.DataSet := TUtils.ObjectToDataSet<TVIPER>(FDataSet);

  FirstControl := nil;
  FieldIndex := 0;
  
  inherited;
end;

procedure TFrmVIPERView.GravarFalha(Mensagem: String);
begin
  TMensagem.Atencao(Mensagem);
end;

procedure TFrmVIPERView.GravarRegistro;
begin
  Presenter.Gravar(DataSourcePrincipal.DataSet);
end;

procedure TFrmVIPERView.GravarSucesso;
begin
  TFDMemTable(DataSourcePrincipal.DataSet).EmptyDataSet;
  GravadoSucesso;
end;

function TFrmVIPERView.InserirRegistro: Boolean;
begin
  DataSourcePrincipal.DataSet.Append;
  DataSourcePrincipal.DataSet.FieldByName('Id').Value := 0;

  Result := inherited;
end;

end.
