unit TestVIPERPresenter;

interface

uses
  TestFramework, Data.DB, VIPERInterfaces, VIPERPresenter;

type
  TestTVIPERPresenter = class(TTestCase)
  strict private
    FVIPERPresenter: TVIPERPresenter;
  public
    procedure SetUp; override;
    procedure TearDown; override;
  end;

implementation

procedure TestTVIPERPresenter.SetUp;
begin
  FVIPERPresenter := TVIPERPresenter.Create;
end;

procedure TestTVIPERPresenter.TearDown;
begin
  FVIPERPresenter.Free;
  FVIPERPresenter := nil;
end;

initialization
  RegisterTest(TestTVIPERPresenter.Suite);

end.

