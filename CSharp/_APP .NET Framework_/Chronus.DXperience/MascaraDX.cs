using DevExpress.XtraEditors;
using System.Linq;

namespace Chronus.DXperience
{
    public abstract class MascaraDX
    {
        public static void AplicarMascaraCpfCnpj(TextEdit textEdit)
        {
            string old = "";

            string cpfMask = "###.###.###-##";
            string cnpjMask = "##.###.###/####-##";

            string str = "";
            foreach (char c in textEdit.Text.ToArray())
                if ((int)c >= 48 && (int)c <= 57)
                    str += c;

            string mask = str.Length > 11 ? cnpjMask : cpfMask;

            string mascara = "";
            int i = 0;
            foreach (char m in mask.ToArray())
            {
                if ((m != '#' && str.Length > old.Length) || (m != '#' && str.Length < old.Length) && str.Length != i)
                {
                    mascara += m;
                    continue;
                }

                try
                {
                    mascara += str[i];
                }
                catch
                {
                    break;
                }
                i++;
            }

            textEdit.Text = "";
            textEdit.EditValue = mascara;
            textEdit.Refresh();

            textEdit.Select(textEdit.Text.Length + 1, 0);
        }

        public static void AplicarMascaraCpfCnpj(ButtonEdit textEdit)
        {
            string old = "";

            string cpfMask = "###.###.###-##";
            string cnpjMask = "##.###.###/####-##";

            string str = "";
            foreach (char c in textEdit.Text.ToArray())
                if ((int)c >= 48 && (int)c <= 57)
                    str += c;

            string mask = str.Length > 11 ? cnpjMask : cpfMask;

            string mascara = "";
            int i = 0;
            foreach (char m in mask.ToArray())
            {
                if ((m != '#' && str.Length > old.Length) || (m != '#' && str.Length < old.Length) && str.Length != i)
                {
                    mascara += m;
                    continue;
                }

                try
                {
                    mascara += str[i];
                }
                catch
                {
                    break;
                }
                i++;
            }

            textEdit.Text = "";
            textEdit.EditValue = mascara;
            textEdit.Refresh();

            textEdit.Select(textEdit.Text.Length + 1, 0);
        }

        public static void AplicarMascaraTelefone(TextEdit textEdit)
        {
            string old = "";

            string telefoneMask = "(##)####-####";
            string celularMask = "(##)#####-####";

            string str = "";
            foreach (char c in textEdit.Text.ToArray())
                if ((int)c >= 48 && (int)c <= 57)
                    str += c;
            string mask = str.Length > 10 ? celularMask : telefoneMask;

            string mascara = "";
            int i = 0;
            foreach (char m in mask.ToArray())
            {
                if ((m != '#' && str.Length > old.Length) || (m != '#' && str.Length < old.Length) && str.Length != i)
                {
                    mascara += m;
                    continue;
                }

                try
                {
                    mascara += str[i];
                }
                catch
                {
                    break;
                }
                i++;
            }

            textEdit.Text = "";
            textEdit.EditValue = mascara;
            
            textEdit.Select(textEdit.Text.Length + 1, 0);
        }        
    }
}
