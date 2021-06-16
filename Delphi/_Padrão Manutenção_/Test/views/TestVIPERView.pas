unit TestVIPERView;

interface

uses
  TestFramework, VIPERView, VIPERInterfaces;

type
  TestTFrmVIPERView = class(TTestCase)
  strict private
    FFrmVIPERView: TFrmVIPERView;
  public
    procedure SetUp; override;
    procedure TearDown; override;
  end;

implementation

procedure TestTFrmVIPERView.SetUp;
begin
  FFrmVIPERView := TFrmVIPERView.Create;
end;

procedure TestTFrmVIPERView.TearDown;
begin
  FFrmVIPERView.Free;
  FFrmVIPERView := nil;
end;

initialization
  RegisterTest(TestTFrmVIPERView.Suite);

end.

