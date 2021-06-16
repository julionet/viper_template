unit TestVIPERRouter;

interface

uses
  TestFramework, Data.DB, VIPERInterfaces, VIPERRouter;

type
  TestTVIPERRouter = class(TTestCase)
  strict private
    FVIPERRouter: TVIPERRouter;
  public
    procedure SetUp; override;
    procedure TearDown; override;
  end;

implementation

procedure TestTVIPERRouter.SetUp;
begin
  FVIPERRouter := TVIPERRouter.Create;
end;

procedure TestTVIPERRouter.TearDown;
begin
  FVIPERRouter.Free;
  FVIPERRouter := nil;
end;

initialization
  RegisterTest(TestTVIPERRouter.Suite);

end.

