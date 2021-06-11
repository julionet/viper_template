using System.ComponentModel;

namespace Chronus.DXperience
{
    public enum ComponentType
    {
        TFormularioDX,
        TShapeDX,
        TGroupBoxDX,
        TLabelDX,
        TTextEditDX,
        TDateEditDX,
        TTimeEditDX,
        TCheckBoxDX,
        TSpinEditDX,
        TRadioButtonDX,
        TComboBoxDX,
        TRadioGroupDX,
        TCheckListBoxDX,
        TDBComboBoxDX,
        TDBRadioGroupDX,
        TDBCheckListBoxDX
    }

    public enum Alignment
    {
        taLeftAlignment,
        taRightAlignment,
        taCenterAlignment
    }

    public enum DefaultValue
    {
        [Description("")]
        dvNone,
        [Description("[DATA_ATUAL]")]
        dvDataAtual,
        [Description("[HORA_ATUAL]")]
        dvHoraAtual,
        [Description("[HORA_0000]")]
        dvHora0000,
        [Description("[HORA_2359]")]
        dvHora2359,
        [Description("[ANO]")]
        dvAno,
        [Description("[MES]")]
        dvMes,
        [Description("[TRUE]")]
        dvTrue,
        [Description("[FALSE]")]
        dvFalse,
        [Description("[USUARIO_LOGADO]")]
        dvUsuarioLogado
    }

    public static class DefaultValueExtensions
    {
        public static string ToDescriptionString(this DefaultValue val)
        {
            DescriptionAttribute[] attributes = (DescriptionAttribute[])val
               .GetType()
               .GetField(val.ToString())
               .GetCustomAttributes(typeof(DescriptionAttribute), false);
            return attributes.Length > 0 ? attributes[0].Description : string.Empty;
        }
    }

    public class ComponenteRelatorio
    {
        public ComponentType ComponentType { get; set; }

        public string Name { get; set; }

        public int Top { get; set; }

        public int Left { get; set; }

        public int Width { get; set; }

        public int Height { get; set; }

        public string Load { get; set; }

        public string Close { get; set; }

        public string BeforePrint { get; set; }

        public string AfterPrint { get; set; }

        public string Caption { get; set; }

        public int TabIndex { get; set; }

        public string Hint { get; set; }

        public string Mask { get; set; }

        public string NullText { get; set; }

        public string Parameter { get; set; }

        public DefaultValue DefaultValue { get; set; }

        public bool Required { get; set; }

        public string RequiredMessage { get; set; }

        public Alignment Alignment { get; set; }

        public string Leave { get; set; }

        public string Enter { get; set; }

        public string Change { get; set; }

        public string Components { get; set; }

        public int MinValue { get; set; }

        public int MaxValue { get; set; }

        public string ValueChecked { get; set; }

        public string ValueUnchecked { get; set; }

        public int GroupIndex { get; set; }

        public string Descriptions { get; set; }

        public string Values { get; set; }

        public int Columns { get; set; }

        public string KeyField { get; set; }

        public string ShowField { get; set; }

        public string SQL { get; set; }

        public bool CheckAll { get; set; }
    }
}
