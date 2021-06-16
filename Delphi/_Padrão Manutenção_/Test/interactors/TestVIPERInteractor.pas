unit TestVIPERInteractor;

interface

uses
  TestFramework, Data.DB, VIPERInterfaces, VIPERInteractor;

type
  TestTVIPERInteractor = class(TTestCase)
  strict private
    FVIPERInteractor: TVIPERInteractor;
  public
    procedure SetUp; override;
    procedure TearDown; override;
  published

  end;

implementation

procedure TestTLoginInteractor.SetUp;
begin
  FVIPERInteractor := TVIPERInteractor.Create;
end;

procedure TestTLoginInteractor.TearDown;
begin
  FVIPERInteractor.Free;
  FVIPERInteractor := nil;
end;

initialization
  RegisterTest(TestTVIPERInteractor.Suite);

end.

