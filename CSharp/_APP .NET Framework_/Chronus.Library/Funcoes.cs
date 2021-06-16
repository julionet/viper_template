using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text.RegularExpressions;

namespace Chronus.Library
{
    public class Funcoes
    {
        private Funcoes()
        {
        }

        public static string ReplaceStringCharacter(string s, char c)
        {
            string retorno = "";
            if (s != null)
            {
                for (int i = 0; i < s.Length; i++)
                    retorno += c;
            }
            return retorno;
        }

        public static string OnlyLetterAndNumber(string s)
        {
            string sTexto = "";
            foreach (char c in s.ToArray())
                if (((int)c >= 48 && (int)c <= 57) || ((int)c >= 65 && (int)c <= 90) || ((int)c >= 97 && (int)c <= 122))
                    sTexto += c.ToString();
            return sTexto;
        }

        public static int StringToInt(string s)
        {
            int iTotal = 0;
            foreach (char c in s.ToArray())
                iTotal += (int)c;
            return iTotal;
        }

        public static string NextString(string s)
        {
            string sNovaString = "";
            bool acumulou = false;
            for (int i = s.Length - 1; i >= 0; i--)
            {
                if (!acumulou)
                {
                    if ((int)s[i] < 90)
                    {
                        sNovaString = ((char)(((int)s[i]) + 1)).ToString() + sNovaString;
                        acumulou = true;
                    }
                    else
                        sNovaString = "A" + sNovaString;
                }
                else
                    sNovaString = ((char)((int)s[i])).ToString() + sNovaString;
            }

            bool bSomenteA = true;
            foreach (char c in sNovaString)
                if (c != 'A')
                    bSomenteA = false;
            if (bSomenteA) sNovaString += "A";
            return sNovaString;
        }

        public static bool IsHexa(string s)
        {
            char[] hexa = new char[16] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };
            foreach (char c in s.ToCharArray())
                if (!hexa.Contains(c))
                    return false;
            return true;
        }

        public static bool IsDouble(string s)
        {
            double resultado = 0;
            return double.TryParse(s, out resultado);
        }

        public static bool IsNumberInt64(string s)
        {
            long resultado = 0;
            return long.TryParse(s, out resultado);
        }

        public static bool IsNumberInt32(string s)
        {
            int resultado = 0;
            return int.TryParse(s, out resultado);
        }

        public static bool IsDateTime(string s)
        {
            DateTime resultado;
            return DateTime.TryParse(s, out resultado) && (s.IndexOf("/") > 0);
        }

        public static bool IsTimeSpan(string s)
        {
            TimeSpan resultado;
            return TimeSpan.TryParse(s, out resultado);
        }

        public static bool IsOnlyUpperLetter(string s)
        {
            bool bAchou = false;
            foreach (char c in s.ToArray())
                if ((int)c < 65 || (int)c > 90)
                    bAchou = true;
            return !bAchou;
        }

        public static bool IsOnlyLowerLetter(string s)
        {
            bool bAchou = false;
            foreach (char c in s.ToArray())
                if ((int)c < 97 || (int)c > 122)
                    bAchou = true;
            return !bAchou;
        }

        public static int NullToZero(object i)
        {
            return i == null ? 0 : (int)i;
        }

        public static DateTime FirstDay(int month, int year)
        {
            return new DateTime(year, month, 1);
        }

        public static DateTime LastDay(int month, int year)
        {
            return new DateTime(year, month, DateTime.DaysInMonth(year, month));
        }

        public static DateTime AnyDay(int day, int month, int year)
        {
            return new DateTime(year, month, day);
        }

        public static string GetStringNoAccents(string str)
        {
            string[] acentos = new string[] { "ç", "Ç", "á", "é", "í", "ó", "ú", "ý", "Á", "É", "Í", "Ó", "Ú", "Ý", "à", "è", "ì", "ò", "ù", "À", "È", "Ì", "Ò", "Ù", "ã", "õ", "ñ", "ä", "ë", "ï", "ö", "ü", "ÿ", "Ä", "Ë", "Ï", "Ö", "Ü", "Ã", "Õ", "Ñ", "â", "ê", "î", "ô", "û", "Â", "Ê", "Î", "Ô", "Û" };
            string[] semAcento = new string[] { "c", "C", "a", "e", "i", "o", "u", "y", "A", "E", "I", "O", "U", "Y", "a", "e", "i", "o", "u", "A", "E", "I", "O", "U", "a", "o", "n", "a", "e", "i", "o", "u", "y", "A", "E", "I", "O", "U", "A", "O", "N", "a", "e", "i", "o", "u", "A", "E", "I", "O", "U" };
            for (int i = 0; i < acentos.Length; i++)
            {
                str = str.Replace(acentos[i], semAcento[i]);
            }

            string[] caracteresEspeciais = { ".", ",", "-", ":", "(", ")", "ª", "|", "\\", "°", "/" };
            for (int i = 0; i < caracteresEspeciais.Length; i++)
            {
                str = str.Replace(caracteresEspeciais[i], "");
            }
            str = str.Replace("^\\s+", "");
            str = str.Replace("\\s+$", "");
            str = str.Replace("\\s+", " ");
            return str;
        }

        public static string UpdateMask(string s)
        {
            if (s == null) return "";

            if (s.Contains("SIMP:"))
                return s.Substring(s.IndexOf("SIMP:") + 5, s.Length - (s.IndexOf("SIMP:") + 5));
            else if (s.Contains("NUM:"))
                return s.Substring(s.IndexOf("NUM:") + 4, s.Length - (s.IndexOf("NUM:") + 4));
            else if (s.Contains("DH:"))
                return s.Substring(s.IndexOf("DH:") + 5, s.Length - (s.IndexOf("DH:") + 5));
            else if (s.Contains("ER:"))
                return s.Substring(s.IndexOf("ER:") + 5, s.Length - (s.IndexOf("ER:") + 5));
            else
                return s;
        }

        public static string GetFormatInt32(int d)
        {
            string sMask = "";
            for (int i = 0; i < d; i++) sMask += "0";
            return sMask;
        }

        public static int CalculaMeses(DateTime datafim, DateTime dataini)
        {
            int datafimMes = (datafim.Year * 12) + datafim.Month;
            int datainiMes = (dataini.Year * 12) + dataini.Month;

            return (datafimMes - datainiMes - (datafim.Day < dataini.Day ? 1 : 0));
        }

        public static int CalculaDias(DateTime datafim, DateTime dataini)
        {
            return (datafim.Subtract(dataini).Days);
        }

        public static int CalculaAnos(DateTime datafim, DateTime dataini)
        {
            int iAnos = datafim.Year - dataini.Year;

            if (datafim.Month < dataini.Month || (datafim.Month == dataini.Month && datafim.Day < dataini.Day))
                iAnos--;

            return (iAnos);
        }

        public static string ComaToPoint(string s)
        {
            return s.Replace(',', '.');
        }

        public static string ConfigureStringCondition(string pesquisa, string campo)
        {
            if (pesquisa.Equals("%"))
                return "(0 == 0)";
            else if (pesquisa.Substring(0, 1) == "%")
                return string.Format("{0}.ToLower().EndsWith({1}.ToLower())", campo, (char)34 + pesquisa.Replace("%", "") + (char)34);
            else if (pesquisa.Substring(pesquisa.Length - 1, 1) == "%")
                return string.Format("{0}.ToLower().StartsWith({1}.ToLower())", campo, (char)34 + pesquisa.Replace("%", "") + (char)34);
            else
                return string.Format("{0}.ToLower().Contains({1}.ToLower())", campo, (char)34 + pesquisa + (char)34);
        }

        public static string ConfigureTimeCondition(string sHora, string sCampo)
        {
            string sCondicao = "";
            int hora = 0;
            int minuto = 0;
            int segundo = 0;
            int i = 1;

            foreach (string s in sHora.Split(':'))
            {
                if (IsNumberInt32(s))
                {
                    if (i == 1)
                    {
                        if (Convert.ToInt32(s) >= 0 && Convert.ToInt32(s) <= 23)
                            hora = Convert.ToInt32(s);
                    }
                    else if (i == 2)
                    {
                        if (Convert.ToInt32(s) >= 0 && Convert.ToInt32(s) <= 59)
                            minuto = Convert.ToInt32(s);
                    }
                    else if (i == 3)
                    {
                        if (Convert.ToInt32(s) >= 0 && Convert.ToInt32(s) <= 59)
                            segundo = Convert.ToInt32(s);
                    }
                }
                i++;
            }
            if ((hora != 0) || (minuto != 0) || (segundo != 0))
            {
                if (hora != 0)
                    sCondicao += sCampo + ".Hours == " + hora.ToString();
                if (minuto != 0)
                    sCondicao += (sCondicao != "" ? " and " : "") + sCampo + ".Minutes == " + minuto.ToString();
                if (segundo != 0)
                    sCondicao += (sCondicao != "" ? " and " : "") + sCampo + ".Seconds == " + segundo.ToString();
            }
            return sCondicao;
        }

        public static string ConfigureDateCondition(string sData, string sCampo)
        {
            string sCondicao = "";
            int dia = 0;
            int mes = 0;
            int ano = 0;
            int i = 1;
            foreach (string s in sData.Split('/'))
            {
                if (IsNumberInt32(s))
                {
                    if (i == 1)
                    {
                        if (Convert.ToInt32(s) >= 1 && Convert.ToInt32(s) <= 31)
                            dia = Convert.ToInt32(s);
                    }
                    else if (i == 2)
                    {
                        if (Convert.ToInt32(s) >= 1 && Convert.ToInt32(s) <= 12)
                            mes = Convert.ToInt32(s);
                    }
                    else if (i == 3)
                        ano = Convert.ToInt32(s);
                }
                i++;
            }
            if ((dia != 0) || (mes != 0) || (ano != 0))
            {
                if (dia != 0)
                    sCondicao += sCampo + ".Day == " + dia.ToString();
                if (mes != 0)
                    sCondicao += (sCondicao != "" ? " and " : "") + sCampo + ".Month == " + mes.ToString();
                if (ano != 0)
                    sCondicao += (sCondicao != "" ? " and " : "") + sCampo + ".Year == " + ano.ToString();
            }
            return "(" + sCondicao + ")";
        }

        public static string ConfigureDateCondition(string campo, string sinal, DateTime data, int tipodb = 0)
        {
            if (tipodb.Equals(3))
                return "((((" + campo + ".Year - 1900) * 365) + ((" + campo + ".Month - 1) * 31) + " + campo + ".Day) " + sinal + " " + (((data.Year - 1900) * 365) + ((data.Month - 1) * 31) + data.Day).ToString() + ")";
            else if (tipodb.Equals(5))
                return campo + " " + sinal + " " + data.ToString("MM/dd/yyyy");
            else
                return campo + " " + sinal + " " + data.ToString("dd/MM/yyyy");
        }

        //public static string ConfigureDateCondition(string campo, string sinal, DateTime data)
        //{
        //    return "((((" + campo + ".Year - 1900) * 365) + ((" + campo + ".Month - 1) * 31) + " + campo + ".Day) " + sinal + " " + (((data.Year - 1900) * 365) + ((data.Month - 1) * 31) + data.Day).ToString() + ")";
        //}

        public static string ParseObject(string condicaoinicial, string campo, string valor, Type tipo)
        {
            string condicao = condicaoinicial;

            if (tipo == typeof(int))
            {
                int i;
                if (int.TryParse(valor, out i))
                {
                    if (!string.IsNullOrEmpty(condicao))
                        condicao += " and ";
                    condicao += string.Format("{0} == {1}", campo, i);
                }
                else
                    condicao = "";
            }
            else if (tipo == typeof(long))
            {
                long l;
                if (long.TryParse(valor, out l))
                {
                    if (!string.IsNullOrEmpty(condicao))
                        condicao += " and ";
                    condicao += string.Format("{0} == {1}", campo, l);
                }
                else
                    condicao = "";
            }
            else if (tipo == typeof(double))
            {
                double d;
                if (double.TryParse(valor, out d))
                {
                    if (!string.IsNullOrEmpty(condicao))
                        condicao += " and ";
                    condicao += string.Format("{0} == {1}", campo, valor.Replace(',', '.'));
                }
                else
                    condicao = "";
            }
            else if (tipo == typeof(DateTime))
            {
                DateTime dt;
                if (DateTime.TryParse(valor, out dt))
                {
                    if (!string.IsNullOrEmpty(condicao))
                        condicao += " and ";
                    condicao += ConfigureDateCondition(valor, campo);
                }
                else
                    condicao = "";
            }
            else if (tipo == typeof(string))
            {
                if (!string.IsNullOrEmpty(valor))
                {
                    if (valor != "%")
                    {
                        if (!string.IsNullOrEmpty(condicao))
                            condicao += " and ";

                        if (valor.Substring(0, 1) == "%")
                            condicao += string.Format("{0}.ToLower().EndsWith({1}.ToLower())", campo, (char)34 + valor.Replace("%", "") + (char)34);
                        else if (valor.Substring(valor.Length - 1, 1) == "%")
                            condicao += string.Format("{0}.ToLower().StartsWith({1}.ToLower())", campo, (char)34 + valor.Replace("%", "") + (char)34);
                        else
                            condicao += string.Format("{0}.ToLower().Contains({1}.ToLower())", campo, (char)34 + valor + (char)34);
                    }
                }
            }
            return condicao;
        }

        public static string TakeAccentuation(string s)
        {
            return s.Replace('á', 'a').Replace('é', 'e').Replace('í', 'i').Replace('ó', 'o').Replace('ú', 'u')
                .Replace('à', 'a').Replace('è', 'e').Replace('ì', 'i').Replace('ò', 'o').Replace('ù', 'u')
                .Replace('â', 'a').Replace('ê', 'e').Replace('î', 'i').Replace('ô', 'o').Replace('û', 'u')
                .Replace('ä', 'a').Replace('ë', 'e').Replace('ï', 'i').Replace('ö', 'o').Replace('ü', 'u')
                .Replace('ã', 'a').Replace('õ', 'o').Replace('ñ', 'n').Replace('ç', 'c')
                .Replace('Á', 'A').Replace('É', 'E').Replace('Í', 'I').Replace('Ó', 'O').Replace('Ú', 'U')
                .Replace('À', 'A').Replace('È', 'E').Replace('Ì', 'I').Replace('Ò', 'O').Replace('Ù', 'U')
                .Replace('Â', 'A').Replace('Ê', 'E').Replace('Î', 'I').Replace('Ô', 'O').Replace('Û', 'U')
                .Replace('Ä', 'A').Replace('Ë', 'E').Replace('Ï', 'I').Replace('Ö', 'O').Replace('Ü', 'U')
                .Replace('Ã', 'A').Replace('Õ', 'O').Replace('Ñ', 'N').Replace('Ç', 'C')
                .Replace('ª', 'a').Replace('º', 'o');
        }

        public static string FormataCpfCnpj(string documento)
        {
            return documento.Length == 14 ? Convert.ToUInt64(documento).ToString(@"00\.000\.000\/0000\-00") : Convert.ToUInt64(documento).ToString(@"000\.000\.000\-00");
        }

        public static string ApenasNumeros(string s)
        {
            string _s = "";
            if (s == null) return _s;
            foreach (char c in s.ToCharArray())
                if ((((int)c) >= 48) && (((int)c) <= 57))
                    _s += c.ToString();
            return _s;
        }

        public static string DigitoVerificador(string CpfCnpj)
        {
            string retorno = "";

            CpfCnpj = CpfCnpj.Trim();
            CpfCnpj = CpfCnpj.Replace(".", "").Replace("-", "").Replace("/", "");

            if (CpfCnpj.Length == 14)
                retorno = DigitoCnpj(CpfCnpj);
            if (CpfCnpj.Length == 11)
                retorno = DigitoCpf(CpfCnpj);
            return retorno;

        }

        public static string DigitoCnpj(string cnpj)
        {
            int[] multiplicador1 = new int[12] { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[13] { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int soma = 0;
            int resto;
            string digito;
            string tempCnpj;

            cnpj = cnpj.Trim();
            cnpj = cnpj.Replace(".", "").Replace("-", "").Replace("/", "");

            if (cnpj.Length != 14)
                return "";

            tempCnpj = cnpj.Substring(0, 12);
            for (int i = 0; i < 12; i++)
                soma += int.Parse(tempCnpj[i].ToString()) * multiplicador1[i];

            resto = (soma % 11);
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            digito = resto.ToString();

            tempCnpj = tempCnpj + digito;
            soma = 0;
            for (int i = 0; i < 13; i++)
                soma += int.Parse(tempCnpj[i].ToString()) * multiplicador2[i];

            resto = (soma % 11);
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            digito = digito + resto.ToString();

            return digito;
        }

        public static string DigitoCpf(string cpf)
        {
            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            string tempCpf;
            string digito;

            int soma;
            int resto;

            cpf = cpf.Trim();
            cpf = cpf.Replace(".", "").Replace("-", "");

            if (cpf.Length != 11)
            {
                return "";
            }
            tempCpf = cpf.Substring(0, 9);

            soma = 0;

            for (int i = 0; i < 9; i++)
            {
                soma += int.Parse(tempCpf[i].ToString()) * (multiplicador1[i]);
            }
            resto = soma % 11;

            if (resto < 2)
            {
                resto = 0;
            }
            else
            {
                resto = 11 - resto;
            }

            digito = resto.ToString();
            tempCpf = tempCpf + digito;
            int soma2 = 0;

            for (int i = 0; i < 10; i++)
            {
                soma2 += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];
            }

            resto = soma2 % 11;

            if (resto < 2)
            {
                resto = 0;
            }
            else
            {
                resto = 11 - resto;
            }

            digito = digito + resto.ToString();

            return digito;
        }

        public static string AplicarMascaraCpfCnpj(string textEdit)
        {
            if (string.IsNullOrWhiteSpace(textEdit))
                return "";
            string old = "";

            string cpfMask = "###.###.###-##";
            string cnpjMask = "##.###.###/####-##";

            string str = "";
            foreach (char c in textEdit.ToArray())
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

            return mascara;
        }

        public static bool IsTextFile(string FilePath)
        {
            using (StreamReader reader = new StreamReader(FilePath))
            {
                int Character;
                while ((Character = reader.Read()) != -1)
                {
                    if ((Character > 0 && Character < 8) || (Character > 13 && Character < 26))
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public static bool CheckForInternetConnection()
        {
            try
            {
                using (var client = new WebClient())
                {
                    using (client.OpenRead("http://clients3.google.com/generate_204"))
                    {
                        return true;
                    }
                }
            }
            catch
            {
                return false;
            }
        }

        public static string getMACAddress()
        {
            string mac = "";
            try
            {
                mac = (from nic in NetworkInterface.GetAllNetworkInterfaces()
                              where nic.OperationalStatus == OperationalStatus.Up
                              select nic.GetPhysicalAddress().ToString()).FirstOrDefault();

                mac = Regex.Replace(mac, "(.{2})(.{2})(.{2})(.{2})(.{2})(.{2})", "$1:$2:$3:$4:$5:$6");
            }
            catch { }

            return mac;
        }
    }
}
