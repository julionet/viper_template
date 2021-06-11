using System;
using System.Xml;

namespace Chronus.Library
{
    public class AppConfig : System.Configuration.AppSettingsReader
    {
        private string _applicationname;
        public string ApplicationName
        {
            get { return _applicationname; }
            set { _applicationname = value; }
        }

        private string _tag = "appSettings";
        public string Tag
        {
            get { return _tag; }
            set { _tag = value; }
        }

        private string _atributochave = "key";
        public string AtributoChave
        {
            get { return _atributochave; }
            set { _atributochave = value; }
        }

        private string _atributo = "value";
        public string Atributo
        {
            get { return _atributo; }
            set { _atributo = value; }
        }

        private string _elemento = "add";
        public string Elemento
        {
            get { return _elemento; }
            set { _elemento = value; }
        }

        public AppConfig()
        {
        }

        public AppConfig(string ApplicationName)
        {
            this.ApplicationName = ApplicationName;
        }

        public bool SetValue(string key, string value, ref string return_value)
        {
            XmlDocument doc = new XmlDocument();
            XmlNode no;
            try
            {
                doc.Load(_applicationname);
                if (doc != null)
                {
                    no = doc.SelectSingleNode("//" + _tag);
                    if (no != null)
                    {
                        XmlElement addElem = (XmlElement)no.SelectSingleNode("//" + _elemento + "[@" + _atributochave + "='" + key + "']");
                        if (addElem != null)
                        {
                            addElem.SetAttribute(_atributo, value);
                        }
                        else
                        {
                            XmlElement entry = doc.CreateElement(_elemento);
                            entry.SetAttribute(_atributochave, key);
                            entry.SetAttribute(_atributo, value);
                            no.AppendChild(entry);
                        }

                        XmlTextWriter writer = new XmlTextWriter(ApplicationName, null);
                        writer.Formatting = Formatting.Indented;
                        doc.WriteTo(writer);
                        writer.Flush();
                        writer.Close();
                        return true;
                    }
                    else
                    {
                        return_value = "Chave informada não foi encontrada no arquivo de configuração.";
                        return false;
                    }
                }
                else
                {
                    return_value = "Arquivo de configuração não foi encontrado.";
                    return false;
                }
            }
            catch (Exception erro)
            {
                if (erro.InnerException != null)
                    return_value = erro.InnerException.Message;
                else
                    return_value = erro.Message;
                return false;
            }
        }

        public string GetValue(string key, ref string return_value)
        {
            XmlDocument doc = new XmlDocument();
            XmlNode no;
            try
            {
                doc.Load(_applicationname);
                if (doc != null)
                {
                    no = doc.SelectSingleNode("//" + _tag);
                    if (no != null)
                    {
                        XmlElement elemento = (XmlElement)no.SelectSingleNode("//" + _elemento + "[@" + _atributochave + "='" + key + "']");
                        if (elemento != null)
                            return elemento.GetAttribute(_atributo);
                        else
                            return "";
                    }
                    else
                    {
                        return_value = "Chave informada não foi encontrada no arquivo de configuração.";
                        return "";
                    }
                }
                else
                {
                    return_value = "Arquivo de configuração não foi encontrado.";
                    return "";
                }
            }
            catch (Exception erro)
            {
                if (erro.InnerException != null)
                    return_value = erro.InnerException.Message;
                else
                    return_value = erro.Message;
                return "";
            }
        }
    }
}