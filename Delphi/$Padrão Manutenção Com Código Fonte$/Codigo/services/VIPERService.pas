{
  __MODULENAME__Service.pas
  __APPNAME__

  Created by __USERNAME__ on __DATETIME__.
  Copyright ? __YEAR__ __ORGANIZATIONNAME__. All rights reserved.
}

unit VIPERService;

interface

uses
  Data.DB;

type
  TVIPERService = class
  private
  public
    class function Filtrar(Condicao: String; DataSet: TDataSet): TDataSet;
    class function Gravar(DataSet: TDataSet): String;
    class function Excluir(DataSet: TDataSet): String;
  end;

implementation

{ TTipoService }

class function TVIPERService.Excluir(DataSet: TDataSet): String;
begin
  Result := '';
end;

class function TVIPERService.Filtrar(Condicao: String;
  DataSet: TDataSet): TDataSet;
begin
  Result := DataSet;
end;

class function TVIPERService.Gravar(DataSet: TDataSet): String;
begin
  Result := '';
end;

end.
