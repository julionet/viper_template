unit VIPERView;

interface

uses
  Winapi.Windows, Winapi.Messages, System.SysUtils, System.Variants, System.Classes,
  Vcl.Graphics, Vcl.Controls, Vcl.Forms, Vcl.Dialogs, VIPERInterfaces,
  VIPERPresenter, Vcl.StdCtrls;

type
  TFrmVIPERView = class(TForm, IViewVIPER)
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
