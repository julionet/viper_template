inherited FrmVIPERView: TFrmVIPERView
  Caption = 'FrmVIPERView'
  PixelsPerInch = 96
  TextHeight = 13
  inherited cxPageControlPrincipal: TcxPageControl
    Properties.ActivePage = cxTabSheetManutencao
    inherited cxTabSheetAcesso: TcxTabSheet
      inherited cxGridPrincipal: TcxGrid
        ExplicitTop = 80
        ExplicitHeight = 205
        inherited cxGridPrincipalDBTableViewPrincipal: TcxGridDBTableView
        end
      end
    end
    inherited cxTabSheetManutencao: TcxTabSheet
      ExplicitLeft = 4
      ExplicitTop = 4
      ExplicitWidth = 629
      ExplicitHeight = 293
      inherited PanelManutecaoBackground: TPanel
      end
    end
  end
end
